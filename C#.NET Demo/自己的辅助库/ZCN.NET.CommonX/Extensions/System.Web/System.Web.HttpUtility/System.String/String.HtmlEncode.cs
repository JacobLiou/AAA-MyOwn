using System;
using System.IO;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将字符串转换为 HTML 编码的字符串
        /// </summary>
        /// <param name="s">要编码的字符串</param>
        /// <returns>一个已编码的字符串</returns>
        public static String HtmlEncode(this String s)
        {
            return HttpUtility.HtmlEncode(s);
        }

        /// <summary>
        /// 自定义扩展方法：将字符串转换为 HTML 编码的字符串并将输出作为 System.IO.TextWriter 输出流返回
        /// </summary>
        /// <param name="s">要编码的字符串</param>
        /// <param name="output">System.IO.TextWriter 输出流</param>
        public static void HtmlEncode(this String s, TextWriter output)
        {
            HttpUtility.HtmlEncode(s, output);
        }
    }
}