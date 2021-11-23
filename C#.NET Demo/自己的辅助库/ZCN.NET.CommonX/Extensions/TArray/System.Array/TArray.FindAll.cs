using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：检索与指定谓词定义的条件匹配的所有元素。
        /// 如果找到一个其中所有元素均与指定谓词定义的条件匹配的 System.Array，则为该数组；否则为一个空 System.Array
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="match">定义要搜索的元素的条件</param>
        /// <returns></returns>
        public static T[] FindAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.FindAll(array, match);
        }
    }
}