namespace ZCN.NET.CommonX.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定 8 位有符号整数的值转换为等效的 8 位无符号整数。
        /// 如果参数小于0，则返回 default(byte)值
        /// </summary>
        /// <param name="value">要转换的 8 位有符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位无符号整数。</returns>
        public static byte ToByte(this sbyte value)
        {
            if (value < (sbyte)0)
                return default(byte);

            return (byte)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 8 位无符号整数的值转换为等效的 8 位有符号整数。
        /// 如果参数大于 SByte.MaxValue，则返回 default(sbyte)值
        /// </summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        public static sbyte ToSByte(this byte value)
        {
            if (value > 127) //  SByte.MaxValue
                return default(sbyte);

            return (sbyte)value;
        }
    }
}