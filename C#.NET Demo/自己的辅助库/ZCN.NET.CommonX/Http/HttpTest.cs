using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace ZCN.NET.CommonX.Http
{
    /// <summary>
    /// HTTP 测试类
    /// </summary>
    public class HttpTest
    {
        /* 参考：https://blog.csdn.net/u011966339/article/details/80996129 */

        /// <summary>
        /// 普通 GET 方式请求
        /// </summary>
        public void Request01_ByGet()
        {
            HttpWebRequest httpWebRequest = WebRequest.Create("http://www.google.com/webhp?hl=zh-CN") as HttpWebRequest;
            httpWebRequest.Method = "GET";

            HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
            if (httpWebResponse != null)
            {
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string content = sr.ReadToEnd();
                }

                httpWebResponse.Close();
            }
        }

        /// <summary>
        /// 普通 POST 方式请求
        /// </summary>
        public void Request02_ByPost()
        {
            string param = "hl=zh-CN&newwindow=1";              //参数
            byte[] paramBytes = Encoding.ASCII.GetBytes(param); //参数转化为 ASCII 码

            HttpWebRequest httpWebRequest = WebRequest.Create("http://www.google.com/webhp?hl=zh-CN") as HttpWebRequest;
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.ContentLength = paramBytes.Length;

            using (Stream reqStream = httpWebRequest.GetRequestStream())
            {
                reqStream.Write(paramBytes, 0, paramBytes.Length);
            }

            HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
            if (httpWebResponse != null)
            {
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string content = sr.ReadToEnd();
                }

                httpWebResponse.Close();
            }
        }

        /// <summary>
        /// 使用 GET 方式提交中文数据
        /// </summary>
        public void Request03_ByGet()
        {
            /*GET 方式通过在网络地址中附加参数来完成数据提交，对于中文的编码，常用的有 gb2312 和 utf8 两种。
             *    由于无法告知对方提交数据的编码类型，所以编码方式要以对方的网站为标准。
             *    常见的网站中， www.baidu.com （百度）的编码方式是 gb2312, www.google.com （谷歌）的编码方式是 utf8。
             */
            Encoding myEncoding = Encoding.GetEncoding("gb2312"); //确定用哪种中文编码方式
            string address = "http://www.baidu.com/s?" + HttpUtility.UrlEncode("参数一", myEncoding) + "=" + HttpUtility.UrlEncode("值一", myEncoding); //拼接数据提交的网址和经过中文编码后的中文参数

            HttpWebRequest httpWebRequest = WebRequest.Create(address) as HttpWebRequest;
            httpWebRequest.Method = "GET";

            HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
            if (httpWebResponse != null)
            {
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string content = sr.ReadToEnd();
                }

                httpWebResponse.Close();
            }
        }

        /// <summary>
        /// 使用 POST 方式提交中文数据
        /// </summary>
        public void Request04_ByPost()
        {
            /* POST 方式通过在页面内容中填写参数的方法来完成数据的提交，由于提交的参数中可以说明使用的编码方式，所以理论上能获得更大的兼容性。*/

            Encoding myEncoding = Encoding.GetEncoding("gb2312"); //确定用哪种中文编码方式
            string param = HttpUtility.UrlEncode("参数一", myEncoding) + "=" + HttpUtility.UrlEncode("值一", myEncoding) + "&"
                         + HttpUtility.UrlEncode("参数二", myEncoding) + "=" + HttpUtility.UrlEncode("值二", myEncoding);
            byte[] paramBytes = Encoding.ASCII.GetBytes(param); //参数转化为 ASCII 码

            HttpWebRequest httpWebRequest = WebRequest.Create("https://www.baidu.com/") as HttpWebRequest;
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/x-www-form-urlencoded;charset=gb2312";
            httpWebRequest.ContentLength = paramBytes.Length;

            using (Stream reqStream = httpWebRequest.GetRequestStream())
            {
                reqStream.Write(paramBytes, 0, paramBytes.Length);
            }

            HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse; // 获取响应
            if (httpWebResponse != null)
            {
                using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    string content = sr.ReadToEnd();
                }

                httpWebResponse.Close();
            }
        }

        #region 公共方法

        /// <summary>
        /// Get数据接口
        /// </summary>
        /// <param name="getUrl">接口地址</param>
        /// <returns></returns>
        private static string GetWebRequest(string getUrl)
        {
            string responseContent = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getUrl);
            request.ContentType = "application/json";
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //在这里对接收到的页面内容进行处理
            using (Stream resStream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(resStream, Encoding.UTF8))
                {
                    responseContent = reader.ReadToEnd().ToString();
                }
            }
            return responseContent;
        }

        /// <summary>
        /// Post数据接口
        /// </summary>
        /// <param name="postUrl">接口地址</param>
        /// <param name="paramData">提交json数据</param>
        /// <param name="dataEncode">编码方式(Encoding.UTF8)</param>
        /// <returns></returns>
        private static string PostWebRequest(string postUrl, string paramData, Encoding dataEncode)
        {
            string responseContent = "";
            try
            {
                byte[] byteArray = dataEncode.GetBytes(paramData); //转化
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
                webReq.Method = "POST";
                webReq.ContentType = "application/x-www-form-urlencoded";
                webReq.ContentLength = byteArray.Length;
                using (Stream reqStream = webReq.GetRequestStream())
                {
                    reqStream.Write(byteArray, 0, byteArray.Length); //写入参数
                }
                using (HttpWebResponse response = (HttpWebResponse)webReq.GetResponse())
                {
                    //在这里对接收到的页面内容进行处理
                    using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.Default))
                    {
                        responseContent = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return responseContent;
        }


        /// <summary>
        /// 发起Post请求（采用HttpWebRequest，支持传Cookie）
        /// </summary>
        /// <param name="strUrl">请求Url</param>
        /// <param name="formData">发送的表单数据</param>
        /// <param name="strResult">返回请求结果（如果请求失败，返回异常消息）</param>
        /// <param name="cookieContainer">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>
        /// <returns>返回：是否请求成功</returns>
        public static bool HttpPost(string strUrl, Dictionary<string, string> formData, CookieContainer cookieContainer, out string strResult)
        {
            strResult = "";
            string strPostData = null;
            if (formData != null && formData.Count > 0)
            {
                StringBuilder sbData = new StringBuilder();
                int i = 0;
                foreach (KeyValuePair<string, string> data in formData)
                {
                    if (i > 0)
                    {
                        sbData.Append("&");
                    }
                    sbData.AppendFormat("{0}={1}", data.Key, data.Value);
                    i++;
                }
                strPostData = sbData.ToString();
            }

            byte[] postBytes = string.IsNullOrEmpty(strPostData) ? new byte[0] : Encoding.UTF8.GetBytes(strPostData);

            return true; //HttpPost(strUrl, postBytes, cookieContainer, out strResult);
        }

        /// <summary>
        /// 发起Post文件请求（采用HttpWebRequest，支持传Cookie）
        /// </summary>
        /// <param name="strUrl">请求Url</param>
        /// <param name="strFilePostName">上传文件的PostName</param>
        /// <param name="strFilePath">上传文件路径</param>
        /// <param name="cookieContainer">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>
        /// <param name="strResult">返回请求结果（如果请求失败，返回异常消息）</param>
        /// <returns>返回：是否请求成功</returns>
        public static bool HttpPostFile(string strUrl, string strFilePostName, string strFilePath, CookieContainer cookieContainer, out string strResult)
        {
            strResult = "";
            //HttpWebRequest request = null;
            //FileStream fileStream = FileHelper.GetFileStream(strFilePath);

            //try
            //{
            //    if (fileStream == null)
            //    {
            //        throw new FileNotFoundException();
            //    }

            //    request = (HttpWebRequest)WebRequest.Create(strUrl);
            //    request.Method = "POST";
            //    request.KeepAlive = false;
            //    request.Timeout = 30000;

            //    if (cookieContainer != null)
            //    {
            //        request.CookieContainer = cookieContainer;
            //    }

            //    string boundary = string.Format("---------------------------{0}", DateTime.Now.Ticks.ToString("x"));

            //    byte[] header = Encoding.UTF8.GetBytes(string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: application/octet-stream\r\n\r\n",
            //        boundary, strFilePostName, Path.GetFileName(strFilePath)));
            //    byte[] footer = Encoding.UTF8.GetBytes(string.Format("\r\n--{0}--\r\n", boundary));

            //    request.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
            //    request.ContentLength = header.Length + fileStream.Length + footer.Length;

            //    using (Stream reqStream = request.GetRequestStream())
            //    {
            //        // 写入分割线及数据信息
            //        reqStream.Write(header, 0, header.Length);

            //        // 写入文件
            //        FileHelper.WriteFile(reqStream, fileStream);

            //        // 写入尾部
            //        reqStream.Write(footer, 0, footer.Length);
            //    }

            //    strResult = GetResponseResult(request, cookieContainer);
            //}
            //catch (Exception ex)
            //{
            //    strResult = ex.Message;
            //    return false;
            //}
            //finally
            //{
            //    if (request != null)
            //    {
            //        request.Abort();
            //    }
            //    if (fileStream != null)
            //    {
            //        fileStream.Close();
            //    }
            //}

            return true;
        }

        /// <summary>
        /// 获取请求结果字符串
        /// </summary>
        /// <param name="request">请求对象（发起请求之后）</param>
        /// <param name="cookieContainer">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>
        /// <returns>返回请求结果字符串</returns>
        private static string GetResponseResult(HttpWebRequest request, CookieContainer cookieContainer = null)
        {
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (cookieContainer != null)
                {
                    response.Cookies = cookieContainer.GetCookies(response.ResponseUri);
                }
                using (Stream rspStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(rspStream, Encoding.UTF8))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }


        #endregion
    }
}