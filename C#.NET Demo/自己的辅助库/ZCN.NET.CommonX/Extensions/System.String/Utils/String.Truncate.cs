namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将阶段的字符串使用三个点代替
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="maxLength">最终显示的最大长度</param>
        /// <returns>A string.</returns>
        public static string Truncate(this string @this, int maxLength)
        {
            const string suffix = "...";

            if (@this == null || @this.Length <= maxLength)
            {
                return @this;
            }

            int strLength = maxLength - suffix.Length;
            return @this.Substring(0, strLength) + suffix;
        }

        /// <summary>
        ///  自定义扩展方法：将截断的字符串使用后缀代替
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="maxLength">最终显示的最大长度</param>
        /// <param name="suffix">后缀，替换字符串</param>
        /// <returns>A string.</returns>
        public static string Truncate(this string @this, int maxLength, string suffix)
        {
            if (@this == null || @this.Length <= maxLength)
            {
                return @this;
            }

            int strLength = maxLength - suffix.Length;
            return @this.Substring(0, strLength) + suffix;
        }
    }
}