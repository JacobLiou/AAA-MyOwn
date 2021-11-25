// /* ---------------------------------------------------------------------------------------
//    文件名：FileUploadPolicyResponse.cs
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
    ///  文件直传返回的结果类
    /// </summary>
    [Serializable]
    public class FileUploadPolicyResponse : GeneralResponse<UploadPolicyEntity>
    {
      
    }

    [Serializable]
    public class UploadPolicyEntity
    {
        [JsonProperty("accessId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessId { get; set; }

        [JsonProperty("callbackBody", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackBody { get; set; }

        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expire { get; set; }

        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty("objectKey", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectKey { get; set; }

        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("UploadPolicyEntity [accessId={0}, callbackBody={1}, expire={2}, host={3}, objectKey={4},policy={5},signature={6},sourceId={7}]",
                                 AccessId, CallbackBody, Expire, Host, ObjectKey, Policy, Signature, SourceId);
        }
    }
}