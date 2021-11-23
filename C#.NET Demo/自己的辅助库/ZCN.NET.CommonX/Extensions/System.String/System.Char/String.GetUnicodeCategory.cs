using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定字符串中位于指定位置的字符分类到由一个 System.Globalization.UnicodeCategory 值标识的组中
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>一个 System.Globalization.UnicodeCategory 枚举常数，标识包含字符串中位于 index 处的字符的组</returns>
        public static UnicodeCategory GetUnicodeCategory(this string @this, int index)
        {
            return Char.GetUnicodeCategory(@this, index);
        }
    }
}