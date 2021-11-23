using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定的 8 位带符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        public static float ToSingle(this sbyte value)
        {
            return (float)value;
        }

        /// <summary>自定义扩展方法：将指定的 8 位无符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的单精度浮点数。</returns>
        public static float ToSingle(this byte value)
        {
            return (float)value;
        }
    }
}