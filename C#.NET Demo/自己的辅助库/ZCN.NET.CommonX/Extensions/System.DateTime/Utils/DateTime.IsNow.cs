using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：判断指定的日期时间是否是现在(等于DateTime.Now)
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsNow(this DateTime @this)
        {
            return @this == DateTime.Now;
        }
    }
}