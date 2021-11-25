<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIDemo3.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.APIDemo3" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>文件直传</title>
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
        <asp:Button ID="btnGetPolicy" runat="server" Text="获取policy凭证" Width="150px" OnClick="btnGetPolicy_Click"  />&nbsp;
        <asp:Button ID="btnUploadFileByUrl" runat="server" Text="文件直传" Width="180px" OnClick="btnUploadFileByUrl_Click"/>
    </div>
    <div style="margin: 20px;">
        <asp:Label ID="Label2" runat="server" Text="结果："></asp:Label>
        <br />
        <asp:TextBox ID="txtResult" runat="server" Height="280px" TextMode="MultiLine" Width="1000px"></asp:TextBox>
    </div>
</form>
</body>
</html>

