using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：根据时区标识符将时间转换为另一时区中的时间
        /// </summary>
        /// <param name="dateTimeOffset">扩展对象。要转换的日期和时间</param>
        /// <param name="destinationTimeZoneId">目标时区的标识符</param>
        /// <returns>目标时区的日期和时间</returns>
        public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset,
            String destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
        }
    }
}