using System;
using System.Text;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定编码对象对 URL 字符串进行编码
        /// </summary>
        /// <param name="str">要编码的文本</param>
        /// <returns>一个已编码的字符串</returns>
        public static String UrlEncode(this String str)
        {
            return HttpUtility.UrlEncode(str);
        }

        /// <summary>
        ///  自定义扩展方法：将指定编码对象对 URL 字符串进行编码
        /// </summary>
        /// <param name="str">要编码的文本</param>
        /// <param name="e">指定编码方案的 System.Text.Encoding 对象</param>
        /// <returns>一个已编码的字符串</returns>
        public static String UrlEncode(this String str, Encoding e)
        {
            return HttpUtility.UrlEncode(str, e);
        }
    }
}