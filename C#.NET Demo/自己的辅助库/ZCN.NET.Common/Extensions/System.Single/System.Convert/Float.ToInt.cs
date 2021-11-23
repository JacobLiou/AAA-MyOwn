using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的 16 位带符号整数。
        /// 如果参数小于 Int16.MinValue 或者 大于 Int16.MaxValue，则返回 default(Int16)。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns></returns>
        public static short ToInt16(this float value)
        {
            if (value < Int16.MinValue || value > Int16.MaxValue)
                return default(Int16);

            return Convert.ToInt16((double)value);
        }

        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的 16 位无符号整数。
        /// 如果参数小于 UInt16.MinValue 或者 大于 UInt16.MaxValue，则返回 default(UInt16)。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns></returns>
        public static ushort ToUInt16(this float value)
        {
            if (value < UInt16.MinValue || value > UInt16.MaxValue) // UInt16.MinValue = 0
                return default(UInt16);

            return Convert.ToUInt16((double)value);
        }

        /// <summary>
        ///  自定义扩展方法：将指定单精度浮点数的值转换为等效的 32 位带符号整数。
        ///  如果参数小于 int.MinValue 或者 大于 int.MaxValue，则返回 default(Int32)。
        /// </summary>
        /// <param name="value">单精度浮点数。</param>
        /// <returns>
        /// </returns>
        public static int ToIn32(this float value)
        {
            if (value < Int32.MinValue || value > Int32.MaxValue)
                return default(Int32);

            return Convert.ToInt32((double)value); //Convert.ToInt32(value); 的内部实现方式
        }

        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的 32 位无符号整数。
        /// 如果参数小于 0 或者 大于 uint.MaxValue，则返回 default(uint)。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns></returns>
        public static uint ToUInt32(this float value)
        {
            if (value < 0 || value > UInt32.MaxValue)
                return default(uint);

            return Convert.ToUInt32((double)value);
        }

        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的 64 位带符号整数。
        /// 如果参数小于 Int64.MinValue 或者 大于 Int64.MaxValue，则返回 default(long)。
        /// </summary>
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        /// <paramref name="value" />，舍入为最接近的 64 位有符号整数。 如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.Int64.MaxValue" /> 或小于 <see cref="F:System.Int64.MinValue" />。</exception>
        public static long ToInt64(this float value)
        {
            if (value < Int64.MinValue || value > Int64.MaxValue)
                return default(long);

            return Convert.ToInt64((double)value);
        }


        /// <summary>
        /// 自定义扩展方法：将指定的单精度浮点数的值转换为等效的 64 位无符号整数。</summary>
        /// 如果参数小于 UInt64.MinValue 或者 大于 UInt64.MaxValue，则返回 default(UInt64)。
        /// <param name="value">要转换的单精度浮点数。</param>
        /// <returns>
        /// <paramref name="value" />，舍入为最接近的 64 位无符号整数。 如果 <paramref name="value" /> 为两个整数中间的数字，则返回二者中的偶数；即 4.5 转换为 4，而 5.5 转换为 6。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于零或大于 <see cref="F:System.UInt64.MaxValue" />。</exception>
        public static ulong ToUInt64(this float value)
        {
            if (value < UInt64.MinValue || value > UInt64.MaxValue)
                return default(ulong);

            return Convert.ToUInt64((double)value);
        }
    }
}