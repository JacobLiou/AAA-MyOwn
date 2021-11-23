namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的 decimal 类型值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDecimalValue(this string @this)
        {
            return decimal.TryParse(@this, out decimal result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的 decimal 类型值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDecimalValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return decimal.TryParse(@this, out decimal result);
        }
    }
}