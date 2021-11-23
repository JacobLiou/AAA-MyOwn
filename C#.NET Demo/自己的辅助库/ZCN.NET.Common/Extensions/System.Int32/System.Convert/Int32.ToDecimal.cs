using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定的 32 位带符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的十进制数。</returns>
        public static Decimal ToDecimal(this int value)
        {
            return (Decimal)value;
        }

        /// <summary>自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的十进制数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的十进制数。</returns>
        public static Decimal ToDecimal(this uint value)
        {
            return (Decimal)value;
        }
    }
}