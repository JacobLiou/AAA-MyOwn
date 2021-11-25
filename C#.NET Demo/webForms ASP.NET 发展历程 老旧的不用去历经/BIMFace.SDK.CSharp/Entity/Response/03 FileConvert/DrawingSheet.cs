// /* ---------------------------------------------------------------------------------------
//    文件名：DrawingSheet.cs
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
    ///  图纸信息类
    /// </summary>
    [Serializable]
    public class DrawingSheet
    {
        /// <summary>
        ///  文件ID 
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileId { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("portsAndViews")]
        public PortAndView[] PortAndViews { get; set; }

        [JsonProperty("viewInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ViewInfo ViewInfo { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            //return String.Format("[fileId={0}, portAndViews={1}, viewInfo={2}]",
            //                     FileId, PortAndViews.ToStringLine(), ViewInfo);

            return String.Format("[portAndViews={0}, viewInfo={1}]",PortAndViews.ToStringLine(), ViewInfo);
        }
    }

    [Serializable]
    public class PortAndView
    {
        /// <summary>
        ///  样例 :  0.0 
        /// </summary>
        [JsonProperty("elevation", NullValueHandling = NullValueHandling.Ignore)]
        public double? Elevation { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("outline", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] Outline { get; set; }

        /// <summary>
        ///  样例 :  "6278f2c7786043d4a35ae4115571b7c8"
        /// </summary>
        [JsonProperty("viewId", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewId { get; set; }

        [JsonProperty("viewPoint", NullValueHandling = NullValueHandling.Ignore)]
        public ViewPoint ViewPoint { get; set; }

        /// <summary>
        ///  样例 : "viewType"
        /// </summary>
        [JsonProperty("viewType", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewType { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("viewport", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] Viewport { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[elevation={0}, outline={1}, viewId={2}, viewPoint={3}, viewType={4}, viewport={5}]",
                                 Elevation, Outline.ToStringWith(","), ViewId, ViewPoint, ViewType, Viewport.ToStringWith(","));
        }
    }

    public class ViewPoint
    {
        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] Origin { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("rightDirection", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] RightDirection { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
        public int? Scale { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("upDirection", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] UpDirection { get; set; }

        /// <summary>
        ///  样例 : [ 0.0 ]
        /// </summary>
        [JsonProperty("viewDirection", NullValueHandling = NullValueHandling.Ignore)]
        public double?[] ViewDirection { get; set; }

        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return String.Format("[origin={0}, rightDirection={1}, scale={2}， upDirection={3}, viewDirection={4}]",
                                 Origin.ToStringWith(","), RightDirection.ToStringWith(","), Scale, UpDirection.ToStringWith(","),
                                 ViewDirection.ToStringWith(","));
        }
    }

    //[Serializable]
    //public class View
    //{
    //    [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
    //    public string ContentType { get; set; }
    //}
}