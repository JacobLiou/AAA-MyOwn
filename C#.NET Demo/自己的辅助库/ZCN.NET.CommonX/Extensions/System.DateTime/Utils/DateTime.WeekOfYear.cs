using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：计算指定的日期是一年中的第几周
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="cultureInfo">区域性对象，例如：new CultureInfo("zh-CN")</param>
        /// <returns></returns>
        public static int WeekOfYear(this DateTime @this, CultureInfo cultureInfo)
        {
            return cultureInfo.Calendar.GetWeekOfYear(@this, cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek);
        }
    }
}