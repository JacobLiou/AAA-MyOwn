namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定的 16 位带符号整数的值转换为等效的双精度浮点数。
        /// </summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的单精度浮点数。
        /// </returns>
        public static double ToDouble(this short value)
        {
            return (double)value;
        }

        /// <summary>
        /// 自定义扩展方法：将指定的 16 位无符号整数的值转换为等效的双精度浮点数。
        /// </summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的双精度浮点数。</returns>
        public static double ToDouble(this ushort value)
        {
            return (double)value;
        }
    }
}