// /* ---------------------------------------------------------------------------------------
//    文件名：MultipleModelsFloors.cs
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
    ///  获取多个模型的楼层信息
    /// </summary>
    public class MultipleModelsFloors : GeneralResponse<List<MultipleModelsFloorsEntity>>
    {

    }

    public class MultipleModelsFloorsEntity
    {
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        [JsonProperty("floors", NullValueHandling = NullValueHandling.Ignore)]
        public Floor[] Floors { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[fileId={0}, floors={1}]",
                                 FileId, Floors.ToStringLine());
        }
    }
}