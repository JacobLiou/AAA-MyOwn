using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定字符串中位于指定位置的字符是否具有代理项码位
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>如果字符串中位于位置 index 的字符为高代理项或低代理项，则为 true；否则为 false</returns>
        public static bool IsSurrogate(this string @this, int index)
        {
            return Char.IsSurrogate(@this, index);
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串中指定位置处的 System.Char 对象是否为高代理项
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns> 如果 s 参数中指定字符的数值范围从 U+D800 到 U+DBFF，则为 true；否则为 false</returns>
        public static bool IsHighSurrogate(this string @this, int index)
        {
            return Char.IsHighSurrogate(@this, index);
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串中指定位置处的 System.Char 对象是否为低代理项
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns> 如果 s 参数中指定字符的数值范围从 U+DC00 到 U+DFFF，则为 true；否则为 false
        /// </returns>
        public static bool IsLowSurrogate(this string @this, int index)
        {
            return Char.IsLowSurrogate(@this, index);
        }
    }
}