using System.Collections.Generic;
using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region 改用 CustomLINQtoDataSetMethods 中的扩展方法 CopyToDataTable()

        ///// <summary>
        /////  自定义扩展方法：将 IEnumerable 集合转换为 DataTable
        ///// </summary>
        ///// <typeparam name="T">泛型类型参数</typeparam>
        ///// <returns></returns>
        //public static DataTable CopyToDataTable<T>(this IEnumerable<T> data)
        //{
        //    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        //    var table = new DataTable();
        //    foreach (PropertyDescriptor prop in properties)
        //    {
        //        table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        //    }

        //    foreach (T item in data)
        //    {
        //        DataRow row = table.NewRow();
        //        foreach (PropertyDescriptor prop in properties)
        //        {
        //            row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
        //        }
        //        table.Rows.Add(row);
        //    }
        //    return table;
        //}

        #endregion

        #region CustomLINQtoDataSetMethods

        /// <summary>
        /// 自定义扩展方法：将 IEnumerable 集合转换为 DataTable
        /// </summary>
        /// <typeparam name="T"> 非 DataRow 类型的泛型类</typeparam>
        /// <param name="source">要加载到DataTable中的对象序列（一般是 Linq 对 DataTable 查询操作的结果）</param>
        /// <returns></returns>
        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source)
        {
            return new ObjectShredder<T>().Shred(source, null, null);
        }

        /// <summary>
        /// 自定义扩展方法：将 IEnumerable 集合转换为 DataTable
        /// </summary>
        /// <typeparam name="T"> 非 DataRow 类型的泛型类</typeparam>
        /// <param name="source">要加载到DataTable中的对象序列</param>
        /// <param name="table">输入表。表的架构必须与类型T匹配。如果表为null，则将使用从T类型的公共属性和字段创建的架构创建新表。</param>
        /// <param name="options">指定如何将源序列中的值应用于表中的现有行</param>
        /// <returns></returns>
        public static DataTable CopyToDataTable<T>(this IEnumerable<T> source, DataTable table, LoadOption? options)
        {
            return new ObjectShredder<T>().Shred(source, table, options);
        }

        #endregion
    }
}