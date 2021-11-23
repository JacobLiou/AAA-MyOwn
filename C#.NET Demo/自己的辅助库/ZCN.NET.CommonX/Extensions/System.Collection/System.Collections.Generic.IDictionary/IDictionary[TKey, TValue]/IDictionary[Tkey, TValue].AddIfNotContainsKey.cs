using System;
using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断如果字典中不包含指定的键，则将键与值加入字典中并返回 true ；否则返回 false
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="value">指定的泛型类型值</param>
        /// <returns></returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            TValue value)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(key,value);
                return true;
            }

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断如果字典中不包含指定的键，则将键与值加入字典中并返回 true ；否则返回 false
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="valueFactory">指定的泛型类型值(产生值的委托方法)</param>
        /// <returns></returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TValue> valueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(key,valueFactory());
                return true;
            }

            return false;
        }

        /// <summary>
        ///  自定义扩展方法：判断如果字典中不包含指定的键，则将键与值加入字典中并返回 true ；否则返回 false
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="valueFactory">指定的泛型类型值(产生值的委托方法)</param>
        /// <returns></returns>
        public static bool AddIfNotContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TKey,TValue> valueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(key,valueFactory(key));
                return true;
            }

            return false;
        }
    }
}