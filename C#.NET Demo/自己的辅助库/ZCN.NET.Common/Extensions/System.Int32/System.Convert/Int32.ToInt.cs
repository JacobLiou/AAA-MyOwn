using System;
using ZCN.NET.Common.Enums;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：(2、8、10 或 16位进制之间的转换)将指定基数的数字的字符串表示形式转换为等效的 32 位有符号整数。
        ///  如果 <paramref name="value" /> 为 <see langword="null" />，则返回 0（零）。
        ///  如果转换失败则返回 default(int) 值。
        ///  具体请参考微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.convert.tobyte?view=netcore-3.1
        /// </summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="digitBit">进制位枚举</param>
        /// <returns></returns>
        public static int ToInt32(this string value, DigitBit digitBit)
        {
            try
            {
                return Convert.ToInt32(value, digitBit.ToInt32());
            }
            catch
            {
                return default(int);
            }
        }

        /// <summary>
        ///  自定义扩展方法：(2、8、10 或 16位进制之间的转换)将指定基数的数字的字符串表示形式转换为等效的 32 位无符号整数。
        ///  如果 <paramref name="value" /> 为 <see langword="null" />，则返回 0（零）。
        ///  如果转换失败则返回 default(ushort) 值。
        ///  具体请参考微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.convert.tobyte?view=netcore-3.1
        /// </summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="digitBit">进制位枚举</param>
        /// <returns></returns>
        public static uint ToUInt32(this string value, DigitBit digitBit)
        {
            try
            {
                return Convert.ToUInt32(value, digitBit.ToInt32());
            }
            catch
            {
                return default(uint);
            }
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位有符号整数的值转换为等效的 16 位有符号整数。
        /// 如果参数大于 short.MaxValue 或者小于 short.MinValue， 则返回 default(short)值。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToInt16(this int value)
        {
            if (value < (int)short.MinValue || value > (int)short.MaxValue)
                return default(short);

            return (short)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的 16 位有符号整数。
        /// 如果参数大于 short.MaxValue ， 则返回 default(short)值。
        /// </summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToInt16(this uint value)
        {
            if (value > (uint)short.MaxValue)
                return default(short);

            return (short)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的 16 位无符号整数。
        /// 如果参数大于 大于 UInt16.MaxValue，则返回 default(ushort)值。
        /// </summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.UInt16.MaxValue" />。</exception>
        public static ushort ToUInt16(this uint value)
        {
            if (value > (uint)ushort.MaxValue)
                return default(ushort);

            return (ushort)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位有符号整数的值转换为等效的 32 位无符号整数。
        /// 如果参数大于 小于 0，则返回 default(uint)值。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于零。</exception>
        public static uint ToUInt32(this int value)
        {
            if (value < 0)
                return default(uint);

            return (uint)value;
        }

        /// <summary>自定义扩展方法：返回指定的 32 位无符号整数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 32 位无符号整数。</param>
        /// <returns>不经更改即返回 <paramref name="value" />。</returns>
        public static uint ToUInt32(this uint value)
        {
            return value;
        }

        /// <summary>自定义扩展方法：将指定的 32 位有符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static long ToInt64(this int value)
        {
            return (long)value;
        }

        /// <summary>自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static long ToInt64(this uint value)
        {
            return (long)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位有符号整数的值转换为等效的 64 位无符号整数。
        /// 如果参数小于0，则返回 default(ulong) 值。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位无符号整数。</returns>
        public static ulong ToUInt64(this int value)
        {
            if (value < 0)
                return default(ulong);

            return (ulong)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的 64 位无符号整数。
        /// </summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位无符号整数。</returns>
        public static ulong ToUInt64(this uint value)
        {
            return (ulong)value;
        }
    }
}