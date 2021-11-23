using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将 8 位无符号整数数组的子集转换为用 Base64 数字编码的 Unicode 字符数组的等价子集。
        /// 参数将子集指定为输入和输出数组中的偏移量和输入数组中要转换的元素数。
        /// 如果参数为null，则返回0
        /// </summary>
        /// <param name="inArray">8 位无符号整数的输入数组</param>
        /// <param name="offsetIn">inArray 内的一个位置</param>
        /// <param name="length">要转换的 inArray 的元素数</param>
        /// <param name="outArray">Unicode 字符的输出数组</param>
        /// <param name="offsetOut">outArray 内的一个位置</param>
        /// <returns>包含 outArray 中的字节数的 32 位有符号整数</returns>
        public static int ToBase64CharArray(this byte[] inArray,
            int offsetIn,
            int length,
            char[] outArray,
            int offsetOut)
        {
            if (inArray == null)
                return 0;
            
            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut);
        }

        /// <summary>
        /// 自定义扩展方法： 将 8 位无符号整数数组的子集转换为用 Base64 数字编码的 Unicode 字符数组的等价子集。
        /// 参数指定作为输入和输出数组中偏移量的子集、输入数组中要转换的元素数以及是否在输出数组中插入分行符。
        /// 如果参数为null，则返回0
        /// </summary>
        /// <param name="inArray">8 位无符号整数的输入数组</param>
        /// <param name="offsetIn">inArray 内的一个位置</param>
        /// <param name="length">要转换的 inArray 的元素数</param>
        /// <param name="outArray">Unicode 字符的输出数组</param>
        /// <param name="offsetOut">outArray 内的一个位置</param>
        /// <param name="options">如果每 76 个字符插入一个分行符，则使用 System.Base64FormattingOptions.InsertLineBreaks，
        /// 如果不插入分行符，则使用System.Base64FormattingOptions.None</param>
        /// <returns></returns>
        public static int ToBase64CharArray(this byte[] inArray,
            int offsetIn,
            int length,
            char[] outArray,
            int offsetOut,
            Base64FormattingOptions options)
        {
            if (inArray == null)
                return 0;

            return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options);
        }
    }
}