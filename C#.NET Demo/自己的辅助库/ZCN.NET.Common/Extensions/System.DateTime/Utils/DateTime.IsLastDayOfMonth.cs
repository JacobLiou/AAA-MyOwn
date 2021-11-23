using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断一个日期是否是一个月的最后一天
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsLastDayOfMonth(this DateTime @this)
        {
            int lastDayOfMonth = DaysCountOfMonth(@this);
            return lastDayOfMonth == @this.Day;
        }

        /// <summary>
        /// 自定义扩展方法：计算每个月的天数
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static int DaysCountOfMonth(this DateTime instance)
        {
            if(IsLeapYear(instance) && instance.Month == 2)
                return 29;

            if(instance.Month == 2)
                return 28;

            if(instance.Month == 1 ||
                instance.Month == 3 ||
                instance.Month == 5 ||
                instance.Month == 7 ||
                instance.Month == 8 ||
                instance.Month == 10 ||
                instance.Month == 12)
                return 31;

            return 30;
        }
    }
}