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

using System.IO;

using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    /// 文件操作接口
    /// </summary>
    public interface IFileApi
    {
        #region 源文件相关

        #region 源文件上传

        /// <summary>
        ///  普通文件流上传【不推荐使用该方式。推荐使用文件直传 UploadFileByPolicy()方法】
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileName">【必填】文件的名称(不包含路径)</param>
        /// <param name="fileStream">文件流</param>
        /// <param name="sourceId">【可选】调用方的文件源ID，不能重复</param>
        /// <returns></returns>
        FileUploadResponse UploadFileByStream(string accessToken, string fileName, Stream fileStream,string sourceId = "");

        /// <summary>
        ///  指定外部文件url方式上传文件
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileName">【必填】文件的全名</param>
        /// <param name="fileUrl">【必填】文件所在url</param>
        /// <param name="sourceId">【可选】调用方的文件源ID，不能重复</param>
        /// <param name="etag">【可选】文件etag</param>
        /// <returns></returns>
        FileUploadResponse UploadFileByUrl(string accessToken, string fileName, string fileUrl, string sourceId = "",string etag = "");

        #endregion

        #region 文件直传

        /// <summary>
        ///  获取文件直传的policy凭证。
        /// 【特别提醒：BIMFACE公有云支持文件直传。私有化部署时使用的对象存储是 MinIO，不支持 Policy 上传。使用普通文件流上传 或者 指定外部文件URL方式上传。】
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileName">【必填】文件的全名</param>
        /// <param name="sourceId">【可选】调用方的文件源ID，不能重复</param>
        /// <returns></returns>
        FileUploadPolicyResponse GetFileUploadPolicy(string accessToken, string fileName, string sourceId = "");

        /// <summary>
        ///  通过文件直传的policy凭证，直接上传文件【推荐使用该方式】。
        /// 【特别提醒：BIMFACE公有云支持文件直传。私有化部署时使用的对象存储是 MinIO，不支持 Policy 上传。使用普通文件流上传 或者 指定外部文件URL方式上传。】
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileFullName">【必填】待上传的文件(包含全路径的完全限定名)</param>
        /// <returns></returns>
        FileUploadResponse UploadFileByPolicy(string accessToken, string fileFullName);

        #endregion

        #region 断点续传(未实现)
        #endregion

        #region 源文件信息获取

        /// <summary>
        ///   根据文件ID获取文件详细信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        FileInfoGetResponse GetFileInfo(string accessToken, long fileId);

        /// <summary>
        ///  获取文件信息列表
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="startTime">起始日期,格式为 yyyy-MM-dd。默认为空，查询所有</param>
        /// <param name="endTime">截止日期,格式为 yyyy-MM-dd。默认为空，查询所有</param>
        /// <param name="rows">查询结果数, 默认为100， 最大500。默认100</param>
        /// <param name="offset">查询结果偏移，从查询结果的第offset条开始返回数据。默认-1，查询所有</param>
        /// <param name="status">文件状态,uploading，success，failure。默认为空，查询所有</param>
        /// <param name="suffix">文件后缀。默认为空，查询所有</param>
        /// <returns></returns>
        FileInfoListGetResponse GetFileInfoList(string accessToken, string startTime = "", string endTime = "", long rows = 100, long offset = -1, string status = "", string suffix = "");

        /// <summary>
        ///  获取文件上传状态信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        FileUploadStatusResponse GetFileUploadStatus(string accessToken, long fileId);

        /// <summary>
        ///  获取应用支持的文件类型
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        FileSupportResponse GetFileSupport(string accessToken);

        #endregion

        #region 源文件下载

        /// <summary>
        ///  获取文件下载链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <param name="name">文件名称</param>
        /// <returns></returns>
        FileDownloadUrlGetResponse GetFileDownloadUrl(string accessToken, long fileId, string name = "");

        #endregion

        #region 源文件删除

        /// <summary>
        ///  根据文件ID删除文件
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        FileDeleteResponse DeleteFile(string accessToken, long fileId);

        #endregion

        #endregion
    }
}