// /* ---------------------------------------------------------------------------------------
//    文件名：HttpMethod.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁  （QQ：905442693  微信：savionzhang）
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

namespace BIMFace.SDK.CSharp.Common.Http
{
    /// <summary>
    ///  Http请求的方法
    /// </summary>
    public class HttpMethod
    {
        /// <summary>
        ///  返回服务器支持的 HTTP 请求方法。
        /// </summary>
        public const string OPTIONS = "OPTIONS";

        /// <summary>
        ///  向服务器获取指定资源。参数放在URL后面。
        /// </summary>
        public const string GET = "GET";

        /// <summary>
        ///  与 GET 相同，但只返回 HTTP 报头，不返回文档主体。
        /// </summary>
        public const string HEAD = "HEAD";

        /// <summary>
        ///  向服务器提交数据，数据放在请求体里。
        /// </summary>
        public const string POST = "POST";

        /// <summary>
        ///  上传指定的 URI 表示。与POST相似，只是具有幂等特性，一般用于更新。
        /// </summary>
        public const string PUT = "PUT";

        /// <summary>
        ///  删除服务器上的指定资源。
        /// </summary>
        public const string DELETE = "DELETE";

        /// <summary>
        ///  回显服务器端收到的请求，测试的时候会用到这个。
        /// </summary>
        public const string TRACE = "TRACE";

        /// <summary>
        ///  把请求连接转换到透明的 TCP/IP 通道。
        /// </summary>
        public const string CONNECT = "CONNECT";
    }
}