using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将字符串中指定位置的 UTF-16 编码字符或代理项对的值转换为 Unicode 码位
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>字符或代理项对表示的 21 位 Unicode 码位，该字符或代理项对在字符串参数中的位置由 index 参数指定</returns>
        public static int ConvertToUtf32(this string @this, int index)
        {
            return Char.ConvertToUtf32(@this, index);
        }
    }
}