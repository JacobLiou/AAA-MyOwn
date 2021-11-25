// /* ---------------------------------------------------------------------------------------
//    文件名：ModelInfoAndElementPropertyQueryApi.cs
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
    ///  模型信息和构件属性查询API实现类
    /// （上传到BIMFACE的模型文件转换以及模型集成，模型对比都是在云端进行的。
    ///   借助BIMFACE在云端强大的数据能力， 为满足不同的业务需要，开发者可以方便得对在转换/集成/对比过程中产生的数据进行灵活的查询检索。
    ///   这是BIMFACE基于云计算的独特优势。
    ///   为满足灵活的，可扩展的查询需求，BIMFACE参考Elastic Search，定义了一套通用的查询领域语言）
    /// </summary>
    public class ModelInfoAndElementPropertyQueryApi : IModelInfoAndElementPropertyQueryApi
    {
        /// <summary>
        ///  查询符合条件的构件ID列表。
        ///  支持查询模型属性重写后符合条件的构件ID列表，需要设置请求参数includeOverrides的值为true
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="dsl">【必填】查询DSL</param>
        /// <param name="includeOverrid">是否查询修改的属性</param>
        /// <returns></returns>
        public virtual QueryElementIdsResponse QueryElementIds(string accessToken, string dsl, bool includeOverrid = false)
        {
            //POST https://api.bimface.com/data/v2/query/elementIds
            string url = BIMFaceConstants.API_HOST + "/data/v2/query/elementIds?includeOverrid=" + includeOverrid;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                QueryElementIdsResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url, dsl);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<QueryElementIdsResponse>();
                }
                else
                {
                    response = new QueryElementIdsResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[查询满足条件的构件ID列表]发生异常！", ex);
            }
        }

        /// <summary>
        /// 查询指定模型构件属性的所有可能值。
        /// 仅支持查询单模型，即targetType可填：file。
        /// 支持查询模型属性重写后构件的属性的所有可能值，需要设置请求参数includeOverrides的值为true
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="properties">【必填】需要查询的属性列表</param>
        /// <param name="targetIds">【必填】目标ID</param>
        /// <param name="targetType">【必填】目标类型。此处填写 file 即可。</param>
        /// <param name="includeOverrid">是否查询修改的属性</param>
        /// <returns></returns>
        public virtual QueryPropertyValuesResponse QueryPropertyValues(string accessToken, string[] properties, string[] targetIds, string targetType = "file", bool includeOverrid = false)
        {
            //GET https://api.bimface.com/data/v2/query/propertyValues

            string url = BIMFaceConstants.API_HOST + "/data/v2/query/elementIds?includeOverrid=" + includeOverrid;
            url += "&properties=" + properties.ToStringWith(",");
            url += "&targetIds=" + targetIds.ToStringWith(",");
            url += "&targetType=" + targetType;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                QueryPropertyValuesResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<QueryPropertyValuesResponse>();
                }
                else
                {
                    response = new QueryPropertyValuesResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[查询指定模型构件属性的所有可能值]发生异常！", ex);
            }
        }

        /// <summary>
        /// 生成分页查询的ContextId
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <returns></returns>
        public virtual QueryPaginationContextIdResponse QueryPaginationContextId(string accessToken)
        {
            //GET https://api.bimface.com/data/v2/query/paginationContextId

            string url = BIMFaceConstants.API_HOST + "/data/v2/query/paginationContextId";

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                QueryPaginationContextIdResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<QueryPaginationContextIdResponse>();
                }
                else
                {
                    response = new QueryPaginationContextIdResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[生成分页查询的ContextId]发生异常！", ex);
            }
        }
    }
}