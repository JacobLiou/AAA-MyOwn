using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 DataTable 数据行转换为T类型的实体对象集合
        /// 【该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式】
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        [Obsolete("该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式")]
        public static IEnumerable<T> ToEntityList<T>(this DataTable @this) where T : new()
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            foreach (DataRow dr in @this.Rows)
            {
                T entity = new T();

                foreach (PropertyInfo property in properties)
                {
                    if (@this.Columns.Contains(property.Name))
                    {
                        Type valueType = property.PropertyType;
                        property.SetValue(entity, dr[property.Name].ConvertTo(valueType), null);
                    }
                }

                foreach (FieldInfo field in fields)
                {
                    if (@this.Columns.Contains(field.Name))
                    {
                        Type valueType = field.FieldType;
                        field.SetValue(entity, dr[field.Name].ConvertTo(valueType));
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}