using System;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    /// <summary>
    /// CAD图纸拆分示例类
    /// </summary>
    public partial class APIDemo4 : System.Web.UI.Page
    {
        readonly string _appKey = ConfigUtility.GetAppSettingValue("BIMFACE_AppKey");
        readonly string _appSecret = ConfigUtility.GetAppSettingValue("BIMFACE_AppSecret");
        readonly string _callback = ConfigUtility.GetAppSettingValue("BIMFACE_Callback");

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

        // 发起模型转换（着色模式）
        protected void btnTranslateRvt1_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            TranslateSource source = new TranslateSource
            {
                FileId = txtFileId.Text.Trim().ToLong()
            };

            RvtModelConfig config = GetRvtModelConfig();

            RvtFileTranslateRequest request = new RvtFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            IFileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateRvtToRenderStyle(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 发起模型转换（真实模式）
        protected void btnTranslateRvt2_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            TranslateSource source = new TranslateSource
            {
                FileId = txtFileId.Text.Trim().ToLong()
            };

            RvtModelConfig config = GetRvtModelConfig();
            config.Texture = true; //必填

            RvtFileTranslateRequest request = new RvtFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            IFileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateRvtToRealStyle(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 发起模型转换（二三维联动）
        protected void btnTranslateRvt3_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            TranslateSource source = new TranslateSource
            {
                FileId = txtFileId.Text.Trim().ToLong()
            };

            RvtModelConfig config = GetRvtModelConfig();
            config.Texture = false; //参考官方示例，不知道设置不同的参数转换后有何区别。需要了解rvt文件的格式才行。
            config.ExportDwg = true;
            config.ExportPdf = true;
            config.ExportDrawing = true;

            RvtFileTranslateRequest request = new RvtFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            FileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateRvtTo23LinkStyle(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取转换状态
        protected void btnGetRvtTranslateStatus_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            IFileConvertApi api = new FileConvertApi();

            var response = api.GetFileTranslateStatus(txtAccessToken.Text, txtFileId.Text.Trim().ToLong());
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

        private RvtModelConfig GetRvtModelConfig()
        {
            RvtModelConfig config = new RvtModelConfig();
            if (chkRvtTexture.Checked)
            {
                config.Texture = true;   //转换时是否添加材质
            }

            if (chkRvtExportDwg.Checked)
            {
                config.ExportDwg = true; //rvt2md是否导出dwg文件
            }

            if (chkRvtExportDrawing.Checked)
            {
                config.ExportDrawing = true; //dwg2md是否导出mdv(矢量化图纸);取值为true时，exportDwg自动设置为true
            }

            if (chkRvtExportPdf.Checked)
            {
                config.ExportPdf = true; //dwg2md是否导出pdf文件
            }

            if (txtRvtViewName.Text.Trim() != "3D") //转换使用的3D视图，默认为 3D
            {
                config.ViewName = txtRvtViewName.Text.Trim();
            }

            if (rbtnRvtDisplayLevelOfMedium.Checked)
            {
                config.DisplayLevel = "medium"; //设置转换的精细度。fine（精细），medium（中等），coarse（粗略）。默认为 fine
            }
            else if (rbtnRvtDisplayLevelOfCoarse.Checked)
            {
                config.DisplayLevel = "coarse";
            }

            if (chkRvtExportDwgInstance.Checked)
            {
                config.ExportDwgInstance = true; //是否导出dwg实例
            }
            if (chkRvtExportHiddenObjects.Checked)
            {
                config.ExportHiddenObjects = true; //是否导出三维视图中隐藏的构件
            }
            if (chkRvtExportSystemType.Checked)
            {
                config.ExportSystemType = true; //是否在userData中加入mepSystemType
            }

            if (chkRvtExportProperties.Checked)
            {
                config.ExportProperties = true; //是否在导出NWD的属性db文件
            }

            if (chkRvtExportSchedule.Checked)
            {
                config.ExportSchedule = true; //是否使用明细表内容
            }

            if (txtRvtUnit.Text.Trim().IsNotNullAndWhiteSpace())
            {
                config.Unit = txtRvtUnit.Text;//设置转换使用的单位。取值"ft"\"feet"\"英尺"，采用revit默认的英尺为单位 ，默认以毫米为单位
            }

            return config;
        }

    }
}