#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 405
        ///  (Method Not Allowed 请求方法（GET、POST、HEAD、DELETE、PUT、TRACE等）对指定的资源不适用，
        ///   用来访问本页面的 HTTP 谓词不被允许（方法不被允许）)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusMovedPermanently(this HttpResponse @this)
        {
            @this.StatusCode = 301;
            //@this.StatusDescription = "Moved permanently.";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 405
        ///  (Method Not Allowed 请求方法（GET、POST、HEAD、DELETE、PUT、TRACE等）对指定的资源不适用，
        ///   用来访问本页面的 HTTP 谓词不被允许（方法不被允许）)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusMovedPermanently(this HttpResponse @this)
        {
            @this.StatusCode = 301;
            @this.StatusDescription = "Moved permanently.";
        }
    }
}

#endif