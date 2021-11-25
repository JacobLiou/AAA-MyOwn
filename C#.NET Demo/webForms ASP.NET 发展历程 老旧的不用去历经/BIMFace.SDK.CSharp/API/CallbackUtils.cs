// /* ---------------------------------------------------------------------------------------
//    文件名：CallbackUtils.cs
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

using BIMFace.SDK.CSharp.Common.Utils;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  BIMFACE回调机制处理类
    /// </summary>
    public class CallbackUtils
    {
        #region Callback 消息签名验证

        /// <summary>
        ///  验证BIMFace发出的回调消息签名信息是否安全可靠
        /// </summary>
        /// <param name="appKey">开发者秘钥</param>
        /// <param name="appSecret">开发者密码</param>
        /// <param name="fileId">BIMFace发出的回调信息：文件ID</param>
        /// <param name="status">BIMFace发出的回调信息：转换的结果</param>
        /// <param name="nonce">BIMFace发出的回调信息：回调随机数</param>
        /// <param name="signature">BIMFace发出的回调信息：签名</param>
        /// <returns></returns>
        public static bool CheckCallbackSignature(string appKey, string appSecret, long fileId, string status, string nonce, string signature)
        {
            string custCalcSignature = string.Empty;
            return CheckCallbackSignature(appKey, appSecret, fileId, status, nonce, signature, out custCalcSignature);
        }

        /// <summary>
        ///  验证BIMFace发出的回调消息签名信息是否安全可靠
        /// </summary>
        /// <param name="appKey">开发者秘钥</param>
        /// <param name="appSecret">开发者密码</param>
        /// <param name="fileId">BIMFace发出的回调信息：文件ID</param>
        /// <param name="status">BIMFace发出的回调信息：转换的结果</param>
        /// <param name="nonce">BIMFace发出的回调信息：回调随机数</param>
        /// <param name="signature">BIMFace发出的回调信息：签名</param>
        /// <param name="custCalcSignature">输出参数：根据BIMFACE平台的加密规则计算出来的签名信息</param>
        /// <returns></returns>
        public static bool CheckCallbackSignature(string appKey, string appSecret, long fileId, string status, string nonce, string signature, out string custCalcSignature)
        {
            /* signature（签名）：为了确保回调消息是由BIMFace发出的，应用在收到回调消息后，须验证签名。
            * 签名的计算方式：MD5("appKey:appSecret:fileId:status:nonce")，如果应用计算的签名与BIMFace返回的签名一致，则证明该消息是安全可靠的。 
            */
            custCalcSignature = GetCallbackSignature(appKey, appSecret, fileId, status, nonce);

            return custCalcSignature == signature;
        }

        /// <summary>
        ///  根据回调的参数计算签名
        /// </summary>
        /// <param name="appKey">开发者秘钥</param>
        /// <param name="appSecret">开发者密码</param>
        /// <param name="fileId">BIMFace发出的回调信息：文件ID</param>
        /// <param name="status">BIMFace发出的回调信息：转换的结果</param>
        /// <param name="nonce">BIMFace发出的回调信息：回调随机数</param>
        /// <returns></returns>
        public static string GetCallbackSignature(string appKey, string appSecret, long fileId, string status, string nonce)
        {
            return string.Format("{0}:{1}:{2}:{3}:{4}", appKey, appSecret, fileId, status, nonce).EncryptByMD5();
        }

        #endregion
    }
}