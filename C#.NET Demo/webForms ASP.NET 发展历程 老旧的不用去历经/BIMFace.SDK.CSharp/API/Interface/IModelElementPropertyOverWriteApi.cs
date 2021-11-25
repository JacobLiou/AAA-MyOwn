// /* ---------------------------------------------------------------------------------------
//    文件名：IModelElementPropertyOverWriteApi.cs
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

using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    /// 模型构件属性重写API接口
    /// </summary>
    public interface IModelElementPropertyOverWriteApi
    {
        /// <summary>
        ///  修改单模型指定构件的属性（支持修改（包含添加和更新）构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】单模型Id</param>
        /// <param name="elementId">【必填】构件Id</param>
        /// <param name="propertyGroups">修改的属性</param>
        /// <returns></returns>
        SingleModelElementPropertyModifyResponse ModifySingleModelElementProperty(string accessToken, long fileId, string elementId, PropertyGroup[] propertyGroups);

        /// <summary>
        ///  删除单模型指定构件的属性（支持删除构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】单模型Id</param>
        /// <param name="elementId">【必填】>构件Id</param>
        /// <param name="propertyGroups">删除的属性</param>
        /// <returns></returns>
        SingleModelElementPropertyDeleteResponse DeleteSingleModelElementProperty(string accessToken, long fileId, string elementId, PropertyGroup[] propertyGroups);

        /// <summary>
        ///  修改集成模型指定构件的属性（支持修改（包含添加和更新）构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型Id</param>
        /// <param name="fileIdHash">【必填】</param>
        /// <param name="elementId">【必填】构件Id</param>
        /// <param name="propertyGroups">修改的属性</param>
        /// <returns></returns>
        IntegrateModelElementPropertyModifyResponse ModifyIntegrateModelElementProperty(string accessToken, long integrateId, string fileIdHash, string elementId, PropertyGroup[] propertyGroups);

        /// <summary>
        ///  删除集成模型指定构件的属性（支持修改（包含添加和更新）构件基本属性组以外的属性）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型Id</param>
        /// <param name="fileIdHash">【必填】</param>
        /// <param name="elementId">【必填】构件Id</param>
        /// <param name="propertyGroups">修改的属性</param>
        /// <returns></returns>
        IntegrateModelElementPropertyDeleteResponse DeleteIntegrateModelElementProperty(string accessToken, long integrateId, string fileIdHash, string elementId, PropertyGroup[] propertyGroups);
    }
}