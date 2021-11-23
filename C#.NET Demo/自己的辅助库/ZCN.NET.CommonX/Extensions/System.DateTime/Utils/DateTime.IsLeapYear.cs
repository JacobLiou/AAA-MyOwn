using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断日期是否是闰年
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsLeapYear(this DateTime @this)
        {
            return DateTime.IsLeapYear(@this.Year);
        }

        /// <summary>
        /// 自定义扩展方法：判断是否是闰年
        /// </summary>
        /// <param name="this">扩展对象。年份</param>
        /// <returns></returns>
        public static bool IsLeapYear(this Int32 @this)
        {
            return DateTime.IsLeapYear(@this);
        }
    }
}