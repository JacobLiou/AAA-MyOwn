using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 判断指定字符串中位于指定位置处的字符是否属于小写字母类别
        /// </summary>
        /// <param name="this">字符串</param>
        /// <param name="index">要计算的字符在 s 中的位置</param>
        /// <returns>如果字符串中位于 index 处的字符是小写字母，则为 true；否则，为 false</returns>
        public static bool IsLower(this string @this, int index)
        {
            return Char.IsLower(@this, index);
        }
    }
}