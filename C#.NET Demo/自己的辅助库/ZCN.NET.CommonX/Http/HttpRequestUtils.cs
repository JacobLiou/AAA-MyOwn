using System;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

using Microsoft.AspNetCore.Http;

using ZCN.NET.Common.Extensions;
using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Http
{
    /// <summary>
    ///  基于 HttpWebRequest 与 HttpWebResponse 技术封装的 HTTP 请求与响应辅助类（获取网页数据）
    /// </summary>
    public class HttpRequestUtils
    {
        #region 私有变量
        private readonly CookieContainer _cookieContainer;
        private string _contentType = "application/x-www-form-urlencoded";
        private string _accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/x-silverlight-2-b1, */*";
        private string _userAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";

        private Encoding encoding = Encoding.GetEncoding("utf-8");
        private int delay = 1000;
        private int maxTry = 3;//最大尝试次数
        private int currentTry = 0;
        #endregion

        #region 属性

        /// <summary>
        ///  内容类型，默认为"application/x-www-form-urlencoded"
        /// </summary>
        public string ContentType
        {
            get { return _contentType; }
            set { _contentType = value; }
        }

        /// <summary>
        ///  Accept值，默认支持各种类型
        /// </summary>
        public string Accept
        {
            get { return _accept; }
            set { _accept = value; }
        }

        /// <summary>
        ///  UserAgent，默认支持Mozilla/MSIE等
        /// </summary>
        public string UserAgent
        {
            get { return _userAgent; }
            set { _userAgent = value; }
        }

        /// <summary>
        ///  Cookie容器
        /// </summary>
        public CookieContainer CookieContainer
        {
            get { return _cookieContainer; }
        }

        /// <summary>
        ///  获取网页源码时使用的编码
        /// </summary>
        /// <value></value>
        public Encoding Encoding
        {
            get { return encoding; }
            set { encoding = value; }
        }

        /// <summary>
        ///  网络延时
        /// </summary>
        public int NetworkDelay
        {
            get { return (new Random().Next(delay / 1000, delay / 1000 * 2)) * 1000; }
            set { delay = value; }
        }

        /// <summary>
        ///  最大尝试次数
        /// </summary>
        public int MaxTry
        {
            get { return maxTry; }
            set { maxTry = value; }
        }

        #endregion

        #region 构造函数

        /// <summary>
        ///  默认构造函数
        /// </summary>
        public HttpRequestUtils()
        {
            _cookieContainer = new CookieContainer();
        }

        /// <summary>
        ///  使用指定CookieContainer的值来初始化该类的实例
        /// </summary>
        /// <param name="cookieContainer">指定CookieContainer的值</param>
        public HttpRequestUtils(CookieContainer cookieContainer)
        {
            this._cookieContainer = cookieContainer;
        }

        /// <summary>
        ///  使用内容类型、Accept类型、UserAgent内容来初始化该类的实例
        /// </summary>
        /// <param name="contentType">内容类型</param>
        /// <param name="accept">Accept类型</param>
        /// <param name="userAgent">UserAgent内容</param>
        public HttpRequestUtils(string contentType, string accept, string userAgent)
        {
            this._contentType = contentType;
            this._accept = accept;
            this._userAgent = userAgent;
        }

        /// <summary>
        ///  使用指定CookieContainer的值、内容类型、Accept类型、UserAgent内容来初始化该类的实例
        /// </summary>
        /// <param name="cookieContainer">指定CookieContainer的值</param>
        /// <param name="contentType">内容类型</param>
        /// <param name="accept">Accept类型</param>
        /// <param name="userAgent">UserAgent内容</param>
        public HttpRequestUtils(CookieContainer cookieContainer, string contentType, string accept, string userAgent)
        {
            this._cookieContainer = cookieContainer;
            this._contentType = contentType;
            this._accept = accept;
            this._userAgent = userAgent;
        }

        #endregion

        #region 公共方法

        /// <summary>
        ///  获取浏览器的信息
        /// </summary>
        /// <returns></returns>
        public static string GetBrowserInfo()
        {
            return String.Empty; //暂时没找到解决方法
        }

        /// <summary>
        ///  以 GET 方式发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <returns></returns>
        public string GetHtml(string url)
        {
            return GetHtml(url, _cookieContainer, url);
        }

        /// <summary>
        ///  以 GET 方式发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="reference">页面引用</param>
        /// <returns></returns>
        public string GetHtml(string url, string reference)
        {
            return GetHtml(url, _cookieContainer, reference);
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="postData">回发的数据</param>
        /// <param name="isPost">是否以post方式发送请求</param>
        /// <returns></returns>
        public string GetHtml(string url, string postData, bool isPost)
        {
            string redirectUrl = "";
            return GetHtml(url, _cookieContainer, postData, isPost, redirectUrl);
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="headerCollection">请求的头部信息</param>
        /// <param name="postData">回发的数据</param>
        /// <param name="isPost">是否以post方式发送请求</param>
        /// <returns></returns>
        public string GetHtml(string url, WebHeaderCollection headerCollection, string postData, bool isPost)
        {
            string redirectUrl = "";
            return GetHtml(url, _cookieContainer, postData, isPost, redirectUrl, headerCollection);
        }

        /// <summary>
        ///  以 GET 方式发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="cookieContainer">Cookie集合</param>
        /// <param name="reference">页面引用</param>
        /// <returns></returns>
        public string GetHtml(string url, CookieContainer cookieContainer, string reference)
        {
            currentTry++;

            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = _contentType;
                httpWebRequest.Referer = reference;
                httpWebRequest.Accept = _accept;
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.Method = "GET";

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, encoding);
                string html = streamReader.ReadToEnd();

                streamReader.Close();
                responseStream.Close();
                httpWebResponse.Close();

                currentTry = 0;
                return html;
            }
            catch
            {
                if (currentTry <= maxTry)
                {
                    GetHtml(url, cookieContainer, reference);
                }

                currentTry = 0;
                return string.Empty;
            }
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="cookieContainer">Cookie集合</param>
        /// <param name="postData">回发的数据</param>
        /// <param name="isPost">是否以post方式发送请求</param>
        /// <returns></returns>
        public string GetHtml(string url, CookieContainer cookieContainer, string postData, bool isPost)
        {
            return GetHtml(url, cookieContainer, postData, isPost, url);
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(HTML代码)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="cookieContainer">Cookie集合对象</param>
        /// <param name="postData">回发的数据</param>
        /// <param name="isPost">是否以post方式发送请求</param>
        /// <param name="referer">页面引用</param>
        /// <param name="headerCollection">请求的头部信息</param>
        /// <returns></returns>
        public string GetHtml(string url, CookieContainer cookieContainer, string postData, bool isPost, string referer, WebHeaderCollection headerCollection = null)
        {
            if (string.IsNullOrEmpty(postData))
            {
                return GetHtml(url, cookieContainer, referer);
            }

            currentTry++;
            try
            {
                byte[] byteRequest = Encoding.GetBytes(postData);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = _contentType;
                httpWebRequest.Referer = referer;
                httpWebRequest.Accept = _accept;
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.Method = isPost ? "POST" : "GET";
                httpWebRequest.ContentLength = byteRequest.Length;
                httpWebRequest.AllowAutoRedirect = false;

                if (headerCollection != null)
                {
                    httpWebRequest.Headers = headerCollection;
                }

                Stream requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(byteRequest, 0, byteRequest.Length);
                requestStream.Close();

                HttpWebResponse httpWebResponse;
                try
                {
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                }
                catch (WebException ex)
                {
                    httpWebResponse = (HttpWebResponse)ex.Response;
                }
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, encoding);
                string html = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();

                currentTry = 0;
                return html;
            }
            catch
            {
                if (currentTry <= maxTry)
                {
                    GetHtml(url, cookieContainer, postData, isPost);
                }

                currentTry = 0;
                return string.Empty;
            }
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(指定页面的 Stream 对象)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="fileName">文件名称</param>
        /// <param name="cookieContainer">Cookie集合对象</param>
        /// <returns></returns>
        public Stream GetStream(string url, ref string fileName, CookieContainer cookieContainer)
        {
            return GetStream(url, ref fileName, cookieContainer, url);
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(指定页面的 Stream 对象)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="fileName"></param>
        /// <param name="cookieContainer">Cookie对象</param>
        /// <param name="reference">页面引用</param>
        public Stream GetStream(string url, ref string fileName, CookieContainer cookieContainer, string reference)
        {
            currentTry++;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = _contentType;
                httpWebRequest.Referer = reference;
                httpWebRequest.Accept = _accept;
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.Method = "GET";

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();

                fileName = httpWebResponse.Headers["Content-Disposition"] != null ?
                    httpWebResponse.Headers["Content-Disposition"].Replace("attachment; filename=", "").Replace("\"", "") :
                    httpWebResponse.Headers["Location"] != null ? Path.GetFileName(httpWebResponse.Headers["Location"]) :
                    Path.GetFileName(url).Contains("?") || Path.GetFileName(url).Contains("=") ?
                    Path.GetFileName(httpWebResponse.ResponseUri.ToString()) : "";

                fileName = !string.IsNullOrEmpty(fileName) ? Path.GetFileName(fileName) : "UnKnowFileName";
                currentTry = 0;

                return responseStream;
            }
            catch
            {
                if (currentTry <= maxTry)
                {
                    CookieCollection cookie = new CookieCollection();
                    GetHtml(url, cookieContainer, url);
                }

                currentTry = 0;
                return null;
            }
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(指定页面的 Stream 对象)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="fileName"></param>
        /// <param name="cookieContainer">Cookie对象</param>
        /// <param name="postData">请求参数(json格式)</param>
        /// <param name="isPost">是否以Post方式提交</param>
        public Stream GetStream(string url, ref string fileName, CookieContainer cookieContainer, string postData, bool isPost)
        {
            return GetStream(url, ref fileName, cookieContainer, postData, isPost, url);
        }

        /// <summary>
        ///  发送 HTTP 请求并返回来自 Internet 资源的响应(指定页面的 Stream 对象)
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="fileName"></param>
        /// <param name="cookieContainer">Cookie对象</param>
        /// <param name="postData">请求参数(json格式)</param>
        /// <param name="isPost">是否以Post方式提交</param>
        /// <param name="reference">页面引用</param>
        /// <param name="headerCollection">请求的头部信息</param>
        public Stream GetStream(string url, ref string fileName, CookieContainer cookieContainer, string postData, bool isPost, string reference, WebHeaderCollection headerCollection = null)
        {
            if (postData.IsNullOrWhiteSpace())
            {
                return GetStream(url, ref fileName, cookieContainer);
            }

            currentTry++;
            try
            {
                byte[] byteRequest = Encoding.UTF8.GetBytes(postData);

                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = _contentType;
                httpWebRequest.Referer = reference;
                httpWebRequest.Accept = _accept;
                httpWebRequest.UserAgent = _userAgent;
                httpWebRequest.Method = isPost ? "POST" : "GET";
                if (headerCollection != null)
                {
                    httpWebRequest.Headers = headerCollection;
                }

                Stream requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(byteRequest, 0, byteRequest.Length);
                requestStream.Close();

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();

                fileName = httpWebResponse.Headers["Content-Disposition"] != null ?
                    httpWebResponse.Headers["Content-Disposition"].Replace("attachment; filename=", "").Replace("\"", "") :
                    httpWebResponse.Headers["Location"] != null ? Path.GetFileName(httpWebResponse.Headers["Location"]) :
                    Path.GetFileName(url).Contains("?") || Path.GetFileName(url).Contains("=") ?
                    Path.GetFileName(httpWebResponse.ResponseUri.ToString()) : "";

                fileName = !string.IsNullOrEmpty(fileName) ? Path.GetFileName(fileName) : "UnKnowFileName";
                currentTry = 0;

                return responseStream;
            }
            catch
            {
                if (currentTry <= maxTry)
                {
                    CookieCollection cookie = new CookieCollection();
                    GetHtml(url, cookieContainer, url);
                }

                currentTry = 0;
                return null;
            }
        }

        /// <summary>
        ///  提交文件流到服务地址
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="files">提交的文件列表</param>
        /// <param name="nvc">其他内容（名称-值键值）</param>
        /// <param name="cookieContainer">Cookie对象</param>
        /// <param name="reference">页面引用</param>
        /// <param name="headerCollection">发送请求的头内容</param>
        /// <returns></returns>
        public string PostStream(string url, string[] files, NameValueCollection nvc = null, CookieContainer cookieContainer = null, string reference = null, WebHeaderCollection headerCollection = null)
        {
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
            webRequest.Method = "POST";
            webRequest.KeepAlive = true;
            webRequest.Credentials = System.Net.CredentialCache.DefaultCredentials;
            webRequest.Timeout = -1;
            webRequest.CookieContainer = cookieContainer;
            webRequest.Referer = reference;
            if (headerCollection != null && headerCollection.Count > 0)
            {
                webRequest.Headers = headerCollection ?? new WebHeaderCollection();
            }

            Stream memStream = new System.IO.MemoryStream();
            byte[] boundaryBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
            string formDataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}";

            if (nvc != null)
            {
                foreach (string key in nvc.Keys)
                {
                    string formItem = string.Format(formDataTemplate, key, nvc[key]);
                    byte[] formItemBytes = Encoding.GetBytes(formItem);
                    memStream.Write(formItemBytes, 0, formItemBytes.Length);
                }
            }
            memStream.Write(boundaryBytes, 0, boundaryBytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n Content-Type: application/octet-stream\r\n\r\n";
            for (int i = 0; i < files.Length; i++)
            {
                string header = string.Format(headerTemplate, "file", files[i]);
                byte[] headerBytes = Encoding.GetBytes(header);
                memStream.Write(headerBytes, 0, headerBytes.Length);

                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                FileStream fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    memStream.Write(buffer, 0, bytesRead);
                }

                memStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                fileStream.Close();
            }

            webRequest.ContentLength = memStream.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                memStream.Position = 0;
                byte[] tempBuffer = new byte[memStream.Length];
                memStream.Read(tempBuffer, 0, tempBuffer.Length);
                memStream.Close();

                requestStream.Write(tempBuffer, 0, tempBuffer.Length);
                requestStream.Close();
            }

            string result = null;
            using (WebResponse webResponse2 = webRequest.GetResponse())
            {
                using (Stream stream2 = webResponse2.GetResponseStream())
                {
                    using (StreamReader reader2 = new StreamReader(stream2))
                    {
                        result = reader2.ReadToEnd();
                    }
                }
            }
            webRequest = null;

            return result;
        }

        /// <summary>
        ///  提交文件流到服务地址
        /// </summary>
        /// <param name="url">指定页面的路径</param>
        /// <param name="files">提交的文件列表</param>
        /// <param name="nvc">其他内容（名称-值键值）</param>
        /// <param name="cookieContainer">Cookie对象</param>
        /// <param name="reference">页面引用</param>
        /// <param name="headerCollection">发送请求的头内容</param>
        /// <returns></returns>
        public string PostStream2(string url, string[] files, NameValueCollection nvc = null, CookieContainer cookieContainer = null, string reference = null, WebHeaderCollection headerCollection = null)
        {
            string result = null;
            string boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");

            try
            {
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
                webRequest.Method = "POST";
                webRequest.KeepAlive = true;
                webRequest.Credentials = System.Net.CredentialCache.DefaultCredentials;
                webRequest.CookieContainer = cookieContainer;
                webRequest.Referer = reference;

                if (headerCollection != null && headerCollection.Count > 0)
                {
                    webRequest.Headers = headerCollection;
                }

                Stream memStream = new System.IO.MemoryStream();
                byte[] boundaryBytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                string formDataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}";

                if (nvc != null)
                {
                    foreach (string key in nvc.Keys)
                    {
                        string formItem = string.Format(formDataTemplate, key.Replace("_BIMFACE_", ""), nvc[key]);
                        byte[] formItemBytes = Encoding.GetBytes(formItem);
                        memStream.Write(formItemBytes, 0, formItemBytes.Length);
                    }
                }
                memStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n Content-Type: application/octet-stream\r\n\r\n";
                for (int i = 0; i < files.Length; i++)
                {
                    string header = string.Format(headerTemplate, "file", files[i]);
                    byte[] headerBytes = Encoding.GetBytes(header);
                    memStream.Write(headerBytes, 0, headerBytes.Length);

                    byte[] buffer = new byte[1024];
                    int bytesRead = 0;
                    FileStream fileStream = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        memStream.Write(buffer, 0, bytesRead);
                    }

                    memStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                    fileStream.Close();
                }

                webRequest.ContentLength = memStream.Length;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    memStream.Position = 0;
                    byte[] tempBuffer = new byte[memStream.Length];
                    memStream.Read(tempBuffer, 0, tempBuffer.Length);
                    memStream.Close();

                    requestStream.Write(tempBuffer, 0, tempBuffer.Length);
                    requestStream.Close();
                }


                using (WebResponse webResponse2 = webRequest.GetResponse())
                {
                    using (Stream stream2 = webResponse2.GetResponseStream())
                    {
                        using (StreamReader reader2 = new StreamReader(stream2))
                        {
                            result = reader2.ReadToEnd();
                        }
                    }
                }
                webRequest = null;
            }
            catch (WebException webException)
            {
                HttpWebResponse exResponse = webException.Response as HttpWebResponse;
                if (exResponse != null)
                {
                    using (StreamReader sr = new StreamReader(exResponse.GetResponseStream()))
                    {
                        string msg = sr.ReadToEnd();
                    }

                    exResponse.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                throw;
            }

            return result;
        }


        /// <summary>
        /// 根据Cookie字符串获取Cookie的集合
        /// </summary>
        /// <param name="cookieString">Cookie字符串</param>
        /// <returns></returns>
        public CookieCollection GetCookieCollection(string cookieString)
        {
            CookieCollection cookieCollection = new CookieCollection();
            //string cookieString = "SID=ARRGy4M1QVBtTU-ymi8bL6X8mVkctYbSbyDgdH8inu48rh_7FFxHE6MKYwqBFAJqlplUxq7hnBK5eqoh3E54jqk=;Domain=.google.com;Path=/,LSID=AaMBTixN1MqutGovVSOejyb8mVkctYbSbyDgdH8inu48rh_7FFxHE6MKYwqBFAJqlhCe_QqxLg00W5OZejb_UeQ=;Domain=www.google.com;Path=/accounts";
            Regex re = new Regex("([^;,]+)=([^;,]+);Domain=([^;,]+);Path=([^;,]+)", RegexOptions.IgnoreCase);
            foreach (Match m in re.Matches(cookieString))
            {
                //name,   value,   path,   domain   
                Cookie cookie = new Cookie(m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value, m.Groups[3].Value);
                cookieCollection.Add(cookie);
            }
            return cookieCollection;
        }

        /// <summary>
        ///  获取HTML页面内容指定隐藏域Key的Value内容
        /// </summary>
        /// <param name="html">待操作的HTML页面内容</param>
        /// <param name="key">隐藏域的名称</param>
        /// <returns></returns>
        public string GetHiddenKeyValue(string html, string key)
        {
            string result = "";
            string sRegex = string.Format("<input\\s*type=\"hidden\".*?name=\"{0}\".*?\\s*value=[\"|'](?<value>.*?)[\"|'^/]", key);
            Regex re = new Regex(sRegex, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline);
            Match mc = re.Match(html);
            if (mc.Success)
            {
                result = mc.Groups[1].Value;
            }
            return result;
        }

        /// <summary>
        ///  发送 HTTP 请求并返回网页的编码格式
        /// </summary>
        /// <param name="url">网页地址</param>
        /// <returns></returns>
        public string GetEncoding(string url)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader reader = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 20000;
                request.AllowAutoRedirect = false;
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK && response.ContentLength < 1024 * 1024)
                {
                    if (response.ContentEncoding != null && response.ContentEncoding.Equals("gzip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        reader = new StreamReader(new GZipStream(response.GetResponseStream(), CompressionMode.Decompress));
                    }
                    else
                    {
                        reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
                    }

                    string html = reader.ReadToEnd();
                    Regex reg_charset = new Regex(@"charset\b\s*=\s*(?<charset>[^""]*)");
                    if (reg_charset.IsMatch(html))
                    {
                        return reg_charset.Match(html).Groups["charset"].Value;
                    }
                    else if (response.CharacterSet != string.Empty)
                    {
                        return response.CharacterSet;
                    }
                    else
                    {
                        return Encoding.Default.BodyName;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    response = null;
                }

                if (reader != null)
                {
                    reader.Close();
                }

                if (request != null)
                {
                    request = null;
                }
            }
            return Encoding.Default.BodyName;
        }

        /// <summary>
        ///  判断URL是否有效
        /// </summary>
        /// <param name="url">待判断的URL，可以是网页以及图片链接等</param>
        /// <returns>200为正确，其余为大致网页错误代码</returns>
        public int GetUrlError(string url)
        {
            int num = 200;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
                ServicePointManager.Expect100Continue = false;
                ((HttpWebResponse)request.GetResponse()).Close();
            }
            catch (WebException exception)
            {
                if (exception.Status != WebExceptionStatus.ProtocolError)
                {
                    return num;
                }
                if (exception.Message.IndexOf("500 ") > 0)
                {
                    return 500;
                }
                if (exception.Message.IndexOf("401 ") > 0)
                {
                    return 401;
                }
                if (exception.Message.IndexOf("404") > 0)
                {
                    num = 404;
                }
            }
            catch
            {
                num = 401;
            }
            return num;
        }

        /// <summary>
        /// 移除Html标记
        /// </summary>
        public string RemoveHtml(string content)
        {
            string regexStr = @"<[^>]*>";
            return Regex.Replace(content, regexStr, string.Empty, RegexOptions.IgnoreCase);
        }

        #region HttpUtility

        /// <summary>
        ///  返回 HTML 字符串的编码结果
        /// </summary>
        /// <param name="inputData">字符串</param>
        /// <returns>编码结果</returns>
        public static string HtmlEncode(string inputData)
        {
            return HttpUtility.HtmlEncode(inputData);
        }

        /// <summary>
        ///  返回 HTML 字符串的解码结果
        /// </summary>
        /// <param name="str">字符串</param>
        /// <returns>解码结果</returns>
        public static string HtmlDecode(string str)
        {
            return HttpUtility.HtmlDecode(str);
        }

        #endregion

        #region DownLoad

        /// <summary>
        ///  从Url下载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="stream"></param>
        public static void Download(string url, Stream stream)
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData(url);
            stream.Write(data, 0, data.Length);
        }

        /// <summary>
        /// 从Url下载，并保存到指定目录
        /// </summary>
        /// <param name="url">需要下载文件的Url</param>
        /// <param name="filePathName">保存文件的路径，如果下载文件包含文件名，按照文件名储存，否则将分配Ticks随机文件名</param>
        /// <param name="timeOut">超时时间</param>
        /// <returns>返回文件的全路径</returns>
        public static string Download(string url, string filePathName, int timeOut = 999)
        {
            var dir = Path.GetDirectoryName(filePathName) ?? "/";
            Directory.CreateDirectory(dir);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Timeout = timeOut;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                string responseFileName = null;
                var contentDescriptionHeader = response.GetResponseHeader("Content-Disposition");
                if (!string.IsNullOrEmpty(contentDescriptionHeader))
                {
                    var fileName = Regex.Match(contentDescriptionHeader, @"(?<=filename="")([\s\S]+)(?= "")", RegexOptions.IgnoreCase).Value;

                    responseFileName = Path.Combine(dir, fileName);
                }

                var fullName = responseFileName ?? Path.Combine(dir, GetRandomFileName());

                using (var fs = File.Open(filePathName, FileMode.OpenOrCreate))
                {
                    byte[] bArr = new byte[1024];
                    int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                    while (size > 0)
                    {
                        fs.Write(bArr, 0, size);
                        fs.Flush();
                        size = responseStream.Read(bArr, 0, (int)bArr.Length);
                    }

                }

                return fullName;
            }
        }

        /// <summary>
        /// 获取随机文件名
        /// </summary>
        /// <returns></returns>
        private static string GetRandomFileName()
        {
            return DateTimeOffset.Now.ToString("yyyyMMdd-HHmmss") + Guid.NewGuid().ToString("n").Substring(0, 6);
        }


        #endregion

        #endregion
    }
}