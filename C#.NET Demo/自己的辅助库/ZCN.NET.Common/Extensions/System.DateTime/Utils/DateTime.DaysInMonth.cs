using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定年和月中的天数。
        ///  如果 month 等于 2（表示二月），则返回值为 28 或 29，具体取决于 year 是否为闰年
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static int DaysInMonth(this DateTime @this)
        {
            return DateTime.DaysInMonth(@this.Year, @this.Month);
        }

        /// <summary>
        ///  自定义扩展方法：返回指定年和月中的天数。
        ///  如果 month 等于 2（表示二月），则返回值为 28 或 29，具体取决于 year 是否为闰年。
        ///  如果 month 小于1或者大于12 则返回-1
        /// </summary>
        /// <param name="year">扩展对象。年份</param>
        /// <param name="month">月份，月（介于 1 到 12 之间的一个数字）</param>
        /// <returns></returns>
        public static int DaysInMonth(this int year, int month)
        {
            if (month.Between(1, 12))
            {
                return DateTime.DaysInMonth(year, month);
            }

            return -1;
        }
    }
}