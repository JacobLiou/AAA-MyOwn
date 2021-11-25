// /* ---------------------------------------------------------------------------------------
//    文件名：ElementPropertyOverride.cs
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
    public class ElementPropertyOverride
    {
        /// <summary>
        /// 样例 : system_type
        /// </summary>
        [JsonProperty("keyToMatch", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyToMatch { get; set; }

        /// <summary>
        /// 样例 : specialty
        /// </summary>
        [JsonProperty("keyToOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyToOverride { get; set; }

        /// <summary>
        /// 样例 : [ "1468861829161440", "1468862035943904" ]
        /// </summary>
        [JsonProperty("targetFileIds", NullValueHandling = NullValueHandling.Ignore)]
        public object[] TargetFileIds { get; set; }

        [JsonProperty("valueOverrides", NullValueHandling = NullValueHandling.Ignore)]
        public ElementPropertyValueOverride[] ValueOverrides { get; set; }
    }

    public class ElementPropertyValueOverride
    {
        /// <summary>
        /// 样例 : water_support_pipe
        /// </summary>
        [JsonProperty("valueToMatch", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueToMatch { get; set; }

        /// <summary>
        /// 样例 : water_support
        /// </summary>
        [JsonProperty("valueToOverride", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueToOverride { get; set; }
    }
}