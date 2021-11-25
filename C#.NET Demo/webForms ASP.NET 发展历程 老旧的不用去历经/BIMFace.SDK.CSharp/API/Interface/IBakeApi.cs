// /* ---------------------------------------------------------------------------------------
//    文件名：IBakeApi.cs
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

using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  烘焙API接口
    /// </summary>
    public interface IBakeApi
    {
        /// <summary>
        ///  创建文件bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类</param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByFileId(string accessToken, long fileId, string callback = null, DatabagDerivativeRequest request = null);

        /// <summary>
        ///  创建集成模型bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类</param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByIntegrateId(string accessToken, long integrateId, string callback = null, DatabagDerivativeRequest request = null);

        /// <summary>
        ///  查询文件bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByFileId(string accessToken, long fileId);

        /// <summary>
        ///  查询集成模型bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByIntegrateId(string accessToken, long integrateId);
    }
}