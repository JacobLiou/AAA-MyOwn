#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 502
        ///  (Bad Gateway 服务器作为网关或者代理时，为了完成请求访问下一个服务器，但该服务器返回了非法的应答。 
        ///   或者说Web 服务器用作网关或代理服务器时收到了无效响应)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusInvalidResponseWhileGatewayOrProxy(this HttpResponse @this)
        {
            @this.StatusCode = 502;
            //@this.StatusDescription = @"Bad Gateway 服务器作为网关或者代理时，为了完成请求访问下一个服务器，但该服务器返回了非法的应答。 或者说Web 服务器用作网关或代理服务器时收到了无效响应";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 502
        ///  (Bad Gateway 服务器作为网关或者代理时，为了完成请求访问下一个服务器，但该服务器返回了非法的应答。 
        ///   或者说Web 服务器用作网关或代理服务器时收到了无效响应)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusInvalidResponseWhileGatewayOrProxy(this HttpResponse @this)
        {
            @this.StatusCode = 502;
            @this.StatusDescription = @"Bad Gateway 服务器作为网关或者代理时，为了完成请求访问下一个服务器，但该服务器返回了非法的应答。 或者说Web 服务器用作网关或代理服务器时收到了无效响应";
        }
    }
}

#endif