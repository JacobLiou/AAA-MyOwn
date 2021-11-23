namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定的 8 位带符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 8 位带符号整数。</param>
        /// <returns>与 <paramref name="value" /> 等效的 8 位带符号整数。</returns>
        public static double ToDouble(this sbyte value)
        {
            return (double)value;
        }

        /// <summary>自定义扩展方法：将指定的 8 位无符号整数的值转换为等效的双精度浮点数。</summary>
        /// <param name="value">要转换的 8 位无符号整数。</param>
        /// <returns>与 <paramref name="value" /> 等效的双精度浮点数。</returns>
        public static double ToDouble(this byte value)
        {
            return (double)value;
        }
    }
}
