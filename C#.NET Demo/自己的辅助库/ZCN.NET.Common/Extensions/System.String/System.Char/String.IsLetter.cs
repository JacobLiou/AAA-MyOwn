using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 判断指定的 Unicode 字符是否属于字母
        /// </summary>
        /// <param name="this">扩展对象。字符串</param>
        /// <param name="index">要计算的字符在字符串中的位置</param>
        /// <returns>如果字符串中 index 位置处的字符是字母，则为 true；否则为 false</returns>
        public static bool IsLetter(this string @this, int index)
        {
            return Char.IsLetter(@this, index);
        }
    }
}