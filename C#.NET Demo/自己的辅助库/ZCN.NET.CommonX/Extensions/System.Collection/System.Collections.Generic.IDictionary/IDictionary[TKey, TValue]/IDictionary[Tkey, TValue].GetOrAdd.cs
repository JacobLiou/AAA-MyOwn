using System;
using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：如果字典中不包含指定的键则将键值加入集合中，返回键对应的值
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="value">指定的泛型类型值</param>
        /// <returns></returns>
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey,TValue> @this,TKey key,TValue value)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,value));
            }

            return @this[key];
        }

        /// <summary>
        /// 自定义扩展方法：如果字典中不包含指定的键则将键值加入集合中，返回键对应的值
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="valueFactory">指定的泛型类型值(产生值的泛型方法)</param>
        /// <returns></returns>
        public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TKey,TValue> valueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,valueFactory(key)));
            }

            return @this[key];
        }
    }
}