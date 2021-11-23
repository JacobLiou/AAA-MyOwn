using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：截取字符串中指定内容之后的的全部字符。
        ///   如果指定的内容不存在与字符串中则返回空字符串
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value">指定内容</param>
        /// <returns></returns>
        public static string SubstringAfter(this string @this, string value)
        {
            if (@this.IndexOf(value, StringComparison.Ordinal) == -1)
                return String.Empty;

            return @this.Substring(@this.IndexOf(value, StringComparison.Ordinal) + value.Length);
        }


        /// <summary>
        ///   自定义扩展方法：截取从字符串的开始位置到指定内容位置的字符。
        ///   如果指定的内容不存在与字符串中则返回空字符串
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value">指定内容</param>
        /// <returns></returns>
        public static string SubstringBefore(this string @this, string value)
        {
            if (@this.IndexOf(value, StringComparison.Ordinal) == -1)
                return String.Empty;
            
            return @this.Substring(0, @this.IndexOf(value, StringComparison.Ordinal));
        }

        /// <summary>
        ///   自定义扩展方法：如果指定长度小于字符串长度，则从字符串的开头截取到指定位置。
        ///   如果指定长度大于字符串长度，则返回原字符串
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">指定内容</param>
        /// <returns></returns>
        public static string SubstringLeft(this string @this, int length)
        {
            return @this.Substring(0, Math.Min(length, @this.Length));
        }

        /// <summary>
        ///   自定义扩展方法：如果指定长度小于字符串长度，则返回原字符串。
        ///   如果指定长度大于字符串长度，则从字符串的开头截取到指定位置
        /// </summary>
        /// <param name="this"></param>
        /// <param name="length">指定内容</param>
        /// <returns></returns>
        public static string SubstringRight(this string @this, int length)
        {
            return @this.Substring(Math.Max(0, @this.Length - length));
        }

        /// <summary>
        ///   自定义扩展方法：截取字符串中指定的2个字符串之间的字符。
        ///   如果指定的内容不存在与字符串中则返回空字符串
        /// </summary>
        /// <param name="this"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public static string SubstringBetween(this string @this, string before, string after)
        {
            int beforeStartIndex = @this.IndexOf(before, StringComparison.Ordinal);
            int startIndex = beforeStartIndex + before.Length;
            int afterStartIndex = @this.IndexOf(after, startIndex, StringComparison.Ordinal);

            if (beforeStartIndex == -1 || afterStartIndex == -1)
                return string.Empty;

            return @this.Substring(startIndex, afterStartIndex - startIndex);
        }
    }
}