using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 将指定字符串中位于指定位置的数字 Unicode 字符转换为双精度浮点数
        /// </summary>
        /// <param name="this">扩展对象。字符串</param>
        /// <param name="index">要计算的字符在字符串中的位置</param>
        /// <returns>如果字符串中位于 index 处的字符表示数字，则为该字符的数值；否则为 -1 </returns>
        public static double GetNumericValue(this string @this, int index)
        {
            return Char.GetNumericValue(@this, index);
        }
    }
}