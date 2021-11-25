// /* ---------------------------------------------------------------------------------------
//    文件名：GltfDatabagApi.cs
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
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    /// gltf数据包API接口实现（BIMFACE支持将模型导出成特定的格式，直接用于实时渲染。比如，导出成gltf，用于集成GIS，进行模型信息的展示）类
    /// </summary>
    public class GltfDatabagApi : IGltfDatabagApi
    {
        /* 官方API地址：https://static.bimface.com/restful-apidoc/dist/exportDatabag.html#_exporttranslategltfdatabagusingput
         * 文件转换成功后，即可创建gltf数据包。 BIMFACE支持在创建Gltf数据包完成以后，通过Callback机制通知调用方(请参考这里)；另外，调用方也可以通过接口查询Gltf数据包状态。 
         */

        /// <summary>
        ///  根据文件ID创建gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <param name="callback">回调地址</param>
        /// <returns></returns>
        public virtual DatabagDerivativeCreateResponse CreateDatabagByFileId(string accessToken, long fileId, string callback = null)
        {
            return CreateDatabag(accessToken, fileId, ModelType.fileId, callback);
        }

        /// <summary>
        ///  根据模型集成ID创建gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成id</param>
        /// <param name="callback">回调地址</param>
        /// <returns></returns>
        public virtual DatabagDerivativeCreateResponse CreateDatabagByIntegrateId(string accessToken, long integrateId, string callback = null)
        {
            return CreateDatabag(accessToken, integrateId, ModelType.integrateId, callback);
        }

        private DatabagDerivativeCreateResponse CreateDatabag(string accessToken, long objectId, ModelType modelType, string callback = null)
        {
            /* 通过传入相应的ID创建对应gltf数据包:
               文件转换ID：PUT https://api.bimface.com/files/{fileId}/export/gltf
               集成模型ID：PUT https://api.bimface.com/integrations/{integrateId}/export/gltf
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

            string url = BIMFaceConstants.API_HOST + string.Format("/{0}/{1}/export/gltf", actionType, objectId);
            if (callback.IsNotNullAndWhiteSpace())
            {
                url += "?callback=" + callback;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DatabagDerivativeCreateResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Put(url);
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
                throw new BIMFaceException("[创建gltfGltf数据包]发生异常！", ex);
            }
        }

        /// <summary>
        ///  根据文件Id查询Gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByFileId(string accessToken, long fileId)
        {
            return QueryDatabag(accessToken, fileId, ModelType.fileId);
        }

        /// <summary>
        ///  根据模型集成Id查询gltf数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成Id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByIntegrateId(string accessToken, long integrateId)
        {
            return QueryDatabag(accessToken, integrateId, ModelType.integrateId);
        }

        private DatabagDerivativeQueryResponse QueryDatabag(string accessToken, long objectId, ModelType modelType)
        {
            /* 通过传入相应的ID创建对应Gltf数据包:
               文件转换ID：GET https://api.bimface.com/files/{fileId}/export/gltf
               集成模型ID：GET https://api.bimface.com/integrations/{integrateId}/export/gltf
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

            string url = BIMFaceConstants.API_HOST + string.Format("/{0}/{1}/export/gltf", actionType, objectId);

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
                throw new BIMFaceException("[查询gltf数据包]发生异常！", ex);
            }
        }

        /// <summary>
        ///  根据文件ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <returns></returns>
        public virtual GetUrlSwaggerDisplay GetDatabagDownloadUrlByFileId(string accessToken, long fileId, string databagVersion)
        {
            return GetDatabagDownloadUrl(accessToken, fileId, ModelType.fileId, databagVersion);
        }

        /// <summary>
        ///  根据模型集成ID获取数据包下载地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】文件Id</param>
        /// <param name="databagVersion">数据包版本；对于offline、vr数据包，如果只有一个，则下载唯一的数据包，如果多个，则必须指定数据包版本</param>
        /// <returns></returns>
        public virtual GetUrlSwaggerDisplay GetDatabagDownloadUrlByIntegrateId(string accessToken, long integrateId, string databagVersion)
        {
            return GetDatabagDownloadUrl(accessToken, integrateId, ModelType.integrateId, databagVersion);
        }

        private GetUrlSwaggerDisplay GetDatabagDownloadUrl(string accessToken, long objectId, ModelType modelType, string databagVersion)
        {
            //GET https://api.bimface.com/data/databag/downloadUrl?type=gltf
            string url = BIMFaceConstants.API_HOST + "/data/databag/downloadUrl?type=gltf&" + modelType.ToString() + "=" + objectId;
            if (databagVersion.IsNotNullAndWhiteSpace())
            {
                url += "&databagVersion=" + databagVersion;
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