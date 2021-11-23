using System.Collections.Generic;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将泛型数据中的元素加入集合中
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="values">泛型数组</param>
        public static void AddRange<T>(this ICollection<T> @this, params T[] values)
        {
            foreach(T value in values)
            {
                @this.Add(value);
            }
        }
    }
}