// /* ---------------------------------------------------------------------------------------
//    文件名：ShareLinkApi.cs
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
using System.Collections.Generic;

using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Http;
using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  分享链接API实现
    /// </summary>
    public class ShareLinkApi : IShareLinkApi
    {
        /// <summary>
        ///  文件发起转换以后，可以根据fileId生成该文件的分享链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="activeHours">有效时长（与有效期限，二选一），单位：小时，如果不设置表示永久有效</param>
        /// <param name="expireDate">有效期限（与有效时长，二选一），单位：精确到天，如果不设置表示永久有效</param>
        /// <param name="needPassword">分享链接是否生成访问密码</param>
        /// <returns></returns>
        public virtual ShareLinkResponse CreateShareLinkByFileId(string accessToken, long fileId, int? activeHours = null, string expireDate = null, bool? needPassword = null)
        {
            return CreateShareLink(accessToken, fileId, ModelType.fileId, activeHours, expireDate, needPassword);
        }

        /// <summary>
        ///  发起集成模型以后，可以根据integrateId生成集成模型的分享链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型ID </param>
        /// <param name="activeHours">有效时长（与有效期限，二选一），单位：小时，如果不设置表示永久有效</param>
        /// <param name="expireDate">有效期限（与有效时长，二选一），单位：精确到天，如果不设置表示永久有效</param>
        /// <param name="needPassword">分享链接是否生成访问密码</param>
        /// <returns></returns>
        public virtual ShareLinkResponse CreateShareLinkByIntegrateId(string accessToken, long integrateId, int? activeHours = null, string expireDate = null, bool? needPassword = null)
        {
            return CreateShareLink(accessToken, integrateId, ModelType.integrateId, activeHours, expireDate, needPassword);
        }

        /// <summary>
        /// 文件发起转换以后，可以根据fileId生成该文件的分享链接；或者发起集成模型以后，可以根据integrateId生成集成模型的分享链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="objectId">【必填】fileId 或者 integrateId</param>
        /// <param name="modelType">【必填】文件 file 或者 集成模型integrate </param>
        /// <param name="activeHours">有效时长（与有效期限，二选一），单位：小时，如果不设置表示永久有效</param>
        /// <param name="expireDate">有效期限（与有效时长，二选一），单位：精确到天，如果不设置表示永久有效</param>
        /// <param name="needPassword">分享链接是否生成访问密码</param>
        /// <returns></returns>
        private ShareLinkResponse CreateShareLink(string accessToken, long objectId, ModelType modelType, int? activeHours = null, string expireDate = null, bool? needPassword = null)
        {
            //POST https://api.bimface.com/share
            string url = BIMFaceConstants.API_HOST + "/share";
            url += "?" + ModelType.fileId + "=" + objectId;

            if (activeHours.HasValue)
            {
                url += "&activeHours=" + activeHours.Value;
            }
            if (expireDate.IsNotNullAndWhiteSpace())
            {
                url += "&expireDate=" + expireDate;
            }
            if (needPassword.HasValue)
            {
                url += "&needPassword=" + needPassword.Value;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ShareLinkResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ShareLinkResponse>();
                }
                else
                {
                    response = new ShareLinkResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[创建分享链接]发生异常！", ex);
            }
        }

        /// <summary>
        ///  通过文件Id获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        public virtual ShareLinkResponse GetShareLinkByFileId(string accessToken, long fileId)
        {
            return GetShareLink(accessToken, fileId, ModelType.fileId);
        }

        /// <summary>
        ///  通过集成模型ID获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">集成模型ID</param>
        /// <returns></returns>
        public virtual ShareLinkResponse GetShareLinkByIntegrateId(string accessToken, long integrateId)
        {
            return GetShareLink(accessToken, integrateId, ModelType.integrateId);
        }

        /// <summary>
        ///  通过分享链接的识别码获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="token">分享链接的识别码</param>
        /// <returns></returns>
        public virtual ShareLinkResponse GetShareLinkByToken(string accessToken, string token)
        {
            return GetShareLink(accessToken, token, ModelType.token);
        }

        /// <summary>
        /// 获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="objectId">文件ID、集成ID、分享链接的识别码，三选一</param>
        /// <param name="modelType">文件file、集成integrate、分享链接的识别码token，三选一</param>
        /// <returns></returns>
        private ShareLinkResponse GetShareLink(string accessToken, object objectId, ModelType modelType)
        {
            //GET https://api.bimface.com/share
            string url = BIMFaceConstants.API_HOST + "/share";
            url += "?" + ModelType.fileId + "=" + objectId;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ShareLinkResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ShareLinkResponse>();
                }
                else
                {
                    response = new ShareLinkResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取分享链接]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取Appkey下显示的分享列表（包含分页信息）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="pageNo">当前页码（默认为第1页）</param>
        /// <param name="pageSize">每页显示条数（默认为20条）</param>
        /// <returns></returns>
        public virtual ShareLinkListResponse GetShareLinkPagedList(string accessToken, int pageNo = 1, int pageSize = 20)
        {
            if (pageNo <= 1)
            {
                pageNo = 1;
            }
            if (pageSize <= 1)
            {
                pageNo = 20;
            }

            //GET https://api.bimface.com/shares
            string url = BIMFaceConstants.API_HOST + "/shares";
            url += "?pageNo=" + pageNo;
            url += "&pageSize=" + pageSize;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ShareLinkListResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ShareLinkListResponse>();
                }
                else
                {
                    response = new ShareLinkListResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取分享链接列表]发生异常！", ex);
            }

        }

        /// <summary>
        ///  获取Appkey下显示所有的分享列表（包含分页信息）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <returns></returns>
        public virtual ShareLinkListResponse GetShareLinkAllList(string accessToken)
        {
            return GetShareLinkPagedList(accessToken, 1, Int32.MaxValue);
        }

        /// <summary>
        ///  取消分享链接。若不希望继续分享，可以根据fileId取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】fileId</param>
        /// <returns></returns>
        public virtual DeleteShareLinkResponse DeleteShareLinkByFileId(string accessToken, long fileId)
        {
            return DeleteShareLink(accessToken, fileId, "file");
        }

        /// <summary>
        ///  取消分享链接。若不希望继续分享，可以根据integrateId取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填integrateId</param>
        /// <returns></returns>
        public virtual DeleteShareLinkResponse DeleteShareLinkByIntegrateId(string accessToken, long integrateId)
        {
            return DeleteShareLink(accessToken, integrateId, "integrate");
        }

        /// <summary>
        ///  取消分享链接。若不希望继续分享，可以根据fileId或integrateId取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="objectId">【必填】fileId 或者 integrateId</param>
        /// <param name="objectType">【必填】文件 file 或者 集成模型integrate </param>
        /// <returns></returns>
        private DeleteShareLinkResponse DeleteShareLink(string accessToken, long objectId, string objectType)
        {
            //DELETE https://api.bimface.com/share
            string url = BIMFaceConstants.API_HOST + "/share";
            if (objectType == "file")
            {
                url += "?fileId=" + objectId;
            }
            else
            {
                url += "?integrateId=" + objectId;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DeleteShareLinkResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DeleteShareLinkResponse>();
                }
                else
                {
                    response = new DeleteShareLinkResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[删除分享链接]发生异常！", ex);
            }
        }

        /// <summary>
        ///  批量取消分享链接。若不希望继续分享，可以根据sourceId批量取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="sourceIds">sourceId集合</param>
        /// <returns></returns>
        public virtual BatchDeleteShareLinkResponse BatchDeleteShareLink(string accessToken, long[] sourceIds)
        {
            //DELETE https://api.bimface.com/shares
            string url = BIMFaceConstants.API_HOST + "/shares";
            if (sourceIds.IsNotNullAndEmpty())
            {
                url += "?sourceIds=" + sourceIds.ToStringWith(',');
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                BatchDeleteShareLinkResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<BatchDeleteShareLinkResponse>();
                }
                else
                {
                    response = new BatchDeleteShareLinkResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[批量删除分享链接]发生异常！", ex);
            }
        }

        /// <summary>
        ///  批量取消分享链接。若不希望继续分享，可以根据sourceId批量取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="sourceIds">sourceId集合</param>
        /// <returns></returns>
        public virtual BatchDeleteShareLinkResponse BatchDeleteShareLink(string accessToken, List<long> sourceIds)
        {
            return BatchDeleteShareLink(accessToken, sourceIds.ToArray());
        }
    }
}