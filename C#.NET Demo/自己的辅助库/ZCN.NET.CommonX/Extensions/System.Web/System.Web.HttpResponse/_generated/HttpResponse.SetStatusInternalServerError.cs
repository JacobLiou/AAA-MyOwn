using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 500
        ///  (Internal Server Error 服务器遇到了意料不到的情况，不能完成客户的请求)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusInternalServerError(this HttpResponse @this)
        {
            @this.StatusCode = 500;
            //@this.StatusDescription = "Internal Server Error 服务器遇到了意料不到的情况，不能完成客户的请求";
        }
    }
}