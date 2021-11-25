// /* ---------------------------------------------------------------------------------------
//    文件名：BIMFaceHttpHeaders.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁  
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

using System.Net;

using BIMFace.SDK.CSharp.Common.Utils;

namespace BIMFace.SDK.CSharp.Http
{
    /// <summary>
    ///  调用BimFace相关API时，需要放置在 http header 中的参数集合类
    /// </summary>
    public class BIMFaceHttpHeaders : WebHeaderCollection
    {
        public const string AUTHORIZATION = "Authorization";
        public const string CACHE_CONTROL = "Cache-Control";
        public const string CONTENT_DISPOSITION = "Content-Disposition";
        public const string CONTENT_ENCODING = "Content-Encoding";
        public const string CONTENT_LENGTH = "Content-Length";
        public const string CONTENT_MD5 = "Content-MD5";
        public const string CONTENT_TYPE = "Content-Type";
        public const string TRANSFER_ENCODING = "Transfer-Encoding";
        public const string DATE = "Date";
        public const string ETAG = "ETag";
        public const string EXPIRES = "Expires";
        public const string HOST = "Host";
        public const string LAST_MODIFIED = "Last-Modified";
        public const string RANGE = "Range";
        public const string LOCATION = "Location";
        public const string CONNECTION = "Connection";

        /// <summary>
        ///     header 里添加授权 Authorization 的 Basic 认证
        /// </summary>
        /// <param name="appKey"> bimface颁发授权的应用key </param>
        /// <param name="appSecret"> bimface颁发授权的应用secret </param>
        public virtual void AddBasicAuthHeader(string appKey, string appSecret)
        {
            string keyAndSecret = appKey + ":" + appSecret;
            string credential = "Basic" + " " + keyAndSecret.EncryptByBase64(); //Base64 编码

            Add(AUTHORIZATION, credential.Replace("\n", "").Replace("\r", ""));
        }

        /// <summary>
        ///     header 里添加授权 Authorization 的 Bearer 认证
        /// </summary>
        /// <param name="token"> 由bimface颁发的appKey和appSecret通过Basic认证获取的token </param>
        public virtual void AddOAuth2Header(string token)
        {
            Add(AUTHORIZATION, "Bearer " + token);
        }
    }
}