using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断字符串中是否不包含指定的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="value">字符串</param>
        /// <returns>不包含返回true，包含返回false</returns>
        public static bool NotContains(this string @this, string value)
        {
            return @this.Contains(value) == false;
        }

        /// <summary>
        ///  自定义扩展方法：判断字符串中是否包不含指定的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="value">字符串</param>
        /// <param name="comparisonType">指定搜索规则的枚举值之一</param>
        /// <returns>不包含返回true，包含返回false</returns>
        public static bool NotContains(this string @this, string value, StringComparison comparisonType)
        {
            return @this.IndexOf(value, comparisonType) == -1;
        }
    }
}