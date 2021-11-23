using System;
using System.IO;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：将字符串最小限度地转换为 HTML 编码的字符串
        /// </summary>
        /// <param name="s">扩展对象，要编码的字符串</param>
        /// <returns>一个已编码的字符串</returns>
        public static String HtmlAttributeEncode(this String s)
        {
            return HttpUtility.HtmlAttributeEncode(s);
        }

        /// <summary>
        ///   自定义扩展方法：将字符串最小限度地转换为 HTML 编码的字符串，并将已编码的字符串发送给 System.IO.TextWriter 输出流
        /// </summary>
        /// <param name="s">扩展对象，要编码的字符串</param>
        /// <param name="output">System.IO.TextWriter 输出流</param>
        public static void HtmlAttributeEncode(this String s, TextWriter output)
        {
            HttpUtility.HtmlAttributeEncode(s, output);
        }
    }
}