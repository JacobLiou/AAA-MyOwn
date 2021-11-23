using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：基于当前区域性将日期时间进行格式化(U，通用时间的完整日期和时间，长日期和长时间)设置。
        /// 例如：中文简体区域性 DateTime.Now 转换为 2016年12月20日 1:20:30
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns>字符串形式的日期时间</returns>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this)
        {
            return @this.ToString("U", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 自定义扩展方法：基于制定的区域性将日期时间进行格式化(U，通用时间的完整日期和时间，长日期和长时间)设置
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="culture">区域性</param>
        /// <returns>字符串形式的时间</returns>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("U", new CultureInfo(culture));
        }

        /// <summary>
        /// 自定义扩展方法：基于制定的区域性将日期时间进行格式化(U，通用时间的完整日期和时间，长日期和长时间)设置
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="culture">区域性</param>
        /// <returns>字符串形式的时间</returns>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("U", culture);
        }
    }
}