// /* ---------------------------------------------------------------------------------------
//    文件名：MemoryCacheUtils.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁  （QQ：905442693  微信：savionzhang）
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

#region using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

#endregion

namespace BIMFace.SDK.CSharp.Common.Cache
{
    /// <summary>
    ///     基于MemoryCache线程安全的缓存辅助类
    /// </summary>
    public static class MemoryCacheUtils
    {
        private static readonly object _locker = new object();

        /// <summary>
        ///     创建一个缓存的键值，并指定响应的时间范围，如果失效，则自动获取对应的值
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="key">对象的键</param>
        /// <param name="cachePopulate">获取缓存值的操作(返回缓存值)</param>
        /// <param name="slidingExpiration">失效的时间范围</param>
        /// <param name="absoluteExpiration">失效的绝对时间</param>
        /// <returns></returns>
        public static T GetCacheItem<T>(string key, Func<T> cachePopulate, TimeSpan? slidingExpiration = null, DateTime? absoluteExpiration = null)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException("缓存键无效。");

            if (MemoryCache.Default[key] != null)
            {
                /* 不直接调用下面的重载方法的原因是：在特殊情况下防止立即执行委托 Func<T> cachePopulate。
                 * 例如：获取微信的AccessToken的时候，access_token的有效期目前为2个小时，需定时刷新(不是每次调用就重新获取)，重复获取将导致上次获取的access_token失效。
                 */
                return (T)MemoryCache.Default[key];
            }

            return GetCacheItem<T>(key, cachePopulate(), slidingExpiration, absoluteExpiration);

        }

        /// <summary>
        ///     创建一个缓存的键值，并指定响应的时间范围，如果失效，则自动获取对应的值
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="key">对象的键</param>
        /// <param name="keyValue">缓存值</param>
        /// <param name="slidingExpiration">失效的时间范围</param>
        /// <param name="absoluteExpiration">失效的绝对时间</param>
        /// <returns></returns>
        public static T GetCacheItem<T>(string key, object keyValue, TimeSpan? slidingExpiration = null, DateTime? absoluteExpiration = null)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentException("缓存键无效。");

            if (MemoryCache.Default[key] == null)
            {
                if (keyValue == null) throw new ArgumentNullException(@"缓存值不能为 null。");

                if (slidingExpiration == null && absoluteExpiration == null)
                    throw new ArgumentException("必须提供缓存失效的时间范围或失效的绝对时间。");

                lock (_locker)
                {
                    if (MemoryCache.Default[key] == null)
                    {
                        var item = new CacheItem(key, keyValue);
                        var policy = CreatePolicy(slidingExpiration, absoluteExpiration);

                        MemoryCache.Default.Add(item, policy);
                    }
                }
            }

            return (T)MemoryCache.Default[key];
        }

        private static CacheItemPolicy CreatePolicy(TimeSpan? slidingExpiration, DateTime? absoluteExpiration)
        {
            var policy = new CacheItemPolicy();
            ObjectCache cache = MemoryCache.Default;

            if (absoluteExpiration.HasValue)
            {
                policy.AbsoluteExpiration = absoluteExpiration.Value;
            }
            else if (slidingExpiration.HasValue)
            {
                policy.SlidingExpiration = slidingExpiration.Value;
            }

            policy.Priority = CacheItemPriority.Default;

            return policy;
        }

        /// <summary>
        ///      如果指定的项不存在，则插入一个新的缓存项。 如果指定的项存在，则将更新该项。
        ///      如果达到绝对过期时间，则自动从缓存中删除项
        /// </summary>
        /// <param name="key">缓存的键</param>
        /// <param name="value">缓存的值</param>
        /// <param name="absoluteExpiration">指示应从缓存中删除项的时间。</param>
        public static void SetItem(string key, object value, DateTime absoluteExpiration)
        {
            lock (_locker)
            {
                MemoryCache.Default.Set(key, value, absoluteExpiration);
            }
        }

        /// <summary>
        ///     永久放置键值到缓存里面
        /// </summary>
        /// <param name="key">缓存的键</param>
        /// <param name="value">缓存的值</param>
        public static void AddItem(string key, object value)
        {
            lock (_locker)
            {
                MemoryCache.Default.Add(key, value, DateTimeOffset.MaxValue);
            }
        }

        /// <summary>
        ///     在缓存里面获取指定的键值，如果键不存在，则返回null
        /// </summary>
        /// <param name="key">缓存的键</param>
        /// <returns></returns>
        public static object GetItem(string key)
        {
            lock (_locker)
            {
                object result = null;
                if (MemoryCache.Default.Contains(key))
                {
                    result = MemoryCache.Default[key];
                }

                return result;
            }
        }

        /// <summary>
        ///     移除缓存里面对应的键值
        /// </summary>
        /// <param name="key">缓存的键</param>
        public static void RemoveItem(string key)
        {
            lock (_locker)
            {
                if (MemoryCache.Default.Contains(key))
                {
                    MemoryCache.Default.Remove(key);
                }
            }
        }

        /// <summary>
        ///     清空缓存中所有项
        /// </summary>
        public static void ClearCache()
        {
            List<string> cacheKeys = MemoryCache.Default.Select(kvp => kvp.Key).ToList();
            foreach (string cacheKey in cacheKeys)
            {
                MemoryCache.Default.Remove(cacheKey);
            }
        }
    }
}