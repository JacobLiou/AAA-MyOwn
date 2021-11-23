using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：给指定的日期时间设置指定的小时
        /// </summary>
        /// <param name="current">扩展对象。日期时间</param>
        /// <param name="hour">小时数</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour)
        {
            return SetTime(current, hour, 0, 0, 0);
        }

        /// <summary>
        /// 自定义扩展方法：给指定的日期时间设置指定的小时分钟
        /// </summary>
        /// <param name="current">扩展对象。日期时间</param>
        /// <param name="hour">小时数</param>
        /// <param name="minute">分钟数</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute)
        {
            return SetTime(current, hour, minute, 0, 0);
        }

        /// <summary>
        /// 自定义扩展方法：给指定的日期时间设置指定的小时分钟秒
        /// </summary>
        /// <param name="current">扩展对象。日期时间</param>
        /// <param name="hour">小时数</param>
        /// <param name="minute">分钟数</param>
        /// <param name="second">秒</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
        {
            return SetTime(current, hour, minute, second, 0);
        }

        /// <summary>
        /// 自定义扩展方法：给指定的日期时间设置指定的小时分钟秒毫秒
        /// </summary>
        /// <param name="current">扩展对象。日期时间</param>
        /// <param name="hour">小时数</param>
        /// <param name="minute">分钟数</param>
        /// <param name="second">秒</param>
        /// <param name="millisecond">毫秒</param>
        /// <returns></returns>
        public static DateTime SetTime(this DateTime current, int hour, int minute, int second, int millisecond)
        {
            return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
        }
    }
}