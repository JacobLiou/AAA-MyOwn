// /* ---------------------------------------------------------------------------------------
//    文件名：IntegrationTreeOptionalRequestBody.cs
//    文件功能描述：
// 
//    创建标识：20200316
//    作   者：张传宁  （QQ：905442693  微信：savionzhang）
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

using BIMFace.SDK.CSharp.Entity.Response;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    public class IntegrationTreeOptionalRequestBody
    {
        /// <summary>
        ///  用来指定筛选树每个维度用id或者是name作为唯一标识, 如"floor":"id"。自定义节点。 
        /// </summary>
        [JsonProperty("customizedNodeKeys")]
        public Dictionary<string, string> CustomizedNodeKeys { get; set; }

        [JsonProperty("fileIdElementIds")]
        public ElementIdWithFileId[] FileIdElementIds { get; set; }

        /// <summary>
        ///  样例：[ [ "string" ] ]
        /// </summary>
        [JsonProperty("sortedNamesHierarchy")]
        public List<List<string>> SortedNamesHierarchy { get; set; }

        [JsonProperty("sorts")]
        public TreeNodeSort Sorts { get; set; }
    }
}