// /* ---------------------------------------------------------------------------------------
//    文件名：IntegrateFileData.cs
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
    public class IntegrateFileData
    {
        [JsonProperty("databagId")]
        public string DatabagId { get; set; }

        [JsonProperty("drawingSheetCount")]
        public int DrawingSheetCount { get; set; }

        [JsonProperty("fileId")]
        public long FileId { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("floor")]
        public string Floor { get; set; }

        [JsonProperty("floorSort")]
        public double FloorSort { get; set; }

        [JsonProperty("integrateId")]
        public long IntegrateId { get; set; }

        [JsonProperty("linkedBy")]
        public string[] LinkedBy { get; set; }

        [JsonProperty("specialty")]
        public string Specialty { get; set; }

        [JsonProperty("specialtySort")]
        public double SpecialtySort { get; set; }

    }
}