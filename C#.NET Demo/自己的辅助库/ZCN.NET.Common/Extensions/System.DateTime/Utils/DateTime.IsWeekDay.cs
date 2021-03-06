using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的日期是否是工作日(周一到周五)
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsWeekDay(this DateTime @this)
        {
            return !(@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
        }
    }
}