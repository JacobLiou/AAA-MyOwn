namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的 double 双精度浮点类型值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDoubleValue(this string @this)
        {
            return double.TryParse(@this, out double result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的 double 双精度浮点类型值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDoubleValueNullable(this string @this)
        {
            if (@this.IsNull())
                return true;

            return double.TryParse(@this,out double result);
        }
    }
}