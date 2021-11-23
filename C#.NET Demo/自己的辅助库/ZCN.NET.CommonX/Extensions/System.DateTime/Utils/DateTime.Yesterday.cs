using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的日期是否是昨天
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static DateTime Yesterday(this DateTime @this)
        {
            return @this.AddDays(-1);
        }
    }
}