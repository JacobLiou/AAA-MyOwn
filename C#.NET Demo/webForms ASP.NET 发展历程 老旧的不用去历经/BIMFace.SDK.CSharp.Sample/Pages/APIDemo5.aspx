<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIDemo5.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.APIDemo5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>CAD图纸拆分</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px; padding-left:95px;"> 
            <asp:TextBox ID="txtAccessToken" runat="server" Width="400px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" Width="190px" OnClick="btnGetAccessToken_Click" />
        </div>

        <div style="margin: 20px;">
            图纸FileID：
            <asp:TextBox ID="txtFileId" runat="server" Width="400px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnSplitDrawing" runat="server" Text="发起图纸拆分" Width="190px" OnClick="btnSplitDrawing_Click" />
            &nbsp;
            <asp:Button ID="btnGetSplitDrawingStatus" runat="server" Text="获取图纸拆分状态" Width="190px" OnClick="btnGetSplitDrawingStatus_Click" />
            &nbsp;
            <asp:Button ID="btnGetSplitDrawingResult" runat="server" Text="获取图纸拆分结果" Width="190px" OnClick="btnGetSplitDrawingResult_Click" />
        </div>
        <div style="margin: 20px;">
            <asp:Label ID="Label2" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="260px" TextMode="MultiLine" Width="600px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
