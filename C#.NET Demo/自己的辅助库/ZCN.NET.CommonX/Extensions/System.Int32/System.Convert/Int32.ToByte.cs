namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定 32 位有符号整数的值转换为等效的 8 位无符号整数。
        ///  如果参数大于 byte.MaxValue 或者小于0， 则返回 default(byte)值。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数。</returns>
        public static byte ToByte(this int value)
        {
            if (value < 0 || value > (int)byte.MaxValue)
                return default(byte);

            return (byte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定 32 位无符号整数的值转换为等效的 8 位无符号整数。
        /// 如果参数大于 byte.MaxValue， 则返回 default(byte)值。
        /// </summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数。</returns>
        public static byte ToByte(this uint value)
        {
            if (value > (uint)byte.MaxValue)
                return default(byte);

            return (byte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 32 位有符号整数的值转换为等效的 8 位有符号整数。
        /// 如果参数大于 sbyte.MaxValue 或者小于 sbyte.MinValue， 则返回 default(sbyte)值。
        /// </summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        public static sbyte ToSByte(this int value)
        {
            if (value < (int)sbyte.MinValue || value > (int)sbyte.MaxValue)
                return default(sbyte);

            return (sbyte)value;
        }

        /// <summary>
        ///  自定义扩展方法：将指定的 32 位无符号整数的值转换为等效的 8 位有符号整数。
        ///  如果参数大于 sbyte.MaxValue， 则返回 default(sbyte)值。
        /// </summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        public static sbyte ToSByte(this uint value)
        {
            if (value > (uint)sbyte.MaxValue)
                return default(sbyte);

            return (sbyte)value;
        }
    }
}