using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的十进制数。
        /// 如果转换失败，则返回 default(decimal)值。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的十进制数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.Decimal.MaxValue" /> 或小于 <see cref="F:System.Decimal.MinValue" />。</exception>
        public static Decimal ToDecimal(this float value)
        {
            try
            {
                return (Decimal)value;
            }
            catch
            {
                return default(decimal);
            }
        }
    }
}