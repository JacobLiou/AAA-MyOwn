// /* ---------------------------------------------------------------------------------------
//    文件名：HttpManager.cs
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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;

namespace BIMFace.SDK.CSharp.Common.Http
{
    /// <summary>
    ///  基于 HttpWebRequest 与 HttpWebResponse 类封装的 HTTP 请求与响应辅助类（上传或下载普通文本、数据流、文件等）
    /// </summary>
    public sealed class HttpManager
    {
        #region 字段属性

        private readonly bool _allowAutoRedirect;
        private string _userAgent;
        private string _accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/x-silverlight-2-b1, */*";

        /// <summary>
        ///  获取或设置CookieContainer的值
        /// </summary>
        public CookieContainer CookieContainer { get; set; }

        /// <summary>
        ///  获取或设置与请求或响应关联的协议标头
        /// </summary>
        public WebHeaderCollection HeaderCollection { get; set; }

        /// <summary>
        ///  获取或设置解析网页源码时使用的编码，默认
        /// </summary>
        /// <value></value>
        public Encoding EncodingType { get; set; }

        ///// <summary>
        /////  获取或设置<see langword="Content-type" /> HTTP 标头的值。请使用 ContentType 类的常量来获取。
        ///// </summary>
        //public string ContentType { get; set; }

        /// <summary>
        ///  获取或设置读取响应内容的方式。默认为 ResponseReadMode.Stream
        /// </summary>
        public ResponseReadMode ReadMode { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="allowAutoRedirect">是否允许HttpWebRequest的“重定向”，默认禁止</param>
        public HttpManager(bool allowAutoRedirect = false)
        {
            this.CookieContainer = new CookieContainer();
            this.HeaderCollection = new WebHeaderCollection();
            this.EncodingType = Encoding.UTF8;
            this.ReadMode = ResponseReadMode.Stream;

            _allowAutoRedirect = allowAutoRedirect;
            _userAgent = GetUserAgent();
        }

        /// <summary>
        /// 使用 CookieContainer 对象来初始化该类的一个实例
        /// </summary>
        /// <param name="cookieContainer">指定CookieContainer的值</param>
        /// <param name="allowAutoRedirect">是否允许HttpWebRequest的“重定向”，默认禁止</param>
        public HttpManager(CookieContainer cookieContainer, bool allowAutoRedirect = false)
            : this(allowAutoRedirect)
        {
            this.CookieContainer = cookieContainer;
        }

        /// <summary>
        /// 使用 WebHeaderCollection 协议标头对象来初始化该类的一个实例
        /// </summary>
        /// <param name="headerCollection">与请求或响应关联的协议标头</param>
        /// <param name="allowAutoRedirect">是否允许HttpWebRequest的“重定向”，默认禁止</param>
        public HttpManager(WebHeaderCollection headerCollection, bool allowAutoRedirect = false)
            : this(allowAutoRedirect)
        {
            this.HeaderCollection = headerCollection;
        }

        /// <summary>
        /// 使用 CookieContainer 对象与WebHeaderCollection 协议标头对象来初始化该类的一个实例
        /// </summary>
        /// <param name="cookieContainer">指定CookieContainer的值</param>
        /// <param name="headerCollection">与请求或响应关联的协议标头</param>
        /// <param name="allowAutoRedirect">是否允许HttpWebRequest的“重定向”，默认禁止</param>
        public HttpManager(CookieContainer cookieContainer, WebHeaderCollection headerCollection, bool allowAutoRedirect = false)
            : this(allowAutoRedirect)
        {
            this.CookieContainer = cookieContainer;
            this.HeaderCollection = headerCollection;
        }

        #endregion

        #region 方法

        #region Request

        /// <summary>
        ///  HTTP请求(包含文本的body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本或者JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取</param>
        /// <returns></returns>
        private HttpResult RequestString(string url, string data, string method, string contentType)
        {
            HttpResult httpResult = new HttpResult();
            HttpWebRequest httpWebRequest = null;

            try
            {
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.Method = method;
                httpWebRequest.Headers = HeaderCollection;
                httpWebRequest.CookieContainer = CookieContainer;
                if (!string.IsNullOrWhiteSpace(contentType))
                {
                    httpWebRequest.ContentType = contentType;// 此属性的值存储在WebHeaderCollection中。如果设置了WebHeaderCollection，则属性值将丢失。所以放置在Headers 属性之后设置
                }
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.AllowAutoRedirect = _allowAutoRedirect;
                httpWebRequest.ServicePoint.Expect100Continue = false;

                if (!string.IsNullOrWhiteSpace(data))
                {
                    /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                     *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                     */

                    byte[] dataBytes = EncodingType.GetBytes(data);
                    httpWebRequest.ContentLength = dataBytes.Length; /* body 中非空时，必须设置 content-length 的标头*/
                    httpWebRequest.AllowWriteStreamBuffering = true;

