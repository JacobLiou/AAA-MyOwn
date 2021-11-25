// /* ---------------------------------------------------------------------------------------
//    文件名：BakeApi.cs
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
    /// 烘焙API实现类（BIMFACE支持在模型完成转换后，再对其进行烘焙，以获得更具真实感的光影效果）
    /// </summary>
    public class BakeApi : IBakeApi
    {
        /// <summary>
        ///  创建文件bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类</param>
        /// <returns></returns>
        public virtual DatabagDerivativeCreateResponse CreateDatabagByFileId(string accessToken, long fileId, string callback = null, DatabagDerivativeRequest request = null)
        {
            return CreateDatabag(accessToken, fileId, ModelType.fileId, callback, request);
        }

        /// <summary>
        ///  创建集成模型bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型id</param>
        /// <param name="callback">回调地址</param>
        /// <param name="request">请求参数类</param>
        /// <returns></returns>
        public virtual DatabagDerivativeCreateResponse CreateDatabagByIntegrateId(string accessToken, long integrateId, string callback = null, DatabagDerivativeRequest request = null)
        {
            return CreateDatabag(accessToken, integrateId, ModelType.integrateId, callback, request);
        }

        private DatabagDerivativeCreateResponse CreateDatabag(string accessToken, long objectId, ModelType modelType, string callback = null, DatabagDerivativeRequest request = null)
        {
            //PUT https://api.bimface.com/files/{fileId}/bake
            //PUT https://api.bimface.com/integrations/{integrateId}/bake
            string actionType = string.Empty;
            if (modelType == ModelType.fileId)
            {
                actionType = "files";
            }
            else if (modelType == ModelType.integrateId)
            {
                actionType = "integrations";
            }
            string url = BIMFaceConstants.API_HOST + string.Format("/{0}/{1}/bake", actionType, objectId);
            if (callback.IsNotNullAndWhiteSpace())
            {
                url += "?callback=" + callback;
            }

            string data = String.Empty;
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
                throw new BIMFaceException("[创建集成模型bake烘焙数据包]发生异常！", ex);
            }
        }

        /// <summary>
        ///  查询文件bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByFileId(string accessToken, long fileId)
        {
            return QueryDatabag(accessToken, fileId, ModelType.fileId);
        }

        /// <summary>
        ///  查询集成模型bake烘焙数据包
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型id</param>
        /// <returns></returns>
        public virtual DatabagDerivativeQueryResponse QueryDatabagByIntegrateId(string accessToken, long integrateId)
        {
            return QueryDatabag(accessToken, integrateId, ModelType.integrateId);
        }

        private DatabagDerivativeQueryResponse QueryDatabag(string accessToken, long objectId, ModelType modelType)
        {
            //GET https://api.bimface.com/files/{fileId}/bake
            //GET https://api.bimface.com/integrations/{integrateId}/bake

            string actionType = string.Empty;
            if (modelType == ModelType.fileId)
            {
                actionType = "files";
            }
            else if (modelType == ModelType.integrateId)
            {
                actionType = "integrations";
            }
            string url = BIMFaceConstants.API_HOST + string.Format("/{0}/{1}/bake", actionType, objectId);

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
                throw new BIMFaceException("[查询集成模型bake烘焙数据包]发生异常！", ex);
            }
        }
    }
}