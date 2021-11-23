using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region AsOrDefault

        /// <summary>
        ///     自定义扩展方法： 将指定对象的值转换为等效的T类型的值。
        ///     如果转换失败，则返回T类型的默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static T AsOrDefault<T>(this object @this)
        {
            try
            {
                return (T) @this;
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        ///     自定义扩展方法： 将指定对象的值转换为等效的T类型的值。
        ///     如果转换失败，则返回指定的默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static T AsOrDefault<T>(this object @this, T defaultValue)
        {
            try
            {
                return (T) @this;
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///     自定义扩展方法： 将指定对象的值转换为等效的T类型的值。
        ///     如果转换失败，则返回指定的默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">默认值(产生默认值的方法)</param>
        /// <returns></returns>
        public static T AsOrDefault<T>(this object @this, Func<T> defaultValueFactory)
        {
            try
            {
                return (T) @this;
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        /// <summary>
        ///     自定义扩展方法： 将指定对象的值转换为等效的T类型的值。
        ///     如果转换失败，则返回指定的默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">默认值(产生默认值的方法)</param>
        /// <returns></returns>
        public static T AsOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
        {
            try
            {
                return (T) @this;
            }
            catch
            {
                return defaultValueFactory(@this);
            }
        }

        #endregion
    }
}