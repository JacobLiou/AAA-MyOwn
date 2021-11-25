using System;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    /// <summary>
    /// CAD图纸拆分示例类
    /// </summary>
    public partial class APIDemo5 : System.Web.UI.Page
    {
        readonly string _appKey = ConfigUtility.GetAppSettingValue("BIMFACE_AppKey");
        readonly string _appSecret = ConfigUtility.GetAppSettingValue("BIMFACE_AppSecret");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // 获取 AccessToken
        protected void btnGetAccessToken_Click(object sender, EventArgs e)
        {
            txtAccessToken.Text = string.Empty;
            txtResult.Text = string.Empty;

            AccessTokenResponse response = GetAccessToken();
            if (response != null)
            {
                txtAccessToken.Text = response.Data.Token;
                txtResult.Text = response.SerializeToJson(true);
            }
        }

        // 发起图纸拆分
        protected void btnSplitDrawing_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            IFileConvertApi api = new FileConvertApi();

            SplitDrawingResponse response = api.SplitDrawing(txtAccessToken.Text, txtFileId.Text.Trim().ToLong());
            if (response != null)
            {
                txtResult.Text = response.SerializeToJson(true);
            }
        }

        // 获取图纸拆分状态
        protected void btnGetSplitDrawingStatus_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            IFileConvertApi api = new FileConvertApi();

            SplitDrawingResponse response = api.GetSplitDrawingStatus(txtAccessToken.Text, txtFileId.Text.Trim().ToLong());
            if (response != null)
            {
                txtResult.Text = response.SerializeToJson(true);
            }
        }

        // 获取图纸拆分结果

        protected void btnGetSplitDrawingResult_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            IFileConvertApi api = new FileConvertApi();

            SplitDrawingResultResponse response = api.GetSplitDrawingResult(txtAccessToken.Text, txtFileId.Text.Trim().ToLong());
            if (response != null)
            {
                txtResult.Text = response.SerializeToJson(true);
            }
        }


        private AccessTokenResponse GetAccessToken()
        {
            IBasicApi api = new BasicApi();
            AccessTokenResponse response = api.GetAccessToken(_appKey, _appSecret);
            return response;
        }
    }
}