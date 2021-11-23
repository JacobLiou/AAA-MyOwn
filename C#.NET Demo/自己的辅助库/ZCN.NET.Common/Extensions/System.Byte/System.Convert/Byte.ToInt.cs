namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定 8 位带符号整数的值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的16 位带符号整数。</returns>
        public static short ToInt16(this sbyte value)
        {
            return (short)value; //Convert.ToInt16(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 8 位无符号整数的值转换为等效的 16 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位带符号整数。</returns>
        public static short ToInt16(this byte value)
        {
            return (short)value; //Convert.ToInt16(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 8 位有符号整数的值转换为等效的 16 位无符号整数。
        /// 如果参数小于0，则返回 default(ushort) 值。
        /// </summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于零。</exception>
        public static ushort ToUInt16(this sbyte value)
        {
            if (value < (sbyte)0)
                return default(ushort);

            return (ushort)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 8 位无符号整数的值转换为等效的 16 位无符号整数。
        /// </summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 16 位无符号整数。</returns>
        public static ushort ToUInt16(this byte value)
        {
            return (ushort)value;
        }

        /// <summary>自定义扩展方法：将指定 8 位带符号整数的值转换为等效的 32 位带符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static int ToInt32(this sbyte value)
        {
            return (int)value; //Convert.ToInt32(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 8 位无符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static int ToInt32(this byte value)
        {
            return (int)value; //Convert.ToInt32(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定 8 位带符号整数的值转换为等效的 32 位带符号整数。
        /// 如果参数小于0，则返回 default(uint) 值。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static uint ToUInt32(this sbyte value)
        {
            if (value < (sbyte)0)
                return default(uint);

            return (uint)value; //Convert.ToUInt32(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 8 位无符号整数的值转换为等效的 32 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 32 位带符号整数。</returns>
        public static uint ToUInt32(this byte value)
        {
            return (uint)value; //Convert.ToUInt32(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 8 位带符号整数的值转换为等效的 16 位带符号整数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static long ToInt64(this sbyte value)
        {
            return (long)value; //Convert.ToInt64(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 8 位有符号整数的值转换为等效的 64 位无符号整数。
        /// 如果参数小于0，则返回 default(ulong)。
        /// </summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位无符号整数。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于零。</exception>
        public static ulong ToUInt64(this sbyte value)
        {
            if (value < (sbyte)0)
                return default(ulong);

            return (ulong)value;
        }

        /// <summary>自定义扩展方法：将指定 8 位无符号整数的值转换为等效的 64 位有符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static long ToInt64(this byte value)
        {
            return (long)value; //Convert.ToInt64(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定的 8 位无符号整数的值转换为等效的 64 位无符号整数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>一个与 <paramref name="value" /> 等效的 64 位带符号整数。</returns>
        public static ulong ToUInt64(this byte value)
        {
            return (ulong)value;
        }
    }
}