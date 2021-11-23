using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

using ZCN.NET.CommonX.Enums;
using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 IDataReader 对象转换为一个实体对象
        /// 【该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式】
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="handling">针对DBNull字段的处理方式</param>
        /// <returns></returns>
        //[Obsolete("该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式")]
        public static T ToEntity<T>(this IDataReader @this, DBNullHandling handling = DBNullHandling.SetDefaultValue) where T : new()
        {
            if (@this == null || @this.Read() == false)
                return default(T);

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();
            var hash = new HashSet<string>(@this.GetColumnNames());

            foreach (PropertyInfo property in properties)
            {
                if (!property.CanWrite)
                    continue;

                if (hash.Contains(property.Name))
                {
                    //Type valueType = property.PropertyType;
                    //property.SetValue(entity, @this[property.Name].ConvertTo(valueType), null);

                    object value = @this[property.Name];
                    if (value is DBNull)
                    {
                        if (handling == DBNullHandling.SetDefaultValue)
                        {
                            value = property.PropertyType.GetDBNullDefaultValue();
                        }
                        else
                        {
                            continue;
                        }
                    }
                    property.SetValue(entity, value, null);
                }
            }

            return entity;
        }

        /// <summary>
        ///  自定义扩展方法：将 IDataReader 对象转换为实体对象集合
        /// 【该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式】
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="handling">针对DBNull字段的处理方式</param>
        /// <returns></returns>
        [Obsolete("该方法使用反射机制实现，性能较低。大量数据时推荐使用Emit实现方式")]
        public static IEnumerable<T> ToEntityList<T>(this IDataReader @this, DBNullHandling handling = DBNullHandling.SetDefaultValue) where T : new()
        {
            if (@this == null || @this.Read() == false)
                return new List<T>();

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();
            var hash = new HashSet<string>(@this.GetColumnNames());

            while (@this.Read())
            {
                var entity = new T();

                foreach (PropertyInfo property in properties)
                {
                    if (hash.Contains(property.Name))
                    {
                        //Type valueType = property.PropertyType;
                        //property.SetValue(entity,@this[property.Name].ConvertTo(valueType),null);

                        object value = @this[property.Name];
                        if (value is DBNull)
                        {
                            if (handling == DBNullHandling.SetDefaultValue)
                            {
                                value = property.PropertyType.GetDBNullDefaultValue();
                            }
                            else
                            {
                                continue;
                            }
                        }

                        property.SetValue(entity, value, null);
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}