using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：计算传入的日期时间与1970-01-01 00:00:00之间的秒数差(例如：微信里面的消息创建时间)
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns>字符串形式的日期</returns>
        public static int DateTimeToInt(this DateTime @this)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
           
            long second = (@this.Ticks - startTime.Ticks) / 10000000; //现在是10位。除10000调整为13位
            return second.ToInt32();
        }
    }
}