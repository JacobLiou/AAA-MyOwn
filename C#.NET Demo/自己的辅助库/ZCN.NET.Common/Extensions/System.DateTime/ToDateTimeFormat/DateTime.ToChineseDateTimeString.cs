using System;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToDateTimeString
        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，带时分秒，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="showSecond">是否显示秒</param>
        public static string ToDateTimeString(this DateTime @this, bool showSecond = true)
        {
            if (showSecond)
                return @this.ToString("yyyy-MM-dd HH:mm:ss");

            return @this.ToString("yyyy-MM-dd HH:mm");
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，带时分秒，格式："yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="showSecond">是否显示秒</param>
        public static string ToDateTimeString(this DateTime? @this, bool showSecond = true)
        {
            if (@this == null)
                return string.Empty;

            return ToDateTimeString(@this.Value, showSecond);
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToDateString(this DateTime @this)
        {
            return @this.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，不带时分秒，格式："yyyy-MM-dd"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToDateString(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToDateString(@this.Value);
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，不带年月日，格式："HH:mm:ss"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToTimeString(this DateTime @this)
        {
            return @this.ToString("HH:mm:ss");
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，不带年月日，格式："HH:mm:ss"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToTimeString(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToTimeString(@this.Value);
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，带毫秒，格式："yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToDateTimeStringWithMillisecond(this DateTime @this)
        {
            return @this.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，带毫秒，格式："yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToDateTimeStringWithMillisecond(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToDateTimeStringWithMillisecond(@this.Value);
        }

        #endregion

        #region ToChineseDateString

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，不带时分秒，格式："yyyy年MM月dd日"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToChineseDateString(this DateTime @this)
        {
            return string.Format("{0}年{1}月{2}日", @this.Year, @this.Month, @this.Day);
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，不带时分秒，格式："yyyy年MM月dd日"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        public static string ToChineseDateString(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToChineseDateString(@this);
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，带时分秒，格式："yyyy年MM月dd日 HH时mm分"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="showSecond">是否显示秒</param>
        public static string ToChineseDateTimeString(this DateTime @this, bool showSecond = true)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}年{1}月{2}日", @this.Year, @this.Month, @this.Day);
            result.AppendFormat(" {0}时{1}分", @this.Hour, @this.Minute);
            if (showSecond)
                result.AppendFormat("{0}秒", @this.Second);

            return result.ToString();
        }

        /// <summary>
        /// 自定义扩展方法：获取格式化字符串，带时分秒，格式："yyyy年MM月dd日 HH时mm分"
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="showSecond">是否显示毫秒</param>
        public static string ToChineseDateTimeString(this DateTime? @this, bool showSecond = true)
        {
            if (@this == null)
                return string.Empty;

            return ToChineseDateTimeString(@this.Value, showSecond);
        }

        #endregion
    }
}