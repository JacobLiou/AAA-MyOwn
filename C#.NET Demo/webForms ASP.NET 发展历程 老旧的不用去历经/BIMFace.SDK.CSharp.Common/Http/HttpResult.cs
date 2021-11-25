// /* ---------------------------------------------------------------------------------------
//    文件名：HttpResult.cs
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

using System.Net;
using System.Text;

namespace BIMFace.SDK.CSharp.Common.Http
{
    /// <summary>
    ///  HTTP请求(GET,POST等)的响应返回消息
    /// </summary>
    public sealed class HttpResult
    {
        #region  字段

        /// <summary>
        ///  HTTP 响应成功，即状态码为200。【用于判断请求是否正常】
        /// </summary>
        public const string STATUS_SUCCESS = "success";

        /// <summary>
        ///  HTTP 响应失败。【用于判断请求是否正常】
        /// </summary>
        public const string STATUS_FAIL = "fail";

        #endregion

        #region 属性

        /// <summary>
        ///  获取或设置请求的响应状态，success 或者 fail。建议使用常量：HttpResult.STATUS_SUCCESS 与 HttpResult.STATUS_FAIL
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///  获取或设置请求的响应状态描述
        /// </summary>
        public string StatusDescription { get; set; }

        /// <summary>
        /// 状态码。与 HttpWebResponse.StatusCode 完全相同
        /// </summary>
        public int? StatusCode { get; set; }

        /// <summary>
        /// 响应消息或错误文本
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 响应消息或错误(用于存放二进制格式数据)
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// 参考代码(用户自定义)。
        /// 当 Status 等于 success 时，该值为 null；
        /// 当 Status 等于 fail 时，该值为程序给出的用户自定义编码。
        /// </summary>
        public int? RefCode { get; set; }

        /// <summary>
        /// 附加信息(用户自定义内容，如Exception内容或者自定义提示信息)。
        /// 当 Status 等于 success 时，该值为为空
        /// 当 Status 等于 fail 时，该值为程序给出的用户自定义内容，如Exception内容或者自定义提示信息。
        /// </summary>
        public string RefText { get; set; }

        /// <summary>
        ///  获取或设置Http的请求响应。
        /// </summary>
        public HttpWebResponse HttpWebResponse { get; set; }

        ///// <summary>
        ///// 参考信息(从返回消息 WebResponse 的头部获取)
        ///// </summary>
        //public Dictionary<string, string> RefInfo { get; set; }

        #endregion

        #region 构造函数
        /// <summary>
        /// 初始化(所有成员默认值，需要后续赋值)
        /// </summary>
        public HttpResult()
        {
            Status = string.Empty;
            StatusDescription = string.Empty;
            StatusCode = null;
            Text = string.Empty;
            Data = null;

            RefCode = null;
            RefText = string.Empty;
            //RefInfo = null;

            HttpWebResponse = null;
        }

        #endregion

        #region 方法

        /// <summary>
        /// 对象复制
        /// </summary>
        /// <param name="httpResultSource">要复制其内容的来源</param>
        public void Shadow(HttpResult httpResultSource)
        {
            this.Status = httpResultSource.Status;
            this.StatusDescription = string.Empty;
            this.StatusCode = httpResultSource.StatusCode;
            this.Text = httpResultSource.Text;
            this.Data = httpResultSource.Data;

            this.RefCode = httpResultSource.RefCode;
            this.RefText += httpResultSource.RefText;
            //this.RefInfo = httpResultSource.RefInfo;

            this.HttpWebResponse = httpResultSource.HttpWebResponse;
        }

        /// <summary>
        /// 转换为易读或便于打印的字符串格式
        /// </summary>
        /// <returns>便于打印和阅读的字符串</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Status:{0}", Status);
            sb.AppendFormat("StatusCode:{0}", StatusCode);
            sb.AppendFormat("StatusDescription:{0}", StatusDescription);
            sb.AppendLine();

            if (!string.IsNullOrEmpty(Text))
            {
                sb.AppendLine("text:");
                sb.AppendLine(Text);
            }

            if (Data != null)
            {
                sb.AppendLine("data:");
                int n = 1024;
                if (Data.Length <= n)
                {
                    sb.AppendLine(Encoding.UTF8.GetString(Data));
                }
                else
                {
                    sb.AppendLine(Encoding.UTF8.GetString(Data, 0, n));
                    sb.AppendFormat("<--- TOO-LARGE-TO-DISPLAY --- TOTAL {0} BYTES --->", Data.Length);
                    sb.AppendLine();
                }
            }

            sb.AppendLine();

            sb.AppendFormat("ref-code:{0}", RefCode);
            sb.AppendLine();

            if (!string.IsNullOrEmpty(RefText))
            {
                sb.AppendLine("ref-text:");
                sb.AppendLine(RefText);
            }

            //if (RefInfo != null)
            //{
            //    sb.AppendLine("ref-info:");
            //    foreach (var info in RefInfo)
            //    {
            //        sb.AppendLine(string.Format("{0}:{1}", info.Key, info.Value));
            //    }
            //}

            sb.AppendLine();

            return sb.ToString();
        }

        #endregion

    }
}