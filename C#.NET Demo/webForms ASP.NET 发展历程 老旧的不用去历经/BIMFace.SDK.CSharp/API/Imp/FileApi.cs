// /* ---------------------------------------------------------------------------------------
//    文件名：FileApi.cs
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

using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Http;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  文件操作接口实现类
    /// </summary>
    public class FileApi : IFileApi
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
        public virtual FileUploadResponse UploadFileByStream(string accessToken, string fileName, Stream fileStream, string sourceId = "")
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列4 服务端API之源上传文件》 https://www.cnblogs.com/SavionZhang/p/11425804.html

            /* 重要提示：使用普通文件流上传，不支持表单方式; 文件流需要在 request body 中传递 */

            //PUT 方式。例如：https://file.bimface.com/upload?name=3F.rvt
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/upload?name={0}", fileName.UrlEncode(Encoding.UTF8));  //文件的全名，使用URL编码（UTF-8），最多256个字符
            if (sourceId.IsNotNullAndWhiteSpace())
            {
                url = url + "&sourceId=" + sourceId;
            }

            byte[] fileBytes = fileStream.ToByteArray();

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileUploadResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.UploadData(url, fileBytes, WebRequestMethods.Http.Put);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileUploadResponse>();
                }
                else
                {
                    response = new FileUploadResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[普通文件流上传文件]发生异常！", ex);
            }
        }

        /// <summary>
        ///  指定外部文件url方式上传文件
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileName">【必填】文件的全名</param>
        /// <param name="fileUrl">【必填】文件所在url</param>
        /// <param name="sourceId">【可选】调用方的文件源ID，不能重复</param>
        /// <param name="etag">【可选】文件etag</param>
        /// <returns></returns>
        public virtual FileUploadResponse UploadFileByUrl(string accessToken, string fileName, string fileUrl, string sourceId = "", string etag = "")
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列4 服务端API之源上传文件》 https://www.cnblogs.com/SavionZhang/p/11425804.html

            /* 如果需要上传的文件不在本地，且该文件可以通过指定的HTTP URL可以下载，BIMFACE支持直接传一个外部的HTTP文件URL, BIMFACE会去下载该文件，而无须用户先下载，再上传。 */

            //PUT 方式。例如：https://file.bimface.com/upload?name=example.rvt&url=http(s)://xxxxxxxxxxx
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/upload?name={0}&url={1}", fileName.UrlEncode(Encoding.UTF8), fileUrl.UriEscapeDataString()); //文件的全名，使用URL编码（UTF-8），最多256个字符
            if (sourceId.IsNotNullAndWhiteSpace())
            {
                url = url + "&sourceId=" + sourceId;
            }
            if (etag.IsNotNullAndWhiteSpace())
            {
                url = url + "&etag=" + etag;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileUploadResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Put(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileUploadResponse>();
                }
                else
                {
                    response = new FileUploadResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[指定外部文件url方式上传文件]发生异常！", ex);
            }
        }

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
        public virtual FileUploadPolicyResponse GetFileUploadPolicy(string accessToken, string fileName, string sourceId = "")
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列5 服务端API之文件直传》 https://www.cnblogs.com/SavionZhang/p/11425945.html

            /*  BIMFACE 使用了分布式对象存储来存储用户上传的模型/图纸文件。
                如使用普通的文件上传接口，文件流会通过BIMFACE的服务器，再流向最终的分布式存储系统，整个上传过程会受BIMFACE服务器的带宽限制，上传速度非最优。 
                如使用文件直传接口，开发者应用在申请到一个Policy凭证后，可以直接上传文件跟BIMFACE后台的分布式存储系统， 
                这样上传速度和稳定性都会有提升，是我们推荐的上传方式。 
             */

            /* 使用流程如下：
                1、开发者应用向BIMFACE申请上传Policy请求
                2、BIMFACE返回上传Policy和签名给开发者应用。
             */

            //GET https://file.bimface.com/upload/policy 。例如：https://file.bimface.com/upload/policy?name=example.rvt
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/upload/policy?name={0}", fileName.UrlEncode(Encoding.UTF8)); //文件的全名，使用URL编码（UTF-8），最多256个字符
            if (sourceId.IsNotNullAndWhiteSpace())
            {
                url = url + "&sourceId=" + sourceId;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileUploadPolicyResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileUploadPolicyResponse>();
                }
                else
                {
                    response = new FileUploadPolicyResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取文件直传的policy凭证时]发生异常！", ex);
            }
        }

        /// <summary>
        ///  通过文件直传的policy凭证，直接上传文件【推荐使用该方式】
        /// 【特别提醒：BIMFACE公有云支持文件直传。私有化部署时使用的对象存储是 MinIO，不支持 Policy 上传。使用普通文件流上传 或者 指定外部文件URL方式上传。】
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileFullName">【必填】待上传的文件(包含全路径的完全限定名)</param>
        /// <returns></returns>
        public virtual FileUploadResponse UploadFileByPolicy(string accessToken, string fileFullName)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列5 服务端API之文件直传》 https://www.cnblogs.com/SavionZhang/p/11425945.html

            /* BIMFACE使用了分布式对象存储来存储用户上传的模型/图纸文件。
               如使用普通的文件上传接口，文件流会通过BIMFACE的服务器，再流向最终的分布式存储系统，整个上传过程会受BIMFACE服务器的带宽限制，上传速度非最优。 
               如使用文件直传接口，开发者应用在申请到一个Policy凭证后，可以直接上传文件跟BIMFACE后台的分布式存储系统， 
               这样上传速度和稳定性都会有提升，是我们推荐的上传方式。 
            */

            /* 使用流程如下：
                1、开发者应用向BIMFACE申请上传Policy请求。
                2、BIMFACE返回上传Policy和签名给开发者应用。
                3、开发者应用使用在第二个步骤中获取的URL信息，直接上传文件数据到BIMFACE后端的分布式对象存储。
             */

            FileUploadResponse response = null;
            try
            {
                FileInfo fileInfo = new FileInfo(fileFullName);
                string fileName = fileInfo.Name;

                FileUploadPolicyResponse policyResponse = GetFileUploadPolicy(accessToken, fileName);
                if (policyResponse.Code == HttpResult.STATUS_SUCCESS)
                {
                    string url = policyResponse.Data.Host;

                    /* C# 语言 Dictionary 字典中 key 是关键字，不能添加进去。所以同意添加了响应的后缀 _BIMFACE_，解析时再去除后缀 */
                    NameValueCollection kVDatas = new NameValueCollection();
                    kVDatas.Add("name" + StringUtils.Symbol.KEY_SUFFIX, fileName);
                    kVDatas.Add("key" + StringUtils.Symbol.KEY_SUFFIX, policyResponse.Data.ObjectKey);
                    kVDatas.Add("policy" + StringUtils.Symbol.KEY_SUFFIX, policyResponse.Data.Policy);
                    kVDatas.Add("OSSAccessKeyId" + StringUtils.Symbol.KEY_SUFFIX, policyResponse.Data.AccessId);
                    kVDatas.Add("success_action_status" + StringUtils.Symbol.KEY_SUFFIX, "200");
                    kVDatas.Add("callback" + StringUtils.Symbol.KEY_SUFFIX, policyResponse.Data.CallbackBody);
                    kVDatas.Add("signature" + StringUtils.Symbol.KEY_SUFFIX, policyResponse.Data.Signature);

                    HttpManager httpManager = new HttpManager();
                    HttpResult httpResult = httpManager.UploadFormByMultipart(url, fileFullName, kVDatas);
                    if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                    {
                        response = httpResult.Text.DeserializeJsonToObject<FileUploadResponse>();
                    }
                    else
                    {
                        response = new FileUploadResponse
                        {
                            Message = httpResult.RefText
                        };
                    }
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[通过文件直传的policy凭证，直接上传文件时]发生异常！", ex);
            }
        }

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
        public virtual FileInfoGetResponse GetFileInfo(string accessToken, long fileId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列6 服务端API之获取文件信息》 https://www.cnblogs.com/SavionZhang/p/11433179.html

            //GET https://file.bimface.com/files/{fileId}
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/files/{0}", fileId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileInfoGetResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileInfoGetResponse>();
                }
                else
                {
                    response = new FileInfoGetResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[根据文件ID获取文件详细信息]发生异常！", ex);
            }
        }

        /// <summary>
        ///  根据多种查询条件获取文件详细信息列表，支持分页
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="startTime">起始日期,格式为 yyyy-MM-dd。默认为空，查询所有</param>
        /// <param name="endTime">截止日期,格式为 yyyy-MM-dd。默认为空，查询所有</param>
        /// <param name="rows">查询结果数, 默认为100， 最大500。默认100</param>
        /// <param name="offset">查询结果偏移，从查询结果的第offset条开始返回数据。默认-1，查询所有</param>
        /// <param name="status">文件状态,uploading，success，failure。默认为空，查询所有</param>
        /// <param name="suffix">文件后缀。默认为空，查询所有</param>
        /// <returns></returns>
        public virtual FileInfoListGetResponse GetFileInfoList(string accessToken, string startTime = "", string endTime = "", long rows = 100, long offset = -1, string status = "", string suffix = "")
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列7 服务端API之获取文件信息列表》 https://www.cnblogs.com/SavionZhang/p/11433500.html

            FileInfoListGetResponse response = new FileInfoListGetResponse();

            #region 校验
            if (rows < 0 || rows > 500)
            {
                response.Message = "参数[rows]超出范围。要求控制在1到500之间！";

                return response;
            }

            #endregion

            //GET https://file.bimface.com/files
            string url = BIMFaceConstants.FILE_HOST + "/files";
            url = url + "?rows=" + rows;
            if (!string.IsNullOrWhiteSpace(startTime))
            {
                url = url + "?rows=" + rows;
            }
            if (!string.IsNullOrWhiteSpace(endTime))
            {
                url = url + "?endTime=" + endTime;
            }
            if (offset >= 0)
            {
                url = url + "?offset=" + offset;
            }
            if (!string.IsNullOrWhiteSpace(status))
            {
                url = url + "?status=" + status;
            }
            if (!string.IsNullOrWhiteSpace(suffix))
            {
                url = url + "?suffix=" + suffix;
            }

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileInfoListGetResponse>();
                }
                else
                {
                    response = new FileInfoListGetResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取文件信息列表]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取文件上传状态信息
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        public virtual FileUploadStatusResponse GetFileUploadStatus(string accessToken, long fileId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列8 服务端API之获取文件上传状态信息》 https://www.cnblogs.com/SavionZhang/p/11433638.html

            //GET https://file.bimface.com/files/{fileId}/uploadStatus
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/files/{0}/uploadStatus", fileId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileUploadStatusResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileUploadStatusResponse>();
                }
                else
                {
                    response = new FileUploadStatusResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取文件上传状态信息]发生异常！", ex);
            }
        }

        /// <summary>
        ///  获取应用支持的文件类型
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        public virtual FileSupportResponse GetFileSupport(string accessToken)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列9 服务端API之获取应用支持的文件类型》 https://www.cnblogs.com/SavionZhang/p/11433982.html

            //GET https://file.bimface.com/support
            string url = BIMFaceConstants.FILE_HOST + "/support";
            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileSupportResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileSupportResponse>();
                }
                else
                {
                    response = new FileSupportResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取应用支持的文件类型]发生异常！", ex);
            }
        }

        #endregion

        #region 源文件下载

        /// <summary>
        ///  获取文件下载链接
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <param name="name">文件名称</param>
        /// <returns></returns>
        public virtual FileDownloadUrlGetResponse GetFileDownloadUrl(string accessToken, long fileId, string name = "")
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列10 服务端API之获取文件下载链接》 https://www.cnblogs.com/SavionZhang/p/11434093.html

            //GET GET https://file.bimface.com/download/url
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/download/url?fileId={0}", fileId);
            if (name.IsNotNullAndWhiteSpace())
            {
                url = url + "&name=" + name.UriEscapeDataString();
            }
            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileDownloadUrlGetResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileDownloadUrlGetResponse>();
                }
                else
                {
                    response = new FileDownloadUrlGetResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取文件下载链接]发生异常！", ex);
            }
        }

        #endregion

        #region 源文件删除

        /// <summary>
        ///  根据文件ID删除文件
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">文件ID</param>
        /// <returns></returns>
        public virtual FileDeleteResponse DeleteFile(string accessToken, long fileId)
        {
            // 此API详解，参考作者博客：《C#开发BIMFACE系列11 服务端API之源文件删除》 https://www.cnblogs.com/SavionZhang/p/11434270.html

            //DELETE https://file.bimface.com/file
            string url = string.Format(BIMFaceConstants.FILE_HOST + "/file?fileId={0}", fileId);

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                FileDeleteResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Delete(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<FileDeleteResponse>();
                }
                else
                {
                    response = new FileDeleteResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[根据文件ID删除文件]发生异常！", ex);
            }
        }
        #endregion

        #endregion
    }
}