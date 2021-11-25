// /* ---------------------------------------------------------------------------------------
//    文件名：FloorMappingItem.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    public class FloorMappingItem
    {
        /// <summary>
        /// 样例 : "pj1101"
        /// </summary>
        [JsonProperty("fileFloorId", NullValueHandling = NullValueHandling.Ignore)]
        public string FileFloorId { get; set; }

        /// <summary>
        /// 样例 : "pj11"
        /// </summary>
        [JsonProperty("projectFloorId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectFloorId { get; set; }

        /// <summary>
        /// 样例 : "firstfloor"
        /// </summary>

        [JsonProperty("projectFloorName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectFloorName { get; set; }
    }
}