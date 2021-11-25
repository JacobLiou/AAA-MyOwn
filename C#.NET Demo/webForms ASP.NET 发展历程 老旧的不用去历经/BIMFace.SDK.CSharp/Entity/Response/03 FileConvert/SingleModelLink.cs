// /* ---------------------------------------------------------------------------------------
//    文件名：SingleModelLink.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  获取单个模型的链接信息返回的结果类
    /// </summary>
    [Serializable]
    public class SingleModelLink : GeneralResponse<List<Link>>
    {

    }

    [Serializable]
    public class Link
    {
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string Guid { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        ///  样例 : "file_link.rvt : 12 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public string Transform { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[Link guid={0}, id={1}, name={2},transform={3}]",
                                 Guid, Id, Name, Transform);
        }
    }
}