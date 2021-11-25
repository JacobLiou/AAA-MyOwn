<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BIMFaceDemo2.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.BIMFaceDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>文件转换API调用示例</title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="margin: 10px;">
            <asp:TextBox ID="txtAccessToken" runat="server" Width="311px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" OnClick="btnGetAccessToken_Click" Width="260px" />
        </div>
        <div>
             &nbsp;FileID：
            <asp:TextBox ID="txtFileID" runat="server" Width="311px">1684795532158432</asp:TextBox>
        </div>
        <div style="margin: 20px;">
            <asp:Panel ID="Panel1ForDWG" runat="server" BorderStyle="Dotted" GroupingText="DWG文件转换">
                <asp:Label ID="Label1" runat="server" Text="转换选项："></asp:Label>
                <asp:CheckBox ID="chkDwgExportDrawing" runat="server" Text="转成矢量图纸" />
                &nbsp;
                <asp:CheckBox ID="chkDwgExportPdf" runat="server" Text="导出pdf文件" />&nbsp;
                <asp:CheckBox ID="chkDwgExportThumb" runat="server" Text="导出缩略图" />
                <br />
                <br />
                <asp:Button ID="btnTranslateDwgToVectorDrawings" runat="server" Text="将DWG文件转换成矢量图纸" OnClick="btnTranslateDwgToVectorDrawings_Click" Width="260px" />
                &nbsp;
            <asp:Button ID="btnTranslateDwgToPicture" runat="server" Text="将DWG文件转换成图片" OnClick="btnTranslateDwgToPicture_Click" Width="260px" />
            </asp:Panel>
        </div>
        <div style="margin: 20px;">
            <asp:Panel ID="Panel2ForRvt" runat="server" BorderStyle="Dotted" GroupingText="RVT文件转换">
                <asp:Label ID="Label2" runat="server" Text="转换选项："></asp:Label>
                <asp:CheckBox ID="chkRvtTexture" runat="server" Text="转换时添加材质" />
                &nbsp;
                <asp:CheckBox ID="chkRvtExportDwg" runat="server" Text="rvt2md时导出dwg文件" />
                &nbsp;
                <asp:CheckBox ID="chkRvtExportDrawing" runat="server" Text="dwg2md时导出mdv(矢量化图纸).取值为true时，exportDwg自动设置为true" />
                &nbsp; 
                <br />
                <asp:CheckBox ID="chkRvtExportPdf" runat="server" Text="dwg2md时导出pdf文件" />
                &nbsp;
                <asp:CheckBox ID="chkRvtExportDwgInstance" runat="server" Text="导出dwg实例" />
                &nbsp;
                <asp:CheckBox ID="chkRvtExportHiddenObjects" runat="server" Text="导出三维视图中隐藏的构件" />
                &nbsp;
                <asp:CheckBox ID="chkRvtExportSystemType" runat="server" Text="在userData中加入mepSystemType" />
                &nbsp;
                <asp:CheckBox ID="chkRvtExportProperties" runat="server" Text="导出NWD的属性db文件" />
                &nbsp;
                <br />
                <asp:CheckBox ID="chkRvtExportSchedule" runat="server" Text="使用明细表内容" />
                &nbsp;
                
                &nbsp; &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="转换精细度："></asp:Label>
                <asp:RadioButton ID="rbtnRvtDisplayLevelOfFine" runat="server" Checked="True" GroupName="RvtDisplayLevel" Text="精细" />
                <asp:RadioButton ID="rbtnRvtDisplayLevelOfMedium" runat="server" Checked="False" GroupName="RvtDisplayLevel" Text="中等" />
                <asp:RadioButton ID="rbtnRvtDisplayLevelOfCoarse" runat="server" Checked="False" GroupName="RvtDisplayLevel" Text="粗略" />
                <br />
                <asp:Label ID="Label4" runat="server" Text="转换使用的3D视图："></asp:Label><asp:TextBox ID="txtRvtViewName" runat="server">3D</asp:TextBox>
                &nbsp; 
                <asp:Label ID="Label5" runat="server" Text="设置转换使用的单位："></asp:Label><asp:TextBox ID="txtRvtUnit" runat="server"></asp:TextBox>
                &nbsp;取值&quot;ft&quot;\&quot;feet&quot;\&quot;英尺&quot;,采用revit默认的英尺为单位, 默认以毫米为单位.<br />
                <br />
                <asp:Button ID="btnTranslateRvtToRenderStyle" runat="server" OnClick="btnTranslateRvtToRenderStyle_Click" Text="将RVT文件转换成着色模式的效果" Width="310px" />
                &nbsp;<asp:Button ID="btnTranslateRvtToRealStyle" runat="server" OnClick="btnTranslateRvtToRealStyle_Click" Text="将RVT文件转换成真实模式的效果" Width="310px" />
                &nbsp;<asp:Button ID="btnTranslateRvtTo23LinkStyle" runat="server" OnClick="btnTranslateRvtTo23LinkStyle_Click" Text="将RVT格式文件转换为具备二三维联动的功能效果" Width="450px" />
                <br />
                <div style="margin-top: 10px;">
                    <asp:Button ID="btnTranslateOther3DModelToWithoutMaterialStyle" runat="server" OnClick="btnTranslateOther3DModelToWithoutMaterialStyle_Click" Text="其它三维模型文件转换，常规转换（不带材质）" Width="450px" />
                    &nbsp;<asp:Button ID="btnTranslateOther3DModelToWithMaterialStyle" runat="server" Text="其他三维模型文件包括RVT格式文件，需要转换出引用的外部材质场景、贴图等" OnClick="btnTranslateOther3DModelToWithMaterialStyle_Click" Width="750px" />
                </div>

            </asp:Panel>
        </div>
        <div style="margin: 10px;">
            &nbsp;<br />
            <asp:Button ID="btnGetFileTranslateStatus" runat="server" Text="获取转换状态" OnClick="btnGetFileTranslateStatus_Click" Width="260px" />
            &nbsp;<asp:Button ID="btnGetFileTranslateDetails" runat="server" Text="批量获取转换状态详情" OnClick="btnGetFileTranslateDetails_Click" Width="260px" />
            &nbsp;<asp:Button ID="btnGetSingleModelViews" runat="server" OnClick="btnGetSingleModelViews_Click" Text="获取三维视点或二维视图列表" Width="277px" />
            &nbsp;<asp:Button ID="btnGetSingleModelDrawingSheets" runat="server" OnClick="btnGetSingleModelDrawingSheets_Click" Text="获取单个模型的图纸列表" Width="266px" />
        </div>
        <div style="margin: 20px;">
            <asp:Label ID="Label3" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="160px" TextMode="MultiLine" Width="1000px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
