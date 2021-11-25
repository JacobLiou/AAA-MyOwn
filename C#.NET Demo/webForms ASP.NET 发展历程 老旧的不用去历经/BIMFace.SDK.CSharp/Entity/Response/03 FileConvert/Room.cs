// /* ---------------------------------------------------------------------------------------
//    文件名：Room.cs
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
    ///  模型的房间信息
    /// </summary>
    [Serializable]
    public class Room
    {
        /// <summary>
        ///  样例 : 7.256476003661832E7
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public double? Area { get; set; }

        [JsonProperty("bboxMax", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate BboxMax { get; set; }

        [JsonProperty("bboxMin", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinate BboxMin { get; set; }

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

        /// <summary>
        ///  样例 : 40087.80000000279
        /// </summary>
        [JsonProperty("perimeter", NullValueHandling = NullValueHandling.Ignore)]
        public double? Perimeter { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyGroup[] Properties { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[area={0}, bboxMax={1}, bboxMin={2}, boundary={3}, id={4}, levelId={5}, maxPt={6}, minPt={7}, name={8}, perimeter={9}, properties={10}]",
                                 Area, BboxMax, BboxMin, Boundary, Id, LevelId, MaxPt, MinPt, Name, Perimeter, Properties.ToStringLine());
        }
    }
}