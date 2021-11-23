using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断字典中是否包含数组中的任意一个元素。
        ///  包含任意一个时返回 true，否则返回false
        /// </summary>
        /// <typeparam name="TKey">泛型类型键</typeparam>
        /// <typeparam name="TValue">泛型类型值</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="keys">指定的泛型类型键</param>
        /// <returns></returns>
        public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey,TValue> @this,params TKey[] keys)
        {
            foreach(TKey value in keys)
            {
                if(@this.ContainsKey(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}