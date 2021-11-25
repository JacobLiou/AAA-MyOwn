// /* ---------------------------------------------------------------------------------------
//    文件名：Page.cs
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

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  BIMFACE 返回的分页信息对象
    /// </summary>
    public class Page
    {
        /// <summary>
        ///  上一页码
        /// </summary>
        [JsonProperty("prePage", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrePage { get; set; }

        /// <summary>
        ///  下一页码
        /// </summary>
        [JsonProperty("nextPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextPage { get; set; }

        /// <summary>
        ///  当前页码
        /// </summary>
        [JsonProperty("pageNo", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        ///  每页条目数
        /// </summary>
        [JsonProperty("pageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        ///  起始索引数
        /// </summary>
        [JsonProperty("startIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartIndex { get; set; }

        /// <summary>
        ///  条目总数
        /// </summary>
        [JsonProperty("totalCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        ///  页码总数
        /// </summary>
        [JsonProperty("totalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }
    }
}