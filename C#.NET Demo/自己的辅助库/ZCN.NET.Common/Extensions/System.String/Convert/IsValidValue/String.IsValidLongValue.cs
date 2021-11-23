namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位有符号的整数值。
        /// 如果参数 为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidLongValue(this string @this)
        {
            return long.TryParse(@this, out long result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位有符号的整数值。
        /// 如果参数 为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidLongValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return long.TryParse(@this, out long result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位无符号的整数值。
        /// 如果参数 为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidULongValue(this string @this)
        {
            return ulong.TryParse(@this, out ulong result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的64位无符号的整数值。
        /// 如果参数 为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidULongValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return ulong.TryParse(@this, out ulong result);
        }
    }
}