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
using System.Web.UI.WebControls;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Http;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    public partial class BIMFaceDemo3 : System.Web.UI.Page
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

        // 获取转换状态
        protected void btnGetFileTranslateStatus_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            IFileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.GetFileTranslateStatus(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
        }


        // 批量获取转换状态详情
        protected void btnGetFileTranslateDetails_Click(object sender, EventArgs e)
        {
            TranslateQueryRequest request = new TranslateQueryRequest
            {
                AppKey = _appKey  //必填项
            };

            IFileConvertApi api = new FileConvertApi();
            FileTranslateDetailsResponse response = api.GetFileTranslateDetails(txtAccessToken.Text, request);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 查询满足条件的构件ID列表
        protected void btnGetSingleModelElements_Click(object sender, EventArgs e)
        {
            ddlSingleModelElements.Items.Clear();

            IFileConvertApi api = new FileConvertApi();
            SingleModelElementsSwaggerDisplay response = api.GetSingleModelElements(txtAccessToken.Text, txtFileID.Text);

            txtResult.Text = response.SerializeToJson(true);

            if (response.Code == HttpResult.STATUS_SUCCESS && response.Data != null)
            {
                ddlSingleModelElements.Items.Clear();

                foreach (var str in response.Data)
                {
                    ddlSingleModelElements.Items.Add(new ListItem(str, str));
                }
            }
        }

        // 获取构件材质列表
        protected void btnGetSingleModelSingleElementMaterials_Click(object sender, EventArgs e)
        {
            string elementId = ddlSingleModelElements.SelectedValue;

            IFileConvertApi api = new FileConvertApi();
            SingleModelSingleElementMaterials response = api.GetSingleModelSingleElementMaterials(txtAccessToken.Text, txtFileID.Text.ToLong(), elementId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取构件属性
        protected void btnGetSingleModelSingleElementProperty_Click(object sender, EventArgs e)
        {
            string elementId = ddlSingleModelElements.SelectedValue;

            IFileConvertApi api = new FileConvertApi();
            SingleModelSingleElementProperty response = api.GetSingleModelSingleElementProperty(txtAccessToken.Text, txtFileID.Text.ToLong(), elementId, chkIncludeOverrides.Checked);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取多个构件的共同属性
        protected void btnGetSingleModelMultipleElementsCommonProperties_Click(object sender, EventArgs e)
        {
            string[] elementIds = txtMultipleElementIds.Text.Split(',');

            IFileConvertApi api = new FileConvertApi();
            var response = api.GetSingleModelMultipleElementsCommonProperties(txtAccessToken.Text, txtFileID.Text.ToLong(), elementIds, chkIncludeOverrides.Checked);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 批量获取构件属性
        protected void btnGetSingleModelMultipleElementsProperties_Click(object sender, EventArgs e)
        {
            string[] elementIds = txtMultipleElementIds.Text.Split(',');

            ElementPropertyFilterRequest request = new ElementPropertyFilterRequest();
            request.ElementIds = elementIds;

            IFileConvertApi api = new FileConvertApi();
            var response = api.GetSingleModelMultipleElementsProperties(txtAccessToken.Text, txtFileID.Text.ToLong(), request, chkIncludeOverrides.Checked);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取单模型的楼层信息
        protected void btnGetSingleModelFloors_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            IFileConvertApi api = new FileConvertApi();
            SingleModelFloors response = api.GetSingleModelFloors(txtAccessToken.Text, fileId, chkIncludeArea.Checked, chkIncludeRoom.Checked);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取多模型的楼层信息
        protected void btnGetMultipleModelFloors_Click(object sender, EventArgs e)
        {
            string[] fileIds = txtFileID.Text.Split(',');
            IFileConvertApi api = new FileConvertApi();
            MultipleModelsFloors response = api.GetMultipleModelFloors(txtAccessToken.Text, fileIds, chkIncludeArea.Checked, chkIncludeRoom.Checked);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取单模型链接信息
        protected void btnGetSingleModelLink_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            IFileConvertApi api = new FileConvertApi();
            SingleModelLink response = api.GetSingleModelLink(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取单个房间信息
        protected void btnGetSingleModelSingleRoom_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            string roomId = txtRoomId.Text.Trim();
            IFileConvertApi api = new FileConvertApi();
            SingleModelSingleRoom response = api.GetSingleModelSingleRoom(txtAccessToken.Text, fileId, roomId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取楼层对应面积分区列表
        protected void btnGetSingleModelSingleFloorAreas_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            string floorId = txtFloorId.Text.Trim();
            IFileConvertApi api = new FileConvertApi();
            SingleModelSingleFloorAreas response = api.GetSingleModelSingleFloorAreas(txtAccessToken.Text, fileId, floorId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取单个面积分区信息
        protected void btnGetSingleModelSingleArea_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            string areaId = txtAreaId.Text.Trim();
            IFileConvertApi api = new FileConvertApi();
            SingleModelSingleArea response = api.GetSingleModelSingleArea(txtAccessToken.Text, fileId, areaId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取构件分类树（默认）
        protected void btnGetSingleModelTreeByDefault_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            IFileConvertApi api = new FileConvertApi();
            SingleModelTree response = api.GetSingleModelTreeByDefault(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取构件分类树（自定义）
        protected void btnGetSingleModelTreeByCustomized_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();

            List<string> lstDesiredHierarchy = new List<string>();
            if (chkTreeBuilding.Checked)
            {
                lstDesiredHierarchy.Add("building");
            }

            if (chkTreeSystemType.Checked)
            {
                lstDesiredHierarchy.Add("systemType");
            }
            if (chkTreeSpecialty.Checked)
            {
                lstDesiredHierarchy.Add("specialty");
            }

            if (chkTreeFloor.Checked)
            {
                lstDesiredHierarchy.Add("floor");
            }
            if (chkTreeCategory.Checked)
            {
                lstDesiredHierarchy.Add("category");
            }
            if (chkTreeFamily.Checked)
            {
                lstDesiredHierarchy.Add("family");
            }

            if (chkTreeFamilyType.Checked)
            {
                lstDesiredHierarchy.Add("familyType");
            }

            FileTreeRequestBody request = new FileTreeRequestBody();
            request.DesiredHierarchy = lstDesiredHierarchy.ToArray();// new[] { "building", "systemType", "specialty", "floor", "category", "family", "familyType" };
            request.CustomizedNodeKeys = new Dictionary<string, string> { { "category", "name" } };

            IFileConvertApi api = new FileConvertApi();
            SingleModelTreeByCustomized response = api.GetSingleModelTreeByCustomized(txtAccessToken.Text, fileId, "2.0", request);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取三维视点或二维视图列表
        protected void btnGetSingleModelViews_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            IFileConvertApi api = new FileConvertApi();
            SingleModelViews response = api.GetSingleModelViews(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取图纸列表
        protected void btnGetSingleModelDrawingSheets_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            string elementId = txtElementId.Text.Trim();
            IFileConvertApi api = new FileConvertApi();
            SingleModelDrawingSheets response = api.GetSingleModelDrawingSheets(txtAccessToken.Text, fileId, elementId);

            txtResult.Text = response.SerializeToJson(true);
        }
    }
}