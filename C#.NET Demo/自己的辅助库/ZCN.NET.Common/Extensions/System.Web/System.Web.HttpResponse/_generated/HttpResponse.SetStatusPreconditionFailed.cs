#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 412
        ///  (Precondition Failed 请求头中指定的一些前提条件失败)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusPreconditionFailed(this HttpResponse @this)
        {
            @this.StatusCode = 412;
            //@this.StatusDescription = "Precondition Failed 请求头中指定的一些前提条件失败";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 412
        ///  (Precondition Failed 请求头中指定的一些前提条件失败)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusPreconditionFailed(this HttpResponse @this)
        {
            @this.StatusCode = 412;
            @this.StatusDescription = "Precondition Failed 请求头中指定的一些前提条件失败";
        }
    }
}

#endif