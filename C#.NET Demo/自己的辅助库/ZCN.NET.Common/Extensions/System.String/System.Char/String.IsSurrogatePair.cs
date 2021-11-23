using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串中指定位置处的两个相邻 System.Char 对象是否形成代理项对
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>如果字符串参数包括 index 和 index + 1 位置处的相邻字符，并且 index 位置处字符的数值在 U+D800 到 U+DBFF 范围内，
        ///          index +1 位置处字符的数值在 U+DC00 到 U+DFFF 范围内，则为 true；否则为 false
        /// </returns>
        public static bool IsSurrogatePair(this string @this, int index)
        {
            return Char.IsSurrogatePair(@this, index);
        }
    }
}