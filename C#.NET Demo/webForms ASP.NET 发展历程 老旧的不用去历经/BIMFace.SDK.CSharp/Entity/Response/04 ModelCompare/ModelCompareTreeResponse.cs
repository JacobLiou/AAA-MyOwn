// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareTreeResponse.cs
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
    /// 获取模型构件对比差异的响应类
    /// </summary>
    public class ModelCompareTreeResponse : GeneralResponse<Tree>
    {

    }

    public class Tree
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public TreeNode[] Items { get; set; }

        [JsonProperty("root", NullValueHandling = NullValueHandling.Ignore)]
        public string Root { get; set; }
    }

    public class TreeNode
    {
        [JsonProperty("actualName", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualName { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }

        [JsonProperty("elementCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElementCount { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public TreeNode[] Items { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}