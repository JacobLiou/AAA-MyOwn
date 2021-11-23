using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断2个时间是否相等
        /// </summary>
        /// <param name="time">扩展对象。日期时间</param>
        /// <param name="timeToCompare">目标日期时间</param>
        /// <returns></returns>
        public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
        {
            return (time.TimeOfDay == timeToCompare.TimeOfDay);
        }
    }
}