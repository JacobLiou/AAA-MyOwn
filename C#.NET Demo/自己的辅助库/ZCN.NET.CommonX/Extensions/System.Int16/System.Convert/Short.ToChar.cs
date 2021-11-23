namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定 16 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 16 位带符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的 Unicode 字符。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" />。</exception>
        public static char ToChar(this short value)
        {
            if (value < (short)0)
                return default(char);

            return (char)value; //Convert.ToChar(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 16 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 16 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的 Unicode 字符。</returns>
        public static char ToChar(this ushort value)
        {
            return (char)value; //Convert.ToChar(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 32 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 32 位带符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的 Unicode 字符。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" /> 或大于 <see cref="F:System.Char.MaxValue" />。</exception>
        public static char ToChar(this int value)
        {
            //Convert.ToChar(value); 的内部实现方式
            if (value < 0 || value > (int)ushort.MaxValue)
                return default(char);

            return (char)value;
        }

        /// <summary>自定义扩展方法：将指定 32 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 32 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的 Unicode 字符。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.Char.MaxValue" />。</exception>
        public static char ToChar(this uint value)
        {
            //Convert.ToChar(value); 的内部实现方式
            if (value > (uint)ushort.MaxValue)
                return default(char);

            return (char)value;
        }
    }
}