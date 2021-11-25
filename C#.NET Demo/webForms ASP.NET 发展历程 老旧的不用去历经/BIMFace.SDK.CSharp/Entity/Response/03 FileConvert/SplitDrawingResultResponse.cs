// /* ---------------------------------------------------------------------------------------
//    文件名：Coordinate2D.cs
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

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  获取图纸拆分结果的相应类
    /// </summary>
    public class SplitDrawingResultResponse : GeneralResponse<List<DrawingSplitLayout>>
    {

    }

    /// <summary>
    ///  图框拆分布局（模型方式、布局方式）
    /// </summary>

    public class DrawingSplitLayout
    {
        /// <summary>
        ///  图框集合（可选） 
        /// </summary>
        [JsonProperty("frames", NullValueHandling = NullValueHandling.Ignore)]
        public List<DrawingFrame> Frames { get; set; }

        /// <summary>
        ///  图纸布局序号(可选） 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        ///  图纸布局名称（可选） 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

    }

    /// <summary>
    ///  图框（图纸）信息类
    /// </summary>
    public class DrawingFrame
    {
        /// <summary>
        ///  图框（图纸）坐标信息对象（可选） 
        /// </summary>
        [JsonProperty("boundingBox", NullValueHandling = NullValueHandling.Ignore)]
        public BoundingBox2D BoundingBox { get; set; }

        /// <summary>
        ///  图框（图纸）序号(可选） 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        ///  图框（图纸）名称（可选） 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        ///  图框（图纸）图号（可选） 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }
    }

    public class BoundingBox2D
    {
        /// <summary>
        ///  图框左上角坐标对象（可选） 
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate2D Min { get; set; }

        /// <summary>
        ///  图框右下角坐标对象（可选） 
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate2D Max { get; set; }
    }

    /// <summary>
    ///  DWG图纸的二维坐标信息类
    /// </summary>
    public class Coordinate2D
    {
        /// <summary>
        ///  坐标X（可选） 
        /// </summary>
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }

        /// <summary>
        ///  坐标Y（可选） 
        /// </summary>
        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }
    }
}
