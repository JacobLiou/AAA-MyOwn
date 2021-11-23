using System;
using System.IO;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将已经过 HTML 编码的字符串转换为已解码的字符串并将其发送给 System.IO.TextWriter 输出流
        /// </summary>
        /// <param name="s">要解码的字符串</param>
        /// <returns>一个已解码的字符串</returns>
        public static String HtmlDecode(this String s)
        {
            return HttpUtility.HtmlDecode(s);
        }

        /// <summary>
        /// 自定义扩展方法：将已经过 HTML 编码的字符串转换为已解码的字符串并将其发送给 System.IO.TextWriter 输出流output
        /// </summary>
        /// <param name="s">要解码的字符串</param>
        /// <param name="output">System.IO.TextWriter 输出流</param>
        public static void HtmlDecode(this String s, TextWriter output)
        {
            HttpUtility.HtmlDecode(s, output);
        }
    }
}