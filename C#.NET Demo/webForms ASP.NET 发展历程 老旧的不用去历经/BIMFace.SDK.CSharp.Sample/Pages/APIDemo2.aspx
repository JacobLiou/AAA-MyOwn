<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIDemo2.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.APIDemo2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>源文件上传</title>
    <style type="text/css">
        #File1 {
            width: 893px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            <asp:Label ID="Label0" runat="server" Text="源文件："></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" Width="492px" />
        </div>
        <div style="margin: 20px;">
            AccessToken：
            <asp:TextBox ID="txtAccessToken" runat="server" Width="500px" ReadOnly="True"></asp:TextBox>
        </div>
        <div style="margin: 20px;padding-left:108px;">
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" Width="150px" OnClick="btnGetAccessToken_Click" /> &nbsp;
            &nbsp;
            <asp:Button ID="btnUploadFileByUrl" runat="server" Text="指定外部文件url方式上传" Width="180px" OnClick="btnUploadFileByUrl_Click"/>
            <asp:Button ID="btnUploadFileByStream" runat="server" Text="普通文件流上传" Width="150px" OnClick="btnUploadFileByStream_Click" ForeColor="#CC99FF" />
        </div>
        <div style="margin: 20px;">
            <asp:Label ID="Label2" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="260px" TextMode="MultiLine" Width="600px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
