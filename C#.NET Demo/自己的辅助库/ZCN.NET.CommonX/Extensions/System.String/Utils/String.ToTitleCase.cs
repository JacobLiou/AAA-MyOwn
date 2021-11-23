using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定字符串转换为词首字母大写。
        ///  例如：product_no sale 转换结果为 Product_No Sale。
        /// <para>该方法与 ToPascalCase()方法相同</para>
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>首字母大写的字符串</returns>
        public static string ToTitleCase(this string @this)
        {
            return new CultureInfo("en-US").TextInfo.ToTitleCase(@this);
        }

        /// <summary>
        ///  自定义扩展方法：将指定字符串转换为词首字母大写。
        ///  例如：product_no sale 转换结果为 Product_No Sale
        /// <para>该方法与 ToPascalCase()方法相同</para>
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="cultureInfo">区域信息对象</param>
        /// <returns>首字母大写的字符串</returns>
        public static string ToTitleCase(this string @this, CultureInfo cultureInfo)
        {
            return cultureInfo.TextInfo.ToTitleCase(@this);
        }

        /// <summary>
        ///  自定义扩展方法：将指定字符串转换为词首字母大写。
        ///  例如：product_no sale 转换结果为 Product_No Sale。
        /// <para>该方法与 ToTitleCase()方法相同</para>
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>首字母大写的字符串</returns>
        public static string ToPascalCase(this string @this)
        {
            return @this.ToTitleCase();
        }

        /// <summary>
        ///  自定义扩展方法：将指定字符串转换为词首字母大写(Pascal命名)。
        ///  例如：product_no sale 转换结果为 Product_No Sale。
        /// <para>该方法与 ToTitleCase()方法相同</para>
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="cultureInfo">区域信息对象</param>
        /// <returns>首字母大写的字符串</returns>
        public static string ToPascalCase(this string @this, CultureInfo cultureInfo)
        {
            return @this.ToTitleCase(cultureInfo);
        }
    }
}