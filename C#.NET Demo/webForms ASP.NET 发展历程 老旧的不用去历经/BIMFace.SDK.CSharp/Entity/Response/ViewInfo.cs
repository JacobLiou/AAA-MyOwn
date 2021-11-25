// /* ---------------------------------------------------------------------------------------
//    文件名：ViewInfo.cs
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
    /// 三维视点或二维视图
    /// </summary>
    public class ViewInfo
    {
        /// <summary>
        /// 样例：[ -12147.804809235151, -19279.554054815613, -30480.0, 22637.545576143948, 6805.089759789783, 30480.0 ]
        /// </summary>
        [JsonProperty("cropBox", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] CropBox { get; set; }

        /// <summary>
        /// 样例：0.0
        /// </summary>
        [JsonProperty("elevation", NullValueHandling = NullValueHandling.Ignore)]
        public double? Elevation { get; set; }

        /// <summary>
        /// 样例："312"
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 样例："312"
        /// </summary>
        [JsonProperty("levelId", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 样例：[ -146.52900292249365, -215.01048476685295, 240.3331231070219, 110.78415780710446 ]
        /// </summary>
        [JsonProperty("outline", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] Outline { get; set; }

        [JsonProperty("preview", NullValueHandling = NullValueHandling.Ignore)]
        public Preview Preview { get; set; }

        /// <summary>
        /// 缩略图数组。样例：[ "m.bimface.com/9b711803a43b92d871cde346b63e5019/resource/thumbnails/312/312.96x96.png" ]
        /// </summary>
        [JsonProperty("thumbnails", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Thumbnails { get; set; }

        [JsonProperty("viewPoint", NullValueHandling = NullValueHandling.Ignore)]
        public ViewPoint ViewPoint { get; set; }

        [JsonProperty("viewType", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewType { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[cropBox={0}, elevation={1}, width={2}, Id={2}, levelId={3}, Outline={4}, preview={5}, thumbnails={6}, viewPoint={7}, viewType={8}]",
                                 CropBox.ToStringWith(","), Elevation, Id, LevelId, Outline.ToStringWith(","), Preview, Thumbnails.ToStringWith(","), ViewPoint, ViewType);
        }
    }

    [Serializable]
    public class Preview
    {
        /// <summary>
        /// 样例：0
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 样例：0
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("[height={0}, path={1}, width={2}]",
                                 Height, Path, Width);
        }
    }
}