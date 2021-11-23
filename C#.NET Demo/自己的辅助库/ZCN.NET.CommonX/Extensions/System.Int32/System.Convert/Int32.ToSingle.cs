using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定的 32 位带符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的单精度浮点数。</returns>
        public static float ToSingle(this int value)
        {
            return (float)value;
        }

        /// <summary>自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的单精度浮点数。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的单精度浮点数。</returns>
        public static float ToSingle(this uint value)
        {
            return (float)value;
        }
    }
}