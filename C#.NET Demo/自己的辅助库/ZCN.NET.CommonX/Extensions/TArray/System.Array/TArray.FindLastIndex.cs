using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：搜索与指定谓词定义的条件匹配的元素，然后返回整个 System.Array 中最后一个匹配项的从零开始的索引。
        /// 如果找到与 match 定义的条件相匹配的最后一个元素，则为该元素的从零开始的索引；否则为 -1
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="match">定义要搜索的元素的条件</param>
        /// <returns></returns>
        public static int FindLastIndex<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindLastIndex(array, match);
        }

        /// <summary>
        /// 自定义扩展方法：搜索与指定谓词定义的条件匹配的元素，然后返回 System.Array 中从指定索引到最后一个元素的元素范围内
        /// 最后一个匹配项的从零开始的索引。
        /// 如果找到与 match 定义的条件相匹配的最后一个元素，则为该元素的从零开始的索引；否则为 -1
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="startIndex">从零开始的搜索的起始索引</param>
        /// <param name="match">定义要搜索的元素的条件</param>
        /// <returns></returns>
        public static int FindLastIndex<T>(this T[] array, int startIndex, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, match);
        }

        /// <summary>
        /// 自定义扩展方法：搜索与指定谓词定义的条件匹配的元素，然后返回 System.Array 中从指定索引开始并包含指定元素个数的元素范围内
        /// 最后一个匹配项的从零开始的索引。
        /// 如果找到与 match 定义的条件相匹配的最后一个元素，则为该元素的从零开始的索引；否则为 -1
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="startIndex">从零开始的搜索的起始索引</param>
        /// <param name="count">要搜索的部分中的元素数</param>
        /// <param name="match">定义要搜索的元素的条件</param>
        /// <returns></returns>
        public static int FindLastIndex<T>(this T[] array, int startIndex, int count, Predicate<T> match)
        {
            return Array.FindLastIndex(array, startIndex, count, match);
        }
    }
}