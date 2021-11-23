using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：确定指定数组包含的元素是否与指定谓词定义的条件匹配
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="match">定义要搜索的元素的条件</param>
        /// <returns></returns>
        public static bool Exists<T>(this T[] array, Predicate<T> match)
        {
            return Array.Exists(array, match);
        }
    }
}