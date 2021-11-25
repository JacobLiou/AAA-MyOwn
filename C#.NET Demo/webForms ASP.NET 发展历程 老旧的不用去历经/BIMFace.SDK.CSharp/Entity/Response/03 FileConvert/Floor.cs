// /* ---------------------------------------------------------------------------------------
//    文件名：Floor.cs
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

using BIMFace.SDK.CSharp.Common.Extensions;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  楼层信息
    /// </summary>
    [Serializable]
    public class Floor
    {
        /// <summary>
        ///  例如： 0.0
        /// </summary>
        [JsonProperty("archElev", NullValueHandling = NullValueHandling.Ignore)]
        public double? ArchElev { get; set; }

        /// <summary>
        ///  例如： 0.0
        /// </summary>
        [JsonProperty("areas", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectOnFloor[] Areas { get; set; }

        /// <summary>
        ///  例如： 0.0
        /// </summary>
        [JsonProperty("elevation", NullValueHandling = NullValueHandling.Ignore)]
        public double? Elevation { get; set; }

        /// <summary>
        ///  例如：4000.0
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public double? Height { get; set; }

        /// <summary>
        ///  编号。例如："311"
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///  样例 : "787e5907b0ca5cb35f5d10ba091a085b/resource/model/maps/elevation 1.png"
        /// </summary>
        [JsonProperty("miniMap", NullValueHandling = NullValueHandling.Ignore)]
        public string MiniMap { get; set; }

        /// <summary>
        ///  名称。例如："elevation 1"
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 房间信息
        /// </summary>
        [JsonProperty("rooms", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectOnFloor[] Rooms { get; set; }

        /// <summary>
        ///  例如：0.0
        /// </summary>
        [JsonProperty("structElev", NullValueHandling = NullValueHandling.Ignore)]
        public double? StructElev { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[archElev={0}, areas={1}, elevation={2}, height={3}, id={4}, miniMap={5}, name={6}, rooms={7}, structElev={8}]",
                                 ArchElev, Areas.ToStringLine(), Elevation, Height, Id, MiniMap, Name, Rooms.ToStringLine(), StructElev);
        }
    }

    /// <summary>
    ///  楼层上包含的对象
    /// </summary>
    [Serializable]
    public class ObjectOnFloor
    {
        /// <summary>
        ///  边界
        /// </summary>
        [JsonProperty("boundary", NullValueHandling = NullValueHandling.Ignore)]
        public string Boundary { get; set; }

        /// <summary>
        ///  编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        ///  水平线编号
        /// </summary>
        [JsonProperty("levelId", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelId { get; set; }

        [JsonProperty("maxPt", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate MaxPt { get; set; }

        [JsonProperty("minPt", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate MinPt { get; set; }

        /// <summary>
        ///  对象名称。例如："dining room 4"
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[boundary={0}, id={1}, levelId={2}, maxPt={3}, minPt={4}, name={5}]",
                                 Boundary, Id, LevelId, MaxPt, MinPt, Name);
        }
    }

    [Serializable]
    public class Coordinate : ThreeDimensionalCoordinates
    {
        
    }
}