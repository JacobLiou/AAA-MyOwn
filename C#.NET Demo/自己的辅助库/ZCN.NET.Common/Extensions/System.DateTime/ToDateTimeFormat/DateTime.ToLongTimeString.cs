using System;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：基于当前区域性将日期时间进行格式化(T，长时间)设置。
        /// 例如：中文简体区域性 DateTime.Now 转换为 12:20:30
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <returns>字符串形式的时间</returns>
        public static string ToLongTimeString(this DateTime @this)
        {
            return @this.ToString("T", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// 自定义扩展方法：基于制定的区域性将日期时间进行格式化(T，长时间)设置
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="culture">区域性</param>
        /// <returns>字符串形式的时间</returns>
        public static string ToLongTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("T", new CultureInfo(culture));
        }

        /// <summary>
        /// 自定义扩展方法：基于制定的区域性将日期时间进行格式化(T，长时间)设置
        /// </summary>
        /// <param name="this">扩展对象。日期时间</param>
        /// <param name="culture">区域性</param>
        /// <returns>字符串形式的时间</returns>
        public static string ToLongTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("T", culture);
        }
    }
}