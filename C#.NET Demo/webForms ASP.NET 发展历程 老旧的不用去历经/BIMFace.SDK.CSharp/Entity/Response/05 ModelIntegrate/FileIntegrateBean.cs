// /* ---------------------------------------------------------------------------------------
//    文件名：FileIntegrateBean.cs
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

namespace BIMFace.SDK.CSharp.Entity.Response
{
    public class FileIntegrateBean
    {
        /// <summary>
        /// 对比开始时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 集成成功后返回的ID，用于获取对比状态或者结果等信息
        /// </summary>
        [JsonProperty("integrateId", NullValueHandling = NullValueHandling.Ignore)]
        public long? IntegrateId { get; set; }

        /// <summary>
        /// 用户指定集成后的模型的名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 对比优先级。取值 1、2、3。数字越大，优先级越低。默认为2
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        ///  若对比失败，返回失败原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        ///  第三方应用自己的ID
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        ///  对比状态:prepare（待对比）、processing（对比中）、success（对比成功）、failed（对比失败）
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Thumbnails { get; set; }

        /// <summary>
        /// 模型集成的类型 rvt(或者igms…​)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}