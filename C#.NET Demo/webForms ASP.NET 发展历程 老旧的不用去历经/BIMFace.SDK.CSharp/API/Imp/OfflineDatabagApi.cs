// /* ---------------------------------------------------------------------------------------
//    文件名：OfflineDatabagApi.cs
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

using System;

using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Http;
using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    /// 离线数据包相关API实现类
    /// </summary>
    public class OfflineDatabagApi : IOfflineDatabagApi
    {
        /* 官网API地址：https://static.bimface.com/restful-apidoc/dist/offlineDatabag.html#_createtranslateofflinedatabagusingput
         * 
           由于用户所在环境以及应用开发自身的需求，BIMFACE的用户可能想在如下两个场景下还能浏览上传的BIMFACE的模型：
            · 由于内容保护等原因，有些BIMFACE的用户所在的网络环境不一定允许访问公网的BIMFACE服务.
            · 用户自己的应用服务不想依赖于BIMFACE的服务来浏览已经在BIMFACE转换过的模型
           离线数据包功能就是为这种需求量身设计的，每一个用户上传的模型在转换后都可以生成对应的离线数据包， 该离线数据包可以下载到本地，独立部署到用户的环境内，具体操作流程以及部署细节可以参考部署离线数据包。 
         */

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
        public virtual DatabagDerivativeCreateResponse CreateDatabagByFileId(string accessToken, long fileId, string callback = null, DatabagDerivativeRequest request = null)
        {
            return CreateDatabag(accessToken, fileId, ModelType.fileId, callback, request);
        }

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
        public virtual DatabagDerivativeCreateResponse CreateDatabagByIntegrateId(string accessToken, long integrateId, string callback = null, DatabagDerivativeRequest request = null)
        {
            return CreateDatabag(accessToken, integrateId, ModelType.integrateId, callback, request);
        }

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
        public virtual DatabagDerivativeCreateResponse CreateDatabagByCompareId(string accessToken, long compareId, string callback = null, DatabagDerivativeRequest request = null)
        {
            return CreateDatabag(accessToken, compareId, ModelType.compareId, callback, request);
        }

        private DatabagDerivativeCreateResponse CreateDatabag(string accessToken, long objectId, ModelType modelType, string callback = null, DatabagDerivativeRequest request = null)
        {
            /* 通过传入相应的ID创建对应离线数据包:
               文件转换ID：PUT  https://api.bimface.com/files/{fileId}/offlineDatabag
               集成模型ID：PUT  https://api.bimface.com/integrations/{integrateId}/offlineDatabag
               模型对比ID：PUT  https://api.bimface.com/comparisions/{compareId}/offlineDatabag
             */

            string actionType = string.Empty;
            if (modelType == ModelType.fileId)
            {
                actionType = "files";
            }
            else if (modelType == ModelType.integrateId)
            {
                actionType = "integrations";
            }
            else if (modelType == ModelType.compareId)
            {
                actionType = "comparisions";
            }

            string url = BIMFaceConstants.API_HOST + string.Format("/{0}/{1}/offlineDatabag", actionType, objectId);
            if (callback.IsNotNullAndWhiteSpace())
            {
                url += "?callback=" + callback;
            }

            string data = string.Empty;
            if (request != null)
            {
                data = request.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DatabagDerivativeCreateResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Put(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DatabagDerivativeCreateResponse>();
                }
                else
                {
                    response = new DatabagDerivativeCreateResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[创建离线数据包]发生异常！", ex);
            }
        }

        /// <summary>
        ///  根据文件Id查询离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByFileId(string accessToken, long fileId)
        {
            return QueryDatabag(accessToken, fileId, ModelType.fileId);
        }

        /// <summary>
        ///  根据模型集成Id查询离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成Id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByIntegrateId(string accessToken, long integrateId)
        {
            return QueryDatabag(accessToken, integrateId, ModelType.integrateId);
        }

        /// <summary>
        ///  根据模型对比Id查询离线数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比Id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByCompareId(string accessToken, long compareId)
        {
            return QueryDatabag(accessToken, compareId, ModelType.compareId);
        }

        private DatabagDerivativeQueryResponse QueryDatabag(string accessToken, long objectId, ModelType modelType)
        {
            /* 通过传入相应的ID创建对应离线数据包:
               文件转换ID：GET https://api.bimface.com/files/{fileId}/offlineDatabag
               集成模型ID：GET https://api.bimface.com/comparisions/{compareId}/offlineDatabag
               模型对比ID：GET https://api.bimface.com/integrations/{integrateId}/offlineDatabag
             */

            string actionType = string.Empty;
            if (modelType == ModelType.fileId)
            {
                actionType = "files";
            }
            else if (modelType == ModelType.integrateId)
            {
                actionType = "integrations";
            }
            else if (modelType == ModelType.compareId)
            {
                actionType = "comparisions";
            }

            string url = BIMFaceConstants.API_HOST + string.Format("/{0}/{1}/offlineDatabag", actionType, objectId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DatabagDerivativeQueryResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DatabagDerivativeQueryResponse>();
                }
                else
                {
                    response = new DatabagDerivativeQueryResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[查询离线数据包]发生异常！", ex);
            }
        }

        /// <summary>
        ///  根据文件ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        public virtual GetUrlSwaggerDisplay GetDatabagDownloadUrlByFileId(string accessToken, long fileId, string databagVersion, string type)
        {
            return GetDatabagDownloadUrl(accessToken, fileId, ModelType.fileId, databagVersion, type);
        }

        /// <summary>
        ///  根据模型集成ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        public virtual GetUrlSwaggerDisplay GetDatabagDownloadUrlByIntegrateId(string accessToken, long integrateId, string databagVersion, string type)
        {
            return GetDatabagDownloadUrl(accessToken, integrateId, ModelType.integrateId, databagVersion, type);
        }

        /// <summary>
        ///  根据模型对比ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        public virtual GetUrlSwaggerDisplay GetDatabagDownloadUrlByCompareId(string accessToken, long compareId, string databagVersion, string type)
        {
            return GetDatabagDownloadUrl(accessToken, compareId, ModelType.compareId, databagVersion, type);
        }

        /// <summary>
        ///  获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="objectId">【必填】模型Id 或 模型集成Id 或 模型对比Id</param>
        /// <param name="modelType">【必填】模型类别</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <param name="type">数据包类型，如offline、vr、igms</param>
        /// <returns></returns>
        private GetUrlSwaggerDisplay GetDatabagDownloadUrl(string accessToken, long objectId, ModelType modelType, string databagVersion, string type)
        {
            //GET https://api.bimface.com/data/databag/downloadUrl
            string url = BIMFaceConstants.API_HOST + "/data/databag/downloadUrl?" + modelType.ToString() + "=" + objectId;
            if (databagVersion.IsNotNullAndWhiteSpace())
            {
                url += "&databagVersion=" + databagVersion;
            }
            if (type.IsNotNullAndWhiteSpace())
            {
                url += "&type=" + type;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                GetUrlSwaggerDisplay response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<GetUrlSwaggerDisplay>();
                }
                else
                {
                    response = new GetUrlSwaggerDisplay
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取数据包下载地址]发生异常！", ex);
            }
        }
    }
}