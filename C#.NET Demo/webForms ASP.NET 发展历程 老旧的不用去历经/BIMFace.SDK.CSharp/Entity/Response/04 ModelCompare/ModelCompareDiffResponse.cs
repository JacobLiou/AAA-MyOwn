// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareDiffResponse.cs
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
    /// 分页获取模型对比结果的响应类
    /// </summary>
    public class ModelCompareDiffResponse : GeneralResponse<PaginationModelCompareDiff>
    {

    }

    public class PaginationModelCompareDiff
    {
        /// <summary>
        /// 模型对比差异类数组
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public ModelCompareDiff[] Data { get; set; }

        /// <summary>
        ///  当前页码
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int Page { get; set; }

        /// <summary>
        ///  总页数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int Total { get; set; }
    }

    /// <summary>
    /// 模型对比差异类
    /// </summary>
    public class ModelCompareDiff
    {
        /// <summary>
        ///  对比差异构件所属类别ID。样例 : "-2001320"
        /// </summary>
        [JsonProperty("categoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        ///  对比差异构件所属类别名称。样例 : "framework"
        /// </summary>
        [JsonProperty("categoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        ///  对比构件差异类型：NEW、DELETE、CHANGE
        /// </summary>
        [JsonProperty("diffType", NullValueHandling = NullValueHandling.Ignore)]
        public string DiffType { get; set; }

        /// <summary>
        ///   对比差异构件ID。样例 : "296524"
        /// </summary>
        [JsonProperty("elementId", NullValueHandling = NullValueHandling.Ignore)]
        public string ElementId { get; set; }

        /// <summary>
        ///  对比差异构件名称
        /// </summary>
        [JsonProperty("elementName", NullValueHandling = NullValueHandling.Ignore)]
        public string ElementName { get; set; }

        /// <summary>
        ///  对比差异构件的族名称。样例 : "framework 1"
        /// </summary>
        [JsonProperty("family", NullValueHandling = NullValueHandling.Ignore)]
        public string Family { get; set; }

        /// <summary>
        ///  对比差异构件来源构件ID。样例 : "0213154515478"
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///  对比差异构件变更文件ID，即(当前)变更后的文件ID。样例 : "1136893002033344"
        /// </summary>
        [JsonProperty("followingFileId", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowingFileId { get; set; }

        /// <summary>
        /// 对比差异构件来源文件ID，即 (历史)变更前的文件ID。样例 : "0213154515478"
        /// </summary>
        [JsonProperty("previousFileId", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousFileId { get; set; }

        /// <summary>
        ///  对比差异构件所属专业。样例 : "civil"
        /// </summary>
        [JsonProperty("specialty", NullValueHandling = NullValueHandling.Ignore)]
        public string Specialty { get; set; }
    }
}