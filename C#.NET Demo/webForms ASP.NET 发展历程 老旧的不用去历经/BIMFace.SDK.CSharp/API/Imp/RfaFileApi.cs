// /* ---------------------------------------------------------------------------------------
//    文件名：RfaFileApi.cs
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
    ///  rfa构件数据API实现
    /// </summary>
    public class RfaFileApi : IRfaFileApi
    {
        /// <summary>
        ///  获取rfa文件族类型属性key列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="rfaFileId">【必填】rfaFileId</param>
        public virtual RfaFileFamilyTypePropertyKeyListResponse GetRfaFileFamilyTypePropertyKeyList(string accessToken, long rfaFileId)
        {
            //GET https://api.bimface.com/data/v2/rfaFiles/{rfaFileId}/propertyNames
            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/rfaFiles/{0}/propertyNames", rfaFileId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                RfaFileFamilyTypePropertyKeyListResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<RfaFileFamilyTypePropertyKeyListResponse>();
                }
                else
                {
                    response = new RfaFileFamilyTypePropertyKeyListResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取rfa文件族类型属性key列表]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取rfa文件族类型属性列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="rfaFileId">【必填】rfaFileId</param>
        /// <param name="familyTypeGuid">【必填】族类型guid</param>
        public virtual RfaFileFamilyTypePropertyListResponse GetRfaFileFamilyTypePropertyList(string accessToken, long rfaFileId, string familyTypeGuid)
        {
            //GET https://api.bimface.com/data/v2/rfaFiles/{rfaFileId}/familyTypes/{familyTypeGuid}
            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/rfaFiles/{0}/familyTypes/{1}", rfaFileId, familyTypeGuid);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                RfaFileFamilyTypePropertyListResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<RfaFileFamilyTypePropertyListResponse>();
                }
                else
                {
                    response = new RfaFileFamilyTypePropertyListResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取rfa文件族类型属性列表]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取rfa文件族类型列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="rfaFileId">【必填】rfaFileId</param>
        public virtual RfaFileFamilyTypeListResponse GetRfaFileFamilyTypeList(string accessToken, long rfaFileId)
        {
            //GET https://api.bimface.com/data/v2/rfaFiles/{rfaFileId}/familyTypeMetas
            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/rfaFiles/{0}/familyTypeMetas", rfaFileId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                RfaFileFamilyTypeListResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<RfaFileFamilyTypeListResponse>();
                }
                else
                {
                    response = new RfaFileFamilyTypeListResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取rfa文件族类型列表]发生异常！", ex);
            }
        }
    }
}