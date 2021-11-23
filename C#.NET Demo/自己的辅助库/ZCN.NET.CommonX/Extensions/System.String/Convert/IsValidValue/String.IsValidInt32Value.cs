namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：判断字符串的值是否是有效的32位有符号的整数值。
        ///  如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt32Value(this string @this)
        {
            return int.TryParse(@this, out int result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的32位有符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidInt32NullableValue(this string @this)
        {
            if (@this.IsNull())
                return true;

            return int.TryParse(@this, out int result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的32位无符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt32Value(this string @this)
        {
            return uint.TryParse(@this, out uint result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的32位无符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUInt32NullableValue(this string @this)
        {
            if (@this.IsNull())
                return true;

            return uint.TryParse(@this, out uint result);
        }
    }
}