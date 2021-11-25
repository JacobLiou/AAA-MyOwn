using System;
using System.IO;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    /// <summary>
    /// 示例2：源文件上传
    /// </summary>
    public partial class APIDemo2 : System.Web.UI.Page
    {
        readonly string _appKey = ConfigUtility.GetAppSettingValue("BIMFACE_AppKey");
        readonly string _appSecret = ConfigUtility.GetAppSettingValue("BIMFACE_AppSecret");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        // 获取 AccessToken
        protected void btnGetAccessToken_Click(object sender, EventArgs e)
        {
            txtAccessToken.Text = string.Empty;
            AccessTokenResponse response = GetAccessToken();
            if (response != null)
            {
                txtAccessToken.Text = response.Data.Token;
            }
        }

        // 普通文件流上传
        protected void btnUploadFileByStream_Click(object sender, EventArgs e)
        {
            string filePath = FileUpload1.PostedFile.FileName;//必须在IE兼容模式下才能获取到文件的绝对路径

            FileInfo fileInfo = new FileInfo(filePath);
            string fileName = fileInfo.Name;
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            
            IFileApi api = new FileApi();
            FileUploadResponse fileUploadResponse = api.UploadFileByStream(txtAccessToken.Text, fileName, fileStream);
            txtResult.Text = fileUploadResponse.SerializeToJson(true);
        }

        // 指定外部文件url方式上传
        protected void btnUploadFileByUrl_Click(object sender, EventArgs e)
        {
            string fileName = "test.rvt";
            string fileUrl = "xxxx/test.rvt";// 请替换成自己真实业务场景中的图纸所在的url地址

            IFileApi api = new FileApi();
            FileUploadResponse fileUploadResponse = api.UploadFileByUrl(txtAccessToken.Text, fileName, fileUrl);
            txtResult.Text = fileUploadResponse.SerializeToJson(true);
        }

        private AccessTokenResponse GetAccessToken()
        {
            IBasicApi api = new BasicApi();
            AccessTokenResponse response = api.GetAccessToken(_appKey, _appSecret);
            return response;
        }
    }
}