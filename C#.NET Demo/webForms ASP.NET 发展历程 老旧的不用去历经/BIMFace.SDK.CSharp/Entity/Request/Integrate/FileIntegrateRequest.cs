// /* ---------------------------------------------------------------------------------------
//    文件名：FileIntegrateRequest.cs
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

using System;
using System.Collections.Generic;

using BIMFace.SDK.CSharp.Common.Extensions;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    /// 模型集成请求参数类
    /// </summary>
    [Serializable]
    public class FileIntegrateRequest
    {
        public FileIntegrateRequest(string name = "")
        {
            if (name.IsNullOrWhiteSpace())
            {
                Name = DateTime.Now.ToString("yyyyMMddHHmmss") + "集成";
            }
        }

        /// <summary>
        ///     Callback地址，待转换完毕以后，BIMFace会回调该地址
        /// </summary>
        [JsonProperty("callback", NullValueHandling = NullValueHandling.Ignore)]
        public string CallBack { get; set; }

        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public string Config { get; set; }

        [JsonProperty("floorMapping", NullValueHandling = NullValueHandling.Ignore)]
        public FloorMappingItem[] FloorMapping { get; set; }

        [JsonProperty("floorSort", NullValueHandling = NullValueHandling.Ignore)]
        public string[] FloorSort { get; set; }

        [JsonProperty("internalConfigMap", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> InternalConfigMap { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("parentIntegrateId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParentIntegrateId { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int Priority { get; set; }

        [JsonProperty("propertyOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public ElementPropertyOverride[] PropertyOverrides { get; set; }

        /// <summary>
        /// 样例 : [ 1232134213412 ]
        /// </summary>
        [JsonProperty("ruleFileIds", NullValueHandling = NullValueHandling.Ignore)]
        public object[] RuleFileIds { get; set; }

        /// <summary>
        ///  样例：hduf2w3ho21nowr23rqwjrn2o3
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public IntegrateSource[] Sources { get; set; }

        /// <summary>
        /// 样例：[ "2" ]
        /// </summary>
        [JsonProperty("specialtySort", NullValueHandling = NullValueHandling.Ignore)]
        public string[] SpecialtySort { get; set; }
    }
}