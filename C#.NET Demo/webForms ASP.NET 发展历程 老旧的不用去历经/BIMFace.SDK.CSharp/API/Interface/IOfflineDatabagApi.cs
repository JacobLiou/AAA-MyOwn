// /* ---------------------------------------------------------------------------------------
//    文件名：IOfflineDatabagApi.cs
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
    /// 离线数据包相关API接口
    /// </summary>
    public interface IOfflineDatabagApi
    {
        /// <summary>
        ///  根据文件ID创建离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类。
        ///     若需要离线数据包保留db文件，请求体中参数设置为
        ///     {
        ///        "config": {
        ///             "keepModel": true,
        ///             "keepDB": true
        ///        }
        ///     }
        /// </param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByFileId(string accessToken, long fileId, string callback = null, DatabagDerivativeRequest request = null);

        /// <summary>
        ///  根据模型集成ID创建离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类。
        ///     若需要离线数据包保留db文件，请求体中参数设置为
        ///     {
        ///        "config": {
        ///             "keepModel": true,
        ///             "keepDB": true
        ///        }
        ///     }
        /// </param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByIntegrateId(string accessToken, long integrateId, string callback = null, DatabagDerivativeRequest request = null);

        /// <summary>
        ///  根据模型对比ID创建离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类。
        ///     若需要离线数据包保留db文件，请求体中参数设置为
        ///     {
        ///        "config": {
        ///             "keepModel": true,
        ///             "keepDB": true
        ///        }
        ///     }
        /// </param>
        /// <returns></returns>
        DatabagDerivativeCreateResponse CreateDatabagByCompareId(string accessToken, long compareId, string callback = null, DatabagDerivativeRequest request = null);

        /// <summary>
        ///  根据文件Id查询离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByFileId(string accessToken, long fileId);

        /// <summary>
        ///  根据模型集成Id查询离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成Id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByIntegrateId(string accessToken, long integrateId);

        /// <summary>
        ///  根据模型对比Id查询离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比Id</param>
        /// <returns></returns>
        DatabagDerivativeQueryResponse QueryDatabagByCompareId(string accessToken, long compareId);

        /// <summary>
        ///  根据文件ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        GetUrlSwaggerDisplay GetDatabagDownloadUrlByFileId(string accessToken, long fileId, string databagVersion, string type);

        /// <summary>
        ///  根据模型集成ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        GetUrlSwaggerDisplay GetDatabagDownloadUrlByIntegrateId(string accessToken, long integrateId, string databagVersion, string type);

        /// <summary>
        ///  根据模型对比ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        GetUrlSwaggerDisplay GetDatabagDownloadUrlByCompareId(string accessToken, long compareId, string databagVersion, string type);
    }
}