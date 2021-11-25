// /* ---------------------------------------------------------------------------------------
//    文件名：FileEntity.cs
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
using System.Collections.Generic;
using System.IO;
using System.Text;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    public partial class BIMFaceDemo1 : System.Web.UI.Page
    {
        readonly string _appKey = ConfigUtility.GetAppSettingValue("BIMFACE_AppKey");
        readonly string _appSecret = ConfigUtility.GetAppSettingValue("BIMFACE_AppSecret");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        /// <summary>
        ///  获取 AccessToken
        /// </summary>
        protected void btnGetAccessToken_Click(object sender, EventArgs e)
        {
            txtAccessToken.Text = string.Empty;

            IBasicApi api = new BasicApi();
            AccessTokenResponse response = api.GetAccessToken(_appKey, _appSecret);
            if (response != null)
            {
                txtAccessToken.Text = response.Data.Token;
            }
        }

        // 普通文件流上传（建议使用文件直传方式）
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string filePath = txtFile.Text;

            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            AccessTokenResponse response = new BasicApi().GetAccessToken(_appKey, _appSecret);
            string token = response.Data.Token;

            FileApi api = new FileApi();
            FileUploadResponse fileUploadResponse = api.UploadFileByStream(token, fileName, fileStream);
            txtResult.Text = fileUploadResponse.SerializeToJson(true);

            txtFileId.Text = fileUploadResponse.Data.FileId.ToString();
        }

        // 文件直传（优先推荐使用该方式）
        protected void btnUpload2_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            string filePath = txtFile.Text;

            AccessTokenResponse response = new BasicApi().GetAccessToken(_appKey, _appSecret);
            string token = response.Data.Token;

            FileApi api = new FileApi();
            FileUploadResponse fileUploadResponse = api.UploadFileByPolicy(token, filePath);

            txtResult.Text = fileUploadResponse.SerializeToJson(true);

            txtFileId.Text = fileUploadResponse.Data.FileId.ToString();
        }

        // 获取文件信息
        protected void btnGetFileInfo_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            string token = txtAccessToken.Text;
            string fileId = txtFileId.Text;

            FileApi api = new FileApi();
            FileInfoGetResponse response = api.GetFileInfo(token, fileId.ToLong());

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取文件信息列表
        protected void btnGetFileList_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            string token = txtAccessToken.Text;

            FileApi api = new FileApi();
            FileInfoListGetResponse response = api.GetFileInfoList(token);

            List<FileInfoGetEntity> fileInfoList = response.Data;
            StringBuilder sbFiles = new StringBuilder();
            foreach (FileInfoGetEntity fileInfo in fileInfoList)
            {
                sbFiles.AppendLine("名称：" + fileInfo.ToString());
            }

            txtResult.Text = response.Code
                             + Environment.NewLine
                             + response.Message
                             + Environment.NewLine
                             + "共获取 " + fileInfoList.Count + " 个文件。"
                             + Environment.NewLine
                             + sbFiles
                             + Environment.NewLine
                             + Environment.NewLine
                             + response.SerializeToJson(true);
        }

        // 获取文件上传状态信息
        protected void btnGetFileUploadStatus_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            string token = txtAccessToken.Text;
            string fileId = txtFileId.Text;

            FileApi api = new FileApi();
            FileUploadStatusResponse response = api.GetFileUploadStatus(token, fileId.ToLong());

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取应用支持的文件类型
        protected void btnGetFileSupport_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            string token = txtAccessToken.Text;

            FileApi api = new FileApi();
            FileSupportResponse response = api.GetFileSupport(token);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取文件下载链接
        protected void btnGetFileDownloadUrl_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            string token = txtAccessToken.Text;
            string fileId = txtFileId.Text;

            FileApi api = new FileApi();
            FileDownloadUrlGetResponse response = api.GetFileDownloadUrl(token, fileId.ToLong());

            txtResult.Text = response.SerializeToJson(true);
        }

        // 根据文件ID删除文件
        protected void btnDeleteFile_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            string token = txtAccessToken.Text;
            string fileId = txtFileId.Text;

            FileApi api = new FileApi();
            FileDeleteResponse response = api.DeleteFile(token, fileId.ToLong());

            txtResult.Text = response.SerializeToJson(true);
        }


        // 获取 ViewToken【文件转换ID】
        protected void btnGetViewTokenByFileId_Click(object sender, EventArgs e)
        {
            BasicApi api = new BasicApi();
            ViewTokenResponse response = api.GetViewTokenByFileId(txtAccessToken.Text, txtFileId.Text.ToLong());

            txtResult.Text = response.SerializeToJson();
        }
    }
}