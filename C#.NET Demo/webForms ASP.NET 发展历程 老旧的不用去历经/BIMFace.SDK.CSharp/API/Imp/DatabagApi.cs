// /* ---------------------------------------------------------------------------------------
//    文件名：DatabagApi.cs
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
    ///  转换/集成/对比数据包相关API实现类（当模型转换/集成/对比成功执行后，都会在服务器端生成一个对应的数据包，这个数据包里包含了转换的部分结果，特别是显示数据。不同的转换类型（如rvt文件转换）会产生不同的结果文件）
    /// </summary>
    public class DatabagApi : IDatabagApi
    {
        /// <summary>
        ///  当模型转换成功执行后，获取数据包大小
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <returns></returns>
        public virtual DatabagLengthQueryResponse QueryDatabagLengthByFileId(string accessToken, long fileId)
        {
            return QueryDatabagLength(accessToken, fileId, ModelType.fileId);
        }

        /// <summary>
        ///  当模型对比成功执行后，获取数据包大小
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】compareId</param>
        /// <returns></returns>
        public virtual DatabagLengthQueryResponse QueryDatabagLengthByCompareId(string accessToken, long compareId)
        {
            return QueryDatabagLength(accessToken, compareId, ModelType.compareId);
        }

        /// <summary>
        ///  当模型集成成功执行后，获取数据包大小
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】integrateId</param>
        /// <returns></returns>
        public virtual DatabagLengthQueryResponse QueryDatabagLengthByIntegrateId(string accessToken, long integrateId)
        {
            return QueryDatabagLength(accessToken, integrateId, ModelType.integrateId);
        }

        /// <summary>
        ///  当模型转换/集成/对比成功执行后，获取数据包大小
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="objectId">【必填】文件id 或者 integrateId 或者 compareId</param>
        /// <param name="modelType">模型类型</param>
        /// <returns></returns>
        private DatabagLengthQueryResponse QueryDatabagLength(string accessToken, long objectId, ModelType modelType)
        {
            //GET https://api.bimface.com/data/databag/length
            string url = BIMFaceConstants.API_HOST + "/data/databag/length";
            url += "?" + modelType + "=" + objectId;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DatabagLengthQueryResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DatabagLengthQueryResponse>();
                }
                else
                {
                    response = new DatabagLengthQueryResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取数据包大小]发生异常！", ex);
            }
        }

        /// <summary>
        ///  当模型转换成功执行后，获取缩略图链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件id</param>
        /// <param name="size">【必填】缩略图大小</param>
        /// <returns></returns>
        public virtual DatabagThumbnailQueryResponse QueryDatabagThumbnailFileId(string accessToken, long fileId, int size)
        {
            return QueryDatabagThumbnail(accessToken, fileId, size, ModelType.fileId);
        }

        /// <summary>
        ///  当模型对比成功执行后，获取缩略图链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】 compareId</param>
        /// <param name="size">【必填】缩略图大小</param>
        /// <returns></returns>
        public virtual DatabagThumbnailQueryResponse QueryDatabagThumbnailByCompareId(string accessToken, long compareId, int size)
        {
            return QueryDatabagThumbnail(accessToken, compareId, size, ModelType.compareId);
        }

        /// <summary>
        ///  当模型集成成功执行后，获取缩略图链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】integrateId</param>
        /// <param name="size">【必填】缩略图大小</param>
        /// <returns></returns>
        public virtual DatabagThumbnailQueryResponse QueryDatabagThumbnailByIntegrateId(string accessToken, long integrateId, int size)
        {
            return QueryDatabagThumbnail(accessToken, integrateId, size, ModelType.integrateId);
        }

        /// <summary>
        ///  当模型转换/集成/对比成功执行后，获取缩略图链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="objectId">【必填】文件id 或者 integrateId 或者 compareId</param>
        /// <param name="size">【必填】缩略图大小</param>
        /// <param name="modelType">模型类型</param>
        /// <returns></returns>
        private DatabagThumbnailQueryResponse QueryDatabagThumbnail(string accessToken, long objectId, int size, ModelType modelType)
        {
            //GET https://api.bimface.com/data/v2/databag/thumbnail
            string url = BIMFaceConstants.API_HOST + "/data/v2/databag/thumbnail";
            url += "?" + modelType + "=" + objectId + "&size=" + size;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                DatabagThumbnailQueryResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<DatabagThumbnailQueryResponse>();
                }
                else
                {
                    response = new DatabagThumbnailQueryResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取缩略图链接]发生异常！", ex);
            }
        }
    }
}