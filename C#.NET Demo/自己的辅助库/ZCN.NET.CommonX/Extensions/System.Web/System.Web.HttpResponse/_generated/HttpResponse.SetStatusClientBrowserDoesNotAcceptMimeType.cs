using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 406
        ///  (Not Acceptable 指定的资源已经找到，但它的MIME类型和客户在Accept头中所指定的不兼容，
        ///   客户端浏览器不接受所请求页面的MIME 类型)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusClientBrowserDoesNotAcceptMimeType(this HttpResponse @this)
        {
            @this.StatusCode = 406;
            //@this.StatusDescription = @"Not Acceptable 指定的资源已经找到，但它的MIME类型和客户在Accept头中所指定的不兼容，客户端浏览器不接受所请求页面的MIME 类型";
        }
    }
}