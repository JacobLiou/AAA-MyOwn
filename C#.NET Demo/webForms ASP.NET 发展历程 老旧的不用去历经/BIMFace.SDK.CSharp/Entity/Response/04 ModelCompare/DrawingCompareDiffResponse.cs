// /* ---------------------------------------------------------------------------------------
//    文件名：DrawingCompareDiffResponse.cs
//    文件功能描述：
// 
//    创建标识：20200319
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
    /// 分页获取二维图纸对比结果的响应类
    /// </summary>
    public class DrawingCompareDiffResponse : GeneralResponse<PaginationDrawingCompareDiff>
    {

    }

    public class PaginationDrawingCompareDiff
    {
        /// <summary>
        /// 模型对比差异类数组
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DrawingCompareDiff[] Data { get; set; }

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

    public class DrawingCompareDiff
    {
        /// <summary>
        ///  对比构件差异类型：NEW、DELETE、CHANGE
        /// </summary>
        [JsonProperty("diffType", NullValueHandling = NullValueHandling.Ignore)]
        public string DiffType { get; set; }

        /// <summary>
        ///  对比构件差异类型：NEW、DELETE、CHANGE
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }
    }
}