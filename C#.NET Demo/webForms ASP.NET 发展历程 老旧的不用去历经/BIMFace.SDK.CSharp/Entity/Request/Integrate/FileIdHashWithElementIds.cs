// /* ---------------------------------------------------------------------------------------
//    文件名：FileIdHashWithElementIds.cs
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
    public class FileIdHashWithElementIds
    {
        /// <summary>
        /// 样例 :[ "1109329", "1109300" ]
        /// </summary>
        [JsonProperty("elementIds", NullValueHandling = NullValueHandling.Ignore)]
        public object[] ElementIds { get; set; }

        /// <summary>
        /// 样例 : "pj1101"
        /// </summary>
        [JsonProperty("fileIdHash", NullValueHandling = NullValueHandling.Ignore)]
        public string FileIdHash { get; set; }
    }
}