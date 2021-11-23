using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定的双精度浮点数的值转换为等效的十进制数。
        /// 如果转换失败，则返回 default(decimal)值。
        /// </summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns></returns>
        public static Decimal ToDecimal(double value)
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