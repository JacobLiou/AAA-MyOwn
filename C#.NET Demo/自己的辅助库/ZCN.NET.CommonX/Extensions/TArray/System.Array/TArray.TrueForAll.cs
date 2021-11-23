using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：确定数组中的每个元素是否都与指定谓词定义的条件匹配。
        /// 
        /// 如果 array 中的每个元素都与指定谓词定义的条件匹配，则为 true；否则为 false。
        /// 如果数组中没有元素，则返回值为 true
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="array">扩展对象。从零开始的一维数组</param>
        /// <param name="match">定义检查元素时要对照的条件</param>
        /// <returns></returns>
        public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
        {
            return Array.TrueForAll(array, match);
        }
    }
}