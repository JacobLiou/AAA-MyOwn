using System;
using System.Text;
using System.Web;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        /// <summary>
        /// 自定义扩展方法：将已经为在 URL 中传输而编码的字符串转换为解码的字符串
        /// </summary>
        /// <param name="str">要解码的字符串</param>
        /// <returns>一个已解码的字符串</returns>
        public static String UrlDecode(this String str)
        {
            return HttpUtility.UrlDecode(str);
        }

        /// <summary>
        /// 自定义扩展方法：将已经为在 URL 中传输而编码的字符串转换为解码的字符串
        /// </summary>
        /// <param name="str">要解码的字符串</param>
        /// <param name="e">指定解码方法的 System.Text.Encoding</param>
        /// <returns>一个已解码的字符串</returns>
        public static String UrlDecode(this String str, Encoding e)
        {
            return HttpUtility.UrlDecode(str, e);
        }
    }
}