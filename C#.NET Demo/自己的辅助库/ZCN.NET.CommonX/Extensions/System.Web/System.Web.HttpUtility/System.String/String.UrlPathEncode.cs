using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：对 URL 字符串的路径部分进行编码，以进行从 Web 服务器到客户端的可靠的 HTTP 传输
        /// </summary>
        /// <param name="str">要进行 URL 编码的文本</param>
        /// <returns> URL 编码的文本</returns>
        public static String UrlPathEncode(this String str)
        {
            return HttpUtility.UrlPathEncode(str);
        }
    }
}