// /* ---------------------------------------------------------------------------------------
//    文件名：HttpStatusCode2.cs
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
    ///     包含为 HTTP 定义的状态代码的值 以及 用户自定义的状态代码的值
    /// </summary>
    public enum HttpStatusCode2
    {
        #region HttpStatusCode

        /// <summary>
        ///     等效于 HTTP 状态 100。
        ///     <see cref="F:System.Net.HttpStatusCode.Continue" /> 指示客户端可以继续其请求。
        /// </summary>
        Continue = 100, // 0x00000064

        /// <summary>
        ///     等效于 HTTP 状态为 101。
        ///     <see cref="F:System.Net.HttpStatusCode.SwitchingProtocols" /> 指示正在更改的协议版本或协议。
        /// </summary>
        SwitchingProtocols = 101, // 0x00000065

        /// <summary>
        ///     等效于 HTTP 状态 200。
        ///     <see cref="F:System.Net.HttpStatusCode.OK" /> 指示请求成功，且请求的信息包含在响应中。
        ///     这是要接收的最常见状态代码。
        /// </summary>
        OK = 200, // 0x000000C8

        /// <summary>
        ///     等效于 HTTP 状态 201。
        ///     <see cref="F:System.Net.HttpStatusCode.Created" /> 指示请求导致已发送响应之前创建一个新的资源。
        /// </summary>
        Created = 201, // 0x000000C9

        /// <summary>
        ///     等效于 HTTP 状态 202。
        ///     <see cref="F:System.Net.HttpStatusCode.Accepted" /> 指示请求已被接受进行进一步处理。
        /// </summary>
        Accepted = 202, // 0x000000CA

        /// <summary>
        ///     等效于 HTTP 状态 203。
        ///     <see cref="F:System.Net.HttpStatusCode.NonAuthoritativeInformation" /> 指示返回的元信息来自而不是原始服务器的缓存副本，因此可能不正确。
        /// </summary>
        NonAuthoritativeInformation = 203, // 0x000000CB

        /// <summary>
        ///     等效于 HTTP 状态 204。
        ///     <see cref="F:System.Net.HttpStatusCode.NoContent" /> 指示已成功处理请求和响应是有意留为空白。
        /// </summary>
        NoContent = 204, // 0x000000CC

        /// <summary>
        ///     等效于 HTTP 状态 205。
        ///     <see cref="F:System.Net.HttpStatusCode.ResetContent" /> 指示客户端应重置 （而不是重新加载） 的当前资源。
        /// </summary>
        ResetContent = 205, // 0x000000CD

        /// <summary>
        ///     等效于 HTTP 206 状态。
        ///     <see cref="F:System.Net.HttpStatusCode.PartialContent" /> 指示根据包括字节范围的 GET 请求的请求的响应是部分响应。
        /// </summary>
        PartialContent = 206, // 0x000000CE

        /// <summary>
        ///     等效于 HTTP 状态 300。
        ///     <see cref="F:System.Net.HttpStatusCode.Ambiguous" /> 指示所需的信息有多种表示形式。
        ///     默认操作是将此状态视为一个重定向，并按照与此响应关联的位置标头的内容。
        /// </summary>
        Ambiguous = 300, // 0x0000012C

        /// <summary>
        ///     等效于 HTTP 状态 300。
        ///     <see cref="F:System.Net.HttpStatusCode.MultipleChoices" /> 指示所需的信息有多种表示形式。
        ///     默认操作是将此状态视为一个重定向，并按照与此响应关联的位置标头的内容。
        /// </summary>
        MultipleChoices = 300, // 0x0000012C

        /// <summary>
        ///     等效于 HTTP 状态 301。
        ///     <see cref="F:System.Net.HttpStatusCode.Moved" /> 指示已将所需的信息移动到的位置标头中指定的 URI。
        ///     当收到此状态时的默认操作是遵循与响应关联的位置标头。
        ///     当原始请求方法是 POST 时，重定向的请求将使用 GET 方法。
        /// </summary>
        Moved = 301, // 0x0000012D

        /// <summary>
        ///     等效于 HTTP 状态 301。
        ///     <see cref="F:System.Net.HttpStatusCode.MovedPermanently" /> 指示已将所需的信息移动到的位置标头中指定的 URI。
        ///     当收到此状态时的默认操作是遵循与响应关联的位置标头。
        /// </summary>
        MovedPermanently = 301, // 0x0000012D

        /// <summary>
        ///     等效于 HTTP 状态 302。
        ///     <see cref="F:System.Net.HttpStatusCode.Found" /> 指示所需的信息位于的位置标头中指定的 URI。
        ///     当收到此状态时的默认操作是遵循与响应关联的位置标头。
        ///     当原始请求方法是 POST 时，重定向的请求将使用 GET 方法。
        /// </summary>
        Found = 302, // 0x0000012E

        /// <summary>
        ///     等效于 HTTP 状态 302。
        ///     <see cref="F:System.Net.HttpStatusCode.Redirect" /> 指示所需的信息位于的位置标头中指定的 URI。
        ///     当收到此状态时的默认操作是遵循与响应关联的位置标头。
        ///     当原始请求方法是 POST 时，重定向的请求将使用 GET 方法。
        /// </summary>
        Redirect = 302, // 0x0000012E

        /// <summary>
        ///     等效于 HTTP 状态 303。
        ///     <see cref="F:System.Net.HttpStatusCode.RedirectMethod" /> 自动将客户端重定向到的位置标头中指定作为公告的结果的 URI。
        ///     对指定的位置标头的资源的请求将会执行与 GET。
        /// </summary>
        RedirectMethod = 303, // 0x0000012F

        /// <summary>
        ///     等效于 HTTP 状态 303。
        ///     <see cref="F:System.Net.HttpStatusCode.SeeOther" /> 自动将客户端重定向到的位置标头中指定作为公告的结果的 URI。
        ///     对指定的位置标头的资源的请求将会执行与 GET。
        /// </summary>
        SeeOther = 303, // 0x0000012F

        /// <summary>
        ///     等效于 HTTP 状态 304。
        ///     <see cref="F:System.Net.HttpStatusCode.NotModified" /> 指示客户端的缓存的副本是最新。
        ///     不会传输资源的内容。
        /// </summary>
        NotModified = 304, // 0x00000130

        /// <summary>
        ///     等效于 HTTP 状态 305。
        ///     <see cref="F:System.Net.HttpStatusCode.UseProxy" /> 指示该请求应使用的位置标头中指定的 uri 的代理服务器。
        /// </summary>
        UseProxy = 305, // 0x00000131

        /// <summary>
        ///     等效于 HTTP 状态 306。
        ///     <see cref="F:System.Net.HttpStatusCode.Unused" /> 是对未完全指定的 HTTP/1.1 规范建议的扩展。
        /// </summary>
        Unused = 306, // 0x00000132

        /// <summary>
        ///     等效于 HTTP 状态 307。
        ///     <see cref="F:System.Net.HttpStatusCode.RedirectKeepVerb" /> 指示请求信息位于的位置标头中指定的 URI。
        ///     当收到此状态时的默认操作是遵循与响应关联的位置标头。
        ///     当原始请求方法是 POST 时，重定向的请求还将使用 POST 方法。
        /// </summary>
        RedirectKeepVerb = 307, // 0x00000133

        /// <summary>
        ///     等效于 HTTP 状态 307。
        ///     <see cref="F:System.Net.HttpStatusCode.TemporaryRedirect" /> 指示请求信息位于的位置标头中指定的 URI。
        ///     当收到此状态时的默认操作是遵循与响应关联的位置标头。
        ///     当原始请求方法是 POST 时，重定向的请求还将使用 POST 方法。
        /// </summary>
        TemporaryRedirect = 307, // 0x00000133

        /// <summary>
        ///     等效于 HTTP 状态 400。
        ///     <see cref="F:System.Net.HttpStatusCode.BadRequest" /> 指示无法由服务器理解此请求。
        ///     <see cref="F:System.Net.HttpStatusCode.BadRequest" /> 如果没有其他错误适用，或者如果具体的错误是未知的或不具有其自己的错误代码发送。
        /// </summary>
        BadRequest = 400, // 0x00000190

        /// <summary>
        ///     等效于 HTTP 状态 401。
        ///     <see cref="F:System.Net.HttpStatusCode.Unauthorized" /> 指示所请求的资源需要身份验证。
        ///     Www-authenticate 标头包含如何执行身份验证的详细信息。
        /// </summary>
        Unauthorized = 401, // 0x00000191

        /// <summary>
        ///     等效于 HTTP 状态 402。
        ///     <see cref="F:System.Net.HttpStatusCode.PaymentRequired" /> 已保留供将来使用。
        /// </summary>
        PaymentRequired = 402, // 0x00000192

        /// <summary>
        ///     等效于 HTTP 状态 403。
        ///     <see cref="F:System.Net.HttpStatusCode.Forbidden" /> 指示服务器拒绝无法完成请求。
        /// </summary>
        Forbidden = 403, // 0x00000193

        /// <summary>
        ///     等效于 HTTP 状态 404。
        ///     <see cref="F:System.Net.HttpStatusCode.NotFound" /> 指示所请求的资源不存在的服务器上。
        /// </summary>
        NotFound = 404, // 0x00000194

        /// <summary>
        ///     等效于 HTTP 状态 405。
        ///     <see cref="F:System.Net.HttpStatusCode.MethodNotAllowed" /> 指示请求方法 （POST 或 GET） 不允许对所请求的资源。
        /// </summary>
        MethodNotAllowed = 405, // 0x00000195

        /// <summary>
        ///     等效于 HTTP 状态 406。
        ///     <see cref="F:System.Net.HttpStatusCode.NotAcceptable" /> 表示客户端已指定使用 Accept 标头，它将不接受任何可用的资源表示。
        /// </summary>
        NotAcceptable = 406, // 0x00000196

        /// <summary>
        ///     等效于 HTTP 状态 407。
        ///     <see cref="F:System.Net.HttpStatusCode.ProxyAuthenticationRequired" /> 指示请求的代理要求身份验证。
        ///     代理服务器进行身份验证标头包含如何执行身份验证的详细信息。
        /// </summary>
        ProxyAuthenticationRequired = 407, // 0x00000197

        /// <summary>
        ///     等效于 HTTP 状态 408。
        ///     <see cref="F:System.Net.HttpStatusCode.RequestTimeout" /> 指示客户端的服务器预期请求的时间内没有未发送请求。
        /// </summary>
        RequestTimeout = 408, // 0x00000198

        /// <summary>
        ///     等效于 HTTP 状态 409。
        ///     <see cref="F:System.Net.HttpStatusCode.Conflict" /> 指示该请求可能不会执行由于在服务器上发生冲突。
        /// </summary>
        Conflict = 409, // 0x00000199

        /// <summary>
        ///     等效于 HTTP 状态 410。
        ///     <see cref="F:System.Net.HttpStatusCode.Gone" /> 指示所请求的资源不再可用。
        /// </summary>
        Gone = 410, // 0x0000019A

        /// <summary>
        ///     等效于 HTTP 状态 411。
        ///     <see cref="F:System.Net.HttpStatusCode.LengthRequired" /> 指示缺少必需的内容长度标头。
        /// </summary>
        LengthRequired = 411, // 0x0000019B

        /// <summary>
        ///     等效于 HTTP 状态 412。
        ///     <see cref="F:System.Net.HttpStatusCode.PreconditionFailed" /> 表示失败，此请求的设置的条件，无法执行请求。
        ///     使用条件请求标头，如果匹配项，如设置条件无-If-match，或如果-修改-自从。
        /// </summary>
        PreconditionFailed = 412, // 0x0000019C

        /// <summary>
        ///     等效于 HTTP 状态 413。
        ///     <see cref="F:System.Net.HttpStatusCode.RequestEntityTooLarge" /> 指示请求来说太大的服务器能够处理。
        /// </summary>
        RequestEntityTooLarge = 413, // 0x0000019D

        /// <summary>
        ///     等效于 HTTP 状态 414。
        ///     <see cref="F:System.Net.HttpStatusCode.RequestUriTooLong" /> 指示 URI 太长。
        /// </summary>
        RequestUriTooLong = 414, // 0x0000019E

        /// <summary>
        ///     等效于 HTTP 状态 415。
        ///     <see cref="F:System.Net.HttpStatusCode.UnsupportedMediaType" /> 指示该请求是不受支持的类型。
        /// </summary>
        UnsupportedMediaType = 415, // 0x0000019F

        /// <summary>
        ///     等效于 HTTP 416 状态。
        ///     <see cref="F:System.Net.HttpStatusCode.RequestedRangeNotSatisfiable" />
        ///     指示从资源请求的数据范围不能返回，或者因为范围的开始处，然后该资源的开头或范围的末尾后在资源的结尾。
        /// </summary>
        RequestedRangeNotSatisfiable = 416, // 0x000001A0

        /// <summary>
        ///     等效于 HTTP 状态 417。
        ///     <see cref="F:System.Net.HttpStatusCode.ExpectationFailed" /> 指示无法由服务器满足 Expect 标头中给定。
        /// </summary>
        ExpectationFailed = 417, // 0x000001A1

        /// <summary>
        ///     等效于 HTTP 状态 426。
        ///     <see cref="F:System.Net.HttpStatusCode.UpgradeRequired" /> 指示客户端应切换到不同的协议，例如 TLS/1.0。
        /// </summary>
        UpgradeRequired = 426, // 0x000001AA

        /// <summary>
        ///     等效于 HTTP 状态 500。
        ///     <see cref="F:System.Net.HttpStatusCode.InternalServerError" /> 表示在服务器上发生一般性错误。
        /// </summary>
        InternalServerError = 500, // 0x000001F4

        /// <summary>
        ///     等效于 HTTP 状态 501。
        ///     <see cref="F:System.Net.HttpStatusCode.NotImplemented" /> 指示服务器不支持所请求的功能。
        /// </summary>
        NotImplemented = 501, // 0x000001F5

        /// <summary>
        ///     等效于 HTTP 状态 502。
        ///     <see cref="F:System.Net.HttpStatusCode.BadGateway" /> 指示中间代理服务器从另一个代理或原始服务器接收到错误响应。
        /// </summary>
        BadGateway = 502, // 0x000001F6

        /// <summary>
        ///     等效于 HTTP 状态 503。
        ///     <see cref="F:System.Net.HttpStatusCode.ServiceUnavailable" /> 指示将服务器暂时不可用，通常是由于高负载或维护。
        /// </summary>
        ServiceUnavailable = 503, // 0x000001F7

        /// <summary>
        ///     等效于 HTTP 状态 504。
        ///     <see cref="F:System.Net.HttpStatusCode.GatewayTimeout" /> 指示中间代理服务器在等待来自另一个代理或原始服务器的响应时已超时。
        /// </summary>
        GatewayTimeout = 504, // 0x000001F8

        /// <summary>
        ///     等效于 HTTP 状态 505。
        ///     <see cref="F:System.Net.HttpStatusCode.HttpVersionNotSupported" /> 指示服务器不支持请求的 HTTP 版本。
        /// </summary>
        HttpVersionNotSupported = 505, // 0x000001F9

        #endregion

        #region 用户自定义的状态代码的值

        /// <summary>
        /// 自定义HTTP状态码（指定的参数对象(集合)没有元素）
        /// </summary>
        USER_OBJECT_HAS_NO_ELEMENTS_ = -41,

        /// <summary>
        /// 自定义HTTP状态码（指定的参数对象为NULL）
        /// </summary>
        USER_OBJECT_IS_NULL = -40,

        /// <summary>
        /// 自定义HTTP状态码（指定的文件不存在）
        /// </summary>
        USER_FILE_NOT_EXISTS = -30,

        /// <summary>
        /// 自定义HTTP状态码（流对象为NULL）
        /// </summary>
        USER_STREAM_NULL = -31,

        /// <summary>
        /// 自定义HTTP状态码（凭证不合法）
        /// </summary>
        USER_INVALID_TOKEN = -5,

        /// <summary>
        /// 自定义HTTP状态码 (异常或错误)
        /// </summary>
        USER_INVALID_ARGUMENT = -4,

        /// <summary>
        /// 自定义HTTP状态码（文件不合法）
        /// </summary>
        USER_INVALID_FILE = -3,

        /// <summary>
        /// 自定义HTTP状态码 (用户取消)
        /// </summary>
        USER_CANCELED = -2,

        /// <summary>
        /// 自定义HTTP状态码 (程序出现异常)
        /// </summary>
        USER_EXCEPTION = -1,

        /// <summary>
        /// 自定义HTTP状态码 (默认值)
        /// </summary>
        USER_UNDEF = 0,

        /// <summary>
        /// 自定义HTTP状态码 (用户暂停)
        /// </summary>
        USER_PAUSED = 1,

        /// <summary>
        /// 自定义HTTP状态码 (用户继续)
        /// </summary>
        USER_RESUMED = 2,

        /// <summary>
        /// 自定义HTTP状态码 (需要重试)
        /// </summary>
        USER_NEED_RETRY = 3,

        #endregion
    }
}
