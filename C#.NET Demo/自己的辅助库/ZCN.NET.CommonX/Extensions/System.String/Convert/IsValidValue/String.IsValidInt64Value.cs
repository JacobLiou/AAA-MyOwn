namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位有符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt64Value(this string @this)
        {
            return @this.IsValidLongValue();
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位有符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt64ValueNullable(this string @this)
        {
            return @this.IsValidLongValueNullable();
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位无符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt64Value(this string @this)
        {
            return @this.IsValidULongValue();
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位无符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt64ValueNullable(this string @this)
        {
            return @this.IsValidULongValueNullable();
        }
    }
}