using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：(2、8、10 或 16位进制之间的转换)将 64 位带符号整数的值转换为其等效的二进制格式的字符串表示形式。
        /// 如果转换失败则返回 string.Empty。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>以 <paramref name="value" /> 为基数的二进制的字符串表示形式。</returns>
        public static string ToDigitBit2String(this long value)
        {
            try
            {
                return Convert.ToString(value, 2);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 自定义扩展方法：(2、8、10 或 16位进制之间的转换)将 64 位带符号整数的值转换为其等效的八进制格式的字符串表示形式。
        /// 如果转换失败则返回 string.Empty。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>以 <paramref name="value" /> 为基数的八进制的字符串表示形式。</returns>
        public static string ToDigitBit8String(this long value)
        {
            try
            {
                return Convert.ToString(value, 8);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 自定义扩展方法：(2、8、10 或 16位进制之间的转换)将 64 位带符号整数的值转换为其等效的十进制格式的字符串表示形式。
        /// 如果转换失败则返回 string.Empty。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>以 <paramref name="value" /> 为基数的十进制的字符串表示形式。</returns>
        public static string ToDigitBit10String(this long value)
        {
            try
            {
                return Convert.ToString(value, 10);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 自定义扩展方法：(2、8、10 或 16位进制之间的转换)将 64 位带符号整数的值转换为其等效的十六进制格式的字符串表示形式。
        /// 如果转换失败则返回 string.Empty。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>以 <paramref name="value" /> 为基数的十六进制的字符串表示形式。</returns>
        public static string ToDigitBit16String(this long value)
        {
            try
            {
                return Convert.ToString(value, 16);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}