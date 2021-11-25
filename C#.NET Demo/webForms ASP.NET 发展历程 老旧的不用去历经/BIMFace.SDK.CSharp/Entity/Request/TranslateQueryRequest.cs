// /* ---------------------------------------------------------------------------------------
//    文件名：TranslateQueryRequest.cs
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

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    ///  批量获取转换状态详情的请求数据
    /// </summary>
    [Serializable]
    public class TranslateQueryRequest
    {
        public TranslateQueryRequest()
        {
            FileId = null;
            Suffix = null;
            FileName = null;
            SourceId = null;
            PageNo = null;
            PageSize = null;
            Status = null;
            SortType = null;
            StartDate = null;
            EndDate = null;
        }

        /// <summary>
        /// 【必填项】应用的 appKey
        /// </summary>
        [JsonProperty("appKey")]
        public string AppKey { get; set; }

        /// <summary>
        /// 【非必填项】单模型对应的id，例如：1216871503527744
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 【非必填项】单模型的文件类型。例如：rvt(或者igms,dwg…​)
        /// </summary>
        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        /// <summary>
        /// 【非必填项】单模型的名称。例如：translate-test
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 【非必填项】模型对应的sourceId。例如：389c28de59ee62e66a7d87ec12692a76
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 【非必填项】页码
        /// </summary>
        [JsonProperty("pageNo", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 【非必填项】每页返回数目
        /// </summary>
        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 【非必填项】模型状态码。0(所有) 1(处理中) 99(成功) -1(失败)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public short? Status { get; set; }

        /// <summary>
        /// 【非必填项】筛选类型。例如:create_time desc
        /// </summary>
        [JsonProperty("sortType", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 【非必填项】开始日期。例如：2019-05-01
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 【非必填项】截止日期。例如：2019-05-03
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }
    }
}