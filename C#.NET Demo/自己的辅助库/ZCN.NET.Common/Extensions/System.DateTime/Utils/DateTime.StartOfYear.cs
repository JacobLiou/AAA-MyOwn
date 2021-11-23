using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：返回指定日期所在年的第一个月的第一天的第一刻，时间设置为“00:00:00:000”
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static DateTime StartOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1);
        }
    }
}