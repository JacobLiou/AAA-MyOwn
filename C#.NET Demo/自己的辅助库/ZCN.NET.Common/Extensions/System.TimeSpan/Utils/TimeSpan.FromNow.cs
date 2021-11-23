using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 从当前日期时间加上指定的TimeSpan
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static DateTime FromNow(this TimeSpan @this)
        {
            return DateTime.Now.Add(@this);
        }
    }
}