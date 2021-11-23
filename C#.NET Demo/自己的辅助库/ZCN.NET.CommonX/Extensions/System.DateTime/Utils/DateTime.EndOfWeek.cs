using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 返回一周的最后一天的最后一刻，时间设置为“23:59:59:999”
        /// </summary>
        /// <param name="dt">扩展对象。日期时间</param>
        /// <param name="startDayOfWeek">一周的第一天，默认设置为星期日</param>
        /// <returns></returns>
        public static DateTime EndOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
        {
            DateTime end = dt;
            DayOfWeek endDayOfWeek = startDayOfWeek - 1;
            if(endDayOfWeek < 0)
            {
                endDayOfWeek = DayOfWeek.Saturday;
            }

            if(end.DayOfWeek != endDayOfWeek)
            {
                if(endDayOfWeek < end.DayOfWeek)
                {
                    end = end.AddDays(7 - (end.DayOfWeek - endDayOfWeek));
                }
                else
                {
                    end = end.AddDays(endDayOfWeek - end.DayOfWeek);
                }
            }

            return new DateTime(end.Year, end.Month, end.Day, 23, 59, 59, 999);
        }
    }
}