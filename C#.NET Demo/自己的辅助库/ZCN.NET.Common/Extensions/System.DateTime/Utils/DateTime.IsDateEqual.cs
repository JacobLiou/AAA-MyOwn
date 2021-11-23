using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断2个日期是否相等
        /// </summary>
        /// <param name="date">扩展对象。日期时间</param>
        /// <param name="dateToCompare">目标日期时间</param>
        /// <returns></returns>
        public static bool IsDateEqual(this DateTime date, DateTime dateToCompare)
        {
            return (date.Date == dateToCompare.Date);
        }
    }
}