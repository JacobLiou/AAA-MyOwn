using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数的数组转换为其用 Base64 数字编码的等效字符串表示形式
        /// </summary>
        /// <param name="inArray">一个 8 位无符号整数数组</param>
        /// <returns> inArray 的内容的字符串表示形式，以 Base64 表示</returns>
        public static string ToBase64String(this byte[] inArray)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray);
        }

        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数的数组转换为其用 Base64 数字编码的等效字符串表示形式。参数指定是否在返回值中插入分行符
        /// </summary>
        /// <param name="inArray">一个 8 位无符号整数数组</param>
        /// <param name="options">如果每 76 个字符插入一个分行符，则使用 System.Base64FormattingOptions.InsertLineBreaks，
        /// 如果不插入分行符，则使用System.Base64FormattingOptions.None</param>
        /// <returns> inArray 的内容的字符串表示形式，以 Base64 表示</returns>
        public static string ToBase64String(this byte[] inArray, Base64FormattingOptions options)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray, options);
        }

        /// <summary>
        /// 自定义扩展方法： 将 8 位无符号整数数组的子集转换为其用 Base64 数字编码的等效字符串表示形式。
        /// 参数将子集指定为输入数组中的偏移量和数组中要转换的元素数
        /// </summary>
        /// <param name="inArray">一个 8 位无符号整数数组</param>
        /// <param name="offset">inArray 中的偏移量</param>
        /// <param name="length">要转换的 inArray 的元素数</param>
        /// <returns></returns>
        public static string ToBase64String(this byte[] inArray, int offset, int length)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray, offset, length);
        }

        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数数组的子集转换为其用 Base64 数字编码的等效字符串表示形式。
        /// 参数指定作为输入数组中偏移量的子集、数组中要转换的元素数以及是否在返回值中插入分行符
        /// </summary>
        /// <param name="inArray">一个 8 位无符号整数数组</param>
        /// <param name="offset">inArray 中的偏移量</param>
        /// <param name="length">要转换的 inArray 的元素数</param>
        /// <param name="options">如果每 76 个字符插入一个分行符，则使用 System.Base64FormattingOptions.InsertLineBreaks，
        /// 如果不插入分行符，则使用System.Base64FormattingOptions.None</param>
        /// <returns></returns>
        public static string ToBase64String(this byte[] inArray, int offset, int length, Base64FormattingOptions options)
        {
            if (inArray == null)
                return null;

            return Convert.ToBase64String(inArray, offset, length, options);
        }

#if NETSTANDARD2_1

        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数的指定范围转换为其用 Base64 数字编码的等效字符串表示形式
        /// </summary>
        /// <param name="bytes">一个 8 位无符号整数数组</param>
        /// <returns> inArray 的内容的字符串表示形式，以 Base64 表示</returns>
        public static string ToBase64String(this ReadOnlySpan<byte> bytes)
        {
            if (bytes == null)
                return null;

            return Convert.ToBase64String(bytes);
        }

#endif
    }
}