// /* ---------------------------------------------------------------------------------------
//    文件名：Property.cs
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
    [Serializable]
    public class Property
    {
        [JsonProperty("boundingBox", NullValueHandling = NullValueHandling.Ignore)]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("elementId", NullValueHandling = NullValueHandling.Ignore)]
        public string ElementId { get; set; }

        [JsonProperty("familyGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyGuid { get; set; }

        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string Guid { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyGroup[] Properties { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("Property： [boundingBox={0}, elementId={1}, familyGuid={2}, Guid={3}， name={4}, Properties={5}]",
                                 BoundingBox, ElementId, FamilyGuid, Guid, Name, Properties.ToStringLine());
        }
    }

    [Serializable]
    public class BoundingBox
    {
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate Max { get; set; }

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate Min { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[max={0}, min={1}]", Max, Min);
        }
    }


    /// <summary>
    ///  三维坐标系
    /// </summary>
    public class ThreeDimensionalCoordinates
    {
        [JsonProperty("x", NullValueHandling = NullValueHandling.Ignore)]
        public double? X { get; set; }

        [JsonProperty("y", NullValueHandling = NullValueHandling.Ignore)]
        public double? Y { get; set; }

        [JsonProperty("z", NullValueHandling = NullValueHandling.Ignore)]
        public double? Z { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[x={0}, y={1}, z={2}]", X, Y, Z);
        }
    }
}