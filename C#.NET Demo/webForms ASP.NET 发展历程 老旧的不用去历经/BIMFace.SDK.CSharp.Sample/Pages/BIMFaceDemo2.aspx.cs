using System;

using BIMFace.SDK.CSharp.API;
using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Utils;
using BIMFace.SDK.CSharp.Entity.Request;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.Sample.Pages
{
    public partial class BIMFaceDemo2 : System.Web.UI.Page
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

        // 将DWG文件转换成矢量图纸
        protected void btnTranslateDwgToVectorDrawings_Click(object sender, EventArgs e)
        {
            TranslateSource source = new TranslateSource
            {
                FileId = txtFileID.Text.Trim().ToLong()
            };

            DwgModelConfig config = new DwgModelConfig
            {

                ExportDrawing = chkDwgExportDrawing.Checked,
                ExportPdf = chkDwgExportPdf.Checked,
                ExportThumb = chkDwgExportThumb.Checked
            };

            DwgFileTranslateRequest request = new DwgFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            FileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateDwgToVectorDrawings(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 将DWG文件转换成图片
        protected void btnTranslateDwgToPicture_Click(object sender, EventArgs e)
        {
            TranslateSource source = new TranslateSource
            {
                FileId = txtFileID.Text.Trim().ToLong()
            };

            DwgModelConfig config = new DwgModelConfig
            {
                ExportDrawing = chkDwgExportDrawing.Checked,
                ExportPdf = chkDwgExportPdf.Checked,
                ExportThumb = chkDwgExportThumb.Checked
            };

            DwgFileTranslateRequest request = new DwgFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            FileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateDwgToPicture(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 将RVT文件转换成着色模式的效果
        protected void btnTranslateRvtToRenderStyle_Click(object sender, EventArgs e)
        {
            TranslateSource source = new TranslateSource
            {
                FileId = txtFileID.Text.Trim().ToLong()
            };

            RvtModelConfig config = GetRvtModelConfig();

            RvtFileTranslateRequest request = new RvtFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            FileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateRvtToRenderStyle(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 将RVT文件转换成真实模式的效果
        protected void btnTranslateRvtToRealStyle_Click(object sender, EventArgs e)
        {
            TranslateSource source = new TranslateSource
            {
                FileId = txtFileID.Text.Trim().ToLong()
            };

            RvtModelConfig config = GetRvtModelConfig();
            config.Texture = true; //必填

            RvtFileTranslateRequest request = new RvtFileTranslateRequest
            {
                Source = source,
                Config = config,
                CallBack = _callback
            };

            FileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.TranslateRvtToRealStyle(txtAccessToken.Text, request);
            txtResult.Text = response.SerializeToJson(true);
        }

        // 将RVT格式文件转换为具备二三维联动的功能效果
        protected void btnTranslateRvtTo23LinkStyle_Click(object sender, EventArgs e)
        {
            TranslateSource source = new TranslateSource
            {
                FileId = txtFileID.Text.Trim().ToLong()
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

        // 其它三维模型文件转换，常规转换（不带材质）
        protected void btnTranslateOther3DModelToWithoutMaterialStyle_Click(object sender, EventArgs e)
        {
            //TranslateSource source = new TranslateSource
            //{
            //    FileId = lblRvtFileId.Text.Trim().ToLong()
            //};

            //RvtModelConfig config = GetRvtModelConfig();

            //Other3DModelFileTranslateRequest request = new Other3DModelFileTranslateRequest
            //{
            //    Source = source,
            //    Config = config,
            //    CallBack = _callback
            //};

            //FileConvertApi api = new FileConvertApi();
            //FileTranslateResponse response = api.TranslateOther3DModelToWithoutMaterialStyle(txtAccessToken.Text, request);

            //txtResult.Text = response.Code.ToString2()
            //               + Environment.NewLine
            //               + response.Message.ToString2()
            //               + Environment.NewLine
            //               + response.Data.ToString2();
        }

        // 其他三维模型文件包括RVT格式文件，需要转换出引用的外部材质场景、贴图等。
        // （上传的文件必须为压缩包，压缩包内同级目录包含模型文件和关联的所有材质文件，转换时必须指定指定压缩包中哪一个是主文件，即设置rootName为主文件）。
        protected void btnTranslateOther3DModelToWithMaterialStyle_Click(object sender, EventArgs e)
        {
            //TranslateSource source = new TranslateSource
            //{
            //    FileId = lblDwgFileId.Text.Trim().ToLong(),
            //    RootName = "" //指定压缩包中哪一个是主文件
            //};

            //RvtModelConfig config = GetRvtModelConfig();
            //config.Texture = true;

            //Other3DModelFileTranslateRequest request = new Other3DModelFileTranslateRequest
            //{
            //    Source = source,
            //    Config = config,
            //    CallBack = _callback
            //};

            //FileConvertApi api = new FileConvertApi();
            //FileTranslateResponse response = api.TranslateOther3DModelToWithoutMaterialStyle(txtAccessToken.Text, request);

            //txtResult.Text = response.Code.ToString2()
            //               + Environment.NewLine
            //               + response.Message.ToString2()
            //               + Environment.NewLine
            //               + response.Data.ToString2();
        }

        // 获取转换状态
        protected void btnGetFileTranslateStatus_Click(object sender, EventArgs e)
        {
            long fileId = txtFileID.Text.Trim().ToLong();
            FileConvertApi api = new FileConvertApi();
            FileTranslateResponse response = api.GetFileTranslateStatus(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
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

        // 批量获取转换状态详情
        protected void btnGetFileTranslateDetails_Click(object sender, EventArgs e)
        {
            TranslateQueryRequest request = new TranslateQueryRequest
            {
                AppKey = _appKey  //必填项
            };

            FileConvertApi api = new FileConvertApi();
            FileTranslateDetailsResponse response = api.GetFileTranslateDetails(txtAccessToken.Text, request);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取三维视点或二维视图列表
        protected void btnGetSingleModelViews_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";

            long fileId = txtFileID.Text.Trim().ToLong();
            FileConvertApi api = new FileConvertApi();
            SingleModelViews response = api.GetSingleModelViews(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
        }

        // 获取单个模型的图纸列表。果请求参数elementId为null，返回所有图纸，否则返回包含该构件的所有图纸
        protected void btnGetSingleModelDrawingSheets_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            long fileId = txtFileID.Text.Trim().ToLong();
            FileConvertApi api = new FileConvertApi();
            SingleModelDrawingSheets response = api.GetSingleModelDrawingSheets(txtAccessToken.Text, fileId);

            txtResult.Text = response.SerializeToJson(true);
        }
    }
}