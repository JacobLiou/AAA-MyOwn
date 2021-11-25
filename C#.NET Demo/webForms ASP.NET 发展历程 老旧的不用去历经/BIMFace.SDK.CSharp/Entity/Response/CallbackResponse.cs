// /* ---------------------------------------------------------------------------------------
//    文件名：CallbackResponse.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  文件发起耗时操作(比如：大文件转换、文件对比等)完毕后，根据应用传入的回调地址，BIMFace 服务器返回的通知结果类(可能成功、也可能失败) 
    /// </summary>
    [Serializable]
    public class CallbackResponse
    {
        /// <summary>
        ///  文件ID
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileId { get; set; }

        /// <summary>
        ///  转换的结果
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        ///  若转换失败，则返回失败原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        ///  缩略图地址
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public string Thumbnail { get; set; }

        /// <summary>
        ///  回调随机数
        /// </summary>
        [JsonProperty("nonce", NullValueHandling = NullValueHandling.Ignore)]
        public string Nonce { get; set; }

        /// <summary>
        ///  签名
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[FileId={0}，Status={1}，Reason={2}, Thumbnail={3}, Nonce={4}，Signature={5}]",
                                 FileId, Status, Reason, Thumbnail, Nonce, Signature);
        }
    }
}