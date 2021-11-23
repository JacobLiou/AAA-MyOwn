using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断如果集合中包含数组中的元素则将元素从集合中移除
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="values">泛型数组</param>
        public static void RemoveRangeIfContains<T>(this ICollection<T> @this,params T[] values)
        {
            foreach(T value in values)
            {
                if(@this.Contains(value))
                {
                    @this.Remove(value);
                }
            }
        }
    }
}