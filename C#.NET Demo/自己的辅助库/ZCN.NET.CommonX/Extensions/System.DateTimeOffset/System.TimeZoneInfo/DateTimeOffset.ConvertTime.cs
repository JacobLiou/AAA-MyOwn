using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将时间转换为特定时区的时间
        /// </summary>
        /// <param name="dateTimeOffset">扩展对象。要转换的日期和时间</param>
        /// <param name="destinationTimeZone">要将 dateTime 转换到的时区</param>
        /// <returns>目标时区的日期和时间</returns>
        public static DateTimeOffset ConvertTime(this DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
        }
    }
}