// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareQueryRequest.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    ///  批量获取模型对比状态的请求参数类
    /// </summary>
    public class ModelCompareQueryRequest
    {
        /// <summary>
        /// 【必填项】应用的 appKey
        /// </summary>
        [JsonProperty("appKey")]
        public string AppKey { get; set; }

        /// <summary>
        /// 【非必填项】对比后返回的ID，用于获取对比状态或者结果等信息
        /// </summary>
        [JsonProperty("compareId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CompareId { get; set; }

        /// <summary>
        ///  【非必填项】模型对比的类型 rvt(或者igms…​)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 【非必填项】文件名称
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        ///  【非必填项】模型对应的sourceId。例如：389c28de59ee62e66a7d87ec12692a76
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 【非必填项】(分页)当前页码
        /// </summary>
        [JsonProperty("pageNo", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 【非必填项】(分页)每页记录数
        /// </summary>
        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        ///  【非必填项】模型状态码。0(所有) 1(处理中) 99(成功) -1(失败)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public short? Status { get; set; }

        /// <summary>
        /// 【非必填项】筛选类型。例如:create_time desc
        /// </summary>
        [JsonProperty("sortType", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 【非必填项】对比开始时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 【非必填项】对比结束时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }
    }
}