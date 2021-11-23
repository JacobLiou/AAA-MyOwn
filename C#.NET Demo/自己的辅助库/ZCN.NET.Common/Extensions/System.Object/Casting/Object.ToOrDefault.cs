using System;
using System.ComponentModel;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ConvertTo

        /// <summary>
        ///  自定义扩展方法：将 object 类型对象转换为T类型
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns>T类型</returns>
        public static T ConvertTo<T>(this object @this)
        {
            if (@this != null)
            {
                Type targetType = typeof(T);

                if (@this.GetType() == targetType)
                {
                    return (T)@this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return (T)converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return (T)converter.ConvertFrom(@this);
                    }
                }

                if (@this == DBNull.Value)
                {
                    return (T)(object)null;
                }
            }

            return (T)@this;
        }

        /// <summary>
        /// 自定义扩展方法：将 object 类型对象转换为T类型
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值</param>
        /// <returns>T类型</returns>
        public static T ToOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
        {
            try
            {
                return @this.ConvertTo<T>();
            }
            catch
            {
                return defaultValueFactory(@this);
            }
        }

        /// <summary>
        /// 自定义扩展方法：将 object 类型对象转换为T类型
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>T类型</returns>
        public static T ToOrDefault<T>(this object @this, T defaultValue)
        {
            return @this.ToOrDefault(x => defaultValue);
        }

        /// <summary>
        /// 自定义扩展方法：将 object 类型对象转换为T类型
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值</param>
        /// <returns></returns>
        public static T ToOrDefault<T>(this object @this, Func<T> defaultValueFactory)
        {
            return @this.ToOrDefault(x => defaultValueFactory());
        }

        /// <summary>
        /// 自定义扩展方法：将 object 类型对象转换为指定的类型
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="type">目标类型</param>
        /// <returns></returns>
        public static object ConvertTo(this object @this, Type type)
        {
            if (@this != null)
            {
                Type targetType = type;

                if (@this.GetType() == targetType)
                {
                    return @this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return converter.ConvertFrom(@this);
                    }
                }

                if (@this == DBNull.Value)
                {
                    return null;
                }
            }

            return @this;
        }

        #endregion
    }
}