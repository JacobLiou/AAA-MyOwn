// /* ---------------------------------------------------------------------------------------
//    文件名：FileTranslateResponse.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  文件转换返回的结果类
    /// </summary>
    [Serializable]
    public class FileTranslateResponse : GeneralResponse<FileTranslateEntity>
    {

    }

    [Serializable]
    public class FileTranslateEntity
    {
        /// <summary>
        /// 文件转换开始的时间
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        ///  数据包ID
        /// </summary>
        [JsonProperty("databagId", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabagId { get; set; }

        /// <summary>
        ///  文件ID
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileId { get; set; }

        /// <summary>
        ///  文件的名称，包括后缀
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 优先级，数字越大，优先级越低。1, 2, 3
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        ///  若转换失败，则返回失败原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        ///  转换的状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        ///  缩略图
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Thumbnails { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if(Thumbnails != null && Thumbnails.Length > 0)
            {
                foreach(string thumbnail in Thumbnails)
                {
                    sb.AppendLine(thumbnail);
                }
            }

            return string.Format("FileTranslateEntity [createTime={0}, fileId={1}, name={2}, priority={3},reason={4},status={5},thumbnail={6}]",
                                 CreateTime, FileId, Name, Priority, Reason, Status, sb.ToString());
        }
    }
}