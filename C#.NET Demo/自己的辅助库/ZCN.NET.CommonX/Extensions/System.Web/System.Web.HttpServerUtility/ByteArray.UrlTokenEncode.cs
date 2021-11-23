#if NETFRAMEWORK

using System;
using System.Web;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：将一个字节数组编码为使用 Base64 编码方案的等效字符串表示形式，Base64 是一种适于通过 URL 传输数据的编码方案
        /// </summary>
        /// <param name="input">扩展对象</param>
        /// <returns></returns>
        public static string UrlTokenEncode(this byte[] input)
        {
            return HttpServerUtility.UrlTokenEncode(input);
        }

        /// <summary>
        ///   自定义扩展方法：将 URL 字符串标记解码为使用 64 进制数字的等效字节数组
        /// </summary>
        /// <param name="input">扩展对象</param>
        /// <returns></returns>
        public static byte[] UrlTokenEncode(this string input)
        {
            return HttpServerUtility.UrlTokenDecode(input);
        }
    }
}

#endif