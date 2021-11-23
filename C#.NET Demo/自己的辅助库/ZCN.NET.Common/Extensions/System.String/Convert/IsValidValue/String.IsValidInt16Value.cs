namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位有符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt16Value(this string @this)
        {
            return @this.IsValidShortValue();
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位有符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt16ValueNullable(this string @this)
        {
            return @this.IsValidShortValueNullable();
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位无符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt16Value(this string @this)
        {
            return @this.IsValidUShortValue();
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位无符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt16ValueNullable(this string @this)
        {
            return @this.IsValidUShortValueNullable();
        }
    }
}