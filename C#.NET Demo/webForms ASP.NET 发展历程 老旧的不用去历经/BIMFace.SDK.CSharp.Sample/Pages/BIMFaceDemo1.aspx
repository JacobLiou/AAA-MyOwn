<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BIMFaceDemo1.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.BIMFaceDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Token、源文件上传及上传成功后获取信息API调用示例</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 25px;">
            <asp:TextBox ID="txtAccessToken" runat="server" Width="310px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" OnClick="btnGetAccessToken_Click" Width="189px" />
        </div>
        <div style="margin: 25px;">
            文件：<asp:TextBox ID="txtFile" runat="server" Width="780px">F:\BIM示例模型文件\Samples\rac_advanced_sample_project.rvt</asp:TextBox>
            &nbsp;&nbsp;<br /><br />
           <div style="padding-left: 330px;">
               <asp:Button ID="btnUpload" runat="server" Text="上传 -- 普通文件流" OnClick="btnUpload_Click" Width="160px" />
               &nbsp;<asp:Button ID="btnUpload2" runat="server" Text="上传 -- 文件直传" OnClick="btnUpload2_Click" Width="160px" />
           </div>
          
        </div>
        <div style="margin: 25px;">
            <asp:Label ID="Label1" runat="server" Text="文件ID：">
            </asp:Label><asp:TextBox ID="txtFileId" runat="server" Width="246px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnGetFileInfo" runat="server" Text="获取文件信息" OnClick="btnGetFileInfo_Click" Width="160px" />
            &nbsp;<asp:Button ID="btnGetFileUploadStatus" runat="server" Text="获取文件上传状态信息" OnClick="btnGetFileUploadStatus_Click" Width="210px" />
            &nbsp;<asp:Button ID="btnGetFileList" runat="server" Text="获取文件信息列表" OnClick="btnGetFileList_Click" Width="227px" />
            &nbsp;<br />
           
            <div style="margin-top: 10px; padding-left: 330px;">
                <asp:Button ID="btnGetFileSupport" runat="server" Text="获取应用支持的文件类型" OnClick="btnGetFileSupport_Click" Width="251px" />
                &nbsp;<asp:Button ID="btnGetFileDownloadUrl" runat="server" Text=" 获取文件下载链接" OnClick="btnGetFileDownloadUrl_Click" Width="209px" />
                &nbsp;<asp:Button ID="btnDeleteFile" runat="server" Text=" 根据文件ID删除文件" OnClick="btnDeleteFile_Click" Width="197px" />
            </div>
         
            <div style="margin-top: 10px; padding-left: 330px;">
                <asp:Button ID="btnGetViewTokenByFileId" runat="server" Text="获取 ViewToken【文件转换ID】" Width="483px" OnClick="btnGetViewTokenByFileId_Click" />
            </div>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="120px" TextMode="MultiLine" Width="820px"></asp:TextBox>
        </div>

    </form>
</body>
</html>
