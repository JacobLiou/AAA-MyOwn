using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定区域性特定格式设置信息将指定 Unicode 字符的值转换为它的小写等效项
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <param name="culture">提供区域性特定的大小写规则的对象，或 null</param>
        /// <returns></returns>
        public static char ToLower(this char c,CultureInfo culture)
        {
            return char.ToLower(c,culture);
        }

        /// <summary>
        /// 自定义扩展方法：将 Unicode 字符的值转换为它的小写等效项
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static char ToLower(this char c)
        {
            return char.ToLower(c);
        }

        /// <summary>
        /// 自定义扩展方法：使用固定区域性的大小写规则，将 Unicode 字符的值转换为其小写等效项
        /// </summary>
        /// <param name="c">扩展对象</param>
        /// <returns></returns>
        public static char ToLowerInvariant(this char c)
        {
            return char.ToLowerInvariant(c);
        }
    }
}