USE [HzyAdminRazor]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[Id] [uniqueidentifier] NOT NULL,
	[Number] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
	[Sex] [nvarchar](255) NULL,
	[Birthday] [datetime] NOT NULL,
	[Photo] [nvarchar](255) NULL,
	[Introduce] [nvarchar](255) NULL,
	[FilePath] [nvarchar](255) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__FreeSqlT__3214EC0764A3C16E] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysFunction]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysFunction](
	[Id] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,
	[Name] [nvarchar](255) NULL,
	[ByName] [nvarchar](255) NULL,
	[Remark] [nvarchar](255) NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__SysFunct__3214EC0749F8ECB2] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysMenu]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysMenu](
	[Id] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,
	[Name] [nvarchar](255) NULL,
	[Url] [nvarchar](255) NULL,
	[Icon] [nvarchar](255) NULL,
	[ParentId] [uniqueidentifier] NULL,
	[IsShow] [int] NOT NULL,
	[IsClose] [int] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__FreeSqlT__3214EC07A99B1246] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysMenuFunction]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysMenuFunction](
	[Id] [uniqueidentifier] NOT NULL,
	[MenuId] [uniqueidentifier] NOT NULL,
	[FunctionId] [uniqueidentifier] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__SysMenuF__3214EC07594C72BD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysRole]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysRole](
	[Id] [uniqueidentifier] NOT NULL,
	[Number] [int] NULL,
	[Name] [nvarchar](255) NULL,
	[Remark] [nvarchar](255) NULL,
	[IsDelete] [int] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__SysRole__3214EC07CF50E1D0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysRoleMenuFunction]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysRoleMenuFunction](
	[Id] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[MenuId] [uniqueidentifier] NOT NULL,
	[FunctionId] [uniqueidentifier] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__SysRoleM__3214EC075D76B808] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUser]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUser](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[LoginName] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[Email] [nvarchar](255) NULL,
	[IsDelete] [int] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__FreeSqlT__3214EC079C566918] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SysUserRole]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SysUserRole](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
 CONSTRAINT [PK__SysUserR__3214EC070ABEE823] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 2021/3/20 15:09:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([Id], [Number], [Name], [Phone], [Sex], [Birthday], [Photo], [Introduce], [FilePath], [UserId], [CreateTime], [UpdateTime]) VALUES (N'96a1aa3d-a61a-42d0-954a-c71753fb2065', N'123', N'123', N'123', N'女', CAST(N'2018-04-25T23:00:00.000' AS DateTime), N'/upload/files/20210319/time_223807_old_name_微信图片_20200521081252.jpg', NULL, NULL, N'ac18f496-e93d-42f0-b59e-e321acc85335', CAST(N'2020-10-24T00:07:42.470' AS DateTime), CAST(N'2021-03-19T22:38:14.890' AS DateTime))
INSERT [dbo].[Member] ([Id], [Number], [Name], [Phone], [Sex], [Birthday], [Photo], [Introduce], [FilePath], [UserId], [CreateTime], [UpdateTime]) VALUES (N'9a604aa2-9ae6-4a2f-8ddb-d9e0289ead9e', N'1', N'测试会员', N'18510912123', N'男', CAST(N'2019-07-08T11:47:24.000' AS DateTime), N'/upload/files/20210319/time_223801_old_name_HZY.IOT.png', N'<p>兄弟们牛逼</p>', N'/admin/libs/neditor/net/upload/image/20200329/6372111070665271023522535.png', N'ac18f496-e93d-42f0-b59e-e321acc85335', CAST(N'2018-04-25T23:00:00.000' AS DateTime), CAST(N'2021-03-19T22:44:40.437' AS DateTime))
GO
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'b6fd5425-504a-46a9-993b-2f8dc9158eb8', 80, N'打印', N'print', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'c9518758-b2e1-4f51-b517-5282e273889c', 10, N'显示', N'have', NULL, CAST(N'2021-03-19T22:32:59.627' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'f27ecb0a-197d-47b1-b243-59a8c71302bf', 60, N'检索', N'search', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'383e7ee2-7690-46ac-9230-65155c84aa30', 50, N'保存', N'save', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'9c388461-2704-4c5e-a729-72c17e9018e1', 40, N'删除', N'delete', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', 20, N'添加', N'insert', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'2401f4d0-60b0-4e2e-903f-84c603373572', 70, N'导出', N'export', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
INSERT [dbo].[SysFunction] ([Id], [Number], [Name], [ByName], [Remark], [UpdateTime], [CreateTime]) VALUES (N'e7ef2a05-8317-41c3-b588-99519fe88bf9', 30, N'修改', N'update', NULL, CAST(N'2016-06-20T13:40:52.360' AS DateTime), CAST(N'2016-06-20T13:40:52.360' AS DateTime))
GO
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'9674d439-864e-4bf8-9dd8-08d7d70ad6bb', 20, N'组件展示', N'/Admin/Components/Index', N'el-icon-news', NULL, 1, 1, CAST(N'2021-03-20T15:03:32.200' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', 130, N'菜单功能', N'/Admin/SysMenu/Index', NULL, N'9591f249-1471-44f7-86b5-6fdae8b93888', 1, 1, CAST(N'2018-03-10T12:18:33.997' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'd721fc55-2174-40eb-bb37-5c54a158525a', 120, N'功能管理', N'/Admin/SysFunction/Index', NULL, N'9591f249-1471-44f7-86b5-6fdae8b93888', 1, 1, CAST(N'2018-03-10T12:18:21.087' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'6056054b-ac4f-6a84-0028-6dfb1196737f', 30, N'富文本编辑器', N'/views/editor.html', N'el-icon-menu', NULL, 1, 1, CAST(N'2021-03-20T15:03:38.547' AS DateTime), CAST(N'2021-03-20T14:23:07.260' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'6056089c-ac4f-6a84-0028-6dff4ebd452c', 40, N'图形报表', N'/views/chart/base.html', N'el-icon-s-data', NULL, 1, 1, CAST(N'2021-03-20T15:03:46.697' AS DateTime), CAST(N'2021-03-20T14:37:16.310' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'6056092a-ac4f-6a84-0028-6e0561e0d506', 50, N'Antv图形库', N'/views/chart/more.html', N'el-icon-s-marketing', NULL, 1, 1, CAST(N'2021-03-20T15:03:51.847' AS DateTime), CAST(N'2021-03-20T14:39:38.743' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'9591f249-1471-44f7-86b5-6fdae8b93888', 100, N'系统管理', NULL, N'el-icon-monitor', NULL, 1, 1, CAST(N'2021-03-20T15:03:57.177' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'0b7f8e2c-9faa-4496-9068-80b87ba1b64e', 1, N'首页', N'/Admin/Home/Main', N'el-icon-s-home', NULL, 1, 0, CAST(N'2021-03-20T15:03:18.353' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', 100, N'用户管理', N'/Admin/SysUser/Index', NULL, N'9591f249-1471-44f7-86b5-6fdae8b93888', 1, 1, CAST(N'2018-03-10T12:18:03.657' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'bd024f3a-99a7-4407-861c-a016f243f222', 140, N'角色功能', N'/Admin/SysRoleMenuFunction/Index', NULL, N'9591f249-1471-44f7-86b5-6fdae8b93888', 1, 1, CAST(N'2018-03-10T12:18:46.617' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'7c34c2fd-98ed-4655-aa04-bb00b915a751', 10, N'会员管理', N'/Admin/Member/Index', NULL, N'1ec76c4c-b9b3-4517-9854-f08cd11d653d', 1, 1, CAST(N'2018-04-25T21:36:28.533' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'60ae9382-31ab-4276-a379-d3876e9bb783', 110, N'角色管理', N'/Admin/SysRole/Index', NULL, N'9591f249-1471-44f7-86b5-6fdae8b93888', 1, 1, CAST(N'2018-03-10T12:18:55.290' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'f35d64ae-ecb7-4d06-acfb-d91595966d9e', 150, N'修改密码', N'/Admin/ChangePassword/Index', NULL, N'9591f249-1471-44f7-86b5-6fdae8b93888', 1, 1, CAST(N'2018-03-10T12:17:03.810' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
INSERT [dbo].[SysMenu] ([Id], [Number], [Name], [Url], [Icon], [ParentId], [IsShow], [IsClose], [UpdateTime], [CreateTime]) VALUES (N'1ec76c4c-b9b3-4517-9854-f08cd11d653d', 10, N'基础信息', NULL, N'el-icon-coin', NULL, 1, 1, CAST(N'2021-03-20T15:03:25.110' AS DateTime), CAST(N'2020-11-16T13:09:47.937' AS DateTime))
GO
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'9d7baf7d-36b0-4b3b-a5ad-064c8dfc8324', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2019-07-08T18:37:14.633' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'e2d0c07a-e74f-46f2-8991-113cd58c4785', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'2401f4d0-60b0-4e2e-903f-84c603373572', CAST(N'2019-07-11T10:21:32.810' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'0b81b937-fdc2-4a2c-90c4-11e9ddf3ba71', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2019-07-11T10:22:14.937' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'8aaa6319-d36a-4fcd-8797-19d97a077e1b', N'74b837ae-d24f-4f57-b107-e20dbe70f5d3', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2019-07-08T21:15:57.680' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'cfc06085-563d-488d-807a-1b766180eff9', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'2401f4d0-60b0-4e2e-903f-84c603373572', CAST(N'2019-07-08T18:37:25.673' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'7f549d57-c5d3-4ad8-bc12-1e7c99ae4de5', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'9c388461-2704-4c5e-a729-72c17e9018e1', CAST(N'2019-07-11T10:21:54.010' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'8c0bf314-fa41-40d3-8d8c-20f614dd078a', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'9c388461-2704-4c5e-a729-72c17e9018e1', CAST(N'2019-07-11T10:21:32.807' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'a49b958c-f00c-4c0d-b031-21190e5c74fa', N'f35d64ae-ecb7-4d06-acfb-d91595966d9e', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2018-04-22T15:47:38.933' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'7e466377-1810-4027-ae1b-227f53953b21', N'74b837ae-d24f-4f57-b107-e20dbe70f5d3', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2019-07-08T21:15:57.680' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'd32e240a-ab34-41a3-92fc-249dab655c3a', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'2401f4d0-60b0-4e2e-903f-84c603373572', CAST(N'2019-07-11T10:21:54.010' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'73caab90-ac89-4334-ae61-2b55f3d08826', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2019-07-11T10:21:54.007' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'4a99997e-ef14-414b-94a6-2f480e5b2cd2', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'2401f4d0-60b0-4e2e-903f-84c603373572', CAST(N'2019-07-08T18:37:14.637' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'f134c325-eb68-498f-86b2-307c315eb8cc', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'9c388461-2704-4c5e-a729-72c17e9018e1', CAST(N'2019-07-11T10:22:14.940' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'ed6454dc-3d01-47e2-86f3-40121f9c6976', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'9c388461-2704-4c5e-a729-72c17e9018e1', CAST(N'2019-07-08T18:37:25.670' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'92913243-421b-420d-9fbf-42d7db59aec9', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2019-07-08T18:37:14.627' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'397b5f2c-812e-431a-914d-43d318bc4242', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2019-07-08T18:37:25.667' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'0cb00876-7247-4d4a-b68d-44f807232b3c', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2020-04-04T11:32:16.203' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'44dd215e-1edf-45aa-b6c6-4910ed14a228', N'b73c82f9-54ea-4f02-b7d9-fc3976becb19', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2020-04-04T11:44:37.933' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'6529e142-e4de-44a7-9acb-53df1796480c', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2019-07-08T18:37:14.630' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'1e827ff5-b7c8-43dd-b9ed-571d376b3dce', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2019-07-11T10:22:14.940' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'26cf07df-7c4b-4c59-b091-57479a28a8ac', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'9c388461-2704-4c5e-a729-72c17e9018e1', CAST(N'2019-07-08T18:37:14.630' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'540d4cfb-1b2f-4736-80ca-5a613642b5b4', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2019-07-11T10:21:32.807' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'c6dbd0f0-db95-4251-895b-6009239106cc', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2019-07-11T10:22:14.937' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'ef36a4f2-a70e-4ae3-923b-609910127a33', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2019-07-11T10:21:32.807' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'd72a7e1a-94a2-4d7c-ba13-6727398f8e35', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2019-07-11T10:21:54.010' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'5689b539-88db-49d2-8c5b-720e9ebc673e', N'74b837ae-d24f-4f57-b107-e20dbe70f5d3', N'2401f4d0-60b0-4e2e-903f-84c603373572', CAST(N'2019-07-08T21:15:57.680' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'b8aa1a54-9076-4c72-a323-7b3b95ab26f4', N'74b837ae-d24f-4f57-b107-e20dbe70f5d3', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2019-07-08T21:15:57.680' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'842d38fc-29a2-4a9e-8949-84d76fc6a259', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2019-07-11T10:21:32.803' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'afbd3366-4c4f-46b1-8f96-903cfe6f8a00', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2019-07-08T18:37:14.633' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'a3074d55-141e-496e-a55c-93b5fd2dce6c', N'74b837ae-d24f-4f57-b107-e20dbe70f5d3', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2019-07-08T21:15:57.680' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'e60670d2-4ade-449c-8a4b-9ad7d5179a43', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2019-07-11T10:21:54.003' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'd6f2707f-70ab-45f0-9c57-9d11ee5078d2', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2019-07-08T18:37:25.670' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'2ab18520-ee93-40f1-8633-9f5b174ac14e', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2019-07-08T18:37:25.667' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'bb14769d-4760-4341-9faf-9fa82eeada65', N'2ff9bb67-aa42-48cf-80c9-6d1cfb6b1ead', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2018-06-28T11:30:09.723' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'7861b618-0b12-4a56-abda-a5e8d17ac5d7', N'2ff9bb67-aa42-48cf-80c9-6d1cfb6b1ead', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2018-06-28T11:30:09.723' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'0b9170f7-e444-49a2-9f0c-a7e02ea1c33e', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'b6fd5425-504a-46a9-993b-2f8dc9158eb8', CAST(N'2019-07-11T10:21:54.010' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'09a29222-8f8d-4ca6-9bd1-aeddbabe7d7b', N'2dc579dc-2325-4063-b051-e92454ee3838', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2020-01-02T22:14:55.447' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'd62f6c43-ae93-4d50-a6f0-b64c9cacec7b', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2019-07-11T10:21:32.807' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'f0a60dc3-46ad-4fac-9a28-bd05eb8f11d6', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'2401f4d0-60b0-4e2e-903f-84c603373572', CAST(N'2019-07-11T10:22:14.947' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'ffd4aebd-6283-4c52-976b-c09b70f8034b', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'b6fd5425-504a-46a9-993b-2f8dc9158eb8', CAST(N'2019-07-11T10:22:14.947' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'42fc1519-61c2-4501-bb4e-cd160bea87a5', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2019-07-08T18:37:14.630' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'259c0396-8390-4632-be02-d02dc1c17123', N'bd024f3a-99a7-4407-861c-a016f243f222', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2018-07-31T13:51:51.553' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'30507f21-c866-4494-ae07-dae4d3906295', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2019-07-08T18:37:25.673' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'9d079f5a-c791-4628-b0d6-e3f7c8580a08', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2019-07-11T10:21:54.010' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'60560eb6-7f51-e024-0000-e549143bf5f6', N'0b7f8e2c-9faa-4496-9068-80b87ba1b64e', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2021-03-20T15:03:18.397' AS DateTime), CAST(N'2021-03-20T15:03:18.397' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'60560ec4-7f51-e024-0000-e54a2749b449', N'9674d439-864e-4bf8-9dd8-08d7d70ad6bb', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2021-03-20T15:03:32.210' AS DateTime), CAST(N'2021-03-20T15:03:32.210' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'60560eca-7f51-e024-0000-e54b497fec5d', N'6056054b-ac4f-6a84-0028-6dfb1196737f', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2021-03-20T15:03:38.557' AS DateTime), CAST(N'2021-03-20T15:03:38.557' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'60560ed2-7f51-e024-0000-e54c4408109a', N'6056089c-ac4f-6a84-0028-6dff4ebd452c', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2021-03-20T15:03:46.703' AS DateTime), CAST(N'2021-03-20T15:03:46.703' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'60560ed7-7f51-e024-0000-e54d2ace412e', N'6056092a-ac4f-6a84-0028-6e0561e0d506', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2021-03-20T15:03:51.860' AS DateTime), CAST(N'2021-03-20T15:03:51.860' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'fa162511-0213-4da2-9fbf-e5f45af5b7fc', N'7c34c2fd-98ed-4655-aa04-bb00b915a751', N'b6fd5425-504a-46a9-993b-2f8dc9158eb8', CAST(N'2019-07-11T10:21:32.810' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'8b445869-735c-4582-8af1-ec41d78a58dd', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2019-07-11T10:22:14.943' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'1c127383-0c46-44ac-8784-f8ae8a6dc390', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2019-07-08T18:37:25.667' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'ca5601ec-7cd9-4577-a699-fc7c3c4c1308', N'd721fc55-2174-40eb-bb37-5c54a158525a', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2019-07-11T10:21:54.003' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
INSERT [dbo].[SysMenuFunction] ([Id], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'9bee8a50-35bc-4198-b172-ffa341b9bc6e', N'e5d4da6b-aab0-4aaa-982f-43673e8152c0', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2019-07-11T10:22:14.943' AS DateTime), CAST(N'2020-11-16T13:24:03.533' AS DateTime))
GO
INSERT [dbo].[SysRole] ([Id], [Number], [Name], [Remark], [IsDelete], [UpdateTime], [CreateTime]) VALUES (N'18fa4771-6f58-46a3-80d2-6f0f5e9972e3', 1, N'超级管理员', N'拥有所有权限', 2, CAST(N'2016-06-20T10:20:10.000' AS DateTime), CAST(N'2016-07-06T17:59:20.000' AS DateTime))
INSERT [dbo].[SysRole] ([Id], [Number], [Name], [Remark], [IsDelete], [UpdateTime], [CreateTime]) VALUES (N'40ff1844-c099-4061-98e0-cd6e544fcfd3', 2, N'普通用户', N'普通用户', 1, CAST(N'2021-03-19T22:32:55.817' AS DateTime), CAST(N'2016-07-06T17:59:20.000' AS DateTime))
GO
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'69319296-75c1-4b22-3d5a-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2020-11-18T21:03:28.657' AS DateTime), CAST(N'2020-11-18T21:03:28.657' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'e0e47543-352f-49ec-3d5b-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2020-11-18T21:03:28.660' AS DateTime), CAST(N'2020-11-18T21:03:28.660' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'87804130-196f-4b2a-3d5c-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2020-11-18T21:03:28.660' AS DateTime), CAST(N'2020-11-18T21:03:28.660' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'0eb1ed6f-1dcc-44b7-3d5d-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'9c388461-2704-4c5e-a729-72c17e9018e1', CAST(N'2020-11-18T21:03:28.663' AS DateTime), CAST(N'2020-11-18T21:03:28.663' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'f40568cb-4371-4764-3d5e-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'383e7ee2-7690-46ac-9230-65155c84aa30', CAST(N'2020-11-18T21:03:28.663' AS DateTime), CAST(N'2020-11-18T21:03:28.663' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'5ce16c83-2d00-46f2-3d5f-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'38d864ff-f6e7-43af-8c5c-8bbcf9fa586d', N'f27ecb0a-197d-47b1-b243-59a8c71302bf', CAST(N'2020-11-18T21:03:28.667' AS DateTime), CAST(N'2020-11-18T21:03:28.667' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'be0e9ebc-b255-4f4c-3d60-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2020-11-18T21:03:29.317' AS DateTime), CAST(N'2020-11-18T21:03:29.317' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'6dd6132a-2628-4805-3d61-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'bffefb1c-8988-4ddf-b4ac-81c2b30e80cd', CAST(N'2020-11-18T21:03:29.320' AS DateTime), CAST(N'2020-11-18T21:03:29.320' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'cc7f7e79-341f-4a30-3d62-08d88bc25510', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', N'60ae9382-31ab-4276-a379-d3876e9bb783', N'e7ef2a05-8317-41c3-b588-99519fe88bf9', CAST(N'2020-11-18T21:03:29.323' AS DateTime), CAST(N'2020-11-18T21:03:29.323' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'93ce6573-523e-4e3c-3d63-08d88bc25510', N'18fa4771-6f58-46a3-80d2-6f0f5e9972e3', N'0b7f8e2c-9faa-4496-9068-80b87ba1b64e', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2020-11-18T21:03:35.763' AS DateTime), CAST(N'2020-11-18T21:03:35.763' AS DateTime))
INSERT [dbo].[SysRoleMenuFunction] ([Id], [RoleId], [MenuId], [FunctionId], [UpdateTime], [CreateTime]) VALUES (N'605526aa-b311-0944-0031-ec9058d528c9', N'18fa4771-6f58-46a3-80d2-6f0f5e9972e3', N'9674d439-864e-4bf8-9dd8-08d7d70ad6bb', N'c9518758-b2e1-4f51-b517-5282e273889c', CAST(N'2021-03-19T22:33:14.807' AS DateTime), CAST(N'2021-03-19T22:33:14.807' AS DateTime))
GO
INSERT [dbo].[SysUser] ([Id], [Name], [LoginName], [Password], [Email], [IsDelete], [UpdateTime], [CreateTime]) VALUES (N'0198459e-2034-4533-b843-5d227ad20740', N'管理员', N'admin', N'123456', N'1396510655@qq.com', 2, CAST(N'2021-03-20T14:58:56.090' AS DateTime), CAST(N'2017-04-06T19:55:53.083' AS DateTime))
INSERT [dbo].[SysUser] ([Id], [Name], [LoginName], [Password], [Email], [IsDelete], [UpdateTime], [CreateTime]) VALUES (N'ac18f496-e93d-42f0-b59e-e321acc85335', N'用户', N'user', N'123', N'18123456789@live.com', 1, CAST(N'2021-03-20T13:32:46.127' AS DateTime), CAST(N'2017-04-06T19:55:53.083' AS DateTime))
GO
INSERT [dbo].[SysUserRole] ([Id], [UserId], [RoleId], [UpdateTime], [CreateTime]) VALUES (N'5df9731c-c5ff-48c6-82cd-0ea9d7015a97', N'ac18f496-e93d-42f0-b59e-e321acc85335', N'40ff1844-c099-4061-98e0-cd6e544fcfd3', CAST(N'2021-03-20T13:32:46.197' AS DateTime), CAST(N'2021-03-20T13:32:46.197' AS DateTime))
INSERT [dbo].[SysUserRole] ([Id], [UserId], [RoleId], [UpdateTime], [CreateTime]) VALUES (N'8c2a4aed-7122-4f7b-a74c-271be34e6be3', N'0198459e-2034-4533-b843-5d227ad20740', N'18fa4771-6f58-46a3-80d2-6f0f5e9972e3', CAST(N'2021-03-20T14:18:47.687' AS DateTime), CAST(N'2021-03-20T14:18:47.687' AS DateTime))
GO
ALTER TABLE [dbo].[Member] ADD  CONSTRAINT [DF_Member_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Member] ADD  CONSTRAINT [DF_Member_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'生日' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Birthday'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Photo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'简介' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'Introduce'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'文件' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'FilePath'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账户Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'UserId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'member' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Member'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'ByName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysFunction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'Url'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单图标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'Icon'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父级Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'ParentId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否显示菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'IsShow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否可关闭' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'IsClose'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenuFunction', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenuFunction', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenuFunction', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单与功能绑定' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysMenuFunction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'Number'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'能否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRole'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRoleMenuFunction', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRoleMenuFunction', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRoleMenuFunction', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色菜单功能绑定' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysRoleMenuFunction'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账户名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'LoginName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'账户邮件地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'Email'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'能否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUser'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUserRole', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUserRole', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUserRole', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户与角色绑定' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'SysUserRole'
GO
