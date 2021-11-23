using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 503
        ///  (Service Unavailable 服务不可用，服务器由于维护或者负载过重未能应答。
        ///  例如，Servlet可能在数据库连接池已满的情况下返回503。服务器返回503时可以提供一个 Retry-After头。这个错误代码为 IIS 6.0 所专用)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusServiceUnavailable(this HttpResponse @this)
        {
            @this.StatusCode = 503;
            //@this.StatusDescription = @"Service Unavailable 服务不可用，服务器由于维护或者负载过重未能应答。例如，Servlet可能在数据库连接池已满的情况下返回503。服务器返回503时可以提供一个 Retry-After头。这个错误代码为 IIS 6.0 所专用";
        }
    }
}