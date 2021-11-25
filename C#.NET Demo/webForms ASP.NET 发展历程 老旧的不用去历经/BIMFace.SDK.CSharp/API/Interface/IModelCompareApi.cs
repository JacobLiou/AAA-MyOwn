// /* ---------------------------------------------------------------------------------------
//    文件名：IModelCompareApi.cs
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

using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  模型对比接口
    /// </summary>
    public interface IModelCompareApi
    {
        #region 模型对比相关

        /// <summary>
        ///  不同版本的模型文件上传并转换成功后，即可发起模型对比。由于对比不能立即完成，BIMFace支持在模型对比完成以后，通过Callback机制通知应用；另外，应用也可以通过接口查询对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="followingId">修改后图纸(当前本班，本轮)模型文件ID</param>
        /// <param name="previousId">修改前图纸(历史版本，上一轮次)模型文件ID</param>
        /// <returns></returns>
        ModelCompareResponse Compare(string accessToken, long followingId, long previousId);

        /// <summary>
        ///  不同版本的模型文件上传并转换成功后，即可发起模型对比。由于对比不能立即完成，BIMFace支持在模型对比完成以后，通过Callback机制通知应用；另外，应用也可以通过接口查询对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">对比时的请求参数</param>
        /// <returns></returns>
        ModelCompareResponse Compare(string accessToken, CompareRequest request);

        /// <summary>
        /// 应用发起对比以后，可以通过该接口查询对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比ID</param>
        /// <returns></returns>
        ModelCompareResponse GetCompareStatus(string accessToken, long compareId);

        /// <summary>
        ///  批量获取模型对比状态
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="request">【必填】批量获取模型对比状态的请求参数</param>
        /// <returns></returns>
        ModelCompareQueryResponse GetCompareStatusList(string accessToken, ModelCompareQueryRequest request);

        /// <summary>
        ///  删除模型对比
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】模型对比ID</param>
        /// <returns></returns>
        DeleteModelCompareResponse DeleteModelCompare(string accessToken, long compareId);

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
        ModelCompareChangeResponse GetModelCompareChange(string accessToken, long compareId,
                                                         long followingFileId, string followingElementId,
                                                         long previousFileId, string previousElementId);

        /// <summary>
        ///  获取模型对比构件分类树
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <returns></returns>
        ModelCompareTreeResponse GetModelCompareTree(string accessToken, long compareId);

        /// <summary>
        ///  分页获取模型对比结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="elementName">构件名称</param>
        /// <param name="family">族名称</param>
        /// <param name="page">页码（提示：私有云部署不支持分页查询）</param>
        /// <param name="pageSize">每页记录数（提示：私有云部署不支持分页查询）</param>
        /// <returns></returns>
        ModelCompareDiffResponse GetModelCompareDiff(string accessToken, long compareId, string elementName = "",
                                                     string family = "", int? page = null, int? pageSize = null);

        /// <summary>
        /// 获取模型对比的所有结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="elementName">构件名称</param>
        /// <param name="family">族名称</param>
        /// <returns></returns>
        ModelCompareDiffResponse GetModelCompareDiffAll(string accessToken, long compareId, string elementName = "",string family = "");

        /// <summary>
        ///  分页获取二维图纸对比结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <param name="page">页码（提示：私有云部署不支持分页查询）</param>
        /// <param name="pageSize">每页记录数（提示：私有云部署不支持分页查询）</param>
        /// <returns></returns>
        DrawingCompareDiffResponse GetDrawingCompareDiff(string accessToken, long compareId, int? page = null, int? pageSize = null);

        /// <summary>
        /// 获取二维图纸对比的所有结果
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="compareId">【必填】对比ID</param>
        /// <returns></returns>
        DrawingCompareDiffResponse GetDrawingCompareDiffAll(string accessToken, long compareId);


        #endregion
    }
}