using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 从当前日期时间(UTC协调世界时间)加上指定的TimeSpan
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static DateTime UtcFromNow(this TimeSpan @this)
        {
            return DateTime.UtcNow.Add(@this);
        }
    }
}