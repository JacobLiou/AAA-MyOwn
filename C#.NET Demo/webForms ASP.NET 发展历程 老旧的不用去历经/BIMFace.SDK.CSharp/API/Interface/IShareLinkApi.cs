// /* ---------------------------------------------------------------------------------------
//    文件名：IShareLinkApi.cs
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

using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  分享链接API接口
    /// </summary>
    public interface IShareLinkApi
    {
        /// <summary>
        ///  文件发起转换以后，可以根据fileId生成该文件的分享链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="activeHours">有效时长（与有效期限，二选一），单位：小时，如果不设置表示永久有效</param>
        /// <param name="expireDate">有效期限（与有效时长，二选一），单位：精确到天，如果不设置表示永久有效</param>
        /// <param name="needPassword">分享链接是否生成访问密码</param>
        /// <returns></returns>
        ShareLinkResponse CreateShareLinkByFileId(string accessToken, long fileId, int? activeHours = null,
                                                  string expireDate = null, bool? needPassword = null);

        /// <summary>
        ///  发起集成模型以后，可以根据integrateId生成集成模型的分享链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】集成模型ID </param>
        /// <param name="activeHours">有效时长（与有效期限，二选一），单位：小时，如果不设置表示永久有效</param>
        /// <param name="expireDate">有效期限（与有效时长，二选一），单位：精确到天，如果不设置表示永久有效</param>
        /// <param name="needPassword">分享链接是否生成访问密码</param>
        /// <returns></returns>
        ShareLinkResponse CreateShareLinkByIntegrateId(string accessToken, long integrateId, int? activeHours = null,
                                                       string expireDate = null, bool? needPassword = null);

        /// <summary>
        ///  通过文件Id获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        ShareLinkResponse GetShareLinkByFileId(string accessToken, long fileId);

        /// <summary>
        ///  通过集成模型ID获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">集成模型ID</param>
        /// <returns></returns>
        ShareLinkResponse GetShareLinkByIntegrateId(string accessToken, long integrateId);

        /// <summary>
        ///  通过分享链接的识别码获取分享链接信息，包括有效期、访问密码、访问地址
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="token">分享链接的识别码</param>
        /// <returns></returns>
        ShareLinkResponse GetShareLinkByToken(string accessToken, string token);


        /// <summary>
        ///  获取Appkey下显示的分享列表（包含分页信息）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="pageNo">当前页码（默认为第1页）</param>
        /// <param name="pageSize">每页显示条数（默认为20条）</param>
        /// <returns></returns>
        ShareLinkListResponse GetShareLinkPagedList(string accessToken, int pageNo = 1, int pageSize = 20);

        /// <summary>
        ///  获取Appkey下显示所有的分享列表（包含分页信息）
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <returns></returns>
        ShareLinkListResponse GetShareLinkAllList(string accessToken);

        /// <summary>
        ///  取消分享链接。若不希望继续分享，可以根据fileId取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】fileId</param>
        /// <returns></returns>
        DeleteShareLinkResponse DeleteShareLinkByFileId(string accessToken, long fileId);

        /// <summary>
        ///  取消分享链接。若不希望继续分享，可以根据integrateId取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填integrateId</param>
        /// <returns></returns>
        DeleteShareLinkResponse DeleteShareLinkByIntegrateId(string accessToken, long integrateId);

        /// <summary>
        ///  批量取消分享链接。若不希望继续分享，可以根据sourceId批量取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="sourceIds">sourceId集合</param>
        /// <returns></returns>
        BatchDeleteShareLinkResponse BatchDeleteShareLink(string accessToken, long[] sourceIds);

        /// <summary>
        ///  批量取消分享链接。若不希望继续分享，可以根据sourceId批量取消对应的分享链接，使之失效
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="sourceIds">sourceId集合</param>
        /// <returns></returns>
        BatchDeleteShareLinkResponse BatchDeleteShareLink(string accessToken, List<long> sourceIds);
    }
}