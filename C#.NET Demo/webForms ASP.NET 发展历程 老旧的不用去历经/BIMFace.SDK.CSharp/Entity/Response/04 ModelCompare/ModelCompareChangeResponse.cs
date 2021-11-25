// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareChangeResponse.cs
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
    public class ModelCompareChangeResponse : GeneralResponse<ModelCompareChange>
    {

    }

    /// <summary>
    /// 模型构件对比差异类
    /// </summary>
    public class ModelCompareChange
    {
        /// <summary>
        /// 变化图元前一个版本的ID
        /// </summary>
        [JsonProperty("_A", NullValueHandling = NullValueHandling.Ignore)]
        public string A { get; set; }

        /// <summary>
        /// 变化图元后一个版本的ID
        /// </summary>
        [JsonProperty("_B", NullValueHandling = NullValueHandling.Ignore)]
        public string B { get; set; }

        /// <summary>
        ///  变更的构建属性集合
        /// </summary>

        [JsonProperty("changeAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeAttributes[] ChangeAttributes { get; set; }

        /// <summary>
        ///  变更的工程量集合
        /// </summary>

        [JsonProperty("changeQuantities", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeQuantities[] ChangeQuantities { get; set; }

        /// <summary>
        ///  删除的构建属性集合
        /// </summary>

        [JsonProperty("deleteAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attribute[] DeleteAttributes { get; set; }

        /// <summary>
        ///  删除的工程量集合
        /// </summary>

        [JsonProperty("deleteQuantities", NullValueHandling = NullValueHandling.Ignore)]
        public Quantity[] DeleteQuantities { get; set; }

        /// <summary>
        ///  新增的构建属性集合
        /// </summary>

        [JsonProperty("newAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Attribute[] NewAttributes { get; set; }

        /// <summary>
        ///  新增的工程量集合
        /// </summary>

        [JsonProperty("newQuantities", NullValueHandling = NullValueHandling.Ignore)]
        public Quantity[] NewQuantities { get; set; }
    }

    /// <summary>
    ///  变更的构建属性
    /// </summary>
    public class ChangeAttributes
    {
        /// <summary>
        /// 前一个版本
        /// </summary>
        [JsonProperty("_A", NullValueHandling = NullValueHandling.Ignore)]
        public Attribute A { get; set; }

        /// <summary>
        /// 后一个版本
        /// </summary>
        [JsonProperty("_B", NullValueHandling = NullValueHandling.Ignore)]
        public Attribute B { get; set; }
    }

    /// <summary>
    ///  变更的工程量
    /// </summary>
    public class ChangeQuantities
    {
        /// <summary>
        /// 前一个版本
        /// </summary>
        [JsonProperty("_A", NullValueHandling = NullValueHandling.Ignore)]
        public Quantity A { get; set; }

        /// <summary>
        /// 后一个版本
        /// </summary>
        [JsonProperty("_B", NullValueHandling = NullValueHandling.Ignore)]
        public Quantity B { get; set; }
    }

    /// <summary>
    ///  构建属性
    /// </summary>
    public class Attribute
    {
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }

    /// <summary>
    /// 工程量
    /// </summary>
    public class Quantity
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public string Qty { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }
}