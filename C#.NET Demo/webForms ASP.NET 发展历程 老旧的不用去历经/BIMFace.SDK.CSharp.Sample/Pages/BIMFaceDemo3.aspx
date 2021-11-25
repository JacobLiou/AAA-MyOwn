<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BIMFaceDemo3.aspx.cs" Inherits="BIMFace.SDK.CSharp.Sample.Pages.BIMFaceDemo3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>获取模型数据API调用示例</title>
</head>
<body>
      <form id="form1" runat="server">
        <div style="margin: 10px;">
            <asp:TextBox ID="txtAccessToken" runat="server" Width="311px"></asp:TextBox>
            &nbsp;
            <asp:Button ID="btnGetAccessToken" runat="server" Text="获取 AccessToken" OnClick="btnGetAccessToken_Click" Width="260px" />
        </div>
        <div style="margin: 10px;">
            <asp:Panel ID="Panel1ForDWG" runat="server" BorderStyle="Dotted" GroupingText="获取模型数据">
                &nbsp; 
                FileID：
                <asp:TextBox ID="txtFileID" runat="server" Width="1000px"></asp:TextBox>
                <div style="margin: 5px;">
                    &nbsp;<asp:Button ID="btnGetFileTranslateStatus" runat="server" Text="获取转换状态" OnClick="btnGetFileTranslateStatus_Click" Width="260px" />
                    &nbsp;<asp:Button ID="btnGetFileTranslateDetails" runat="server" Text="批量获取转换状态详情" Width="260px" OnClick="btnGetFileTranslateDetails_Click" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;<asp:Button ID="btnGetSingleModelElements" runat="server" Text="查询满足条件的构件ID列表" OnClick="btnGetSingleModelElements_Click" Width="260px" />
                    &nbsp;构建ID列表：<asp:DropDownList ID="ddlSingleModelElements" runat="server" Width="140px"></asp:DropDownList>
                    &nbsp;<asp:Button ID="btnGetSingleModelSingleElementMaterials" runat="server" Text="获取构件材质列表" Width="180px" OnClick="btnGetSingleModelSingleElementMaterials_Click" />
                    &nbsp;<asp:Button ID="btnGetSingleModelSingleElementProperty" runat="server" OnClick="btnGetSingleModelSingleElementProperty_Click" Text="获取构件属性" Width="180px" />
                    &nbsp;<asp:CheckBox ID="chkIncludeOverrides" runat="server" Text="查询修改的属性" />
                    <br />
                    <br />
                    多个构建ID：<asp:TextBox ID="txtMultipleElementIds" runat="server" Width="415px"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnGetSingleModelMultipleElementsCommonProperties" runat="server" Text="获取多个构件的共同属性" OnClick="btnGetSingleModelMultipleElementsCommonProperties_Click" Width="240px" />
                    &nbsp;<asp:Button ID="btnGetSingleModelMultipleElementsProperties" runat="server" Text="批量获取构件属性" OnClick="btnGetSingleModelMultipleElementsProperties_Click" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;<asp:Button ID="btnGetSingleModelFloors" runat="server" Text="获取单模型的楼层信息" Width="260px" OnClick="btnGetSingleModelFloors_Click" />
                    &nbsp;<asp:Button ID="btnGetMultipleModelFloors" runat="server" Text="获取多模型的楼层信息" Width="260px" OnClick="btnGetMultipleModelFloors_Click" />
                    &nbsp;<asp:CheckBox ID="chkIncludeArea" runat="server" Text="是否将楼层中的面积分区ID、名称一起返回" />
                    &nbsp;<asp:CheckBox ID="chkIncludeRoom" runat="server" Text="是否将楼层中的房间ID、名称一起返回" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;<asp:Button ID="btnGetSingleModelLink" runat="server" Text="获取单模型链接信息" Width="260px" OnClick="btnGetSingleModelLink_Click" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 房间ID：<asp:TextBox ID="txtRoomId" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnGetSingleModelSingleRoom" runat="server" Text="获取单个房间信息" Width="280px" OnClick="btnGetSingleModelSingleRoom_Click" />

                </div>
                <div style="margin: 5px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 楼层ID：<asp:TextBox ID="txtFloorId" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnGetSingleModelSingleFloorAreas" runat="server" Text="获取楼层对应面积分区列表" Width="280px" OnClick="btnGetSingleModelSingleFloorAreas_Click" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;面积分区ID：<asp:TextBox ID="txtAreaId" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnGetSingleModelSingleArea" runat="server" Text="获取单个面积分区信息" Width="280px" OnClick="btnGetSingleModelSingleArea_Click" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;<asp:Button ID="btnGetSingleModelTreeByDefault" runat="server" Text="获取构件分类树（默认）" Width="280px" OnClick="btnGetSingleModelTreeByDefault_Click" />
                    &nbsp;<br />

                    &nbsp;<asp:Button ID="btnGetSingleModelTreeByCustomized" runat="server" OnClick="btnGetSingleModelTreeByCustomized_Click" Text="获取构件分类树（自定义）" Width="280px" />
                    &nbsp;筛选树的层次：<asp:CheckBox ID="chkTreeBuilding" runat="server" Text="building" Checked="True" />
                    &nbsp;<asp:CheckBox ID="chkTreeSystemType" runat="server" Text="systemType" Checked="True" />
                    &nbsp;<asp:CheckBox ID="chkTreeSpecialty" runat="server" Text="specialty" Checked="True" />
                    &nbsp;<asp:CheckBox ID="chkTreeFloor" runat="server" Text="floor" Checked="True" />
                    &nbsp;<asp:CheckBox ID="chkTreeCategory" runat="server" Text="category" Checked="True" />
                    &nbsp;<asp:CheckBox ID="chkTreeFamily" runat="server" Text="family" Checked="True" />
                    &nbsp;<asp:CheckBox ID="chkTreeFamilyType" runat="server" Text="familyType" Checked="True" />
                    <br />
                    &nbsp;<asp:Button ID="btnGetSingleModelViews" runat="server" Text="获取三维视点或二维视图列表" Width="280px" OnClick="btnGetSingleModelViews_Click" />
                </div>
                <div style="margin: 5px;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 构建ID：<asp:TextBox ID="txtElementId" runat="server"></asp:TextBox>
                    &nbsp;<asp:Button ID="btnGetSingleModelDrawingSheets" runat="server" Text="获取图纸列表" Width="280px" OnClick="btnGetSingleModelDrawingSheets_Click" />

                </div>
            </asp:Panel>
        </div>

        <div style="margin: 10px;">
            <asp:Label ID="Label3" runat="server" Text="结果："></asp:Label>
            <br />
            <asp:TextBox ID="txtResult" runat="server" Height="160px" TextMode="MultiLine" Width="1000px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
