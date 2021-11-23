using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 204
        ///  (No Content 没有新文档，浏览器应该继续显示原来的文档。如果用户定期地刷新页面，
        ///   而Servlet可以确定用户文档足够新，这个状态代码是很有用的)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusNoContent(this HttpResponse @this)
        {
            @this.StatusCode = 204;
            //@this.StatusDescription = "No Content 没有新文档，浏览器应该继续显示原来的文档。如果用户定期地刷新页面，而Servlet可以确定用户文档足够新，这个状态代码是很有用的";
        }
    }
}