#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 202(Accepted 已经接受请求，但处理尚未完成)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusAccepted(this HttpResponse @this)
        {
            @this.StatusCode = 202;
            // @this.StatusDescription = "Accepted 已经接受请求，但处理尚未完成";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 202(Accepted 已经接受请求，但处理尚未完成)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusAccepted(this HttpResponse @this)
        {
            @this.StatusCode = 202;
            @this.StatusDescription = "Accepted 已经接受请求，但处理尚未完成";
        }
    }
}

#endif