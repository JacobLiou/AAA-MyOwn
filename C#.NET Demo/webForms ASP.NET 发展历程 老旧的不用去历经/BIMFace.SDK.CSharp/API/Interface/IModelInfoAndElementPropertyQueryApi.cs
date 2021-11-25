// /* ---------------------------------------------------------------------------------------
//    文件名：IModelInfoAndElementPropertyQueryApi.cs
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
{  /// <summary>
    ///  模型信息和构件属性查询API接口
    /// </summary>
    public interface IModelInfoAndElementPropertyQueryApi
    {
        /// <summary>
        ///  查询符合条件的构件ID列表。
        ///  支持查询模型属性重写后符合条件的构件ID列表，需要设置请求参数includeOverrides的值为true
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="dsl">【必填】查询DSL</param>
        /// <param name="includeOverrid">是否查询修改的属性</param>
        /// <returns></returns>
        QueryElementIdsResponse QueryElementIds(string accessToken, string dsl, bool includeOverrid = false);

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
        QueryPropertyValuesResponse QueryPropertyValues(string accessToken, string[] properties, string[] targetIds, string targetType = "file", bool includeOverrid = false);

        /// <summary>
        /// 生成分页查询的ContextId
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <returns></returns>
        QueryPaginationContextIdResponse QueryPaginationContextId(string accessToken);
    }
}