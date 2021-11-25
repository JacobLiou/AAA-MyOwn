// /* ---------------------------------------------------------------------------------------
//    文件名：ElementPropertyFilterRequest.cs
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
    ///   批量获取构件属性的请求参数
    /// </summary>
    [Serializable]
    public class ElementPropertyFilterRequest
    {
        /// <summary>
        ///  【必填】构建ID数组。例如： [ "313154", "313047" ]
        /// </summary>
        [JsonProperty("elementIds")]
        public string[] ElementIds { get; set; }

        /// <summary>
        /// 【非必填】过来条件
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public GroupAndKeysPair[] Filters { get; set; }
    }

    [Serializable]
    public class GroupAndKeysPair
    {
        /// <summary>
        ///  分组名称。例如：default、shape、size
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        ///  关键字数组。例如： [ "length", "width", "a" ]
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Keys { get; set; }
    }
}