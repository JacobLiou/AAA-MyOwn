#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 203
        ///  (Non-Authoritative Information 文档已经正常地返回，但一些应答头可能不正确，
        ///  因为使用的是文档的拷贝，非权威性信息)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusNonAuthoritativeInformation(this HttpResponse @this)
        {
            @this.StatusCode = 203;
            //@this.StatusDescription = "Non-Authoritative Information 文档已经正常地返回，但一些应答头可能不正确，因为使用的是文档的拷贝，非权威性信息";
        }
    }
}

#elif NETFRAMEWORK

using System.Web;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 203
        ///  (Non-Authoritative Information 文档已经正常地返回，但一些应答头可能不正确，
        ///  因为使用的是文档的拷贝，非权威性信息)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusNonAuthoritativeInformation(this HttpResponse @this)
        {
            @this.StatusCode = 203;
            @this.StatusDescription = "Non-Authoritative Information 文档已经正常地返回，但一些应答头可能不正确，因为使用的是文档的拷贝，非权威性信息。";
        }
    }
}

#endif