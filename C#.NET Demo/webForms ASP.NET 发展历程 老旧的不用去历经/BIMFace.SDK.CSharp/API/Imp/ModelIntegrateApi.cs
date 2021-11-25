// /* ---------------------------------------------------------------------------------------
//    文件名：ModelIntegrateApi.cs
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
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    /// 模型集成API实现类
    /// </summary>
    public class ModelIntegrateApi : IModelIntegrateApi
    {
        #region 模型集成介绍
        /*官方地址：https://static.bimface.com/restful-apidoc/dist/modelIntegration.html#%E6%A8%A1%E5%9E%8B%E9%9B%86%E6%88%90%E5%8F%91%E8%B5%B7%E7%9B%B8%E5%85%B3
         *
           随着建筑信息化模型技术的发展，越来越多的人选择在云端浏览建筑模型。现阶段的云端模型浏览大多是基于文件级别， 一次只可以浏览一个模型文件中的内容。而在工程项目模型设计的过程中，通常由多个设计师协同设计， 不同的设计师负责不同的专业领域（例如建筑、结构、水电等）。
           如果想要在云端浏览整个项目工程， 就需要把这些组成部分集成起来一起展示。更近一步，如果要在集成的模型之上进行业务集成的话， 就要求在集成过程中对构件按单体，楼层，专业，构件分类，系统类型等进行分类或映射。
           
           现有的最接近的方案一般是用Revit建模，然后再把多专业的模型导入到Navisworks中，但这样的方法有如下的缺点:
           (1)即使是满足浏览模型的需求，也需要安装Revit以及Navisworks软件。
           (2)在Navisworks里进行的模型导入只做了几何的导入集成，不支持上面提到的建筑领域各种分类信息。
           (3)只支持Windows操作系统，不支持桌面端的MacOS, Linux等操作系统以及移动端的iOS和安卓操作系统。
           
           针对上述的限制，BIMFACE的模型集成，能完美解决上述的所有问题。
           
           在业务方面，BIMFACE的模型集成能：
           (1)集成不同专业的模型，包括建筑、结构、装修、幕墙、钢构，以及机电中给排水、采暖燃气、通风空调、消防、强弱电等各专业。        
           (2)自定义楼层映射
           (3)支持单体，系统类型，构件类型等其他分类维度
           (4)支持模型链接集成，如带标准层的集成模型
           (5)支持自定义文件转换矩阵（transform）
           
           在技术方法，BIMFACE的模型集成充分运用了云端无穷的计算资源，在模型集成过程中：
           (1)运用图形几何算法进行了如下优化，大大提升在浏览器里能展示模型的规模以及渲染的性能:
             ·识别基本体
             ·实例绘制优化
             ·同材质全场景动态合并
             ·外围壳光线追踪识别
           (2)构件属性在云端进行入库索引，提供任意的属性查询能力。
         */
        #endregion

        #region 模型集成发起相关 
        /// <summary>
        /// 发起模型集成。
        /// 对于参与集成的文件来说，当单个文件转换成功以后，可以将多个文件集成，生成一个全专业/楼层模型。
        /// 由于集成不能立即完成，BIMFACE支持在模型集成完成以后，通过Callback机制通知调用方；另外，调用方也可以通过接口查询集成状态。
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">集成时的请求参数</param>
        /// <returns></returns>
        public virtual ModelIntegrateResponse Integrate(string accessToken, FileIntegrateRequest request)
        {
            //PUT https://api.bimface.com/integrate
            string url = BIMFaceConstants.API_HOST + "/integrate";
            string data = request.SerializeToJson();

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelIntegrateResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Put(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelIntegrateResponse>();
                }
                else
                {
                    response = new ModelIntegrateResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[发起模型集成]发生异常！", ex);
            }
        }

        /// <summary>
        /// 调用方发起集成以后，可以通过该接口查询集成状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">集成模型id</param>
        /// <returns></returns>
        public virtual ModelIntegrateResponse GetIntegrateStatus(string accessToken, long integrateId)
        {
            //GET https: //api.bimface.com/integrate
            string url = BIMFaceConstants.API_HOST + "/integrate?integrateId=" + integrateId;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelIntegrateResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelIntegrateResponse>();
                }
                else
                {
                    response = new ModelIntegrateResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[查询集成状态]发生异常！", ex);
            }
        }

        /// <summary>
        ///  批量获取模型集成状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">【必填】批量获取模型集成状态的请求参数</param>
        /// <returns></returns>
        public virtual ModelIntegrateQueryResponse GetIntegrateStatusList(string accessToken, IntegrateQueryRequest request)
        {
            //POST https://api.bimface.com/integrateDetails
            string url = BIMFaceConstants.API_HOST + "/integrateDetails";
            string data = request.SerializeToJson();
            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelIntegrateQueryResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelIntegrateQueryResponse>();
                }
                else
                {
                    response = new ModelIntegrateQueryResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[批量获取模型集成状态]发生异常！", ex);
            }
        }

        /// <summary>
        /// 根据集成模型id删除集成模型
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">集成模型id</param>
        /// <returns></returns>
        public virtual ModelIntegrateDeleteResponse DeleteModelIntegrate(string accessToken, long integrateId)
        {
            //DELETE https: //api.bimface.com/integrate
            string url = BIMFaceConstants.API_HOST + "/integrate?integrateId=" + integrateId;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ModelIntegrateDeleteResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ModelIntegrateDeleteResponse>();
                }
                else
                {
                    response = new ModelIntegrateDeleteResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[删除模型集成]发生异常！", ex);
            }
        }

        #endregion

        #region 集成模型数据
        /// <summary>
        ///  查询满足条件的构件ID列表（根据六个维度（专业，系统类型，楼层，构件类型，族，族类型）获取对应的构件ID列表，任何维度都是可选的。）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="request">【非必填】请求参数对象</param>
        /// <returns></returns>
        public virtual SingleIntegrateModelElements GetSingleIntegrateModelElements(string accessToken, string integrateId, FileElementsGetRequest request = null)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/elementIds
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/elementIds", integrateId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            string data = string.Empty;
            if (request != null)
            {
                data = request.SerializeToJson();
            }

            try
            {
                SingleIntegrateModelElements response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleIntegrateModelElements>();
                }
                else
                {
                    response = new SingleIntegrateModelElements
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
        ///  获取单个集成模型的单个构件材质列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="fileIdHash">【必填】子文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <returns></returns>
        public virtual SingleModelSingleElementMaterials GetSingleModelSingleElementMaterials(string accessToken, long integrateId, string fileIdHash, string elementId)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}/materials
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/files/{1}/elements/{2}/materials", integrateId, fileIdHash, elementId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelSingleElementMaterials response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelSingleElementMaterials>();
                }
                else
                {
                    response = new SingleModelSingleElementMaterials
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取构件材质列表]发生异常！", ex);
            }
        }

        /// <summary>
        /// 计算指定构件列表的包围盒
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="fileIdWithEleIdList">构件ID列表,由','分隔.每个构件ID由fileID和elementID组成</param>
        /// <returns></returns>
        public virtual ElementsBoundingBoxesCalcResponse CalcElementsBoundingBoxes(string accessToken, long integrateId, string[] fileIdWithEleIdList)
        {
            //GET https://api.bimface.com/data/integrations/{integrateId}/elements/boundingboxes

            string url = string.Format(BIMFaceConstants.API_HOST + "/data/integrations/{0}/elements/boundingboxes", integrateId);
            string data = string.Empty;
            if (fileIdWithEleIdList.IsNotNullAndEmpty())
            {
                data = fileIdWithEleIdList.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                ElementsBoundingBoxesCalcResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<ElementsBoundingBoxesCalcResponse>();
                }
                else
                {
                    response = new ElementsBoundingBoxesCalcResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[计算指定构件列表的包围盒]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取单个集成模型的单个构件属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        public virtual SingleModelSingleElementProperty GetSingleModelSingleElementProperty(string accessToken, long integrateId, string elementId, bool? includeOverrides = null)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/elements/{elementId}
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/elements/{1}", integrateId, elementId);
            if (includeOverrides != null)
            {
                url = url + "?includeOverrides=" + includeOverrides;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelSingleElementProperty response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelSingleElementProperty>();
                }
                else
                {
                    response = new SingleModelSingleElementProperty
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取指定构件的属性]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取单个模型的多个构件的共同属性
        /// （若传入的elementId不止一个，则返回这些elementId共同的属性，共同的定义为：属性key与value都相等支持查询模型属性重写后多个构件的共同属性，需要设置请求参数includeOverrides的值为true）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="fileIdHashWithElementIdsL"></param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        public virtual SingleModelMultipleElementsCommonProperties GetSingleModelMultipleElementsCommonProperties(string accessToken, long integrateId, FileIdHashWithElementIds[] fileIdHashWithElementIdsL = null, bool? includeOverrides = null)
        {
            // POST https://api.bimface.com/data/v2/integrations/{integrateId}/commonElementProperties
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/commonElementProperties", integrateId);
            if (includeOverrides != null)
            {
                url = url + "&includeOverrides=" + includeOverrides;
            }

            string data = string.Empty;
            if (fileIdHashWithElementIdsL.IsNotNullAndEmpty())
            {
                data = fileIdHashWithElementIdsL.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelMultipleElementsCommonProperties response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelMultipleElementsCommonProperties>();
                }
                else
                {
                    response = new SingleModelMultipleElementsCommonProperties
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取多个构件的公共属性]发生异常！", ex);
            }
        }

        /// <summary>
        /// 获取子文件/链接内的指定构件的属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成文件ID</param>
        /// <param name="fileIdHash">【必填】子文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        public virtual SingleModelSingleElementProperty GetSingleSubModelSingleElementProperty(string accessToken, long integrateId, string fileIdHash, string elementId, bool? includeOverrides = null)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/files/{1}/elements/{2}", integrateId, fileIdHash, elementId);
            if (includeOverrides != null)
            {
                url = url + "?includeOverrides=" + includeOverrides;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelSingleElementProperty response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelSingleElementProperty>();
                }
                else
                {
                    response = new SingleModelSingleElementProperty
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取子文件/链接内的指定构件的属性]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取单个模型的楼层列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="includeArea">【非必填】是否将楼层中的面积分区ID、名称一起返回</param>
        /// <param name="includeRoom">【非必填】是否将楼层中的房间ID、名称一起返回</param>
        /// <returns></returns>
        public virtual SingleModelFloors GetSingleModelFloors(string accessToken, long integrateId, bool? includeArea = null, bool? includeRoom = null)
        {
            //GET https://api.bimface.com/data/v2/integrations/{integrateId}/floors
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/floors", integrateId);
            if (includeArea != null && includeRoom == null)
            {
                url = url + "?includeArea=" + includeArea;
            }
            else if (includeArea == null && includeRoom != null)
            {
                url = url + "?includeRoom=" + includeRoom;
            }
            else if (includeArea != null && includeRoom != null)
            {
                url = url + "?includeArea=" + includeArea + "&includeRoom=" + includeRoom.ToString();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelFloors response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelFloors>();
                }
                else
                {
                    response = new SingleModelFloors
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取楼层列表]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取参与集成的子文件列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="includeDrawingSheet">【非必填】是否将文件下转换出的图纸数量一起返回</param>
        /// <returns></returns>
        public virtual SingleIntegrateModeSubFiles GetSingleIntegrateModeSubFiles(string accessToken, long integrateId, bool? includeDrawingSheet = null)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/files
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/files", integrateId);
            if (includeDrawingSheet.HasValue)
            {
                url = url + "?includeDrawingSheet=" + includeDrawingSheet;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleIntegrateModeSubFiles response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleIntegrateModeSubFiles>();
                }
                else
                {
                    response = new SingleIntegrateModeSubFiles
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取参与集成的子文件列表]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取指定房间的属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="roomId">【必填】房间ID</param>
        /// <returns></returns>
        public virtual SingleModelSingleRoom GetSingleModelSingleRoom(string accessToken, long integrateId, string roomId)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/rooms/{roomId}
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/rooms/{1}", integrateId, roomId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelSingleRoom response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelSingleRoom>();
                }
                else
                {
                    response = new SingleModelSingleRoom
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取指定房间的属性]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取楼层对应面积分区列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="floorId">【必填】楼层ID</param>
        /// <returns></returns>
        public virtual SingleModelSingleFloorAreas GetSingleModelSingleFloorAreas(string accessToken, long integrateId, string floorId)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/areas
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/areas?floorId={1}", integrateId, floorId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelSingleFloorAreas response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelSingleFloorAreas>();
                }
                else
                {
                    response = new SingleModelSingleFloorAreas
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取楼层对应面积分区列表]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取单个模型中单个面积分区信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】代表该单模型的文件ID</param>
        /// <param name="areaId">【必填】面积分区ID</param>
        /// <returns></returns>
        public virtual SingleModelSingleArea GetSingleModelSingleArea(string accessToken, long integrateId, string areaId)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/areas/{areaId}
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/areas/{1}", integrateId, areaId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelSingleArea response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelSingleArea>();
                }
                else
                {
                    response = new SingleModelSingleArea
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取单个面积分区信息]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取分类树
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="treeType">分类树的类型。仅接受三个值：floor, specialty和customized</param>
        /// <param name="desiredHierarchy">分类树的层次结构。例如：[ [ "string" ] ]</param>
        /// <param name="request">其他请求参数</param>
        /// <returns></returns>
        public virtual SingleModelTree GetSingleModelTree(string accessToken, long integrateId, TreeType treeType = TreeType.Floor, List<List<string>> desiredHierarchy = null, IntegrationTreeOptionalRequestBody request = null)
        {
            /* 单模型构件分类树,
              （集成模型默认楼层分类树(v2.0), treeType接受三个值：floor, specialty和customized, 当treeType为"customized", 则desiredHierarchy表示了筛选树的层次，如：desiredHierarchy=specialty,systemtype
            */

            string tempTreeType = TreeType.Default.ToString().ToLower(); //treeType == TreeType.Default ? "default" : "customized";

            // POST https://api.bimface.com/data/v2/integrations/{integrateId}/tree
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/tree", integrateId, tempTreeType);
            url += "?treeType=" + treeType;

            string data = string.Empty;
            if (request != null)
            {
                data = request.SerializeToJson();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleModelTree response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Post(url, data);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleModelTree>();
                }
                else
                {
                    response = new SingleModelTree
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取分类树]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取视图信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="viewType">视图类型。当viewType = ViewType.None值时，则返回所有集合</param>
        /// <returns></returns>
        public virtual SingleIntegrateModelViews GetSingleModelViews(string accessToken, long integrateId, ViewType viewType = ViewType.None)
        {
            // GET https://api.bimface.com/data/v2/integrations/{integrateId}/fileViews
            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/fileViews", integrateId);
            if (viewType != ViewType.None)
            {
                url += "?viewType=" + viewType.ToString();
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                SingleIntegrateModelViews response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<SingleIntegrateModelViews>();
                }
                else
                {
                    response = new SingleIntegrateModelViews
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取视图信息]发生异常！", ex);
            }
        }

        #endregion
    }
}