using System;
using ZCN.NET.CommonX.Enums;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定的 32 位有符号整数的值转换为等效的 16 位有符号整数。
        /// 如果参数大于 short.MaxValue 或者小于 short.MinValue，则返回 default(short)值。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToInt16(this long value)
        {
            if (value < (long)short.MinValue || value > (long)short.MaxValue)
                return default(short);

            return (short)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位有符号整数的值转换为等效的 16 位无符号整数。
        /// 如果参数大于 short.MaxValue，则返回 default(short)值。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToInt16(this ulong value)
        {
            if (value > (ulong)short.MaxValue)
                return default(short);

            return (short)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位有符号整数的值转换为等效的 16 位无符号整数。
        /// 如果参数大于 ushort.MaxValue 或者小于 ushort.MinValue，则返回 default(ushort)值。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位无符号整数。</returns>
        public static ushort ToUInt16(this long value)
        {
            if (value < 0L || value > (long)ushort.MaxValue)
                return default(ushort);

            return (ushort)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位无符号整数的值转换为等效的 16 位无符号整数。
        /// 如果参数大于 ushort.MaxValue，则返回 default(ushort)值。
        /// </summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位无符号整数。</returns>
        public static ushort ToUInt16(this ulong value)
        {
            if (value > (ulong)ushort.MaxValue)
                return default(ushort);

            return (ushort)value;
        }

        /// <summary>
        ///  自定义扩展方法：将指定 64 位有符号整数的值转换为等效的 32 位有符号整数。
        ///  如果参数小于 int.MinValue 或者 大于 int.MaxValue，则返回 default(Int32)
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static int ToInt32(this long value)
        {
            if (value < (long)int.MinValue || value > (long)int.MaxValue)
                return default(Int32);

            return (int)value; //Convert.ToInt32(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定 64 位无符号整数的值转换为等效的 32 位有符号整数。
        /// 如果参数大于 int.MaxValue，则返回 default(Int32)
        /// </summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static int ToInt32(this ulong value)
        {
            if (value > (ulong)int.MaxValue)
                return default(Int32);

            return (int)value; //Convert.ToInt32(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位有符号整数的值转换为等效的 32 位无符号整数。
        /// 如果参数大于 uint.MaxValue 或者小于 uint.MinValue，则返回 default(uint)值。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt32.MaxValue" />。</exception>
        public static uint ToUInt32(this long value)
        {
            if (value < 0L || value > (long)uint.MaxValue)
                return default(uint);

            return (uint)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位无符号整数的值转换为等效的 32 位无符号整数。
        /// 如果参数大于 uint.MaxValue，则返回 default(uint)值。
        /// </summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.UInt32.MaxValue" />。</exception>
        public static uint ToUInt32(this ulong value)
        {
            if (value > (ulong)uint.MaxValue)
                return default(uint);

            return (uint)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位无符号整数的值转换为等效的 64 位有符号整数。
        /// 如果参数大于 (ulong)long.MaxValue)，则返回 default(long) 值。
        /// </summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.Int64.MaxValue" />。</exception>
        public static long ToInt64(this ulong value)
        {
            if (value > (ulong)long.MaxValue)
                return default(long);

            return (long)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 64 位有符号整数的值转换为等效的 64 位无符号整数。
        /// 如果参数小于0，则返回 default(ulong) 值。
        /// </summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于零。</exception>
        public static ulong ToUInt64(this long value)
        {
            if (value < 0L)
                return default(ulong);

            return (ulong)value;
        }

        /// <summary>自定义扩展方法：返回指定的 64 位无符号整数；不执行任何实际的转换。</summary>
        /// <param name="value">要返回的 64 位无符号整数。</param>
        /// <returns>不经更改即返回 <paramref name="value" />。</returns>
        public static ulong ToUInt64(this ulong value)
        {
            return value;
        }

        /// <summary>
        ///  自定义扩展方法：(2、8、10 或 16位进制之间的转换)将指定基数的数字的字符串表示形式转换为等效的 64 位有符号整数。
        ///  如果 <paramref name="value" /> 为 <see langword="null" />，则返回 0（零）。
        ///  如果转换失败则返回 default(long) 值。
        ///  具体请参考微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.convert.tobyte?view=netcore-3.1
        /// </summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="digitBit">进制位枚举</param>
        /// <returns></returns>
        public static long ToInt64(this string value, DigitBit digitBit)
        {
            try
            {
                return Convert.ToInt64(value, digitBit.ToInt32());
            }
            catch
            {
                return default(long);
            }
        }

        /// <summary>
        ///  自定义扩展方法：(2、8、10 或 16位进制之间的转换)将指定基数的数字的字符串表示形式转换为等效的 64 位无符号整数。
        ///  如果 <paramref name="value" /> 为 <see langword="null" />，则返回 0（零）。
        ///  如果转换失败则返回 default(ulong) 值。
        ///  具体请参考微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.convert.tobyte?view=netcore-3.1
        /// </summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="digitBit">进制位枚举</param>
        /// <returns></returns>
        public static ulong ToUInt64(this string value, DigitBit digitBit)
        {
            try
            {
                return Convert.ToUInt64(value, digitBit.ToInt32());
            }
            catch
            {
                return default(ulong);
            }
        }

    }
}