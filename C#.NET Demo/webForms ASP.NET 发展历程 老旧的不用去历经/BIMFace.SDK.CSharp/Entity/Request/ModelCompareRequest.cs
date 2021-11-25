// /* ---------------------------------------------------------------------------------------
//    文件名：CompareRequest.cs
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

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    ///     模型对比请求参数类
    /// </summary>
    [Serializable]
    public class CompareRequest
    {
        /// <summary>
        ///  使用变更后文件ID、变更前文件ID、自定义对比的名称来初始化该类的一个实例
        /// </summary>
        /// <param name="followingId">变更后文件ID，如果为删除文件，则为null</param>
        /// <param name="previousId">变更前文件ID，如果为新增文件，则为null</param>
        /// <param name="name">自定义对比的名称</param>
        public CompareRequest(long? followingId, long? previousId, string name = "")
        {
            ComparedEntityType = "file"; //要么赋值，必须是正确的值。如果赋值null，则报错
            Config = null;
            SourceId = null;
            Priority = 2;
            CallBack = "http://www.app.com/receive";

            FollowingId = followingId;
            PreviousId = previousId;
            if (name.IsNullOrWhiteSpace())
            {
                Name = DateTime.Now.ToString("yyyyMMddHHmmss-") + "对比：" + followingId.ToString2() + "-" + previousId.ToString2();
            }
            else
            {
                Name = name;
            }
        }

        /// <summary>
        ///     对比的模型类型：file
        /// </summary>
        [JsonProperty("comparedEntityType", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparedEntityType { get; set; }

        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public object Config { get; set; }

        /// <summary>
        ///     变更后文件ID，如果为删除文件，则为null
        /// </summary>
        [JsonProperty("followingId")]
        public long? FollowingId { get; set; }

        /// <summary>
        ///     变更前文件ID，如果为新增文件，则为null
        /// </summary>
        [JsonProperty("previousId")]
        public long? PreviousId { get; set; }

        /// <summary>
        ///     用户指定对比后的模型的名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     第三方应用自己的ID
        /// </summary>
        [JsonProperty("sourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        ///     对比优先级。取值 1、2、3。数字越大，优先级越低。默认为2
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        ///     Callback地址，待转换完毕以后，BIMFace会回调该地址
        /// </summary>
        [JsonProperty("callback")]
        public string CallBack { get; set; }
    }
}