// /* ---------------------------------------------------------------------------------------
//    文件名：BasicApi.cs
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

#region using
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Http;
using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;
#endregion

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  BIMFace 基础操作 API 实现类。用于和BIMFace服务器通讯。
    ///  官网地址：http://static.bimface.com/developer/doc/apidoc/index.html
    /// </summary>
    public class BasicApi : IBasicApi
    {
        /// <summary>
        ///  获取访问服务端其他API的令牌
        /// </summary>
        /// <param name="appKey">开发者秘钥</param>
        /// <param name="appSecret">开发者密码</param>
        /// <returns></returns>
        public AccessTokenResponse GetAccessToken(string appKey, string appSecret)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列3 服务端API之获取应用访问凭证AccessToken》 https://www.cnblogs.com/SavionZhang/p/11424481.html

            //POST https://api.bimface.com/oauth2/token
            string url = BIMFaceConstants.API_HOST + "/oauth2/token";

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddBasicAuthHeader(appKey, appSecret);

            try
            {
                AccessTokenResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<AccessTokenResponse>();
                }
                else
                {
                    response = new AccessTokenResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取AccessToken]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取单个模型的 ViewToken
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="modelType">模型类型</param>
        /// <param name="objectId">文件转换ID(fileId)、模型对比ID(compareId)、集成模型ID(integrateId)的值，三者中的一个</param>
        /// <returns></returns>
        protected ViewTokenResponse GetViewToken(string accessToken, ModelType modelType, long objectId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列15 服务端API之获取模型的View token》 https://www.cnblogs.com/SavionZhang/p/11457365.html

            //GET https://api.bimface.com/view/token
            string url = string.Format(BIMFaceConstants.API_HOST + "/view/token?{0}={1}", modelType.ToString(), objectId);
            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ViewTokenResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ViewTokenResponse>();
                }
                else
                {
                    response = new ViewTokenResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取ViewToken] 发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取单个模型的 ViewToken
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="fileId">文件转换ID</param>
        /// <returns></returns>
        public ViewTokenResponse GetViewTokenByFileId(string accessToken, long fileId)
        {
            return GetViewToken(accessToken, ModelType.fileId, fileId);
        }

        /// <summary>
        ///  获取模型集成的 ViewToken
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="integrateId">集成模型ID</param>
        /// <returns></returns>
        public ViewTokenResponse GetViewTokenByIntegrateId(string accessToken, long integrateId)
        {
            return GetViewToken(accessToken, ModelType.integrateId, integrateId);
        }

        /// <summary>
        ///  获取模型比对的 ViewToken
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="compareId">模型比对ID</param>
        /// <returns></returns>
        public ViewTokenResponse GetViewTokenByCompareId(string accessToken, long compareId)
        {
            return GetViewToken(accessToken, ModelType.compareId, compareId);
        }

        /// <summary>
        ///  获取子文件的 ViewToken
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="integrateId">集成ID</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        public ViewTokenResponse GetSubFileViewToken(string accessToken, long integrateId, long fileId)
        {
            //POST https://api.bimface.com/data/v2/integrations/{integrateId}/files/{fileId}/viewToken
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/files/{1}/viewToken", integrateId, fileId); // POST 方式
            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ViewTokenResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ViewTokenResponse>();
                }
                else
                {
                    response = new ViewTokenResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取子文件的ViewToken]发生异常！", ex);
            }
        }

        /// <summary>
        ///  批量获取同一类型的模型的 ViewToken 集合
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="modelType">模型类型</param>
        /// <param name="objectIds">文件转换ID(fileId)、模型对比ID(compareId)、集成模型ID(integrateId)的值，三者中的一个</param>
        /// <returns></returns>
        public ConcurrentDictionary<long, ViewTokenResponse> GetViewTokenList(string accessToken, ModelType modelType, List<long> objectIds)
        {
            if (objectIds.IsNullOrEmpty())
            {
                return null;
            }

            ConcurrentDictionary<long, ViewTokenResponse> responses = new ConcurrentDictionary<long, ViewTokenResponse>();
            foreach (var fileId in objectIds)
            {
                try
                {
                    var response = GetViewToken(accessToken, modelType, fileId);
                    responses.TryAdd(fileId, response);
                }
                catch
                {
                    responses.TryAdd(fileId, null);
                }
            }

            return responses;
        }

        /// <summary>
        ///  批量获取不同类型的模型的 ViewToken 集合
        /// </summary>
        /// <param name="accessToken">令牌</param>
        /// <param name="objectInfos">模型类型以及对应的模型ID</param>
        /// <returns></returns>
        public ConcurrentDictionary<long, ViewTokenResponse> GetViewTokenList(string accessToken, ConcurrentDictionary<ModelType, List<long>> objectInfos)
        {
            if (objectInfos.IsNullOrEmpty())
            {
                return null;
            }

            ConcurrentDictionary<long, ViewTokenResponse> responses = new ConcurrentDictionary<long, ViewTokenResponse>();

            foreach (var modelType in objectInfos.Keys)
            {
                foreach (var fileId in objectInfos[modelType])
                {
                    try
                    {
                        var response = GetViewToken(accessToken, modelType, fileId);
                        responses.TryAdd(fileId, response);
                    }
                    catch
                    {
                        responses.TryAdd(fileId, null);
                    }
                }
            }

            return responses;
        }

    }
}