// /* ---------------------------------------------------------------------------------------
//    文件名：IModelIntegrateApi.cs
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

using System.Collections.Generic;

using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    /// 模型集成API接口
    /// </summary>
    public interface IModelIntegrateApi
    {
        #region 模型集成发起相关

        /// <summary>
        /// 发起模型集成。
        /// 对于参与集成的文件来说，当单个文件转换成功以后，可以将多个文件集成，生成一个全专业/楼层模型。
        /// 由于集成不能立即完成，BIMFACE支持在模型集成完成以后，通过Callback机制通知调用方；另外，调用方也可以通过接口查询集成状态。
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">集成时的请求参数</param>
        /// <returns></returns>
        ModelIntegrateResponse Integrate(string accessToken, FileIntegrateRequest request);

        /// <summary>
        /// 调用方发起集成以后，可以通过该接口查询集成状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">集成模型id</param>
        /// <returns></returns>
        ModelIntegrateResponse GetIntegrateStatus(string accessToken, long integrateId);

        /// <summary>
        ///  批量获取模型集成状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">【必填】批量获取模型集成状态的请求参数</param>
        /// <returns></returns>
        ModelIntegrateQueryResponse GetIntegrateStatusList(string accessToken, IntegrateQueryRequest request);

        /// <summary>
        /// 根据集成模型id删除集成模型
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">集成模型id</param>
        /// <returns></returns>
        ModelIntegrateDeleteResponse DeleteModelIntegrate(string accessToken, long integrateId);

        #endregion

        #region 集成模型数据

        /// <summary>
        ///  查询满足条件的构件ID列表（根据六个维度（专业，系统类型，楼层，构件类型，族，族类型）获取对应的构件ID列表，任何维度都是可选的。）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="request">【非必填】请求参数对象</param>
        /// <returns></returns>
        SingleIntegrateModelElements GetSingleIntegrateModelElements(string accessToken, string integrateId, FileElementsGetRequest request = null);

        /// <summary>
        ///  获取单个集成模型的单个构件材质列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="fileIdHash">【必填】子文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <returns></returns>
        SingleModelSingleElementMaterials GetSingleModelSingleElementMaterials(string accessToken, long integrateId, string fileIdHash, string elementId);

        /// <summary>
        /// 计算指定构件列表的包围盒
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="fileIdWithEleIdList">构件ID列表,由','分隔.每个构件ID由fileID和elementID组成</param>
        /// <returns></returns>
        ElementsBoundingBoxesCalcResponse CalcElementsBoundingBoxes(string accessToken, long integrateId, string[] fileIdWithEleIdList);

        /// <summary>
        ///  获取单个集成模型的单个构件属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelSingleElementProperty GetSingleModelSingleElementProperty(string accessToken, long integrateId, string elementId, bool? includeOverrides = null);

        /// <summary>
        ///  获取单个模型的多个构件的共同属性
        /// （若传入的elementId不止一个，则返回这些elementId共同的属性，共同的定义为：属性key与value都相等支持查询模型属性重写后多个构件的共同属性，需要设置请求参数includeOverrides的值为true）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="fileIdHashWithElementIdsL"></param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelMultipleElementsCommonProperties GetSingleModelMultipleElementsCommonProperties(string accessToken, long integrateId, FileIdHashWithElementIds[] fileIdHashWithElementIdsL = null, bool? includeOverrides = null);

        /// <summary>
        /// 获取子文件/链接内的指定构件的属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成文件ID</param>
        /// <param name="fileIdHash">【必填】子文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelSingleElementProperty GetSingleSubModelSingleElementProperty(string accessToken, long integrateId, string fileIdHash, string elementId, bool? includeOverrides = null);

        /// <summary>
        ///  获取单个模型的楼层列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="includeArea">【非必填】是否将楼层中的面积分区ID、名称一起返回</param>
        /// <param name="includeRoom">【非必填】是否将楼层中的房间ID、名称一起返回</param>
        /// <returns></returns>
        SingleModelFloors GetSingleModelFloors(string accessToken, long integrateId, bool? includeArea = null, bool? includeRoom = null);

        /// <summary>
        ///  获取参与集成的子文件列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="includeDrawingSheet">【非必填】是否将文件下转换出的图纸数量一起返回</param>
        /// <returns></returns>
        SingleIntegrateModeSubFiles GetSingleIntegrateModeSubFiles(string accessToken, long integrateId, bool? includeDrawingSheet = null);

        /// <summary>
        ///  获取指定房间的属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="roomId">【必填】房间ID</param>
        /// <returns></returns>
        SingleModelSingleRoom GetSingleModelSingleRoom(string accessToken, long integrateId, string roomId);

        /// <summary>
        ///  获取楼层对应面积分区列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="floorId">【必填】楼层ID</param>
        /// <returns></returns>
        SingleModelSingleFloorAreas GetSingleModelSingleFloorAreas(string accessToken, long integrateId, string floorId);

        /// <summary>
        ///  获取单个模型中单个面积分区信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】代表该单模型的文件ID</param>
        /// <param name="areaId">【必填】面积分区ID</param>
        /// <returns></returns>
        SingleModelSingleArea GetSingleModelSingleArea(string accessToken, long integrateId, string areaId);

        /// <summary>
        ///  获取分类树
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="treeType">分类树的类型。仅接受三个值：floor, specialty和customized</param>
        /// <param name="desiredHierarchy">分类树的层次结构。例如：[ [ "string" ] ]</param>
        /// <param name="request">其他请求参数</param>
        /// <returns></returns>
        SingleModelTree GetSingleModelTree(string accessToken, long integrateId, TreeType treeType = TreeType.Floor, List<List<string>> desiredHierarchy = null, IntegrationTreeOptionalRequestBody request = null);

        /// <summary>
        ///  获取视图信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成ID</param>
        /// <param name="viewType">视图类型。当viewType = ViewType.None值时，则返回所有集合</param>
        /// <returns></returns>
        SingleIntegrateModelViews GetSingleModelViews(string accessToken, long integrateId, ViewType viewType = ViewType.None);

        #endregion

    }
}