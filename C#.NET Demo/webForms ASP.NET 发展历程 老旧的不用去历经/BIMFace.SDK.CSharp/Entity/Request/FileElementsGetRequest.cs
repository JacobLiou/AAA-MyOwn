// /* ---------------------------------------------------------------------------------------
//    文件名：FileElementsGetRequest.cs
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

using BIMFace.SDK.CSharp.Constants;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    ///  查询满足条件的构件ID列表请求参数类
    /// </summary>
    [Serializable]
    public class FileElementsGetRequest
    {
        public FileElementsGetRequest()
        {
            CategoryId = null;
            Family = null;
            FamilyType = null;
            Floor = null;
            PaginationContextId = null;
            PaginationNo = null;
            PaginationSize = null;
            RoomId = null;
            RoomToleranceXY = null;
            RoomToleranceZ = null;
            Specialty = null;
            SystemType = null;
        }

        ///// <summary>
        ///// 【必填】代表该单模型的文件ID
        ///// </summary>
        //[JsonProperty("fileId")]
        //public long FileId { get; set; }

        /// <summary>
        ///  【非必填】筛选条件构件类型id
        /// </summary>
        [JsonProperty("categoryId", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        ///  【非必填】筛选条件族
        /// </summary>
        [JsonProperty("family", NullValueHandling = NullValueHandling.Ignore)]
        public string Family { get; set; }

        /// <summary>
        ///  【非必填】筛选条件族类型
        /// </summary>
        [JsonProperty("familyType", NullValueHandling = NullValueHandling.Ignore)]
        public string FamilyType { get; set; }

        /// <summary>
        ///  【非必填】筛选条件楼层
        /// </summary>
        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public string Floor { get; set; }

        /// <summary>
        ///  【非必填】根据paginationContextId返回构件ID列表
        /// </summary>
        [JsonProperty("paginationContextId", NullValueHandling = NullValueHandling.Ignore)]
        public string PaginationContextId { get; set; }

        /// <summary>
        ///  【非必填】返回结果中paginationNo对应的页码构件ID项
        /// </summary>
        [JsonProperty("paginationNo", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaginationNo { get; set; }

        /// <summary>
        ///  【非必填】返回结果按照paginationSize分页
        /// </summary>
        [JsonProperty("paginationSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaginationSize { get; set; }

        /// <summary>
        ///  【非必填】筛选条件房间id
        /// </summary>
        [JsonProperty("roomId", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        ///  【非必填】XY坐标轴方向对构件的筛选容忍度
        /// </summary>
        [JsonProperty("roomToleranceXY", NullValueHandling = NullValueHandling.Ignore)]
        public RoomTolerance? RoomToleranceXY { get; set; }

        /// <summary>
        ///  【非必填】Z坐标轴方向对构件的筛选容忍度
        /// </summary>
        [JsonProperty("roomToleranceZ", NullValueHandling = NullValueHandling.Ignore)]
        public RoomTolerance? RoomToleranceZ { get; set; }

        /// <summary>
        ///  【非必填】筛选条件专业
        /// </summary>
        [JsonProperty("specialty", NullValueHandling = NullValueHandling.Ignore)]
        public string Specialty { get; set; }

        /// <summary>
        ///  【非必填】筛选条件系统类型
        /// </summary>
        [JsonProperty("systemType", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemType { get; set; }
    }
}