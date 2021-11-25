// /* ---------------------------------------------------------------------------------------
//    文件名：IGltfDatabagApi.cs
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
    /// gltf数据包API接口（BIMFACE支持将模型导出成特定的格式，直接用于实时渲染。比如，导出成gltf，用于集成GIS，进行模型信息的展示）
    /// </summary>
    public interface IGltfDatabagApi
    {
        /// <summary>
        ///  根据文件ID创建gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <param name="callback">回调地址</param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByFileId(string accessToken, long fileId, string callback = null);

        /// <summary>
        ///  根据模型集成ID创建gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成id</param>
        /// <param name="callback">回调地址</param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByIntegrateId(string accessToken, long integrateId, string callback = null);

        /// <summary>
        ///  根据文件Id查询Gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByFileId(string accessToken, long fileId);

        /// <summary>
        ///  根据模型集成Id查询gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成Id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByIntegrateId(string accessToken, long integrateId);

        /// <summary>
        ///  根据文件ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <returns></returns>
        GetUrlSwaggerDisplay GetDatabagDownloadUrlByFileId(string accessToken, long fileId, string databagVersion);

        /// <summary>
        ///  根据模型集成ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <returns></returns>
        GetUrlSwaggerDisplay GetDatabagDownloadUrlByIntegrateId(string accessToken, long integrateId, string databagVersion);
    }
}