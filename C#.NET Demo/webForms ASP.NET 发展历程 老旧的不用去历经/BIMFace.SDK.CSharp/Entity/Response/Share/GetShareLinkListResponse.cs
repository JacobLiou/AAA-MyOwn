// /* ---------------------------------------------------------------------------------------
//    文件名：GetShareLinkListResponse.cs
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

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  获取Appkey下显示所有的分享列表（包含分页信息）的响应结果类
    /// </summary>
    public class ShareLinkListResponse : GeneralResponse<ShareLinkListResponseEntity>
    {

    }

    public class ShareLinkListResponseEntity
    {
        [JsonProperty("list")]
        public ShareLinkBean[] List { get; set; }

        [JsonProperty("page")]
        public Page2 Page { get; set; }
    }
}