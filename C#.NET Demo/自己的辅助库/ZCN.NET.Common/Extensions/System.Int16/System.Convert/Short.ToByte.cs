namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定 16 位有符号整数的值转换为等效的 8 位无符号整数。
        ///  如果参数大于 byte.MaxValue 或者小于0， 则返回 default(byte)值。
        /// </summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数。</returns>
        public static byte ToByte(this short value)
        {
            if (value < (short)0 || value > (short)byte.MaxValue)
                return default(byte);

            return (byte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定 16 位无符号整数的值转换为等效的 8 位无符号整数。
        /// 如果参数大于 byte.MaxValue， 则返回 default(byte)值。
        /// </summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数。</returns>
        public static byte ToByte(this ushort value)
        {
            if (value > (ushort)byte.MaxValue)
                return default(byte);

            return (byte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 16 位带符号整数的值转换为等效的 8 位带符号整数。
        /// 如果参数大于 sbyte.MaxValue 或者小于 sbyte.MinValue， 则返回 default(sbyte)值。
        /// </summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        public static sbyte ToSByte(this short value)
        {
            if (value < (short)sbyte.MinValue || value > (short)sbyte.MaxValue)
                return default(sbyte);

            return (sbyte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 16 位无符号整数的值转换为等效的 8 位有符号整数。
        /// 如果参数大于 sbyte.MaxValue， 则返回 default(sbyte)值。
        /// </summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.SByte.MaxValue" />。</exception>
        public static sbyte ToSByte(this ushort value)
        {
            if (value > (ushort)sbyte.MaxValue)
                return default(sbyte);

            return (sbyte)value;
        }
    }
}