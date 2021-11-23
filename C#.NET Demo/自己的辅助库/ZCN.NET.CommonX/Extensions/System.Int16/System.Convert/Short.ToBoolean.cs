﻿using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定 16 位有符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。</returns>
        public static bool ToBoolean(this short value)
        {
            return (uint)value > 0U; //Convert.ToBoolean(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 16 位无符号整数的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。</returns>
        public static bool ToBoolean(this ushort value)
        {
            return value > (ushort)0; //Convert.ToBoolean(value); 的内部实现方式
        }
    }
}