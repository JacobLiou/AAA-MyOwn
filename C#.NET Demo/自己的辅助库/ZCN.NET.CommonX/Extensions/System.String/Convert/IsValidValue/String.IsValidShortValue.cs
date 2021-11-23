namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位有符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidShortValue(this string @this)
        {
            return short.TryParse(@this, out short result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位有符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidShortValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return short.TryParse(@this, out short result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位无符号的整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUShortValue(this string @this)
        {
            return ushort.TryParse(@this, out ushort result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的16位无符号的整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidUShortValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return ushort.TryParse(@this, out ushort result);
        }
    }
}