// /* ---------------------------------------------------------------------------------------
//    文件名：CaseType.cs
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
using System.Text;
using System.Web;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Log;
using BIMFace.SDK.CSharp.Common.Utils;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    /// <summary>
    ///  BIMFace回调处理
    /// </summary>
    public class BIMFaceCallbackHandler : IHttpHandler
    {
        /// <summary>
        ///  回调机制，详细介绍请参考作者博客：https://www.cnblogs.com/SavionZhang/p/12396058.html
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentEncoding = Encoding.UTF8;

            string appKey = ConfigUtility.GetAppSettingValue("BIMFACE_AppKey");
            string appSecret = ConfigUtility.GetAppSettingValue("BIMFACE_AppSecret");
            string uid = context.Request.QueryString["uid"];  //自定义标志，用于自己确认请求来源的合法性

            #region 校验
            if (appKey.IsNullOrWhiteSpace())
            {
                LogUtility.Error("BIMFace appKey 配置项没有配置！");

                return;
            }

            if (appSecret.IsNullOrWhiteSpace())
            {
                LogUtility.Error("BIMFace appSecret 配置项没有配置！");

                return;
            }

            if (uid.IsNullOrWhiteSpace())
            {
                LogUtility.Error("[非法请求]回调地址Url链接中的参数 uid 没有配置或者配置的值为空！");

                return;
            }
            #endregion

            long fileId = context.Request.QueryString["fileId"].ToLong();  // 文件ID
            string status = context.Request.QueryString["status"];         // 转换的结果
            string reason = context.Request.QueryString["reason"];         // 若转换失败，则返回失败原因
            string thumbnail = context.Request.QueryString["thumbnail"];   // 缩略图地址
            string nonce = context.Request.QueryString["nonce"];           // 回调随机数
            string signature = context.Request.QueryString["signature"];   // BIMFACE的加密签名

            string callbackResponse = string.Format("fileId:{0},\r\nstatus:{1},\r\nreason:{2},\r\nthumbnail:{3},\r\nnonce:{4},\r\nsignature:{5}",
                                                     fileId, status, reason, thumbnail, nonce, signature);
            string tip;
            string custCalcSignature;

            bool checkSignature = CallbackUtils.CheckCallbackSignature(appKey, appSecret, fileId, status, nonce, signature, out custCalcSignature);
            if (checkSignature)
            {
                tip = "[BIMFace发出的回调信息签名验证成功！]"
                      + Environment.NewLine
                      + callbackResponse;
                LogUtility.Info(tip);

                //Todo 此处可以根据fileId把相关的信息写入数据库中

                // 回执消息：应用收到回调后，须向BIMFace发送回执，回执消息：HTTP STATUS 200
                context.Response.Write("HTTP STATUS 200");
            }
            else
            {
                tip = "[BIMFace发出的回调信息签名验证不通过！]"
                    + Environment.NewLine
                    + callbackResponse
                    + Environment.NewLine
                    + "自定义计算签名 custCalcSignature：" + custCalcSignature;

                LogUtility.Error(tip);

                context.Response.Write(tip);
            }

            context.Response.End();
        }

        /// <summary>
        ///  该属性获得一个布尔值，指示另一个请求是否可以使用该HTTP处理程序的实例。
        /// <para>如果设置为true，能提高性能，但要注意线程之间安全性问题。如果设置为false，则线程是安全的</para>
        /// </summary>
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}