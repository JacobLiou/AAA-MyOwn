using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法： 将当前日期和时间转换为协调世界时 (UTC)
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <returns></returns>
        public static DateTime ConvertTimeToUtc(this DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeToUtc(dateTime);
        }

        /// <summary>
        /// 自定义扩展方法：将指定时区中的时间转换为协调世界时 (UTC)
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <param name="sourceTimeZone">目标时区</param>
        /// <returns></returns>
        public static DateTime ConvertTimeToUtc(this DateTime dateTime,TimeZoneInfo sourceTimeZone)
        {
            return TimeZoneInfo.ConvertTimeToUtc(dateTime,sourceTimeZone);
        }
    }
}