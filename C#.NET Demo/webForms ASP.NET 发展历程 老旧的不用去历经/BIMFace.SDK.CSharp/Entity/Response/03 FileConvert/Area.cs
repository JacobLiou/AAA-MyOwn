// /* ---------------------------------------------------------------------------------------
//    文件名：Area.cs
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
    ///  楼层区域信息
    /// </summary>
    [Serializable]
    public class Area
    {
        /// <summary>
        ///  样例 : 7.256476003661832E7
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public double? AreaValue { get; set; }

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

        /// <summary>
        ///   样例 : "1 1"
        /// </summary>
        [JsonProperty("viewName", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewName { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[area={0}, boundary={1}, id={2}, levelId={3}, maxPt={4}, minPt={5}, name={6}, perimeter={7}, properties={8}, viewName={9}]",
                                  AreaValue,  Boundary, Id, LevelId, MaxPt, MinPt, Name, Perimeter, Properties.ToStringLine(), ViewName);
        }
    }
}