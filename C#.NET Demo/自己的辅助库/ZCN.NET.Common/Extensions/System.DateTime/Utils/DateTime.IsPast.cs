using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的日期时间是否是过去(小于DateTime.Now)
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsPast(this DateTime @this)
        {
            return @this < DateTime.Now;
        }
    }
}