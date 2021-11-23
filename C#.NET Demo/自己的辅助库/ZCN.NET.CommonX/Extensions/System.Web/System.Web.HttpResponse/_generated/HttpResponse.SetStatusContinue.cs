using Microsoft.AspNetCore.Http;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 100
        ///  (Continue 初始的请求已经接受，客户应当继续发送请求的其余部分)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusContinue(this HttpResponse @this)
        {
            @this.StatusCode = 100;
            //@this.StatusDescription = @"Continue 初始的请求已经接受，客户应当继续发送请求的其余部分";
        }
    }
}