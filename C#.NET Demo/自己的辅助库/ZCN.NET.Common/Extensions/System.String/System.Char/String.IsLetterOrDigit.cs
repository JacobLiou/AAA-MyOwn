using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断将指定字符串中指定位置处的字符分类为字母还是十进制数字
        /// </summary>
        /// <param name="this">扩展对象。字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>如果字符串中 index 位置处的字符是字母或十进制数字，则为 true；否则为 false</returns>
        public static bool IsLetterOrDigit(this string @this, int index)
        {
            return Char.IsLetterOrDigit(@this, index);
        }
    }
}