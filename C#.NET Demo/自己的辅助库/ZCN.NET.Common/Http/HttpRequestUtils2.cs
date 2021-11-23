using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZCN.NET.Common.Http
{
    /// <summary>
    ///   基于 WebClient 技术封装的网络请求工具类
    /// </summary>
    public class HttpRequestUtils2
    {
        #region DownloadData

        /// <summary>
        ///  作为资源下载 <see cref="T:System.Byte" /> 数组中指定的 URI，并返回字节数组作为结果（没有加入Cookie）
        /// </summary>
        /// <param name="url">请求资源的地址</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static byte[] DownloadData(string url, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = encoding ?? Encoding.UTF8,
                Proxy = webProxy
            };

            byte[] result = wc.DownloadData(url);

            return result;
        }

        /// <summary>
        ///   作为资源下载 <see cref="T:System.Byte" /> 数组中指定的 URI，并返回字节数组作为结果（没有加入Cookie）
        /// </summary>
        /// <param name="uri">请求资源的对象</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static byte[] DownloadData(Uri uri, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Proxy = webProxy
            };

            byte[] result = wc.DownloadData(uri);
            return result;
        }

#if NET45 || NET461 || NETSTANDARD2_0 || NETSTANDARD2_1

        /// <summary>
        ///   作为资源下载 <see cref="T:System.Byte" /> 从 URI 指定为异步操作使用 task 对象的数组
        /// </summary>
        /// <param name="uri">请求资源的对象</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static Task<byte[]> DownloadDataTaskAsync(Uri uri, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Proxy = webProxy
            };

            Task<byte[]> result = wc.DownloadDataTaskAsync(uri);

            return result;
        }

#endif

        #endregion

        #region DownloadFile

        /// <summary>
        ///  作为资源下载 <see cref="T:System.Byte" /> 数组中指定的 URI，并返回字节数组作为结果（没有加入Cookie）
        /// </summary>
        /// <param name="url">请求资源的地址</param>
        /// <param name="fileName">若要接收的数据的本地文件的名称</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static void DownloadFile(string url, string fileName, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = encoding ?? Encoding.UTF8,
                Proxy = webProxy
            };

            wc.DownloadFile(url, fileName);
        }

        /// <summary>
        ///   作为资源下载 <see cref="T:System.Byte" /> 数组中指定的 URI，并返回字节数组作为结果（没有加入Cookie）
        /// </summary>
        /// <param name="uri">请求资源的对象</param>
        /// <param name="fileName">若要接收的数据的本地文件的名称</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static void DownloadFile(Uri uri, string fileName, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Proxy = webProxy
            };

            wc.DownloadFile(uri, fileName);
        }

#if NET45 || NET461 || NETSTANDARD2_0 || NETSTANDARD2_1

        /// <summary>
        ///   作为资源下载 <see cref="T:System.Byte" /> 从 URI 指定为异步操作使用 task 对象的数组
        /// </summary>
        /// <param name="uri">请求资源的对象</param>
        /// <param name="fileName">若要接收的数据的本地文件的名称</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static Task DownloadFileTaskAsync(Uri uri, string fileName, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Proxy = webProxy
            };

            Task result = wc.DownloadFileTaskAsync(uri, fileName);

            return result;
        }
#endif

        #endregion

        #region DownloadString

        /// <summary>
        ///  使用Get方法获取指定路径的资源，并返回字符串结果（没有加入Cookie）
        /// </summary>
        /// <param name="url">请求资源的地址</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static string DownloadString(string url, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = encoding ?? Encoding.UTF8,
                Proxy = webProxy
            };

            string result = wc.DownloadString(url);
            if (result.Contains("errcode"))
            {
                //可能发生错误  
            }

            return result;
        }

        /// <summary>
        ///   下载请求的资源(相当于Get方式)，并返回字符串形式的请求结果
        /// </summary>
        /// <param name="uri">请求资源的对象</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static string DownloadString(Uri uri, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Proxy = webProxy
            };

            string result = wc.DownloadString(uri);
            if (result.Contains("errcode"))
            {
                //可能发生错误  
            }

            return result;
        }

#if NET45 || NET461 || NETSTANDARD2_0 || NETSTANDARD2_1

        /// <summary>
        ///   作为资源下载 <see cref="T:System.String" /> 从 URI 指定为使用 task 对象的异步操作。
        /// </summary>
        /// <param name="uri">请求资源的对象</param>
        /// <param name="encoding">编码格式</param>
        /// <param name="webProxy">代理服务器对象</param>
        /// <returns></returns>
        public static Task<string> DownloadStringTaskAsync(Uri uri, Encoding encoding = null, WebProxy webProxy = null)
        {
            WebClient wc = new WebClient
            {
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Proxy = webProxy
            };

            Task<string> result = wc.DownloadStringTaskAsync(uri);

            return result;
        }

#endif

        #endregion

        #region Upload

        ///// <summary>
        /////  作为资源下载 <see cref="T:System.Byte" /> 数组中指定的 URI，并返回字节数组作为结果（没有加入Cookie）
        ///// </summary>
        ///// <param name="url">请求资源的地址</param>
        ///// <param name="encoding">编码格式</param>
        ///// <param name="webProxy">代理服务器对象</param>
        ///// <returns></returns>
        //private static byte[] UploadFile(string url, Encoding encoding = null, WebProxy webProxy = null)
        //{
        //    return null;
        //}

        #endregion
    }
}