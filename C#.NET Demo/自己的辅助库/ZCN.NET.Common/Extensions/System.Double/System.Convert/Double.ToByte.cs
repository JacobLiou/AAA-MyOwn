using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定双精度浮点数的值转换为等效的 8 位无符号整数。
        /// 如果参数大于 byte.MaxValue 或者小于 byte.MinValue， 则返回 default(byte)值。
        /// </summary>
        /// <param name="value">双精度浮点数。</param>
        /// <returns></returns>
        public static byte ToByte(this double value)
        {
            if (value < byte.MinValue || value > byte.MaxValue)
                return default(byte);

            return Convert.ToByte(Convert.ToInt32(value)); //Convert.ToByte(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定的双精度浮点数的值转换为等效的 8 位带符号整数。
        /// 如果参数大于 sbyte.MaxValue 或者小于 sbyte.MinValue， 则返回 default(sbyte)值。
        /// </summary>
        /// <param name="value">要转换的双精度浮点数。</param>
        /// <returns> </returns>
        public static sbyte ToSByte(double value)
        {
            if (value < sbyte.MinValue || value > sbyte.MaxValue)
                return default(sbyte);

            return Convert.ToSByte(Convert.ToInt32(value));
        }
    }
}