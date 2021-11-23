using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 404
        ///  (Not Found 无法找到指定位置的资源)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusNotFound(this HttpResponse @this)
        {
            @this.StatusCode = 404;
            //@this.StatusDescription = " Not Found 无法找到指定位置的资源";
        }
    }
}