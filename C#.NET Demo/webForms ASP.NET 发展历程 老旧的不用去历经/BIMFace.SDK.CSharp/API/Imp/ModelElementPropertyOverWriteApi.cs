// /* ---------------------------------------------------------------------------------------
//    文件名：ModelElementPropertyOverWriteApi.cs
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
    ///  模型构件属性重写API实现类（模型转换/集成成功之后，用户可能会根据自己的业务需要，将构件的属性进行重写，包括修改属性（添加或者更新属性）和删除属性，BIMFACE提供了以下四个接口支持这种能力（注意：只支持重写基本属性组以外的属性））
    /// </summary>
    public class ModelElementPropertyOverWriteApi : IModelElementPropertyOverWriteApi
    {
        /// <summary>
        ///  修改单模型指定构件的属性（支持修改（包含添加和更新）构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】单模型Id</param>
        /// <param name="elementId">【必填】构件Id</param>
        /// <param name="propertyGroups">修改的属性</param>
        /// <returns></returns>
        public virtual SingleModelElementPropertyModifyResponse ModifySingleModelElementProperty(string accessToken, long fileId, string elementId, PropertyGroup[] propertyGroups)
        {
            //PUT https://api.bimface.com/data/v2/files/{fileId}/elements/{elementId}/properties

            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/files/{0}/elements/{1}/properties", fileId, elementId);
            string data = string.Empty;
            if (propertyGroups.IsNotNullAndEmpty())
            {
                data = propertyGroups.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelElementPropertyModifyResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Put(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelElementPropertyModifyResponse>();
                }
                else
                {
                    response = new SingleModelElementPropertyModifyResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[修改单模型指定构件的属性]发生异常！", ex);
            }
        }

        /// <summary>
        ///  删除单模型指定构件的属性（支持删除构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】单模型Id</param>
        /// <param name="elementId">【必填】>构件Id</param>
        /// <param name="propertyGroups">删除的属性</param>
        /// <returns></returns>
        public virtual SingleModelElementPropertyDeleteResponse DeleteSingleModelElementProperty(string accessToken, long fileId, string elementId, PropertyGroup[] propertyGroups)
        {
            //DELETE https://api.bimface.com/data/v2/files/{fileId}/elements/{elementId}/properties

            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/files/{0}/elements/{1}/properties", fileId, elementId);
            string data = string.Empty;
            if (propertyGroups.IsNotNullAndEmpty())
            {
                data = propertyGroups.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelElementPropertyDeleteResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelElementPropertyDeleteResponse>();
                }
                else
                {
                    response = new SingleModelElementPropertyDeleteResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[修改单模型指定构件的属性]发生异常！", ex);
            }
        }

        /// <summary>
        ///  修改集成模型指定构件的属性（支持修改（包含添加和更新）构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型Id</param>
        /// <param name="fileIdHash">【必填】</param>
        /// <param name="elementId">【必填】构件Id</param>
        /// <param name="propertyGroups">修改的属性</param>
        /// <returns></returns>
        public virtual IntegrateModelElementPropertyModifyResponse ModifyIntegrateModelElementProperty(string accessToken, long integrateId, string fileIdHash, string elementId, PropertyGroup[] propertyGroups)
        {
            //PUT https://api.bimface.com/data/v2/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}/properties

            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/integrations/{0}/files/{1}/elements/{2}/properties", integrateId, fileIdHash, elementId);
            string data = string.Empty;
            if (propertyGroups.IsNotNullAndEmpty())
            {
                data = propertyGroups.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                IntegrateModelElementPropertyModifyResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Put(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<IntegrateModelElementPropertyModifyResponse>();
                }
                else
                {
                    response = new IntegrateModelElementPropertyModifyResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[修改集成模型指定构件的属性]发生异常！", ex);
            }
        }

        /// <summary>
        ///  删除集成模型指定构件的属性（支持修改（包含添加和更新）构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型Id</param>
        /// <param name="fileIdHash">【必填】</param>
        /// <param name="elementId">【必填】构件Id</param>
        /// <param name="propertyGroups">修改的属性</param>
        /// <returns></returns>
        public virtual IntegrateModelElementPropertyDeleteResponse DeleteIntegrateModelElementProperty(string accessToken, long integrateId, string fileIdHash, string elementId, PropertyGroup[] propertyGroups)
        {
            //PUT https://api.bimface.com/data/v2/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}/properties

            string url = BIMFaceConstants.API_HOST + string.Format("/data/v2/integrations/{0}/files/{1}/elements/{2}/properties", integrateId, fileIdHash, elementId);
            string data = string.Empty;
            if (propertyGroups.IsNotNullAndEmpty())
            {
                data = propertyGroups.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                IntegrateModelElementPropertyDeleteResponse response;
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<IntegrateModelElementPropertyDeleteResponse>();
                }
                else
                {
                    response = new IntegrateModelElementPropertyDeleteResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[删除集成模型指定构件的属性]发生异常！", ex);
            }
        }

    }
}