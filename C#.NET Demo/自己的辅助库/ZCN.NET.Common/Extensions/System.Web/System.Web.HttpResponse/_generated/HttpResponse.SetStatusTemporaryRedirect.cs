#if NETSTANDARD

using Microsoft.AspNetCore.Http;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 307
        ///  (Temporary Redirect 和302（Found）相同。许多浏览器会错误地响应302应答进行重定向，即使原来的请求是POST，
        ///   即使它实际上只能在POST/请求的应答是303时 才能重定向。
        ///   由于这个原因，HTTP 1.1新增了307，以便更加清除地区分几个状态代码：当出现303应答时，
        ///   浏览器可以跟随重定向的GET和POST请求；如果是307应答，则浏览器只 能跟随对GET请求的重定向)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusTemporaryRedirect(this HttpResponse @this)
        {
            @this.StatusCode = 307;
            //@this.StatusDescription = @"Temporary Redirect 和302（Found）相同。许多浏览器会错误地响应302应答进行重定向，即使原来的请求是POST，即使它实际上只能在POST请求的应答是303时 才能重定向。由于这个原因，HTTP 1.1新增了307，以便更加清除地区分几个状态代码：当出现303应答时，浏览器可以跟随重定向的GET和POST请求；如果是307应答，则浏览器只 能跟随对GET请求的重定向";
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
        ///  自定义扩展方法：设置 ASP.NET 操作的返回给客户端的输出的 HTTP 状态代码 307
        ///  (Temporary Redirect 和302（Found）相同。许多浏览器会错误地响应302应答进行重定向，即使原来的请求是POST，
        ///   即使它实际上只能在POST/请求的应答是303时 才能重定向。
        ///   由于这个原因，HTTP 1.1新增了307，以便更加清除地区分几个状态代码：当出现303应答时，
        ///   浏览器可以跟随重定向的GET和POST请求；如果是307应答，则浏览器只 能跟随对GET请求的重定向)
        /// </summary>
        /// <param name="this">扩展对象。ASP.NET 操作的 HTTP 响应信息对象</param>
        public static void SetStatusTemporaryRedirect(this HttpResponse @this)
        {
            @this.StatusCode = 307;
            @this.StatusDescription = @"Temporary Redirect 和302（Found）相同。许多浏览器会错误地响应302应答进行重定向，即使原来的请求是POST，即使它实际上只能在POST请求的应答是303时 才能重定向。由于这个原因，HTTP 1.1新增了307，以便更加清除地区分几个状态代码：当出现303应答时，浏览器可以跟随重定向的GET和POST请求；如果是307应答，则浏览器只 能跟随对GET请求的重定向";
        }
    }
}

#endif