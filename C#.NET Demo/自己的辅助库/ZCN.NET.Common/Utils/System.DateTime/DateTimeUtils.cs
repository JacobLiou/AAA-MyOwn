using System;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    /// 日期时间操作工具类
    /// </summary>
    public class DateTimeUtils
    {
        /// <summary>
        ///  开发框架中自定义的日期时间的最小值：1900-01-01 00:00:00
        /// </summary>
        public static DateTime MiniValue
        {
            get { return new DateTime(1900, 1, 1, 0, 0, 0); }
        }

        /// <summary>
        ///  开发框架中自定义的日期时间的最大值：9999-12-31 23:23:23
        /// </summary>
        public static DateTime MaxValue
        {
            get { return new DateTime(9999, 12, 31, 23, 23, 23); }
        }
    }
}