using System;
using System.Collections.Generic;
using System.Linq;
namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：生成指定范围内的整数的序列。
        /// 例如：@this 为 A，toCharacter 为 D，则返回 A B C D 的集合
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="toCharacter"></param>
        /// <returns></returns>
        public static IEnumerable<char> CreateRange(this char @this, char toCharacter)
        {
            bool reverseRequired = @this > toCharacter; //是否需要反转排序。如果扩展对象大于目标字符

            char first = reverseRequired ? toCharacter : @this;
            char last = reverseRequired ? @this : toCharacter;

            IEnumerable<char> result = Enumerable.Range(first, last - first + 1).Select(charCode => (char)charCode);

            if (reverseRequired)
            {
                result = result.Reverse();
            }

            return result;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 Unicode 字符的值转换为等效的 8 位有符号整数。
        /// 如果参数大于 SByte.MaxValue ，则返回 default(short)值
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToSByte(this char value)
        {
            if (value > SByte.MaxValue)
                return default(short);

            return (sbyte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定 Unicode 字符的值转换为等效的 16 位有符号整数。
        /// 如果参数大于 Int16.MaxValue ，则返回 default(short)值
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToInt16(this char value)
        {
            if (value > Int16.MaxValue)
                return default(short);

            return (short)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定 Unicode 字符的值转换为等效的 16 位无符号整数。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static ushort ToUInt16(this char value)
        {
            return (ushort)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定 Unicode 字符的值转换为等效的 32 位有符号整数。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static int ToInt32(this char value)
        {
            return (int)value; 
        }

        /// <summary>
        /// 自定义扩展方法：将指定 Unicode 字符的值转换为等效的 32 位无符号整数。
        /// </summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位无符号整数。</returns>
        public static uint ToUInt32(this char value)
        {
            return (uint)value;
        }

        /// <summary>自定义扩展方法：将指定的 Unicode 字符的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static long ToInt64(this char value)
        {
            return (long)value;
        }

        /// <summary>自定义扩展方法：自定义扩展方法：将指定的 Unicode 字符的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 Unicode 字符。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static ulong ToUInt64(this char value)
        {
            return (ulong)value;
        }

    }
}