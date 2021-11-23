#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 302
        ///  (Object moved.)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusObjectMoved(this HttpResponse @this)
        {
            @this.StatusCode = 302;
            //@this.StatusDescription = "Object moved.";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 302
        ///  (Object moved.)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusObjectMoved(this HttpResponse @this)
        {
            @this.StatusCode = 302;
            @this.StatusDescription = "Object moved.";
        }
    }
}

#endif
