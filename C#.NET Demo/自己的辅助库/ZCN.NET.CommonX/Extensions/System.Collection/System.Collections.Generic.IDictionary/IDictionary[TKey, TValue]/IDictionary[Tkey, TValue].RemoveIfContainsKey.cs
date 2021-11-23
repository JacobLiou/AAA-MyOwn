using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：如果字典中包含指定的键则从字典中移除该键值对
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="key">指定的泛型类型键</param>
        public static void RemoveIfContainsKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,TKey key)
        {
            if(@this.ContainsKey(key))
            {
                @this.Remove(key);
            }
        }
    }
}