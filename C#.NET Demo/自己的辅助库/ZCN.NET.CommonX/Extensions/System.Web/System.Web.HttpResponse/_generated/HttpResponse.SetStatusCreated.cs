using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 210
        ///  (Created 服务器已经创建了文档，Location头给出了它的URL)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusCreated(this HttpResponse @this)
        {
            @this.StatusCode = 201;
            //@this.StatusDescription = "Created 服务器已经创建了文档，Location头给出了它的URL";
        }
    }
}