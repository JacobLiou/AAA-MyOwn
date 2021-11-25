<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APIDemo1.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.APIDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>获取 Access Token</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 20px;">
            AccessToken：
            <asp:TextBox ID="txtAccessToken" runat="server" Width="500px" ReadOnly="True"></asp:TextBox>
        </div>
        <div style="margin: 20px;padding-left:118px;">
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" Width="190px" OnClick="btnGetAccessToken_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnGetAccessTokenFormCache" runat="server" Text="缓存方式获取 AccessToken" Width="295px" OnClick="btnGetAccessTokenFormCache_Click" />
        </div>
        <div style="margin: 20px;">
            <asp:Label ID="Label2" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="260px" TextMode="MultiLine" Width="600px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
