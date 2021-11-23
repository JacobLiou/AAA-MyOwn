using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断集合中是否包含数组中的任意一个元素。
        ///  包含任意一个时返回 true，否则返回false
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象。泛型集合</param>
        /// <param name="values">泛型数组</param>
        /// <returns></returns>
        public static bool ContainsAny<T>(this ICollection<T> @this, params T[] values)
        {
            foreach(T value in values)
            {
                if(@this.Contains(value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}