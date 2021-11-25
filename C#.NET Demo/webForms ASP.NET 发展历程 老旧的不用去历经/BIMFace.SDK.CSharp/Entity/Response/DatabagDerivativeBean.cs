// /* ---------------------------------------------------------------------------------------
//    文件名：DatabagDerivativeBean.cs
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
    /// <summary>
    ///  烘焙数据包或者离线数据包等响应结果类
    /// </summary>
    public class DatabagDerivativeBean
    {
        /// <summary>
        ///  数据包或离线包生成时间
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        ///  数据包或离线包版本
        /// </summary>
        [JsonProperty("databagVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabagVersion { get; set; }

        /// <summary>
        ///  数据包或离线包
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long Length { get; set; }

        /// <summary>
        ///  若生成失败，返回失败原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        ///  数据包或离线包状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
    }
}