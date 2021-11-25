// /* ---------------------------------------------------------------------------------------
//    文件名：BimfaceException.cs
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

using System.Collections.Generic;

using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  文件转换接口
    /// </summary>
    public interface IFileConvertApi
    {
        #region 发起源文件/模型转换

        /// <summary>
        ///  发起转换。将DWG文件转换成矢量图纸。
        /// <para>
        ///   请求参数示例：
        ///    {
        ///      "source":{
        ///         "fileId":1402934652281952,
        ///         "compressed":false
        ///      },
        ///      "priority":2,
        ///      "callback":"http://www.app.com/receive",
        ///      "config":null
        ///    }
        /// </para> 
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">DWG文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateDwgToVectorDrawings(string accessToken, DwgFileTranslateRequest request);

        /// <summary>
        ///  发起转换。将DWG文件转换成图片。
        /// <para>
        ///   请求参数示例：
        ///   {
        ///     "source":{
        ///        "fileId":857482189666208,
        ///        "compressed":false,
        ///        "rootName":"root.dwg"
        ///     },
        ///     "priority":2,
        ///     "callback":"http://www.app.com/receive",
        ///     "config":{
        ///       "exportDrawing":false
        ///     }
        ///    }
        /// </para> 
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">DWG文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateDwgToPicture(string accessToken, DwgFileTranslateRequest request);

        /// <summary>
        ///  发起转换。将RVT文件转换成着色模式的效果。
        /// <para>
        ///   请求参数示例：
        ///    {
        ///      "source":{
        ///         "fileId":857482189666208,
        ///         "compressed":false,
        ///         "rootName":"root.rvt"
        ///      },
        ///      "priority":2,
        ///      "callback":"http://www.app.com/receive",
        ///      "config":null
        ///    }
        /// </para> 
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">RVT文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateRvtToRenderStyle(string accessToken, RvtFileTranslateRequest request);

        /// <summary>
        ///  发起转换。将RVT文件转换成真实模式的效果。
        /// <para>
        ///   请求参数示例：
        ///   {
        ///     "source":{
        ///        "fileId":857482189666208,
        ///        "compressed":false,
        ///        "rootName":"root.rvt"
        ///     },
        ///     "priority":2,
        ///     "callback":"http://www.app.com/receive",
        ///     "config":{
        ///       "texture":true
        ///     }
        ///    }
        /// </para> 
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">RVT文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateRvtToRealStyle(string accessToken, RvtFileTranslateRequest request);

        /// <summary>
        ///  发起转换。将RVT格式文件转换为具备二三维联动的功能效果。
        /// <para>
        ///   请求参数示例：
        ///   {
        ///     "source":{
        ///        "fileId":1402934652281952,
        ///        "compressed":false
        ///     },
        ///     "priority":2,
        ///     "callback":"http://www.app.com/receive",
        ///     "config":{
        ///       "texture":false
        ///       "exportDwg": true,
        ///       "exportPdf": true,
        ///       "exportDrawing": true
        ///     }
        ///    }
        /// </para> 
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">RVT文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateRvtTo23LinkStyle(string accessToken, RvtFileTranslateRequest request);

        /// <summary>
        ///  发起转换。其它三维模型文件转换，常规转换（不带材质）
        /// <para>
        ///   请求参数示例：
        ///    {
        ///      "source":{
        ///         "fileId":857482189666208,
        ///         "compressed":false,
        ///         "rootName":"root.skp"
        ///      },
        ///      "priority":2,
        ///      "callback":"http://www.app.com/receive",
        ///      "config":null
        ///    }
        /// </para> 
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">其他三维模型文件，包括RVT格式文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateOther3DModelToWithoutMaterialStyle(string accessToken, Other3DModelFileTranslateRequest request);

        /// <summary>
        ///  发起转换。
        ///  其他三维模型文件包括RVT格式文件，需要转换出引用的外部材质场景、贴图等
        /// （上传的文件必须为压缩包，压缩包内同级目录包含模型文件和关联的所有材质文件，转换时必须指定rootName为主文件）。
        /// <para>
        ///   请求参数示例：
        ///   {
        ///     "source":{
        ///        "fileId":1234621112557376,
        ///        "compressed":true,
        ///        "rootName":"bimface_2018_打包材质_系统材质库.rvt"
        ///     },
        ///     "priority":2,
        ///     "callback":"http://www.app.com/receive",
        ///     "config":{
        ///       "texture":true
        ///     }
        ///    }
        /// </para>
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">其他三维模型文件，包括RVT格式文件转化的请求数据对象。根据实际需要设置对象里面的参数，不需要的参数不用赋值</param>
        /// <returns></returns>
        FileTranslateResponse TranslateOther3DModelToWithMaterialStyle(string accessToken, Other3DModelFileTranslateRequest request);


        /// <summary>
        ///  获取转换状态(应用发起转换以后，可以通过该接口查询转换状态)
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId"></param>
        /// <returns></returns>
        FileTranslateResponse GetFileTranslateStatus(string accessToken, long fileId);

        /// <summary>
        /// 批量获取转换状态详情
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">请求体参数对象。AppKey属性必须赋值</param>
        /// <returns></returns>
        FileTranslateDetailsResponse GetFileTranslateDetails(string accessToken, TranslateQueryRequest request);

        #endregion

        #region 获取模型数据

        #region 2021110 mark by savion 请调用同名方法

        ///// <summary>
        /////  查询满足条件的构件ID列表。
        /////  BIMFACE通过接口查询模型（单模型、集成模型）的构件id列表时，默认最多返回10000条数据。模型构件量比较多的情况下，如果需要全量查询构件id列表，可以通过分页的方式。
        ///// </summary>
        ///// <param name="accessToken">【必填】令牌</param>
        ///// <param name="fileId">【必填】文件ID</param>
        ///// <param name="request">【非必填】请求参数对象</param>
        ///// <returns></returns>
        //SingleModelElementsSwaggerDisplay GetSingleModelElements(string accessToken, string fileId, FileElementsGetRequest request = null);

        #endregion

        /// <summary>
        ///  查询满足条件的构件ID列表。
        ///  BIMFACE通过接口查询模型（单模型、集成模型）的构件id列表时，默认最多返回10000条数据。模型构件量比较多的情况下，如果需要全量查询构件id列表，可以通过分页的方式。
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="categoryId">【非必填】筛选条件构件类型id</param>
        /// <param name="family">【非必填】筛选条件族</param>
        /// <param name="familyType">【非必填】筛选条件族类型</param>
        /// <param name="floor">【非必填】筛选条件楼层</param>
        /// <param name="paginationContextId">【非必填】根据paginationContextId返回构件ID列表</param>
        /// <param name="paginationNo">【非必填】返回结果中paginationNo对应的页码构件ID项。在公有云建议不传，若传的话，必须严格等于调用查询接口的次数</param>
        /// <param name="paginationSize">【非必填】返回结果按照paginationSize分页。默认1000，取值范围（0，10000]</param>
        /// <param name="roomId">【非必填】筛选条件房间id</param>
        /// <param name="roomToleranceXY">【非必填】XY坐标轴方向对构件的筛选容忍度。只能是STRICT, ORDINARY, LENIENT</param>
        /// <param name="roomToleranceZ">【非必填】Z坐标轴方向对构件的筛选容忍度。只能是STRICT, ORDINARY, LENIENT</param>
        /// <param name="specialty">【非必填】筛选条件专业</param>
        /// <param name="systemType">【非必填】筛选条件系统类型</param>
        /// <returns></returns>
        SingleModelElementsSwaggerDisplay GetSingleModelElements(string accessToken, string fileId,
                                                                 string categoryId = null,
                                                                 string family = null,
                                                                 string familyType = null,
                                                                 string floor = null,
                                                                 string paginationContextId = null,
                                                                 int? paginationNo = null,
                                                                 int? paginationSize = null,
                                                                 string roomId = null,
                                                                 string roomToleranceXY = null,
                                                                 string roomToleranceZ = null,
                                                                 string specialty = null,
                                                                 string systemType = null);

        /// <summary>
        ///  获取单个模型的单个构件材质列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <returns></returns>
        SingleModelSingleElementMaterials GetSingleModelSingleElementMaterials(string accessToken, long fileId, string elementId);

        /// <summary>
        ///  获取单个模型的单个构件属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="elementId">【必填】构件ID</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelSingleElementProperty GetSingleModelSingleElementProperty(string accessToken, long fileId, string elementId, bool? includeOverrides = null);

        /// <summary>
        ///  获取单个模型的多个构件的共同属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】代表多个模型的文件ID</param>
        /// <param name="elementIds">【必填】构件ID列表</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelMultipleElementsCommonProperties GetSingleModelMultipleElementsCommonProperties(
            string accessToken, long fileId, string[] elementIds, bool? includeOverrides = null);

        /// <summary>
        ///  获取单个模型的多个构件的共同属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="elementIds">【必填】构件ID列表</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelMultipleElementsCommonProperties GetSingleModelMultipleElementsCommonProperties(
            string accessToken, long fileId, List<string> elementIds, bool? includeOverrides = null);

        /// <summary>
        ///  批量获取单个模型的多个构件属性
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="request">【必填】请求过滤参数</param>
        /// <param name="includeOverrides">【非必填】是否查询修改的属性</param>
        /// <returns></returns>
        SingleModelMultipleElementsProperties GetSingleModelMultipleElementsProperties(
            string accessToken, long fileId, ElementPropertyFilterRequest request, bool? includeOverrides = null);

        /// <summary>
        ///  获取单个模型的楼层信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="includeArea">【非必填】是否将楼层中的面积分区ID、名称一起返回</param>
        /// <param name="includeRoom">【非必填】是否将楼层中的房间ID、名称一起返回</param>
        /// <returns></returns>
        SingleModelFloors GetSingleModelFloors(string accessToken, long fileId, bool? includeArea = null, bool? includeRoom = null);

        /// <summary>
        ///  获取多个模型的楼层信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileIds">【必填】代表多个模型的文件ID</param>
        /// <param name="includeArea">【非必填】是否将楼层中的面积分区ID、名称一起返回</param>
        /// <param name="includeRoom">【非必填】是否将楼层中的房间ID、名称一起返回</param>
        /// <returns></returns>
        MultipleModelsFloors GetMultipleModelFloors(string accessToken, string[] fileIds, bool? includeArea = null, bool? includeRoom = null);

        /// <summary>
        ///  获取模型链接信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <returns></returns>
        SingleModelLink GetSingleModelLink(string accessToken, long fileId);

        /// <summary>
        ///  获取单个模型中单个房间信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="roomId">【必填】房间ID</param>
        /// <returns></returns>
        SingleModelSingleRoom GetSingleModelSingleRoom(string accessToken, long fileId, string roomId);

        /// <summary>
        ///  获取单个模型中单个楼层对应面积分区列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="floorId">【必填】楼层ID</param>
        /// <returns></returns>
        SingleModelSingleFloorAreas GetSingleModelSingleFloorAreas(string accessToken, long fileId, string floorId);

        /// <summary>
        ///  获取单个模型中单个面积分区信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="areaId">【必填】面积分区ID</param>
        /// <returns></returns>
        SingleModelSingleArea GetSingleModelSingleArea(string accessToken, long fileId, string areaId);

        /// <summary>
        ///  获取单个模型中构件的默认分类树
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="v">【非必填】用来区别treeType为default时返回树的格式</param>
        /// <param name="request">【非必填】其他过滤参数类对象</param>
        /// <returns></returns>
        SingleModelTree GetSingleModelTreeByDefault(string accessToken, long fileId, string v = "2.0", FileTreeRequestBody request = null);

        /// <summary>
        ///  获取单个模型中构件的自定义分类树
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="v">【非必填】用来区别treeType为default时返回树的格式</param>
        /// <param name="request">【非必填】其他过滤参数类对象</param>
        /// <returns></returns>
        SingleModelTreeByCustomized GetSingleModelTreeByCustomized(string accessToken, long fileId, string v = "2.0", FileTreeRequestBody request = null);

        SingleModelTree GetSingleModelTree(string accessToken, long fileId, TreeType treeType = TreeType.Default, string v = "2.0", FileTreeRequestBody request = null);

        /// <summary>
        ///  获取三维视点或二维视图列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <returns></returns>
        SingleModelViews GetSingleModelViews(string accessToken, long fileId);

        /// <summary>
        ///  获取单个模型的图纸列表。
        ///  如果请求参数elementId为null，返回所有图纸，否则返回包含该构件的所有图纸
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="elementId">【非必填】构件ID</param>
        /// <returns></returns>
        SingleModelDrawingSheets GetSingleModelDrawingSheets(string accessToken, long fileId, string elementId = null);

        #endregion

        #region 获取图纸信息

        /// <summary>
        /// 通过图纸文件ID，按图框拆分图纸。
        /// （提示：图纸拆分必须在【图纸转换】接口完成且转换状态为 success 之后才能发起，拆分是在转换成功的基础之上进行的）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】代表该单图纸的文件ID</param>
        /// <param name="callbak">【选填】回调url。图纸拆分是一个耗时的操作，并不能立刻完成。可以通过回调地址通知拆分结果</param>
        /// <returns></returns>
        SplitDrawingResponse SplitDrawing(string accessToken, long fileId, string callbak = "");

        /// <summary>
        ///  获取图纸拆分状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】代表该单图纸的文件ID</param>
        /// <returns></returns>
        SplitDrawingResponse GetSplitDrawingStatus(string accessToken, long fileId);

        /// <summary>
        ///  获取图纸拆分结果
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="fileId"></param>
        /// <returns></returns>
        SplitDrawingResultResponse GetSplitDrawingResult(string accessToken, long fileId);

        #endregion
    }
}