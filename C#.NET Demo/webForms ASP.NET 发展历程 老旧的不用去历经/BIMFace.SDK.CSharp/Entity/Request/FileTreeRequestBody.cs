// /* ---------------------------------------------------------------------------------------
//    文件名：FileTreeRequestBody.cs
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

using System.Collections.Generic;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    ///  获取模型的构建分类树请求体类
    /// </summary>
    public class FileTreeRequestBody
    {
        /// <summary>
        ///  用来指定筛选树每个维度用id或者是name作为唯一标识, 如"floor":"id"。自定义节点。 
        /// </summary>
        [JsonProperty("customizedNodeKeys")]
        public Dictionary<string, string> CustomizedNodeKeys { get; set; }

        /// <summary>
        ///  筛选树的层次。 可选值有 building,systemType,specialty,floor,category,family,familyType。
        /// </summary>
        [JsonProperty("desiredHierarchy")]
        public object[] DesiredHierarchy { get; set; }

    }
}