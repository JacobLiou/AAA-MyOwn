using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将协调世界时 (UTC) 转换为指定时区中的时间
        /// </summary>
        /// <param name="dateTime">扩展对象。日期时间</param>
        /// <param name="destinationTimeZone"></param>
        /// <returns></returns>
        public static DateTime ConvertTimeFromUtc(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, destinationTimeZone);
        }
    }
}