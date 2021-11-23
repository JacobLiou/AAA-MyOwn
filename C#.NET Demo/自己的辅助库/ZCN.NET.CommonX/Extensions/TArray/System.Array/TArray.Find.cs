using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：搜索与指定谓词定义的条件匹配的元素，然后返回整个 System.Array 中的第一个匹配项。
        ///  如果找到与指定谓词定义的条件匹配的第一个元素，则为该元素；否则为类型 T 的默认值
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="match">定义要搜索的元素的条件</param>
        /// <returns></returns>
        public static T Find<T>(this T[] array, Predicate<T> match)
        {
            return Array.Find(array, match);
        }
    }
}