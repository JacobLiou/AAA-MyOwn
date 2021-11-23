using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 判断指定字符串中位于指定位置的字符是否属于数字类别
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>如果字符串中位于 index 的字符是数字，则为 true；否则为 false</returns>
        public static bool IsNumber(this string @this, int index)
        {
            return Char.IsNumber(@this, index);
        }
    }
}