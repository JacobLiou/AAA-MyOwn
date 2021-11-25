// /* ---------------------------------------------------------------------------------------
//    文件名：IntegrateSource.cs
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
    public class IntegrateSource
    {
        [JsonProperty("building", NullValueHandling = NullValueHandling.Ignore)]
        public string Building { get; set; }

        [JsonProperty("databagId", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabagId { get; set; }

        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long FileId { get; set; }

        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public string Floor { get; set; }

        [JsonProperty("floorSort", NullValueHandling = NullValueHandling.Ignore)]
        public double FloorSort { get; set; }

        [JsonProperty("specialty", NullValueHandling = NullValueHandling.Ignore)]
        public string Specialty { get; set; }

        [JsonProperty("specialtySort", NullValueHandling = NullValueHandling.Ignore)]
        public double SpecialtySort { get; set; }

        [JsonProperty("transform", NullValueHandling = NullValueHandling.Ignore)]
        public double[] Transform { get; set; }
    }
}