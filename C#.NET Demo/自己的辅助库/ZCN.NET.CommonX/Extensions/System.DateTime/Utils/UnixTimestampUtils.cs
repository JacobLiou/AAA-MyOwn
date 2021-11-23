using System;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    ///  时间戳与日期时间转换
    /// </summary>
    public static class UnixTimestampUtils
    {
        /// <summary>
        /// 基准时间
        /// </summary>
        private static readonly DateTime BaseDateTime = new DateTime(1970, 1, 1).ToLocalTime();

        /// <summary>
        /// 时间戳末尾7位(补0或截断)
        /// </summary>
        private const long TICK_BASE = 10000000;

        /// <summary>
        /// 自定义扩展方法：从现在(调用此函数时刻)起若干秒以后那个时间点的时间戳
        /// </summary>
        /// <param name="secondsAfterNow">从现在起多少秒以后</param>
        /// <returns>Unix时间戳</returns>
        public static long GetUnixTimestamp(this long secondsAfterNow)
        {
            DateTime dt = DateTime.Now.AddSeconds(secondsAfterNow).ToLocalTime();
            TimeSpan tsx = dt.Subtract(BaseDateTime);
            return tsx.Ticks / TICK_BASE;
        }

        /// <summary>
        /// 自定义扩展方法：日期时间转换为时间戳
        /// </summary>
        /// <param name="dt">日期时间</param>
        /// <returns>时间戳</returns>
        public static long ConvertToTimestamp(this DateTime dt)
        {
            TimeSpan tsx = dt.Subtract(BaseDateTime);
            return tsx.Ticks / TICK_BASE;
        }

        /// <summary>
        /// 自定义扩展方法：从时间戳转换为DateTime
        /// </summary>
        /// <param name="timestamp">时间戳字符串</param>
        /// <returns>日期时间</returns>
        public static DateTime ConvertToDateTime(this string timestamp)
        {
            long ticks = long.Parse(timestamp) * TICK_BASE;
            return BaseDateTime.AddTicks(ticks);
        }

        /// <summary>
        /// 自定义扩展方法：从时间戳转换为DateTime
        /// </summary>
        /// <param name="timestamp">时间戳</param>
        /// <returns>日期时间</returns>
        public static DateTime ConvertToDateTime(this long timestamp)
        {
            long ticks = timestamp * TICK_BASE;
            return BaseDateTime.AddTicks(ticks);
        }

        private static DateTime TimeStampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }

        /// <summary>
        /// 自定义扩展方法：检查Ctx是否过期，给当前时间加上一天来看看是否超过了过期时间
        /// 而不是直接比较是否超过了过期时间，是给这个文件最大1天的上传持续时间
        /// </summary>
        /// <param name="expiredAt"></param>
        /// <returns></returns>
        public static bool IsContextExpired(this long expiredAt)
        {
            if (expiredAt == 0)
            {
                return false;
            }
            bool expired = false;
            DateTime now = DateTime.Now.AddDays(1);
            long nowTs = ConvertToTimestamp(now);
            if (nowTs > expiredAt)
            {
                expired = true;
            }
            return expired;
        }
    }
}