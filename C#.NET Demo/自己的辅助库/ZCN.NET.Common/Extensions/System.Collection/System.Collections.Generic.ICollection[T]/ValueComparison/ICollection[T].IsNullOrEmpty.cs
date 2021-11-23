using System.Collections.Generic;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断集合是否为 null 或者元素的个数等于0 
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
        {
            return @this == null || @this.Count == 0;
        }

        /// <summary>
        ///  自定义扩展方法：判断集合是否不为 null 且元素的个数大于0。
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty<T>(this ICollection<T> @this)
        {
            return @this != null && @this.Count > 0;
        }
    }
}