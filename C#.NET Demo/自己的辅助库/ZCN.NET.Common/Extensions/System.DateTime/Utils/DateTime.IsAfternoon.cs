using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：计算指定日期时间是否是下午(12点(包含)以后为下午时间)
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns></returns>
        public static bool IsAfternoon(this DateTime @this)
        {
            return @this.TimeOfDay >= new DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay;
        }
    }
}