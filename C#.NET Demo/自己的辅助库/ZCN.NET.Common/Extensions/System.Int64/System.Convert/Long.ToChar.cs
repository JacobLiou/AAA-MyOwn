namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>自定义扩展方法：将指定 64 位有符号整数的值转换为它的等效 Unicode 字符。</summary>
        /// <param name="value">要转换的 64 位带符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的 Unicode 字符。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 小于 <see cref="F:System.Char.MinValue" /> 或大于 <see cref="F:System.Char.MaxValue" />。</exception>
        public static char ToChar(this long value)
        {
            return ((ulong)value).ToChar(); //Convert.ToChar(value); 的内部实现方式
        }

        /// <summary>自定义扩展方法：将指定 64 位无符号整数的值转换为其等效的 Unicode 字符。</summary>
        /// <param name="value">要转换的 64 位无符号整数。</param>
        /// <returns>一个等于 <paramref name="value" /> 的 Unicode 字符。</returns>
        /// <exception cref="T:System.OverflowException">
        /// <paramref name="value" /> 大于 <see cref="F:System.Char.MaxValue" />。</exception>
        public static char ToChar(this ulong value)
        {
            if (value > (ulong)ushort.MaxValue)
                return default(char);

            return (char)value; //Convert.ToChar(value); 的内部实现方式
        }
    }
}