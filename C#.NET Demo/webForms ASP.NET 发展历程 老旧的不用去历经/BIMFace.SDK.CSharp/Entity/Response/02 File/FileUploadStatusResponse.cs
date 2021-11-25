// /* ---------------------------------------------------------------------------------------
//    文件名：FileUploadStatusResponse.cs
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
    ///  获取文件上传状态信息返回的结果类
    /// </summary>
    [Serializable]
    public class FileUploadStatusResponse : GeneralResponse<FileUploadStatusEntity>
    {

    }

    [Serializable]
    public class FileUploadStatusEntity
    {
        /// <summary>
        ///  上传失败的原因。
        ///  如果 status 等于 success，则 failedReason 为空字符串
        /// </summary>
        [JsonProperty("failedReason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        ///  文件编号
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileId { get; set; }

        /// <summary>
        ///  文件名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///  上传状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("FileUploadStatusEntity [failedReason={0}, fileId={1}, name={2}, status={3}]",
                                 FailedReason, FileId, Name, Status);
        }
    }
}