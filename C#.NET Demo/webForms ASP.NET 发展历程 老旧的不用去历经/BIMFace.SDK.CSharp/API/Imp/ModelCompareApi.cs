// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareApi.cs
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
    ///  模型对比接口
    /// </summary>
    public class ModelCompareApi : IModelCompareApi
    {
        #region 模型对比相关

        /// <summary>
        ///  不同版本的模型文件上传并转换成功后，即可发起模型对比。由于对比不能立即完成，BIMFace支持在模型对比完成以后，通过Callback机制通知应用；另外，应用也可以通过接口查询对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="followingId">修改后图纸(当前本班，本轮)模型文件ID</param>
        /// <param name="previousId">修改前图纸(历史版本，上一轮次)模型文件ID</param>
        /// <returns></returns>
        public virtual ModelCompareResponse Compare(string accessToken, long followingId, long previousId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列30 服务端API之模型对比1：发起模型对比》https://www.cnblogs.com/SavionZhang/p/12395986.html

            CompareRequest request = new CompareRequest(followingId, previousId);

            return Compare(accessToken, request);
        }

        /// <summary>
        ///  不同版本的模型文件上传并转换成功后，即可发起模型对比。由于对比不能立即完成，BIMFace支持在模型对比完成以后，通过Callback机制通知应用；另外，应用也可以通过接口查询对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">对比时的请求参数</param>
        /// <returns></returns>
        public virtual ModelCompareResponse Compare(string accessToken, CompareRequest request)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列30 服务端API之模型对比1：发起模型对比》https://www.cnblogs.com/SavionZhang/p/12395986.html

            //POST https://api.bimface.com/v2/compare
            string url = BIMFaceConstants.API_HOST + "/v2/compare";
            string data = request.SerializeToJson();

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelCompareResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelCompareResponse>();
                }
                else
                {
                    response = new ModelCompareResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[发起模型对比]发生异常！", ex);
            }
        }

        /// <summary>
        /// 应用发起对比以后，可以通过该接口查询对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比ID</param>
        /// <returns></returns>
        public virtual ModelCompareResponse GetCompareStatus(string accessToken, long compareId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列31 服务端API之模型对比2：获取模型对比状态》 https://www.cnblogs.com/SavionZhang/p/12395996.html

            //GET https://api.bimface.com/v2/compare
            string url = string.Format(BIMFaceConstants.API_HOST + "/v2/compare?compareId={0}", compareId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelCompareResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelCompareResponse>();
                }
                else
                {
                    response = new ModelCompareResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取模型对比状态]发生异常！", ex);
            }
        }

        /// <summary>
        ///  批量获取模型对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">【必填】批量获取模型对比状态的请求参数</param>
        /// <returns></returns>
        public virtual ModelCompareQueryResponse GetCompareStatusList(string accessToken, ModelCompareQueryRequest request)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列32 服务端API之模型对比3：批量获取模型对比状态》 https://www.cnblogs.com/SavionZhang/p/12396001.html

            //POST https://api.bimface.com/compares
            string url = BIMFaceConstants.API_HOST + "/compares";
            string data = request.SerializeToJson();
            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelCompareQueryResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelCompareQueryResponse>();
                }
                else
                {
                    response = new ModelCompareQueryResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[批量获取模型对比状态]发生异常！", ex);
            }
        }

        /// <summary>
        ///  删除模型对比
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比ID</param>
        /// <returns></returns>
        public virtual DeleteModelCompareResponse DeleteModelCompare(string accessToken, long compareId)
        {
            //DELETE https://api.bimface.com/v2/compare
            string url = string.Format(BIMFaceConstants.API_HOST + "/v2/compare?compareId={0}", compareId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DeleteModelCompareResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DeleteModelCompareResponse>();
                }
                else
                {
                    response = new DeleteModelCompareResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[删除模型对比]发生异常！", ex);
            }
        }

        #endregion

        #region 模型对比数据

        /// <summary>
        /// 获取模型构件对比差异
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="followingFileId">【必填】变更后的文件ID</param>
        /// <param name="followingElementId">【必填】变更后的文件的构件ID</param>
        /// <param name="previousFileId">【必填】变更前的文件ID</param>
        /// <param name="previousElementId">【必填】变更前的文件的构件ID</param>
        /// <returns></returns>
        public virtual ModelCompareChangeResponse GetModelCompareChange(string accessToken, long compareId,
               long followingFileId, string followingElementId, long previousFileId, string previousElementId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列34 服务端API之模型对比5：获取模型构件对比差异》 https://www.cnblogs.com/SavionZhang/p/12396011.html

            // GET https: //api.bimface.com/data/v2/comparisons/{comparisonId}/elementChange
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/comparisons/{0}/elementChange", compareId);
            url += "?followingFileId=" + followingFileId;
            url += "&followingElementId=" + followingElementId;
            url += "&previousFileId=" + previousFileId;
            url += "&previousElementId=" + previousElementId;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelCompareChangeResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelCompareChangeResponse>();
                }
                else
                {
                    response = new ModelCompareChangeResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取模型构件对比差异]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取模型对比构件分类树
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <returns></returns>
        public virtual ModelCompareTreeResponse GetModelCompareTree(string accessToken, long compareId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列35 服务端API之模型对比6：获取模型构建对比分类树》 https://www.cnblogs.com/SavionZhang/p/12396032.html

            // GET https://api.bimface.com/data/v2/comparisons/{comparisonId}/tree
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/comparisons/{0}/tree", compareId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelCompareTreeResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelCompareTreeResponse>();
                }
                else
                {
                    response = new ModelCompareTreeResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取模型构件对比差异]发生异常！", ex);
            }
        }

        /// <summary>
        ///  分页获取模型对比结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="elementName">构件名称</param>
        /// <param name="family">族名称</param>
        /// <param name="page">页码（提示：私有云部署不支持分页查询）。如果不传参数，则默认为1</param>
        /// <param name="pageSize">每页记录数（提示：私有云部署不支持分页查询）。如果不传参数，则默认为50</param>
        /// <returns></returns>
        public virtual ModelCompareDiffResponse GetModelCompareDiff(string accessToken, long compareId, string elementName = "", string family = "", int? page = null, int? pageSize = null)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列33 服务端API之模型对比4：获取模型对比结果》 https://www.cnblogs.com/SavionZhang/p/12396008.html

            // GET https://api.bimface.com/data/v2/comparisons/{comparisonId}/diff
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/comparisons/{0}/diff?v=1", compareId);
            if (page.HasValue)
            {
                if (page.Value <= 1)
                {
                    page = 1;
                }

                url += "&page=" + page;
            }

            if (pageSize.HasValue)
            {
                if (pageSize.Value <= 0)
                {
                    pageSize = 50;
                }

                url += "&pageSize=" + pageSize;
            }

            if (elementName.IsNotNullAndWhiteSpace())
            {
                url += "&elementName=" + elementName;
            }
            if (family.IsNotNullAndWhiteSpace())
            {
                url += "&family=" + family;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelCompareDiffResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelCompareDiffResponse>();
                }
                else
                {
                    response = new ModelCompareDiffResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[分页获取模型对比结果]发生异常！", ex);
            }
        }

        /// <summary>
        /// 获取模型对比的所有结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="elementName">构件名称</param>
        /// <param name="family">族名称</param>
        /// <returns></returns>
        public ModelCompareDiffResponse GetModelCompareDiffAll(string accessToken, long compareId, string elementName = "", string family = "")
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列33 服务端API之模型对比4：获取模型对比结果》 https://www.cnblogs.com/SavionZhang/p/12396008.html

            return GetModelCompareDiff(accessToken, compareId, elementName,family, 1, Int32.MaxValue);
        }

        /// <summary>
        ///  分页获取二维图纸对比结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="page">页码（提示：私有云部署不支持分页查询）。如果不传参数，则默认为1</param>
        /// <param name="pageSize">每页记录数（提示：私有云部署不支持分页查询）。如果不传参数，则默认为50</param>
        /// <returns></returns>
        public virtual DrawingCompareDiffResponse GetDrawingCompareDiff(string accessToken, long compareId, int? page = null, int? pageSize = null)
        {
            // GET https://api.bimface.com/data/v2/comparisons/{comparisonId}/diff
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/comparisons/{0}/drawingdiff?v=1", compareId);
            if (page.HasValue)
            {
                if (page.Value <= 1)
                {
                    page = 1;
                }

                url += "&page=" + page;
            }

            if (pageSize.HasValue)
            {
                if (pageSize.Value <= 0)
                {
                    pageSize = 50;
                }

                url += "&pageSize=" + pageSize;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DrawingCompareDiffResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DrawingCompareDiffResponse>();
                }
                else
                {
                    response = new DrawingCompareDiffResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[分页获取图纸对比结果]发生异常！", ex);
            }
        }

        /// <summary>
        /// 获取二维图纸对比的所有结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <returns></returns>
        public DrawingCompareDiffResponse GetDrawingCompareDiffAll(string accessToken, long compareId)
        {
            return GetDrawingCompareDiff(accessToken, compareId,1,Int32.MaxValue);
        }


        #endregion
    }
}