using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的日期时间类型值。
        /// 如果参数为 null，则此方法返回 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDateTimeValue(this string @this)
        {
            return DateTime.TryParse(@this, out DateTime result);
        }

        /// <summary>
        /// 自定义扩展方法：判断字符串的值是否是有效的日期时间类型值。
        /// 如果参数为 null，则此方法返回 true
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool IsValidDateTimeValueNullable(this string @this)
        {
            if(@this.IsNullOrDBNull())
                return true;

            return DateTime.TryParse(@this, out DateTime result);
        }
    }
}