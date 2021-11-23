using System;
using System.Data;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 DataRow 数据行转换为T类型的实体对象。
        /// 【该方法使用反射机制实现，性能较低。推荐使用Emit实现方式】
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        [Obsolete("该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式")]
        public static T ToEntity<T>(this DataRow @this) where T : new()
        {
            Type type = typeof (T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public|BindingFlags.Instance);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public|BindingFlags.Instance);

            var entity = new T();

            foreach(PropertyInfo property in properties)
            {
                if(@this.Table.Columns.Contains(property.Name))
                {
                    Type valueType = property.PropertyType;
                    property.SetValue(entity, @this[property.Name].ConvertTo(valueType), null);
                }
            }

            foreach(FieldInfo field in fields)
            {
                if(@this.Table.Columns.Contains(field.Name))
                {
                    Type valueType = field.FieldType;
                    field.SetValue(entity, @this[field.Name].ConvertTo(valueType));
                }
            }

            return entity;
        }
    }
}