#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 101
        ///  (Switching Protocols 服务器将遵从客户的请求转换到另外一种协议)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusSwitchingProtocols(this HttpResponse @this)
        {
            @this.StatusCode = 101;
            //@this.StatusDescription = "Switching Protocols 服务器将遵从客户的请求转换到另外一种协议";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 101
        ///  (Switching Protocols 服务器将遵从客户的请求转换到另外一种协议)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusSwitchingProtocols(this HttpResponse @this)
        {
            @this.StatusCode = 101;
            @this.StatusDescription = "Switching Protocols 服务器将遵从客户的请求转换到另外一种协议";
        }
    }
}

#endif