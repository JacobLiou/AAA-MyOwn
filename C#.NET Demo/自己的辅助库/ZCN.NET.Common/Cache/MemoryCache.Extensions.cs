#if NETFRAMEWORK

using System;
using System.Linq.Expressions;
using System.Runtime.Caching;

namespace ZCN.NET.Common.Cache
{
    /// <summary>
    /// 自定义扩展类
    /// </summary>ddd
    public static partial class CommonExtensions
    {
        private const string NAME = "ZCN.NET.Common.Cache.CommonExtensions.FromCache;";

        #region AddOrGetExisting

        /// <summary>
        ///  自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值。如果不存在则添加到缓存中并返回缓存值
        /// </summary>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="cache">内存中的缓存对象</param>
        /// <param name="key">缓存键</param>
        /// <param name="value">缓存值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <returns></returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, TValue value)
        {
            object item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;

            return (TValue)item;
        }

        /// <summary>
        ///  自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值。如果不存在则添加到缓存中并返回缓存值
        /// </summary>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="cache">内存中的缓存对象</param>
        /// <param name="key">缓存键</param>
        /// <param name="valueFactory">缓存值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <returns></returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache, string key, Func<string, TValue> valueFactory)
        {
            var lazy = new Lazy<TValue>(() => valueFactory(key));

            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;

            return item.Value;
        }

        /// <summary>
        ///  自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值。如果不存在则添加到缓存中并返回缓存值
        /// </summary>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="cache">内存中的缓存对象</param>
        /// <param name="key">缓存键</param>
        /// <param name="valueFactory">缓存值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <param name="policy">表示指定缓存项的一组逐出和过期详细信息</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域。
        ///  不要为该参数传递值。默认情况下，此参数为 null，因为 System.Runtime.Caching.MemoryCache类未实现区域
        /// </param>
        /// <returns></returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache,
            string key,
            Func<string, TValue> valueFactory,
            CacheItemPolicy policy,
            string regionName = null)
        {
            var lazy = new Lazy<TValue>(() => valueFactory(key));
            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, policy, regionName) ?? lazy;

            return item.Value;
        }

        /// <summary>
        ///  自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值。如果不存在则添加到缓存中并返回缓存值
        /// </summary>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="cache">内存中的缓存对象</param>
        /// <param name="key">缓存键</param>
        /// <param name="valueFactory">缓存值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <param name="absoluteExpiration">缓存过期时间点</param>
        /// <param name="regionName">缓存中的一个可用来添加缓存项的命名区域。
        ///  不要为该参数传递值。默认情况下，此参数为 null，因为 System.Runtime.Caching.MemoryCache类未实现区域
        /// </param>
        /// <returns></returns>
        public static TValue AddOrGetExisting<TValue>(this MemoryCache cache,
            string key,
            Func<string, TValue> valueFactory,
            DateTimeOffset absoluteExpiration,
            string regionName = null)
        {
            var lazy = new Lazy<TValue>(() => valueFactory(key));

            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, absoluteExpiration, regionName) ?? lazy;

            return item.Value;
        }

        #endregion

        #region Object.FromCache

        ///// <summary>
        /////     自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值。如果不存在则返回默认值
        ///// </summary>
        ///// <typeparam name="T">泛型类型参数，缓存键的类型</typeparam>
        ///// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        ///// <param name="this">扩展对象</param>
        ///// <param name="cache">内存中的缓存对象</param>
        ///// <param name="key">缓存键</param>
        ///// <param name="value">默认值。如果指定的键不存在于缓存中，默认返回此值</param>
        ///// <returns></returns>
        //public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, TValue value)
        //{
        //    object item = cache.AddOrGetExisting(key, value, new CacheItemPolicy()) ?? value;
        //    return (TValue)item;
        //}

        ///// <summary>
        /////     自定义扩展方法：从系统默认的内存缓存对象中获取指定键的缓存值。如果不存在则返回默认值
        ///// </summary>
        ///// <typeparam name="T">泛型类型参数，缓存键的类型</typeparam>
        ///// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        ///// <param name="this">扩展对象</param>
        ///// <param name="key">缓存键</param>
        ///// <param name="value">默认值。如果指定的键不存在于缓存中，默认返回此值</param>
        ///// <returns></returns>
        //public static TValue FromCache<T, TValue>(this T @this, string key, TValue value)
        //{
        //    return @this.FromCache(MemoryCache.Default, key, value);
        //}

        /// <summary>
        ///     自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值。如果不存在则返回默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数，缓存键的类型</typeparam>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="cache">内存中的缓存对象</param>
        /// <param name="key">缓存键</param>
        /// <param name="valueFactory">默认值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <returns></returns>
        public static TValue FromCache<T, TValue>(this T @this, MemoryCache cache, string key, Expression<Func<T, TValue>> valueFactory)
        {
            var lazy = new Lazy<TValue>(() => valueFactory.Compile()(@this));
            Lazy<TValue> item = (Lazy<TValue>)cache.AddOrGetExisting(key, lazy, new CacheItemPolicy()) ?? lazy;
            return item.Value;
        }

        /// <summary>
        ///     自定义扩展方法：从系统默认的内存缓存对象中获取指定键的缓存值。如果不存在则返回默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数，缓存键的类型</typeparam>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">缓存键</param>
        /// <param name="valueFactory">默认值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <returns></returns>
        public static TValue FromCache<T, TValue>(this T @this, string key, Expression<Func<T, TValue>> valueFactory)
        {
            return @this.FromCache(MemoryCache.Default, key, valueFactory);
        }

        /// <summary>
        ///     自定义扩展方法：从系统默认的内存缓存对象中获取指定键的缓存值
        ///     (由固定字符串ZFramework.NET.Extension.Caching.FromCache;扩展对象的完全限定名称与默认值 组合而成)。
        ///     如果不存在则返回默认值
        /// </summary>
        /// <typeparam name="TKey">泛型类型参数，缓存键的类型</typeparam>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="valueFactory">默认值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <returns></returns>
        public static TValue FromCache<TKey, TValue>(this TKey @this, Expression<Func<TKey, TValue>> valueFactory)
        {
            string key = string.Concat(NAME, typeof(TKey).FullName, valueFactory.ToString());
            return @this.FromCache(MemoryCache.Default, key, valueFactory);
        }

        /// <summary>
        ///     自定义扩展方法：从指定的内存缓存对象中获取指定键的缓存值
        ///     (由固定字符串ZFramework.NET.Extension.Caching.FromCache;扩展对象的完全限定名称与默认值 组合而成)。
        ///     如果不存在则返回默认值
        /// </summary>
        /// <typeparam name="TKey">泛型类型参数，缓存键的类型</typeparam>
        /// <typeparam name="TValue">泛型类型参数，缓存值的类型</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="cache">内存中的缓存对象</param>
        /// <param name="valueFactory">默认值。如果指定的键不存在于缓存中，默认返回此值</param>
        /// <returns></returns>
        public static TValue FromCache<TKey, TValue>(this TKey @this, MemoryCache cache, Expression<Func<TKey, TValue>> valueFactory)
        {
            string key = string.Concat(NAME, typeof(TKey).FullName, valueFactory.ToString());
            return @this.FromCache(cache, key, valueFactory);
        }

        #endregion
    }
}

#endif