
using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 计算2个日期时间差(绝对值)。返回具体的差值信息(例如：2天6小时51分钟31秒234毫秒);
        /// 如果天数等于0，则不显示天数；
        /// 如果小时等于0，则不显示小时；
        /// 如果分钟等于0，则不显示分钟；
        /// 如果秒数等于0，则不显示秒数
        /// </summary>
        /// <param name="dateTime1"></param>
        /// <param name="dateTime2"></param>
        /// <returns></returns>
        public static string DateDiff(this DateTime dateTime1,DateTime dateTime2)
        {
            string result = string.Empty;
            TimeSpan span = (dateTime2 - dateTime1).Duration();
            if(span.Days > 0)
            {
                result = span.Days + " 天 " + span.Hours.ToString().PadLeft(2,'0') + " 小时 " + span.Minutes.ToString().PadLeft(2,'0') + " 分 " + span.Seconds.ToString().PadLeft(2,'0') + " 秒 " + span.Milliseconds.ToString().PadLeft(3,'0') + " 毫秒";
            }
            else if(span.Hours > 0)
            {
                result = span.Hours.ToString().PadLeft(2,'0') + " 小时 " + span.Minutes.ToString().PadLeft(2,'0') + " 分 " + span.Seconds.ToString().PadLeft(2,'0') + " 秒 " + span.Milliseconds.ToString().PadLeft(3,'0') + " 毫秒";
            }
            else if(span.Minutes > 0)
            {
                result = span.Minutes.ToString().PadLeft(2,'0') + " 分 " + span.Seconds.ToString().PadLeft(2,'0') + " 秒 " + span.Milliseconds.ToString().PadLeft(3,'0') + " 毫秒";
            }
            else if(span.Seconds > 0)
            {
                result = span.Seconds.ToString().PadLeft(2,'0') + " 秒 " + span.Milliseconds.ToString().PadLeft(3,'0') + " 毫秒";
            }
            else if(span.Milliseconds > 0)
            {
                result = span.Milliseconds + " 毫秒";
            }

            return result;
        }


        /// <summary>
        ///  计算2个日期之间的日期时间差。例如：2天 8小时 3分钟 27秒 15毫秒
        /// </summary>
        /// <param name="dateTime1"></param>
        /// <param name="dateTime2"></param>
        /// <returns></returns>
        public static string DateDiff2(this DateTime dateTime1,DateTime dateTime2)
        {
            TimeSpan ts1 = new TimeSpan(dateTime1.Ticks);
            TimeSpan ts2 = new TimeSpan(dateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            string dateDiff = ts.Days + " 天 " +
                              ts.Hours + " 小时 " +
                              ts.Minutes + " 分钟 " +
                              ts.Seconds + " 秒 " +
                              ts.Milliseconds + " 毫秒";

            return dateDiff;
        }
    }
}