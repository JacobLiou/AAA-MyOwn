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

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    public partial class BIMFaceDemo4 : System.Web.UI.Page
    {
        readonly string _appKey = ConfigUtility.GetAppSettingValue("BIMFACE_AppKey");
        readonly string _appSecret = ConfigUtility.GetAppSettingValue("BIMFACE_AppSecret");
        private readonly string _callback = ConfigUtility.GetAppSettingValue("BIMFACE_Callback");

        protected void Page_Load(object sender, EventArgs e)
        {

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

        /// <summary>
        ///  开始比对
        /// </summary>
        protected void btnStartCompare_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long followingId = txtFile1Id.Text.ToLong();
            long previousId = txtFile2Id.Text.ToLong();

            CompareRequest request = new CompareRequest(followingId, previousId);

            IModelCompareApi api = new ModelCompareApi();
            ModelCompareResponse response = api.Compare(txtAccessToken.Text, request);

            txtResult.Text = response.SerializeToJson(true);
            txtCompareID.Text = response.Data.CompareId.ToString();
        }

        /// <summary>
        ///  获取对比状态
        /// </summary>
        protected void btnGetCompareStatus_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long compareId = txtCompareID.Text.ToLong();
            IModelCompareApi api = new ModelCompareApi();
            ModelCompareResponse response = api.GetCompareStatus(txtAccessToken.Text, compareId);

            txtResult.Text = response.SerializeToJson(true);
        }

        /// <summary>
        ///  获取模型构件对比差异
        /// </summary>
        protected void btnGetModelCompareChange_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long compareId = txtCompareID.Text.ToLong();
            ModelCompareApi api = new ModelCompareApi();
            //ModelCompareChangeResponse response = api.GetModelCompareChange(txtAccessToken.Text, compareId);
        }

        /// <summary>
        ///  获取模型对比构件分类树
        /// </summary>
        protected void btnGetModelCompareTree_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long compareId = txtCompareID.Text.ToLong();
            IModelCompareApi api = new ModelCompareApi();
            ModelCompareTreeResponse response = api.GetModelCompareTree(txtAccessToken.Text, compareId);

            txtResult.Text = response.SerializeToJson(true);
        }

        /// <summary>
        ///  获取模型对比结果(所有)
        /// </summary>
        protected void btnGetModelCompareDiffAll_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long compareId = txtCompareID.Text.ToLong();
            IModelCompareApi api = new ModelCompareApi();
           // ModelCompareDiffResponse response = api.GetModelCompareDiffAll(txtAccessToken.Text, compareId);

            DrawingCompareDiffResponse response = api.GetDrawingCompareDiffAll(txtAccessToken.Text, compareId);

            txtResult.Text = response.SerializeToJson(true);
        }

        /// <summary>
        ///  分页获取模型对比结果
        /// </summary>
        protected void btnGetModelCompareDiff_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long compareId = txtCompareID.Text.ToLong();
            IModelCompareApi api = new ModelCompareApi();
            ModelCompareDiffResponse response = api.GetModelCompareDiff(txtAccessToken.Text, compareId, page: 1, pageSize: 50);

            txtResult.Text = response.SerializeToJson(true);
        }
    }
}