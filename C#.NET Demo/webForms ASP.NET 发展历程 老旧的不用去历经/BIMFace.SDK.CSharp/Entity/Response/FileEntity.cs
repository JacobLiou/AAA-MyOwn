// /* ---------------------------------------------------------------------------------------
//    文件名：FileEntity.cs
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
    ///  文件信息实体
    /// </summary>
    [Serializable]
    public class FileEntity
    {
        /// <summary>
        /// 上传时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        [JsonProperty("etag", NullValueHandling = NullValueHandling.Ignore)]
        public string ETag { get; set; }

        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileId { get; set; }

        /// <summary>
        /// 文件流的长度（单位：byte）
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }

        /// <summary>
        ///  文件的名称，包括后缀
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 上传文件的返回结果状态：success 或其他
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        ///  文件名的后缀
        /// </summary>
        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("FileEntity [fileId={0}, name={1}, suffix={2}, length={3}, createTime={4},etag={5},status={6}]",
                                 FileId, Name, Suffix, Length, CreateTime, ETag, Status);
        }
    }
}