                    using (Stream requestStream = httpWebRequest.GetRequestStream())
                    {
                        /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                         *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                         */
                        requestStream.Write(dataBytes, 0, dataBytes.Length);     // 将请求参数写入请求流中 
                        requestStream.Flush();
                    }
                }

                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    GetResponse(ref httpResult, httpWebResponse);
                    httpWebResponse.Close();
                }
            }
            catch (WebException webException)
            {
                GetWebExceptionResponse(ref httpResult, webException);
            }
            catch (Exception ex)
            {
                GetExceptionResponse(ref httpResult, ex, method, contentType);
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                }
            }

            return httpResult;
        }

        /// <summary>
        ///  将数据缓冲区(一般是指文件流或内存流对应的字节数组)上载到由 URI 标识的资源。(包含body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(字节数据)。如果没有请传递null</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 ContentType 类的常量来获取。默认为 application/octet-stream</param>
        /// <returns>HTTP-POST的响应结果</returns>
        private HttpResult RequestData(string url, byte[] data, string method = HttpMethod.POST, string contentType = HttpContentType.APPLICATION_OCTET_STREAM)
        {
            HttpResult httpResult = new HttpResult();
            HttpWebRequest httpWebRequest = null;

            try
            {
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.Method = method;
                httpWebRequest.Headers = HeaderCollection;
                httpWebRequest.CookieContainer = CookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.AllowAutoRedirect = _allowAutoRedirect;
                httpWebRequest.ServicePoint.Expect100Continue = false;

                if (data != null)
                {
                    /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                     *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                     */
                    httpWebRequest.ContentLength = data.Length;
                    httpWebRequest.AllowWriteStreamBuffering = true;

                    using (Stream requestStream = httpWebRequest.GetRequestStream())
                    {
                        /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                         *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                         */
                        requestStream.Write(data, 0, data.Length);
                        requestStream.Flush();
                    }
                }

                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    GetResponse(ref httpResult, httpWebResponse);
                    httpWebResponse.Close();
                }
            }
            catch (WebException webException)
            {
                GetWebExceptionResponse(ref httpResult, webException);
            }
            catch (Exception ex)
            {
                GetExceptionResponse(ref httpResult, ex, method, contentType);
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                }
            }

            return httpResult;
        }

        #endregion 

        #region (不包含body数据)POST、GET请求

        /// <summary>
        /// HTTP-GET方法，(不包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <returns>HTTP-GET的响应结果</returns>
        public HttpResult Get(string url)
        {
            return RequestString(url, null, HttpMethod.GET, null);
        }

        /// <summary>
        /// HTTP-POST方法，(不包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult Post(string url)
        {
            return RequestString(url, null, HttpMethod.POST, null);
        }

        /// <summary>
        /// HTTP-PUT方法，(不包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult Put(string url)
        {
            return RequestString(url, null, HttpMethod.PUT, null);
        }

        /// <summary>
        /// HTTP-DELETE方法，(不包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult Delete(string url)
        {
            return RequestString(url, null, HttpMethod.DELETE, null);
        }

        #endregion

        #region (包含文本的body数据)请求

        /// <summary>
        /// HTTP-GET方法，(包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本或者JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取</param>
        /// <returns>HTTP-GET的响应结果</returns>
        public HttpResult Get(string url, string data, string contentType = HttpContentType.APPLICATION_JSON)
        {
            return RequestString(url, data, HttpMethod.GET, contentType);
        }

        /// <summary>
        /// HTTP-POST方法，(包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本或者JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult Post(string url, string data, string contentType = HttpContentType.APPLICATION_JSON)
        {
            return RequestString(url, data, HttpMethod.POST, contentType);
        }

        /// <summary>
        /// HTTP-PUT方法，(包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本或者JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult Put(string url, string data, string contentType = HttpContentType.APPLICATION_JSON)
        {
            return RequestString(url, data, HttpMethod.PUT, contentType);
        }

        /// <summary>
        /// HTTP-DELETE方法，(包含body数据)。
        /// 发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本或者JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult Delete(string url, string data, string contentType = HttpContentType.APPLICATION_JSON)
        {
            return RequestString(url, data, HttpMethod.DELETE, contentType);
        }

        ///// <summary>
        /////   HTTP请求(包含JSON文本的body数据)
        ///// </summary>
        ///// <param name="url">请求目标URL</param>
        ///// <param name="data">主体数据(JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        ///// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        ///// <returns></returns>
        //public HttpResult UploadJson(string url, string data, string method = HttpMethod.POST)
        //{
        //    return RequestString(url, data, method, HttpContentType.APPLICATION_JSON);
        //}

        ///// <summary>
        /////  HTTP请求(包含普通文本的body数据)
        ///// </summary>
        ///// <param name="url">请求目标URL</param>
        ///// <param name="data">主体数据(普通文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        ///// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        ///// <returns></returns>
        //public HttpResult UploadText(string url, string data, string method = HttpMethod.POST)
        //{
        //    return RequestString(url, data, method, HttpContentType.TEXT_PLAIN);
        //}

        #endregion

        #region (文件、文件流等)请求


        /// <summary>
        ///  将普通文本或者JSON文本上载到具有指定的 URI 的资源。(包含body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本或者JSON文本)。如果参数中有中文，请使用合适的编码方式进行编码，例如：gb2312或者utf-8</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取。默认为 application/octet-stream</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult UploadString(string url, string data, string method = HttpMethod.POST, string contentType = null)
        {
            return RequestString(url, data, method, contentType);
        }

        /// <summary>
        ///  将指定的本地文件上载到具有指定的 URI 的资源。(包含body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="fileFullName">待上传的文件(包含全路径的完全限定名)</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取。默认为 application/octet-stream</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult UploadFile(string url, string fileFullName, string method = HttpMethod.POST, string contentType = HttpContentType.APPLICATION_OCTET_STREAM)
        {
            HttpResult httpResult = new HttpResult();
            if (!File.Exists(fileFullName))
            {
                httpResult.Status = HttpResult.STATUS_FAIL;

                httpResult.RefCode = (int)HttpStatusCode2.USER_FILE_NOT_EXISTS;
                httpResult.RefText = HttpStatusCode2.USER_FILE_NOT_EXISTS.GetCustomAttributeDescription();
            }
            else
            {
                FileStream fileStream = new FileStream(fileFullName, FileMode.Open, FileAccess.Read);
                byte[] data = fileStream.ToByteArray();
                httpResult = UploadData(url, data, method, contentType);
            }

            return httpResult;
        }

        /// <summary>
        ///  将指定的数据流对象(一般指文件流或内存流)上载到具有指定的 URI 的资源。(包含body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="stream">一般指文件流或内存流</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取。默认为 application/octet-stream</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult UploadStream(string url, Stream stream, string method = HttpMethod.POST, string contentType = HttpContentType.APPLICATION_OCTET_STREAM)
        {
            HttpResult httpResult = new HttpResult();
            if (stream == null)
            {
                httpResult.Status = HttpResult.STATUS_FAIL;

                httpResult.RefCode = (int)HttpStatusCode2.USER_STREAM_NULL;
                httpResult.RefText = HttpStatusCode2.USER_STREAM_NULL.GetCustomAttributeDescription();
            }
            else
            {
                byte[] data = stream.ToByteArray();
                httpResult = UploadData(url, data, method, contentType);
            }

            return httpResult;
        }

        /// <summary>
        ///  将数据缓冲区(一般是指文件流或内存流对应的字节数组)上载到由 URI 标识的资源。(包含body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(字节数据)。如果没有请传递null</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="contentType"><see langword="Content-type" /> HTTP 标头的值。请使用 HttpContentType 类的常量来获取。默认为 application/octet-stream</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult UploadData(string url, byte[] data, string method = HttpMethod.POST, string contentType = HttpContentType.APPLICATION_OCTET_STREAM)
        {
            return RequestData(url, data, method, contentType);
        }

        #endregion

        #region (包含表单数据)请求

        /// <summary>
        ///  HTTP请求(包含表单数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(普通文本)</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <returns></returns>
        public HttpResult UploadForm(string url, string data, string method = HttpMethod.POST)
        {
            return RequestString(url, data, method, HttpContentType.WWW_FORM_URLENCODED);
        }

        /// <summary>
        /// HTTP请求(包含表单数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="kvDatas">请求时表单键值对数据</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <returns></returns>
        public HttpResult UploadForm(string url, Dictionary<string, string> kvDatas, string method = HttpMethod.POST)
        {
            var nvc = kvDatas.ToNameValueCollection();

            return UploadForm(url, nvc, method);
        }

        /// <summary>
        ///  HTTP请求(包含表单数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="kvDatas">请求时表单键值对数据</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <returns></returns>
        public HttpResult UploadForm(string url, NameValueCollection kvDatas, string method = HttpMethod.POST)
        {
            HttpResult httpResult = new HttpResult();
            HttpWebRequest httpWebRequest = null;

            try
            {
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
                httpWebRequest.Method = method;
                httpWebRequest.Headers = HeaderCollection;
                httpWebRequest.CookieContainer = CookieContainer;
                httpWebRequest.ContentType = HttpContentType.WWW_FORM_URLENCODED;
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.AllowAutoRedirect = _allowAutoRedirect;
                httpWebRequest.ServicePoint.Expect100Continue = false;

                if (kvDatas != null)
                {
                    StringBuilder sbKV = new StringBuilder();
                    foreach (string key in kvDatas.Keys)
                    {
                        sbKV.AppendFormat("{0}={1}&", Uri.EscapeDataString(key), Uri.EscapeDataString(kvDatas[key])); //注意中文编码
                    }

                    /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                     *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                     */
                    byte[] dataBytes = EncodingType.GetBytes(sbKV.ToString());
                    httpWebRequest.ContentLength = dataBytes.Length; /* body 中非空时，必须设置 content-length 的标头*/
                    httpWebRequest.AllowWriteStreamBuffering = true;

                    using (Stream requestStream = httpWebRequest.GetRequestStream())
                    {
                        requestStream.Write(dataBytes, 0, sbKV.Length - 1);
                        requestStream.Flush();
                    }
                }

                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
                if (httpWebResponse != null)
                {
                    GetResponse(ref httpResult, httpWebResponse);
                    httpWebResponse.Close();
                }
            }
            catch (WebException webException)
            {
                GetWebExceptionResponse(ref httpResult, webException);
            }
            catch (Exception ex)
            {
                GetExceptionResponse(ref httpResult, ex, method, HttpContentType.WWW_FORM_URLENCODED);
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                }
            }

            return httpResult;
        }

        /// <summary>
        ///  HTTP请求(包含表单数据)。将数据缓冲区上载到由 URI 标识的资源。(包含body数据)
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据(字节数据)</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <returns>HTTP-POST的响应结果</returns>
        public HttpResult UploadForm(string url, byte[] data, string method = HttpMethod.POST)
        {
            return UploadData(url, data, method, HttpContentType.WWW_FORM_URLENCODED);
        }

        /// <summary>
        ///  HTTP请求方法(包含多分部数据,multipart/form-data)
        ///  将数据缓冲区内的内容以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="data">主体数据</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, byte[] data, string method = HttpMethod.POST)
        {
            string boundary = CreateFormDataBoundary();
            string contentType = string.Format(HttpContentType.MULTIPART_FORM_DATA + "; boundary={0}", boundary);

            return UploadData(url, data, method, contentType);
        }

        /// <summary>
        /// HTTP请求(包含多分部数据,multipart/form-data)。
        /// 将多个参数以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="kVDatas">【必填】请求时表单键值对数据。</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="timeOut">获取或设置 <see cref="M:System.Net.HttpWebRequest.GetResponse" /> 和
        ///                       <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> 方法的超时值（以毫秒为单位）。
        ///                       -1 表示永不超时
        /// </param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, Dictionary<string, string> kVDatas, string method = HttpMethod.POST, int timeOut = -1)
        {
            NameValueCollection nvc = kVDatas.ToNameValueCollection();

            return UploadFormByMultipart(url, nvc, method, timeOut);
        }

        /// <summary>
        /// HTTP请求(包含多分部数据,multipart/form-data)。
        /// 将多个参数以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="kVDatas">【必填】请求时表单键值对数据。</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="timeOut">获取或设置 <see cref="M:System.Net.HttpWebRequest.GetResponse" /> 和
        ///                       <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> 方法的超时值（以毫秒为单位）。
        ///                       -1 表示永不超时
        /// </param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, NameValueCollection kVDatas, string method = HttpMethod.POST, int timeOut = -1)
        {
            #region 说明
            /* 阿里云文档：https://www.alibabacloud.com/help/zh/doc-detail/42976.htm
               C# 示例：  https://github.com/aliyun/aliyun-oss-csharp-sdk/blob/master/samples/Samples/PostPolicySample.cs?spm=a2c63.p38356.879954.18.7f3f7c34W3bR9U&file=PostPolicySample.cs
                         (C#示例中仅仅是把文件中的文本内容当做 FormData 中的项，与文件流是不一样的。本方法展示的是文件流，更通用)
              */

            /* 说明：multipart/form-data 方式提交文件
             *     (1) Header 一定要有 Content-Type: multipart/form-data; boundary={boundary}。
             *     (2) Header 和bod y之间由 \r\n--{boundary} 分割。
             *     (3) 表单域格式 ：Content-Disposition: form-data; name="{key}"\r\n\r\n
             *                   {value}\r\n
             *                   --{boundary}
             *     (4)表单域名称大小写敏感，如policy、key、file、OSSAccessKeyId、OSSAccessKeyId、Content-Disposition。
             *     (5)注意:表单域 file 必须为最后一个表单域。即必须放在最后写。
             */
            #endregion

            HttpResult httpResult = new HttpResult();

            #region 校验
            if (kVDatas == null)
            {
                httpResult.Status = HttpResult.STATUS_FAIL;

                httpResult.RefCode = (int)HttpStatusCode2.USER_OBJECT_IS_NULL;
                httpResult.RefText = HttpStatusCode2.USER_OBJECT_IS_NULL.GetCustomAttributeDescription();

                return httpResult;
            }

            if (kVDatas.Keys.Count == 0)
            {
                httpResult.Status = HttpResult.STATUS_FAIL;

                httpResult.RefCode = (int)HttpStatusCode2.USER_OBJECT_HAS_NO_ELEMENTS_;
                httpResult.RefText = HttpStatusCode2.USER_OBJECT_HAS_NO_ELEMENTS_.GetCustomAttributeDescription();

                return httpResult;
            }

            #endregion

            string boundary = CreateFormDataBoundary();                                         // 边界符
            byte[] beginBoundaryBytes = Encoding.UTF8.GetBytes("--" + boundary + "\r\n");     // 边界符开始。【☆】右侧必须要有 \r\n 。
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n"); // 边界符结束。【☆】两侧必须要有 --\r\n 。
            MemoryStream memoryStream = new MemoryStream();

            HttpWebRequest httpWebRequest = null;
            try
            {
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest; // 创建请求
                httpWebRequest.ContentType = string.Format(HttpContentType.MULTIPART_FORM_DATA + "; boundary={0}", boundary);
                //httpWebRequest.Referer = "http://bimface.com/user-console";
                httpWebRequest.Method = method;
                httpWebRequest.KeepAlive = true;
                httpWebRequest.Timeout = timeOut;
                httpWebRequest.UserAgent = GetUserAgent();

                #region 步骤1：写入键值对

                string formDataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n" +
                                         "{1}\r\n";

                foreach (string key in kVDatas.Keys)
                {
                    string formItem = string.Format(formDataTemplate, key.Replace(StringUtils.Symbol.KEY_SUFFIX, String.Empty), kVDatas[key]);
                    byte[] formItemBytes = Encoding.UTF8.GetBytes(formItem);

                    memoryStream.Write(beginBoundaryBytes, 0, beginBoundaryBytes.Length); // 1.1 写入FormData项的开始边界符
                    memoryStream.Write(formItemBytes, 0, formItemBytes.Length);           // 1.2 将键值对写入FormData项中
                }

                memoryStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);         // 1.3 写入FormData的结束边界符

                #endregion

                #region 步骤2：将表单域(内存流)写入 httpWebRequest 的请求流中，并发起请求

                /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                 *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                 */
                httpWebRequest.ContentLength = memoryStream.Length;

                Stream requestStream = httpWebRequest.GetRequestStream();

                memoryStream.Position = 0;
                byte[] tempBuffer = new byte[memoryStream.Length];
                memoryStream.Read(tempBuffer, 0, tempBuffer.Length);
                memoryStream.Close();

                requestStream.Write(tempBuffer, 0, tempBuffer.Length);        // 将内存流中的字节写入 httpWebRequest 的请求流中
                requestStream.Close();
                #endregion

                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
                if (httpWebResponse != null)
                {
                    //GetHeaders(ref httpResult, httpWebResponse);
                    GetResponse(ref httpResult, httpWebResponse);
                    httpWebResponse.Close();
                }
            }
            catch (WebException webException)
            {
                GetWebExceptionResponse(ref httpResult, webException);
            }
            catch (Exception ex)
            {
                GetExceptionResponse(ref httpResult, ex, method, HttpContentType.MULTIPART_FORM_DATA);
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                }
            }

            return httpResult;
        }

        /// <summary>
        /// HTTP请求(包含多分部数据,multipart/form-data)。
        /// 将文件以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="fileFullName">待上传的文件(包含全路径的完全限定名)</param>
        /// <param name="kVDatas">请求时表单键值对数据。</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="timeOut">获取或设置 <see cref="M:System.Net.HttpWebRequest.GetResponse" /> 和
        ///                       <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> 方法的超时值（以毫秒为单位）。
        ///                       -1 表示永不超时
        /// </param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, string fileFullName, Dictionary<string, string> kVDatas = null, string method = HttpMethod.POST, int timeOut = -1)
        {
            var nvc = kVDatas.ToNameValueCollection();
            return UploadFormByMultipart(url, fileFullName, nvc, method, timeOut);
        }

        /// <summary>
        /// HTTP请求(包含多分部数据,multipart/form-data)。
        /// 将文件以及多个参数以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="fileFullName">待上传的文件(包含全路径的完全限定名)</param>
        /// <param name="kVDatas">请求时表单键值对数据。</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="timeOut">获取或设置 <see cref="M:System.Net.HttpWebRequest.GetResponse" /> 和
        ///                       <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> 方法的超时值（以毫秒为单位）。
        ///                       -1 表示永不超时
        /// </param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, string fileFullName, NameValueCollection kVDatas = null, string method = HttpMethod.POST, int timeOut = -1)
        {
            string[] fileFullNames = { fileFullName };

            return UploadFormByMultipart(url, fileFullNames, kVDatas, method, timeOut);
        }

        /// <summary>
        /// HTTP请求(包含多分部数据,multipart/form-data)。
        /// 将多个文件以及多个参数以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="fileFullNames">待上传的文件列表(包含全路径的完全限定名)。如果某个文件不存在，则忽略不上传</param>
        /// <param name="kVDatas">请求时表单键值对数据。</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="timeOut">获取或设置 <see cref="M:System.Net.HttpWebRequest.GetResponse" /> 和
        ///                       <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> 方法的超时值（以毫秒为单位）。
        ///                       -1 表示永不超时
        /// </param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, string[] fileFullNames, NameValueCollection kVDatas = null, string method = HttpMethod.POST, int timeOut = -1)
        {
            #region 说明
            /* 阿里云文档：https://www.alibabacloud.com/help/zh/doc-detail/42976.htm
               C# 示例：  https://github.com/aliyun/aliyun-oss-csharp-sdk/blob/master/samples/Samples/PostPolicySample.cs?spm=a2c63.p38356.879954.18.7f3f7c34W3bR9U&file=PostPolicySample.cs
                         (C#示例中仅仅是把文件中的文本内容当做 FormData 中的项，与文件流是不一样的。本方法展示的是文件流，更通用)
              */

            /* 说明：multipart/form-data 方式提交文件
             *     (1) Header 一定要有 Content-Type: multipart/form-data; boundary={boundary}。
             *     (2) Header 和bod y之间由 \r\n--{boundary} 分割。
             *     (3) 表单域格式 ：Content-Disposition: form-data; name="{key}"\r\n\r\n
             *                   {value}\r\n
             *                   --{boundary}
             *     (4)表单域名称大小写敏感，如policy、key、file、OSSAccessKeyId、OSSAccessKeyId、Content-Disposition。
             *     (5)注意:表单域 file 必须为最后一个表单域。即必须放在最后写。
             */
            #endregion

            #region ContentType 说明
            /* 该ContentType的属性包含请求的媒体类型。分配给ContentType属性的值在请求发送Content-typeHTTP标头时替换任何现有内容。
               
               要清除Content-typeHTTP标头，请将ContentType属性设置为null。
               
             * 注意：此属性的值存储在WebHeaderCollection中。如果设置了WebHeaderCollection，则属性值将丢失。
             *      所以放置在Headers 属性之后设置
             */
            #endregion

            #region Method 说明
            /* 如果 ContentLength 属性设置为-1以外的任何值，则必须将 Method 属性设置为上载数据的协议属性。 */
            #endregion

            #region HttpWebRequest.CookieContainer 在 .NET3.5 与 .NET4.0 中的不同
            /* 请参考：https://www.crifan.com/baidu_emulate_login_for_dotnet_4_0_error_the_fisrt_two_args_should_be_string_type_0_1/ */
            #endregion

            HttpResult httpResult = new HttpResult();

            #region 校验

            if (fileFullNames == null || fileFullNames.Length == 0)
            {
                httpResult.Status = HttpResult.STATUS_FAIL;

                httpResult.RefCode = (int)HttpStatusCode2.USER_FILE_NOT_EXISTS;
                httpResult.RefText = HttpStatusCode2.USER_FILE_NOT_EXISTS.GetCustomAttributeDescription();

                return httpResult;
            }

            List<string> lstFiles = new List<string>();
            foreach (string fileFullName in fileFullNames)
            {
                if (File.Exists(fileFullName))
                {
                    lstFiles.Add(fileFullName);
                }
            }

            if (lstFiles.Count == 0)
            {
                httpResult.Status = HttpResult.STATUS_FAIL;

                httpResult.RefCode = (int)HttpStatusCode2.USER_FILE_NOT_EXISTS;
                httpResult.RefText = HttpStatusCode2.USER_FILE_NOT_EXISTS.GetCustomAttributeDescription();

                return httpResult;
            }

            #endregion

            string boundary = CreateFormDataBoundary();                                         // 边界符
            byte[] beginBoundaryBytes = Encoding.UTF8.GetBytes("--" + boundary + "\r\n");     // 边界符开始。【☆】右侧必须要有 \r\n 。
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n"); // 边界符结束。【☆】两侧必须要有 --\r\n 。
            byte[] newLineBytes = Encoding.UTF8.GetBytes("\r\n"); //换一行
            MemoryStream memoryStream = new MemoryStream();

            HttpWebRequest httpWebRequest = null;
            try
            {
                httpWebRequest = WebRequest.Create(url) as HttpWebRequest; // 创建请求
                httpWebRequest.ContentType = string.Format(HttpContentType.MULTIPART_FORM_DATA + "; boundary={0}", boundary);
                //httpWebRequest.Referer = "http://bimface.com/user-console";
                httpWebRequest.Method = method;
                httpWebRequest.KeepAlive = true;
                httpWebRequest.Timeout = timeOut;
                httpWebRequest.UserAgent = GetUserAgent();

                #region 步骤1：写入键值对
                if (kVDatas != null)
                {
                    string formDataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n" +
                                              "{1}\r\n";

                    foreach (string key in kVDatas.Keys)
                    {
                        string formItem = string.Format(formDataTemplate, key.Replace(StringUtils.Symbol.KEY_SUFFIX, String.Empty), kVDatas[key]);
                        byte[] formItemBytes = Encoding.UTF8.GetBytes(formItem);

                        memoryStream.Write(beginBoundaryBytes, 0, beginBoundaryBytes.Length); // 1.1 写入FormData项的开始边界符
                        memoryStream.Write(formItemBytes, 0, formItemBytes.Length);           // 1.2 将键值对写入FormData项中
                    }
                }
                #endregion

                #region 步骤2：写入文件(表单域 file 必须为最后一个表单域)

                const string filePartHeaderTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n" +
                                                      "Content-Type: application/octet-stream\r\n\r\n";

                int i = 0;
                foreach (var fileFullName in lstFiles)
                {
                    FileInfo fileInfo = new FileInfo(fileFullName);
                    string fileName = fileInfo.Name;

                    string fileHeaderItem = string.Format(filePartHeaderTemplate, "file", fileName);
                    byte[] fileHeaderItemBytes = Encoding.UTF8.GetBytes(fileHeaderItem);

                    if (i > 0)
                    {
                        // 第一笔及第一笔之后的数据项之间要增加一个换行 
                        memoryStream.Write(newLineBytes, 0, newLineBytes.Length);
                    }
                    memoryStream.Write(beginBoundaryBytes, 0, beginBoundaryBytes.Length);      // 2.1 写入FormData项的开始边界符
                    memoryStream.Write(fileHeaderItemBytes, 0, fileHeaderItemBytes.Length);    // 2.2 将文件头写入FormData项中

                    int bytesRead;
                    byte[] buffer = new byte[1024];

                    FileStream fileStream = new FileStream(fileFullName, FileMode.Open, FileAccess.Read);
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        memoryStream.Write(buffer, 0, bytesRead);                              // 2.3 将文件流写入FormData项中
                    }

                    i++;
                }

                memoryStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);             // 2.4 写入FormData的结束边界符

                #endregion

                #region 步骤3：将表单域(内存流)写入 httpWebRequest 的请求流中，并发起请求

                /*  在 http1.1 以上中，如果使用 post，并且 body 中非空时，必须要有 content-length 的标头。
                 *  并且，如果字符中存在汉字，那么在 utf-8 编码模式下，其长度应该采用编码后的字符长度，也就是 byte 数组的长度，而不是原始字符串的长度。
                 */
                httpWebRequest.ContentLength = memoryStream.Length;

                Stream requestStream = httpWebRequest.GetRequestStream();

                memoryStream.Position = 0;
                byte[] tempBuffer = new byte[memoryStream.Length];
                memoryStream.Read(tempBuffer, 0, tempBuffer.Length);
                memoryStream.Close();

                requestStream.Write(tempBuffer, 0, tempBuffer.Length);        // 将内存流中的字节写入 httpWebRequest 的请求流中
                requestStream.Close();
                #endregion

                HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
                if (httpWebResponse != null)
                {
                    //GetHeaders(ref httpResult, httpWebResponse);
                    GetResponse(ref httpResult, httpWebResponse);
                    httpWebResponse.Close();
                }
            }
            catch (WebException webException)
            {
                GetWebExceptionResponse(ref httpResult, webException);
            }
            catch (Exception ex)
            {
                GetExceptionResponse(ref httpResult, ex, method, HttpContentType.MULTIPART_FORM_DATA);
            }
            finally
            {
                if (httpWebRequest != null)
                {
                    httpWebRequest.Abort();
                }
            }

            return httpResult;
        }

        /// <summary>
        /// HTTP请求(包含多分部数据,multipart/form-data)。
        /// 将多个文件以及多个参数以多分部数据表单方式上传到指定url的服务器
        /// </summary>
        /// <param name="url">请求目标URL</param>
        /// <param name="fileFullNames">待上传的文件列表(包含全路径的完全限定名)。如果某个文件不存在，则忽略不上传</param>
        /// <param name="kVDatas">请求时表单键值对数据。</param>
        /// <param name="method">请求的方法。请使用 HttpMethod 的枚举值</param>
        /// <param name="timeOut">获取或设置 <see cref="M:System.Net.HttpWebRequest.GetResponse" /> 和
        ///                       <see cref="M:System.Net.HttpWebRequest.GetRequestStream" /> 方法的超时值（以毫秒为单位）。
        ///                       -1 表示永不超时
        /// </param>
        /// <returns></returns>
        public HttpResult UploadFormByMultipart(string url, List<string> fileFullNames, NameValueCollection kVDatas = null, string method = HttpMethod.POST, int timeOut = -1)
        {
            return UploadFormByMultipart(url, fileFullNames.ToArray(), kVDatas, method, timeOut);
        }

        #endregion

        #region 其他HTTP辅助方法

        /// <summary>
        ///  获取返回信息头
        /// </summary>
        /// <param name="httpResult">即将被HTTP请求封装函数返回的HttpResult变量</param>
        /// <param name="httpWebResponse">正在被读取的HTTP响应</param>
        private void GetHeaders(ref HttpResult httpResult, HttpWebResponse httpWebResponse)
        {
            //if (httpWebResponse != null)
            //{
            //    if (httpResult.RefInfo == null)
            //    {
            //        httpResult.RefInfo = new Dictionary<string, string>();
            //    }

            //    httpResult.RefInfo.Add("ProtocolVersion", httpWebResponse.ProtocolVersion.ToString());

            //    if (!string.IsNullOrEmpty(httpWebResponse.CharacterSet))
            //    {
            //        httpResult.RefInfo.Add("Characterset", httpWebResponse.CharacterSet);
            //    }

            //    if (!string.IsNullOrEmpty(httpWebResponse.ContentEncoding))
            //    {
            //        httpResult.RefInfo.Add("ContentEncoding", httpWebResponse.ContentEncoding);
            //    }

            //    if (!string.IsNullOrEmpty(httpWebResponse.ContentType))
            //    {
            //        httpResult.RefInfo.Add("ContentType", httpWebResponse.ContentType);
            //    }

            //    httpResult.RefInfo.Add("ContentLength", httpWebResponse.ContentLength.ToString());

            //    var headers = httpWebResponse.Headers;
            //    if (headers != null && headers.Count > 0)
            //    {
            //        if (httpResult.RefInfo == null)
            //        {
            //            httpResult.RefInfo = new Dictionary<string, string>();
            //        }
            //        foreach (var key in headers.AllKeys)
            //        {
            //            httpResult.RefInfo.Add(key, headers[key]);
            //        }
            //    }
            //}
        }

        /// <summary>
        /// 获取HTTP的响应信息
        /// </summary>
        /// <param name="httpResult">即将被HTTP请求封装函数返回的HttpResult变量</param>
        /// <param name="httpWebResponse">正在被读取的HTTP响应</param>
        private void GetResponse(ref HttpResult httpResult, HttpWebResponse httpWebResponse)
        {
            httpResult.HttpWebResponse = httpWebResponse;
            httpResult.Status = HttpResult.STATUS_SUCCESS;
            httpResult.StatusDescription = httpWebResponse.StatusDescription;
            httpResult.StatusCode = (int)httpWebResponse.StatusCode;

            if (ReadMode == ResponseReadMode.Binary)
            {
                int len = (int)httpWebResponse.ContentLength;
                httpResult.Data = new byte[len];
                int bytesLeft = len;
                int bytesRead = 0;

                using (BinaryReader br = new BinaryReader(httpWebResponse.GetResponseStream()))
                {
                    while (bytesLeft > 0)
                    {
                        bytesRead = br.Read(httpResult.Data, len - bytesLeft, bytesLeft);
                        bytesLeft -= bytesRead;
                    }
                }
            }
            else
            {
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    httpResult.Text = sr.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// 获取HTTP访问网络期间发生错误时引发的异常响应信息
        /// </summary>
        /// <param name="httpResult">即将被HTTP请求封装函数返回的HttpResult变量</param>
        /// <param name="webException">访问网络期间发生错误时引发的异常对象</param>
        private void GetWebExceptionResponse(ref HttpResult httpResult, WebException webException)
        {
            HttpWebResponse exResponse = webException.Response as HttpWebResponse;
            if (exResponse != null)
            {
                httpResult.HttpWebResponse = exResponse;
                httpResult.Status = HttpResult.STATUS_FAIL;
                httpResult.StatusDescription = exResponse.StatusDescription;
                httpResult.StatusCode = (int)exResponse.StatusCode;

                httpResult.RefCode = httpResult.StatusCode;
                using (StreamReader sr = new StreamReader(exResponse.GetResponseStream(), EncodingType))
                {
                    httpResult.Text = sr.ReadToEnd();
                    httpResult.RefText = httpResult.Text;
                }

                exResponse.Close();
            }
        }

        /// <summary>
        /// 获取HTTP的异常响应信息
        /// </summary>
        /// <param name="httpResult">即将被HTTP请求封装函数返回的HttpResult变量</param>
        /// <param name="ex">异常对象</param>
        /// <param name="method">HTTP请求的方式</param>
        /// <param name="contentType">HTTP的标头类型</param>
        private void GetExceptionResponse(ref HttpResult httpResult, Exception ex, string method, string contentType = "")
        {
            contentType = string.IsNullOrWhiteSpace(contentType) ? string.Empty : "-" + contentType;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[{0}] [{1}] [HTTP-" + method + contentType + "] Error:  ", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff"), _userAgent);

            sb.AppendLine(ex.GetAllExceptionMessage());

            httpResult.HttpWebResponse = null;
            httpResult.Status = HttpResult.STATUS_FAIL;

            httpResult.RefCode = (int)HttpStatusCode2.USER_UNDEF;
            httpResult.RefText += sb.ToString();
        }

        /// <summary>
        /// 获取客户端标识(UserAgent)，示例："SpecifiedClient/1.1 (Universal)"
        /// </summary>
        /// <returns>客户端标识UA</returns>
        public static string GetUserAgent()
        {
            string osDesc = Environment.OSVersion.Platform + "; " + Environment.OSVersion.Version;
            return string.Format("{0}/{1} ({2}; {3})", BIMFace_SDK_CSharp.ALIAS, BIMFace_SDK_CSharp.VERSION, BIMFace_SDK_CSharp.RTFX, osDesc);
        }

        /// <summary>
        /// 设置自定义的客户端标识(UserAgent)，示例："SpecifiedClient/1.1 (Universal)"
        /// 如果设置为空白或者不设置，SDK会自动使用默认的UserAgent
        /// </summary>
        /// <param name="userAgent">用户自定义的UserAgent</param>
        /// <returns>客户端标识UA</returns>
        public void SetUserAgent(string userAgent)
        {
            if (!string.IsNullOrEmpty(userAgent))
            {
                this._userAgent = userAgent;
            }
        }

        /// <summary>
        /// 创建多部分表单数据(multi-part form-data)的分界(boundary)标识
        /// </summary>
        /// <returns>分界(boundary)标识字符串</returns>
        public static string CreateFormDataBoundary()
        {
            string now = DateTime.UtcNow.Ticks.ToString("x");
            return string.Format("----{0}_Boundary_{1}", BIMFace_SDK_CSharp.ALIAS, now.EncryptByMD5());
        }

        /// <summary>
        ///  获取POST请求附带的参数
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static Dictionary<String, Object> GetParameter(HttpContext context)
        {
            StreamReader reader = new StreamReader(context.Request.InputStream);
            String strJson = HttpUtility.UrlDecode(reader.ReadToEnd());

            var dicParameter = strJson.DeserializeJsonToObject<Dictionary<String, Object>>();
            return dicParameter;
        }

        #endregion

        #endregion
    }
}