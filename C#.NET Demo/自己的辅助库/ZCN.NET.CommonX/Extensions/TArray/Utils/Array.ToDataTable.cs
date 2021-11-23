using System;
using System.Data;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    /// 自定义扩展类
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///  自定义扩展方法：将一维数组转换为 DataTable
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。从零开始的一维数组</param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(this T[] @this)
        {
            Type type = typeof (T);

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public|BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public|BindingFlags.Instance);

            var dt = new DataTable();

            foreach(PropertyInfo property in properties)
            {
                dt.Columns.Add(property.Name, property.PropertyType);
            }

            foreach(FieldInfo field in fields)
            {
                dt.Columns.Add(field.Name, field.FieldType);
            }

            foreach(T item in @this)
            {
                DataRow dr = dt.NewRow();

                foreach(PropertyInfo property in properties)
                {
                    dr[property.Name] = property.GetValue(item, null);
                }

                foreach(FieldInfo field in fields)
                {
                    dr[field.Name] = field.GetValue(item);
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}