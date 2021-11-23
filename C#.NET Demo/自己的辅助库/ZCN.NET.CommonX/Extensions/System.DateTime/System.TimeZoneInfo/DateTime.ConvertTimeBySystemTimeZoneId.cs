using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：根据时区标识符将时间转换为另一时区中的时间
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <param name="destinationTimeZoneId">目标时区的标识符</param>
        /// <returns></returns>
        public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, String destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, destinationTimeZoneId);
        }

        /// <summary>
        /// 自定义扩展方法：根据时区标识符将时间从一个时区转换到另一个时区
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <param name="sourceTimeZoneId">源时区的标识符</param>
        /// <param name="destinationTimeZoneId">目标时区的标识符</param>
        /// <returns></returns>
        public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime,
            String sourceTimeZoneId,
            String destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, sourceTimeZoneId, destinationTimeZoneId);
        }
    }
}