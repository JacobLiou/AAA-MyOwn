using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将时间转换为特定时区的时间
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <param name="destinationTimeZone">目标时区</param>
        /// <returns></returns>
        public static DateTime ConvertTime(this DateTime dateTime,TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTime,destinationTimeZone);
        }

        /// <summary>
        /// 自定义扩展方法：将时间从一个时区转换为另一个时区
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <param name="sourceTimeZone">源时区</param>
        /// <param name="destinationTimeZone">目标时区</param>
        /// <returns></returns>
        public static DateTime ConvertTime(this DateTime dateTime,
            TimeZoneInfo sourceTimeZone,
            TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTime,sourceTimeZone,destinationTimeZone);
        }
    }
}