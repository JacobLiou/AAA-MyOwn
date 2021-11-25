// /* ---------------------------------------------------------------------------------------
//    文件名：ElementsWithBoundingBox.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    [Serializable]
    public class ElementsWithBoundingBox
    {
        [JsonProperty("boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("elements")]
        public ElementIdWithFileId[] Elements { get; set; }
    }

    [Serializable]
    public class ElementIdWithFileId
    {
        [JsonProperty("elementId")]
        public string ElementId { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }
    }
}