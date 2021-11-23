using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public class ObjectShredder<T>
    {
        /* 参考：微软文档《如何：在泛型 T 不是 DataRow 的位置实现 CopyToDataTable<T>》
           地址：https://docs.microsoft.com/zh-cn/dotnet/framework/data/adonet/implement-copytodatatable-where-type-not-a-datarow

         * DataTable 对象通常用于数据绑定。 CopyToDataTable 方法接收查询结果并将数据复制到 DataTable 中，后者随后会使用该数据进行数据绑定。
         * 但是，只在 CopyToDataTable 源上执行 IEnumerable<T> 方法，其中泛型参数 T 的类型为 DataRow。
         * 虽然这十分有用，但是它并不允许从标量类型的序列、投影匿名类型的查询或执行表联接的查询创建表。
         * 此主题描述如何实现两个自定义的 CopyToDataTable<T> 扩展方法，其接受类型不是 T 的泛型参数 DataRow。 
         * 从 DataTable 源创建 IEnumerable<T> 的逻辑包含在 ObjectShredder<T> 类中，该类稍后被包装在两个重载的 CopyToDataTable<T> 扩展方法中。 
         * Shred 类的 ObjectShredder<T> 方法返回填充的 DataTable 并接受三个输入参数：一个 IEnumerable<T> 源、一个 DataTable 和一个 LoadOption 枚举。 
         * 返回的 DataTable 的初始架构是以类型为 T 的架构为基础的。 如果现有表作为输入提供，则该架构必须与类型为 T 的架构一致。 
         * 每个公共属性和类型为 T 的字段将转换为返回的表中的 DataColumn。 如果源序列包含从 T 派生的类型，则为任何其他公共属性或字段扩展返回的表的架构。
         */

        private System.Reflection.FieldInfo[] _fi;
        private System.Reflection.PropertyInfo[] _pi;
        private System.Collections.Generic.Dictionary<string, int> _ordinalMap;
        private System.Type _type;

        public ObjectShredder()
        {
            _type = typeof(T);
            _fi = _type.GetFields();
            _pi = _type.GetProperties();
            _ordinalMap = new Dictionary<string, int>();
        }

        /// <summary>
        /// 从一系列对象加载数据表
        /// </summary>
        /// <param name="source">要加载到DataTable中的对象序列</param>
        /// <param name="table">输入表。表的架构必须与类型T匹配。如果表为null，则将使用从T类型的公共属性和字段创建的架构创建新表。</param>
        /// <param name="options">指定如何将源序列中的值应用于表中的现有行</param>
        /// <returns>从源序列创建的数据表</returns>
        public DataTable Shred(IEnumerable<T> source, DataTable table, LoadOption? options)
        {
            // 如果T是基元类型，则从标量序列加载表
            if (typeof(T).IsPrimitive)
            {
                return ShredPrimitive(source, table, options);
            }

            //table ??= new DataTable(typeof(T).Name);
            if (table == null)
            {
                table = new DataTable(typeof(T).Name);
            }

            // 初始化序数映射并基于类型T扩展表模式
            table = ExtendTable(table, typeof(T));

            // 枚举源序列并将对象值加载到行中
            table.BeginLoadData();
            using (IEnumerator<T> e = source.GetEnumerator())
            {
                while (e.MoveNext())
                {
                    if (options != null)
                    {
                        table.LoadDataRow(ShredObject(table, e.Current), (LoadOption)options);
                    }
                    else
                    {
                        table.LoadDataRow(ShredObject(table, e.Current), true);
                    }
                }
            }
            table.EndLoadData();

            return table;
        }

        public DataTable ShredPrimitive(IEnumerable<T> source, DataTable table, LoadOption? options)
        {
            // table ??= new DataTable(typeof(T).Name);
            if (table == null)
            {
                table = new DataTable(typeof(T).Name);
            }

            if (!table.Columns.Contains("Value"))
            {
                table.Columns.Add("Value", typeof(T));
            }

            // 枚举源序列并将标量值加载到行中
            table.BeginLoadData();
            using (IEnumerator<T> e = source.GetEnumerator())
            {
                Object[] values = new object[table.Columns.Count];
                while (e.MoveNext())
                {
                    values[table.Columns["Value"].Ordinal] = e.Current;

                    if (options != null)
                    {
                        table.LoadDataRow(values, (LoadOption)options);
                    }
                    else
                    {
                        table.LoadDataRow(values, true);
                    }
                }
            }
            table.EndLoadData();

            return table;
        }

        public object[] ShredObject(DataTable table, T instance)
        {

            FieldInfo[] fi = _fi;
            PropertyInfo[] pi = _pi;

            if (instance.GetType() != typeof(T))
            {
                // 如果实例是从T派生的，则扩展表模式并获取属性和字段
                ExtendTable(table, instance.GetType());
                fi = instance.GetType().GetFields();
                pi = instance.GetType().GetProperties();
            }

            // 将实例的属性和字段值添加到数组中
            Object[] values = new object[table.Columns.Count];
            foreach (FieldInfo f in fi)
            {
                values[_ordinalMap[f.Name]] = f.GetValue(instance);
            }

            foreach (PropertyInfo p in pi)
            {
                values[_ordinalMap[p.Name]] = p.GetValue(instance, null);
            }

            return values;
        }

        public DataTable ExtendTable(DataTable table, Type type)
        {
            // 如果输入表为null或序列中的值派生自类型T，则扩展表架构
            foreach (FieldInfo f in type.GetFields())
            {
                if (!_ordinalMap.ContainsKey(f.Name))
                {
                    // 如果字段不存在，则将其作为列添加到表中
                    //DataColumn dc = table.Columns.Contains(f.Name) ? table.Columns[f.Name] : table.Columns.Add(f.Name, f.FieldType);
                    DataColumn dc = table.Columns.Contains(f.Name) ? table.Columns[f.Name] : table.Columns.Add(f.Name, Nullable.GetUnderlyingType(f.FieldType) ?? f.FieldType); //处理具有可为 null 的值类型的属性和字段
                    _ordinalMap.Add(f.Name, dc.Ordinal); // 将属性添加到序号映射
                }
            }
            foreach (PropertyInfo p in type.GetProperties())
            {
                if (!_ordinalMap.ContainsKey(p.Name))
                {
                    // 如果属性不存在，则将其作为列添加到表中
                    //DataColumn dc = table.Columns.Contains(p.Name) ? table.Columns[p.Name] : table.Columns.Add(p.Name, p.PropertyType);
                    DataColumn dc = table.Columns.Contains(p.Name) ? table.Columns[p.Name] : table.Columns.Add(p.Name, Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType);//处理具有可为 null 的值类型的属性和字段
                    _ordinalMap.Add(p.Name, dc.Ordinal); // 将属性添加到序号映射
                }
            }

            return table;
        }
    }
}