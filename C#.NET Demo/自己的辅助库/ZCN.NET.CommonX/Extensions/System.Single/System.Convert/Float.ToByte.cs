using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定单精度浮点数的值转换为等效的 8 位无符号整数。
        /// 如果参数大于 byte.MaxValue 或者小于 byte.MinValue， 则返回 default(byte)值。
        /// </summary>
        /// <param name="value">单精度浮点数。</param>
        /// <returns>
        /// <paramref name="value" />，舍入为最接近的 8 位无符号整数。 如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。
        /// </returns>
        public static byte ToByte(this float value)
        {
            if (value < byte.MinValue || value > byte.MaxValue)
                return default(byte);

            return Convert.ToByte((double)value); //Convert.ToByte(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的 8 位带符号整数。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns />
        public static sbyte ToSByte(this float value)
        {
            if (value < sbyte.MinValue || value > sbyte.MaxValue)
                return default(sbyte);

            return Convert.ToSByte((double)value);
        }
    }
}