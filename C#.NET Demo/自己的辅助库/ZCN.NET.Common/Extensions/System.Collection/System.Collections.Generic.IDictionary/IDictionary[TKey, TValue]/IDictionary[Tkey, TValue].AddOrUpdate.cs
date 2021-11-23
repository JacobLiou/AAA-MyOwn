using System;
using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断如果字典中不包含指定的键，则将键与值加入字典中并返回并返回泛型类型的值；
        ///  如果包含键，则更新键对应的值并返回更新后的值
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="value">指定的泛型类型值</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey,TValue> @this,TKey key,TValue value)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,value));
            }
            else
            {
                @this[key] = value;
            }

            return @this[key];
        }

        /// <summary>
        ///  自定义扩展方法：判断如果字典中不包含指定的键，则将键与值加入字典中并返回并返回泛型类型的值；
        ///  如果包含键，则更新键对应的值并返回更新后的值
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="addValue">指定的泛型类型值，用于添加</param>
        /// <param name="updateValueFactory">指定的泛型类型值，用于更新</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            TValue addValue,
            Func<TKey,TValue,TValue> updateValueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,addValue));
            }
            else
            {
                @this[key] = updateValueFactory(key,@this[key]);
            }

            return @this[key];
        }

        /// <summary>
        ///  自定义扩展方法：判断如果字典中不包含指定的键，则将键与值加入字典中并返回并返回泛型类型的值；
        ///  如果包含键，则更新键对应的值并返回更新后的值
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        /// <param name="addValueFactory">指定的泛型类型值，用于添加(产生值的泛型委托)</param>
        /// <param name="updateValueFactory">指定的泛型类型值，用于更新</param>
        /// <returns></returns>
        public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey,TValue> @this,
            TKey key,
            Func<TKey,TValue> addValueFactory,
            Func<TKey,TValue,TValue> updateValueFactory)
        {
            if(!@this.ContainsKey(key))
            {
                @this.Add(new KeyValuePair<TKey,TValue>(key,addValueFactory(key)));
            }
            else
            {
                @this[key] = updateValueFactory(key,@this[key]);
            }

            return @this[key];
        }
    }
}