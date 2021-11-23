#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 206
        ///  (Partial Content 客户发送了一个带有Range头的GET请求（分块请求），服务器完成了它)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusPartialContent(this HttpResponse @this)
        {
            @this.StatusCode = 206;
            //@this.StatusDescription = "Partial Content 客户发送了一个带有Range头的GET请求（分块请求），服务器完成了它";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 206
        ///  (Partial Content 客户发送了一个带有Range头的GET请求（分块请求），服务器完成了它)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusPartialContent(this HttpResponse @this)
        {
            @this.StatusCode = 206;
            @this.StatusDescription = "Partial Content 客户发送了一个带有Range头的GET请求（分块请求），服务器完成了它";
        }
    }
}

#endif