// /* ---------------------------------------------------------------------------------------
//    文件名：FileTranslateDetailsResponse.cs
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
    ///  批量获取转换状态详情返回的结果类
    /// </summary>
    [Serializable]
    public class FileTranslateDetailsResponse : GeneralResponse<FileTranslateDetailsResponseEntity>
    {

    }

    [Serializable]
    public class FileTranslateDetailsResponseEntity
    {
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public Detail[] Details { get; set; }

        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Details != null && Details.Length > 0)
            {
                for (var i = 0; i < Details.Length; i++)
                {
                    Detail detail = Details[i];

                    StringBuilder sbThumbnails = new StringBuilder();
                    string[] thumbnails = detail.Thumbnails;
                    if (thumbnails != null && thumbnails.Length > 0)
                    {
                        foreach (var thumbnail in thumbnails)
                        {
                            sbThumbnails.Append(thumbnail + ";");
                        }
                    }

                    sb.AppendLine(String.Format("\r\nDetail{0}\r\nappKey={1}, cost={2}, createTime={3}, databagId={4}, fileId={5}, length={6}, name={7}, "
                                              + "offlineDatabagStatus={8}, priority={9}, reason={10}, retry={11}, shareToken={12}, shareUrl={13}, sourceId={14}, status={15}, supportOfflineDatabag={16}, "
                                              + "type={17}, thumbnails={18}",
                                                (i + 1), detail.AppKey, detail.Cost, detail.CreateTime, detail.DatabagId, detail.FileId, detail.Length, detail.Name,
                                                detail.OfflineDatabagStatus, detail.Priority, detail.Reason, detail.Retry, detail.ShareToken, detail.ShareUrl, detail.SourceId, detail.Status, detail.SupportOfflineDatabag,
                                                detail.Type, sbThumbnails));
                }
            }

            sb.AppendLine("\r\npage");
            sb.AppendLine(string.Format("prePage={0}, nextPage={1}, pageNo={2}, pageSize={3}, startIndex={4}, totalCount={5}, totalPages={6}",
                                        Page.PrePage, Page.NextPage, Page.PageNo, Page.PageSize, Page.StartIndex, Page.TotalCount, Page.TotalPages));

            return string.Format("FileTranslateDetailsResponseEntity [\r\n{0}\r\n]", sb);
        }
    }

    /// <summary>
    /// 转换状态详情
    /// </summary>
    [Serializable]
    public class Detail
    {
        /// <summary>
        ///  应用的 appkey
        /// </summary>
        [JsonProperty("appKey", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>	
        /// 任务耗时（单位：秒）
        /// </summary>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public int Cost { get; set; }

        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        ///  数据包id。例如：70b8c10b686061525420fc240bf48aca
        /// </summary>
        [JsonProperty("databagId", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabagId { get; set; }

        /// <summary>
        ///  模型的fileId。例如：1609858191716512
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileId { get; set; }

        /// <summary>
        ///  文件长度（单位：字节）
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }

        /// <summary>
        ///  集成模型的名称，例如：integrate-test
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 离线数据包生成状态：prepare(未生成) processing(生成中) success(生成成功) failed(生成失败)
        /// </summary>
        [JsonProperty("offlineDatabagStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string OfflineDatabagStatus { get; set; }

        /// <summary>
        /// 任务优先级。 数字越大，优先级越低。1, 2, 3。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public short? Priority { get; set; }

        /// <summary>
        /// 若转换失败，返回失败原因。转换成功时，返回空字符串
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 重试，true(或者false)
        /// </summary>
        [JsonProperty("retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retry { get; set; }

        /// <summary>
        /// 分享码。例如：3c476c55
        /// </summary>
        [JsonProperty("shareToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareToken { get; set; }

        /// <summary>
        /// 分享链接。例如：https://api.bimface.com/preview/3c476c55
        /// </summary>
        [JsonProperty("shareUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareUrl { get; set; }

        /// <summary>
        /// 模型对应的sourceId。该字段暂时空置
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 模型状态，processing(处理中) success(成功) failed(失败)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 是否支持离线数据包，true(或者false)
        /// </summary>
        [JsonProperty("supportOfflineDatabag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportOfflineDatabag { get; set; }

        /// <summary>
        ///  模型的缩略图，该字段暂时空置
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Thumbnails { get; set; }

        /// <summary>
        /// 转换类型。例如：rvt-translate(或者igms-translate…​)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}