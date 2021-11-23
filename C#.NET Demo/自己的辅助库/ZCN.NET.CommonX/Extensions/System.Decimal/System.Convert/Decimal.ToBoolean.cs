using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定十进制数字的值转换为等效的布尔值。</summary>
        /// <param name="value">要转换的数字。</param>
        /// <returns>如果 <see langword="true" /> 不为零，则为 <paramref name="value" />；否则，为 <see langword="false" />。</returns>
        public static bool ToBoolean(this Decimal value)
        {
            return value != Decimal.Zero; //Convert.ToBoolean(value); 的内部实现方式
        }
    }
}