// /* ---------------------------------------------------------------------------------------
//    文件名：IRfaFileApi.cs
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

using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  rfa构件数据API接口
    /// </summary>
    public interface IRfaFileApi
    {
        /// <summary>
        ///  获取rfa文件族类型属性key列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="rfaFileId">【必填】rfaFileId</param>
        RfaFileFamilyTypePropertyKeyListResponse GetRfaFileFamilyTypePropertyKeyList(string accessToken, long rfaFileId);

        /// <summary>
        ///  获取rfa文件族类型属性列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="rfaFileId">【必填】rfaFileId</param>
        /// <param name="familyTypeGuid">【必填】族类型guid</param>
        RfaFileFamilyTypePropertyListResponse GetRfaFileFamilyTypePropertyList(string accessToken, long rfaFileId, string familyTypeGuid);

        /// <summary>
        ///  获取rfa文件族类型列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="rfaFileId">【必填】rfaFileId</param>
        RfaFileFamilyTypeListResponse GetRfaFileFamilyTypeList(string accessToken, long rfaFileId);
    }
}