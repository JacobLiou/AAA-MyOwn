// /* ---------------------------------------------------------------------------------------
//    文件名：FileTranslateRequest.cs
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

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Request
{
    /// <summary>
    ///  发起文件转化的请求数据类
    /// </summary>
    [Serializable]
    public class FileTranslateRequest
    {
        public FileTranslateRequest()
        {
            Priority = 2;
            CallBack = "http://www.app.com/receive";
        }

        [JsonProperty("source")]
        public TranslateSource Source { get; set; }

        /// <summary>
        /// 优先级，数字越大，优先级越低。只能是1, 2, 3。默认为2
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        ///  Callback地址，待转换完毕以后，BIMFace会回调该地址
        /// </summary>
        [JsonProperty("callback")]
        public string CallBack { get; set; }
    }

    /// <summary>
    ///  发起DWG文件转化的请求数据
    /// </summary>
    [Serializable]
    public class DwgFileTranslateRequest : FileTranslateRequest
    {
        /// <summary>
        ///  Dwg模型转换引擎自定义参数，config参数跟转换引擎相关，不同的转换引擎支持不同的config格式。
        /// 例如转换时添加内置材质，则添加参数值{"texture":true}，添加外部材质时参考“使用模型外置材质场景”请求报文。
        /// 如果不需要设置该参数，则设置为null
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public DwgModelConfig Config { get; set; }
    }

    /// <summary>
    ///  发起Rvt文件转化的请求数据
    /// </summary>
    [Serializable]
    public class RvtFileTranslateRequest : FileTranslateRequest
    {
        /// <summary>
        ///  Rvt模型转换引擎自定义参数，config参数跟转换引擎相关，不同的转换引擎支持不同的config格式。
        /// 例如转换时添加内置材质，则添加参数值{"texture":true}，添加外部材质时参考“使用模型外置材质场景”请求报文。
        /// 如果不需要设置该参数，则设置为null
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public RvtModelConfig Config { get; set; }
    }

    /// <summary>
    ///  其他三维模型文件，包括RVT格式文转化的请求数据
    /// </summary>
    [Serializable]
    public class Other3DModelFileTranslateRequest : RvtFileTranslateRequest
    {
    }

    [Serializable]
    public class TranslateSource
    {
        public TranslateSource()
        {
            Compressed = false;
            RootName = null;
        }

        /// <summary>
        ///  文件Id，即调用上传文件API返回的fileId
        /// </summary>
        [JsonProperty("fileId")]
        public long FileId { get; set; }

        /// <summary>
        ///  是否为压缩文件，默认为false
        /// </summary>
        [JsonProperty("compressed")]
        public bool Compressed { get; set; }

        /// <summary>
        ///  如果是压缩文件，必须指定压缩包中哪一个是主文件。（例如：root.rvt）。
        /// 如果不是压缩，则设置为 null
        /// </summary>
        [JsonProperty("rootName", NullValueHandling = NullValueHandling.Ignore)]
        public string RootName { get; set; }
    }

    /// <summary>
    ///  dwg 模型配置项
    /// </summary>
    [Serializable]
    public class DwgModelConfig
    {
        /// <summary>
        ///  是否转成矢量图纸，默认为 true
        /// </summary>
        [JsonProperty("exportDrawing")]
        public bool ExportDrawing { get; set; }

        /// <summary>
        ///  是否导出pdf文件，默认为 false
        /// </summary>
        [JsonProperty("exportPdf")]
        public bool ExportPdf { get; set; }

        /// <summary>
        ///  是否导出缩略图，默认为 true
        /// </summary>
        [JsonProperty("exportThumb")]
        public bool ExportThumb { get; set; }
    }

    /// <summary>
    ///  rvt 模型配置项
    /// </summary>
    [Serializable]
    public class RvtModelConfig
    {
        public RvtModelConfig()
        {
            //设置 null，在序列化的时候忽略该字段，不出现在序列化后的字符串中
            Texture = null;
            ExportDwg = true;
            ExportDrawing = true;
            ExportPdf = null;
            ViewName = null;
            DisplayLevel = null;
            ExportDwgInstance = null;
            ExportHiddenObjects = null;
            ExportSystemType = null;
            ExportProperties = null;
            Unit = null;
            ExportSchedule = null;
        }

        /// <summary>
        ///  转换时是否添加材质。默认为 false
        /// </summary>
        [JsonProperty("texture", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Texture { get; set; }

        /// <summary>
        ///  rvt2md是否导出dwg文件。默认为 false
        /// </summary>
        [JsonProperty("exportDwg", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportDwg { get; set; }

        /// <summary>
        ///  dwg2md是否导出mdv(矢量化图纸);取值为true时，exportDwg自动设置为true。默认为 false
        /// </summary>
        [JsonProperty("exportDrawing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportDrawing { get; set; }

        /// <summary>
        ///  dwg2md是否导出pdf文件。默认为 false
        /// </summary>
        [JsonProperty("exportPdf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportPdf { get; set; }

        /// <summary>
        ///  转换使用的3D视图。默认为 {3D}
        /// </summary>
        [JsonProperty("viewName", NullValueHandling = NullValueHandling.Ignore)]
        public string ViewName { get; set; }

        /// <summary>
        ///  设置转换的精细度，fine（精细），medium（中等），coarse（粗略）。默认为 fine
        /// </summary>
        [JsonProperty("displaylevel", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayLevel { get; set; }

        /// <summary>
        /// 是否导出dwg实例。默认为 false
        /// </summary>
        [JsonProperty("exportDwgInstance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportDwgInstance { get; set; }

        /// <summary>
        /// 是否导出三维视图中隐藏的构件。默认为 false
        /// </summary>
        [JsonProperty("exportHiddenObjects", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportHiddenObjects { get; set; }

        /// <summary>
        /// 是否在userData中加入mepSystemType。默认为 false
        /// </summary>
        [JsonProperty("exportSystemType", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportSystemType { get; set; }

        /// <summary>
        /// 是否在导出NWD的属性db文件。默认为 false
        /// </summary>
        [JsonProperty("exportProperties", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportProperties { get; set; }

        /// <summary>
        ///  设置转换使用的单位，取值"ft"\"feet"\"英尺"采用revit默认的英尺为单位，默认以毫米为单位。默认为空
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 是否使用明细表内容。默认为 false
        /// </summary>
        [JsonProperty("exportSchedule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExportSchedule { get; set; }
    }
}