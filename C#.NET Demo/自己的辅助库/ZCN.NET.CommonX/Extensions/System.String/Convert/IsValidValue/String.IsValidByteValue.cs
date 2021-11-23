namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的8位无符号整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidByteValue(this string @this)
        {
            return byte.TryParse(@this, out byte result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的8位无符号整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidByteValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return byte.TryParse(@this, out byte result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的8位有符号整数值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidSByteValue(this string @this)
        {
            return sbyte.TryParse(@this, out sbyte result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的8位有符号整数值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidSByteValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return sbyte.TryParse(@this, out sbyte result);
        }
    }
}