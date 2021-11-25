<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIDemo4.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.APIDemo4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>RVT文件转换</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px; padding-left: 95px;">
            <asp:TextBox ID="txtAccessToken" runat="server" Width="400px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" Width="190px" OnClick="btnGetAccessToken_Click" />
        </div>

        <div style="margin: 20px;">
            FileID：
            <asp:TextBox ID="txtFileId" runat="server" Width="400px"></asp:TextBox>
            &nbsp;<br />

            <div style="margin: 20px;">
                <asp:Panel ID="Panel2ForRvt" runat="server" BorderStyle="Dotted" GroupingText="RVT文件转换选项">
                    &nbsp;<asp:CheckBox ID="chkRvtTexture" runat="server" Text="转换时添加材质" />
                    &nbsp;
                    <asp:CheckBox ID="chkRvtExportDwg" runat="server" Text="rvt2md时导出dwg文件" />
                    &nbsp; 
                    <asp:CheckBox ID="chkRvtExportDrawing" runat="server" Text="dwg2md时导出mdv(矢量化图纸).取值为true时，exportDwg自动设置为true" />
                    &nbsp;
                    <br />
                    &nbsp;<asp:CheckBox ID="chkRvtExportPdf" runat="server" Text="dwg2md时导出pdf文件" />
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
                    &nbsp;<asp:CheckBox ID="chkRvtExportSchedule" runat="server" Text="使用明细表内容" />
                    &nbsp; &nbsp; &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Text="转换精细度："></asp:Label>
                    <asp:RadioButton ID="rbtnRvtDisplayLevelOfFine" runat="server" Checked="True" GroupName="RvtDisplayLevel" Text="精细" />
                    <asp:RadioButton ID="rbtnRvtDisplayLevelOfMedium" runat="server" Checked="False" GroupName="RvtDisplayLevel" Text="中等" />
                    <asp:RadioButton ID="rbtnRvtDisplayLevelOfCoarse" runat="server" Checked="False" GroupName="RvtDisplayLevel" Text="粗略" />
                    <br />
                    &nbsp;<asp:Label ID="Label4" runat="server" Text="转换使用的3D视图："></asp:Label>
                    &nbsp;
                    <asp:TextBox ID="txtRvtViewName" runat="server">3D</asp:TextBox>
                    &nbsp;<br />
                    &nbsp;<asp:Label ID="Label5" runat="server" Text="设置转换使用的单位："></asp:Label>
                    <asp:TextBox ID="txtRvtUnit" runat="server"></asp:TextBox>
                    &nbsp;取值&quot;ft&quot;\&quot;feet&quot;\&quot;英尺&quot;,采用revit默认的英尺为单位, 默认以毫米为单位.<br />

                </asp:Panel>
            </div>

            &nbsp;<asp:Button ID="btnTranslateRvt1" runat="server" Text="发起文件转换（着色模式）" Width="190px" OnClick="btnTranslateRvt1_Click" />
            &nbsp;<asp:Button ID="btnTranslateRvt2" runat="server" Text="发起文件转换（真实模式）" Width="190px" OnClick="btnTranslateRvt2_Click" />
            &nbsp;<asp:Button ID="btnTranslateRvt3" runat="server" Text="发起文件转换（二三维联动）" Width="190px" OnClick="btnTranslateRvt3_Click" />
            &nbsp;
            <asp:Button ID="btnGetRvtTranslateStatus" runat="server" Text="获取转换状态" Width="190px" OnClick="btnGetRvtTranslateStatus_Click" />
            &nbsp;
        </div>
        <div style="margin: 20px;">
            <asp:Label ID="Label2" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="260px" TextMode="MultiLine" Width="1000px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
