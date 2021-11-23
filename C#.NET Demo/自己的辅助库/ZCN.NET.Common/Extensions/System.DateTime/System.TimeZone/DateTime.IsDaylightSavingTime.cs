using System;
using System.Collections.Generic;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定日期和时间是否处于指定的夏时制期间
        /// </summary>
        /// <param name="time">扩展对象。日期时间</param>
        /// <param name="daylightTimes">夏时制期间</param>
        /// <returns></returns>
        public static bool IsDaylightSavingTime(this DateTime time, DaylightTime daylightTimes)
        {
            List<int> lstInt = new List<int>();
            List<string> lstStr = new List<string>();

            return TimeZone.IsDaylightSavingTime(time, daylightTimes);
        }
    }
}