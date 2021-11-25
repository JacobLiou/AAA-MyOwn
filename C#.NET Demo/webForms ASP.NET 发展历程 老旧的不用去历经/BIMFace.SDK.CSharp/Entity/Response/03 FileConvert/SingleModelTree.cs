// /* ---------------------------------------------------------------------------------------
//    文件名：SingleModelTree.cs
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
using System.Collections.Generic;

using BIMFace.SDK.CSharp.Common.Extensions;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  获取单个模型的构件分类树(2.0的默认分类树 floor, category, family, familyType)返回的结果类（默认模式）
    /// </summary>
    [Serializable]
    public class SingleModelTree : GeneralResponse<List<TreeItem>> 
    {

    }

    /// <summary>
    ///  获取单个模型的构件分类树(自定义树floor, category, family, familyType)返回的结果类
    /// </summary>
    [Serializable]
    public class SingleModelTreeByCustomized : GeneralResponse<SingleModelTreeByCustomized>
    {
        [JsonProperty("root", NullValueHandling = NullValueHandling.Ignore)]
        public string Root { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public TreeItem[] Items { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[root={0}, items={1}]",
                                 Root, Items.ToStringLine());
        }
    }

    [Serializable]
    public class TreeItem
    {
        /// <summary>
        ///  项的名称
        /// </summary>
        [JsonProperty("actualName", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualName { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("elementCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElementCount { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public TreeItem[] Items { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///  例如：familyType、family、category
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[actualName={0}, data={1}, elementCount={2}, id={3}, items={4}, name={5}, type={6}]",
                                 ActualName, Data, ElementCount, Id, Items.ToStringLine(), Name, Type);
        }
    }

    /// <summary>
    ///  分类树的类型
    /// </summary>
    public enum TreeType
    {
        /// <summary>
        ///  默认
        /// </summary>
        Default,

        /// <summary>
        ///  自定义
        /// </summary>
        Customized,

        /// <summary>
        /// 楼层（用于模型集成）
        /// </summary>
        Floor
    }
}