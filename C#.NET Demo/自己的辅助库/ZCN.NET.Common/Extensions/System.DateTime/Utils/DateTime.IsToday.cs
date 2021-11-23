using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的日期是否是今天
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Today;
        }
    }
}