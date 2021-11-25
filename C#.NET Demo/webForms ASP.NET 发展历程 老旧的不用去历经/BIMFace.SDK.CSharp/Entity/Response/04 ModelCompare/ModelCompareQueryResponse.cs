// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareQueryResponse.cs
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
    /// 批量获取模型对比状态的响应结果类
    /// </summary>
    public class ModelCompareQueryResponse : GeneralResponse<ModelCompareQueryResponseEntity>
    {

    }

    public class ModelCompareQueryResponseEntity
    {
        [JsonProperty("list", NullValueHandling = NullValueHandling.Ignore)]
        public ModelCompareBean[] List { get; set; }

        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page2 Page { get; set; }
    }
}