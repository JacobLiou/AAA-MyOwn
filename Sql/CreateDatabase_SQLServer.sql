IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Domain] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [ContactPerson] nvarchar(50) NULL,
    [Email] nvarchar(200) NULL,
    [Cellphone] nvarchar(11) NULL,
    [MaxSiteCount] int NOT NULL,
    [MaxStaffCount] int NOT NULL,
    [CreateTime] datetime2 NOT NULL,
    [Removed] bit NOT NULL,
    CONSTRAINT [PK_Domain] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [PublishedClientVersion] (
    [Id] uniqueidentifier NOT NULL,
    [Type] nvarchar(max) NULL,
    [Version] nvarchar(max) NULL,
    [Url] nvarchar(max) NULL,
    CONSTRAINT [PK_PublishedClientVersion] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Dictionary] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Key] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Dictionary] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Dictionary_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Organization] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [ParentId] uniqueidentifier NULL,
    [IdPath] nvarchar(max) NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [NumericalOrder] int NOT NULL,
    [Removed] bit NOT NULL,
    CONSTRAINT [PK_Organization] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Organization_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Organization_Organization_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [Organization] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Role] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Role_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Site] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [Code] nvarchar(100) NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [CreateTime] datetime2 NOT NULL,
    [Removed] bit NOT NULL,
    CONSTRAINT [PK_Site] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Site_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SiteSettings_WebChatAd] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [ImageUrl] nvarchar(max) NULL,
    [LinkUrl] nvarchar(max) NULL,
    CONSTRAINT [PK_SiteSettings_WebChatAd] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebChatAd_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [DictionaryItem] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [DictionaryId] uniqueidentifier NOT NULL,
    [Text] nvarchar(100) NOT NULL,
    [Value] int NOT NULL,
    [NumericalOrder] int NOT NULL,
    CONSTRAINT [PK_DictionaryItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DictionaryItem_Dictionary_DictionaryId] FOREIGN KEY ([DictionaryId]) REFERENCES [Dictionary] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DictionaryItem_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Staff] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [OrganizationId] uniqueidentifier NOT NULL,
    [Account] nvarchar(100) NOT NULL,
    [Password] nvarchar(50) NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [NickName] nvarchar(100) NULL,
    [Gender] int NOT NULL,
    [Email] nvarchar(100) NULL,
    [QQ] nvarchar(100) NULL,
    [Telphone] nvarchar(50) NULL,
    [Cellphone] nvarchar(50) NULL,
    [Remark] nvarchar(500) NULL,
    [CreateTime] datetime2 NOT NULL,
    [DomainAdmin] bit NOT NULL,
    [Removed] bit NOT NULL,
    CONSTRAINT [PK_Staff] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Staff_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Staff_Organization_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [RoleAuthorization] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [RoleId] uniqueidentifier NOT NULL,
    [AuthorizationKey] nvarchar(100) NULL,
    CONSTRAINT [PK_RoleAuthorization] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RoleAuthorization_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_RoleAuthorization_Role_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Role] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [CustomerCategory] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Color] nvarchar(10) NOT NULL,
    CONSTRAINT [PK_CustomerCategory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CustomerCategory_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CustomerCategory_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [CustomerCount] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Country] nvarchar(100) NOT NULL,
    [Province] nvarchar(100) NOT NULL,
    [City] nvarchar(100) NOT NULL,
    [Count] int NOT NULL,
    CONSTRAINT [PK_CustomerCount] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CustomerCount_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CustomerCount_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [CustomerImportentLevel] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Color] nvarchar(10) NOT NULL,
    CONSTRAINT [PK_CustomerImportentLevel] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CustomerImportentLevel_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CustomerImportentLevel_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SiteSettings_Misc] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [DomainAddress] nvarchar(500) NULL,
    CONSTRAINT [PK_SiteSettings_Misc] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_Misc_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_Misc_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_MobileWebChatInvitePopupStyle] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Mode] int NOT NULL,
    [BackgroundImage] nvarchar(1000) NULL,
    [Html] nvarchar(max) NULL,
    [Width] int NOT NULL,
    [Height] int NOT NULL,
    [CloseButtonImage] nvarchar(1000) NULL,
    CONSTRAINT [PK_SiteSettings_MobileWebChatInvitePopupStyle] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_MobileWebChatInvitePopupStyle_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_MobileWebChatInvitePopupStyle_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_MobileWebChatInvitingWords] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Words] nvarchar(1000) NULL,
    CONSTRAINT [PK_SiteSettings_MobileWebChatInvitingWords] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_MobileWebChatInvitingWords_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_MobileWebChatInvitingWords_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_MobileWebChatStyle] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [ChatWindowTitle] nvarchar(100) NULL,
    [LogoImage] nvarchar(1000) NULL,
    [ThemeGeneralColor] nvarchar(10) NULL,
    [ThemeSecondaryColor] nvarchar(10) NULL,
    [ButtonColor] nvarchar(10) NULL,
    [LogoAndTitleDisplayMode] int NOT NULL,
    CONSTRAINT [PK_SiteSettings_MobileWebChatStyle] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_MobileWebChatStyle_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_MobileWebChatStyle_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_MobileWebFloatIcon] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Position] int NOT NULL,
    [Visiblity] int NOT NULL,
    [ImageStaffOnline] nvarchar(1000) NULL,
    [ImageStaffOffline] nvarchar(1000) NULL,
    [Width] int NOT NULL,
    [Height] int NOT NULL,
    [HorizontalMargin] int NOT NULL,
    [VerticalMargin] int NOT NULL,
    CONSTRAINT [PK_SiteSettings_MobileWebFloatIcon] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_MobileWebFloatIcon_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_MobileWebFloatIcon_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_MobileWebLeaveMessage] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Notice] nvarchar(4000) NULL,
    CONSTRAINT [PK_SiteSettings_MobileWebLeaveMessage] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_MobileWebLeaveMessage_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_MobileWebLeaveMessage_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebChatInvite] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [AutoInviting] bit NOT NULL,
    [AutoInvitingInterval] int NOT NULL,
    [AutoInvitingEvenNoStaffOnline] bit NOT NULL,
    [AutoInvitingOnlyNullChat] bit NOT NULL,
    [InviteWords] nvarchar(1000) NULL,
    CONSTRAINT [PK_SiteSettings_WebChatInvite] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebChatInvite_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebChatInvite_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebChatInvitePopupStyle] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Mode] int NOT NULL,
    [BackgroundImage] nvarchar(1000) NULL,
    [Html] nvarchar(max) NULL,
    [Width] int NOT NULL,
    [Height] int NOT NULL,
    [CloseButtonImage] nvarchar(1000) NULL,
    CONSTRAINT [PK_SiteSettings_WebChatInvitePopupStyle] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebChatInvitePopupStyle_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebChatInvitePopupStyle_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebChatInvitingWords] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Words] nvarchar(1000) NULL,
    CONSTRAINT [PK_SiteSettings_WebChatInvitingWords] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebChatInvitingWords_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebChatInvitingWords_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebChatOpeningGreetings] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [ChatGreetings] nvarchar(4000) NULL,
    [MiniChatGreetings] nvarchar(4000) NULL,
    [NoStaffOnlineGreetings] nvarchar(4000) NULL,
    CONSTRAINT [PK_SiteSettings_WebChatOpeningGreetings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebChatOpeningGreetings_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebChatOpeningGreetings_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebChatStyle] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [ChatWindowTitle] nvarchar(100) NULL,
    [LogoImage] nvarchar(1000) NULL,
    [BackgroundImage] nvarchar(1000) NULL,
    [ThemeGeneralColor] nvarchar(10) NULL,
    [ThemeSecondaryColor] nvarchar(10) NULL,
    [ButtonColor] nvarchar(10) NULL,
    [ChatWindowOpenMode] int NOT NULL,
    [LogoAndTitleDisplayMode] int NOT NULL,
    CONSTRAINT [PK_SiteSettings_WebChatStyle] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebChatStyle_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebChatStyle_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebFloatIcon] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Position] int NOT NULL,
    [Visiblity] int NOT NULL,
    [ImageStaffOnline] nvarchar(1000) NULL,
    [ImageStaffOffline] nvarchar(1000) NULL,
    [Width] int NOT NULL,
    [Height] int NOT NULL,
    [HorizontalMargin] int NOT NULL,
    [VerticalMargin] int NOT NULL,
    CONSTRAINT [PK_SiteSettings_WebFloatIcon] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebFloatIcon_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebFloatIcon_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SiteSettings_WebLeaveMessage] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Notice] nvarchar(4000) NULL,
    CONSTRAINT [PK_SiteSettings_WebLeaveMessage] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_WebLeaveMessage_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_WebLeaveMessage_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [QuicklyReplyCategory] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [OrderNumber] int NOT NULL,
    CONSTRAINT [PK_QuicklyReplyCategory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuicklyReplyCategory_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_QuicklyReplyCategory_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [RoleStaff] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [RoleId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_RoleStaff] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RoleStaff_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_RoleStaff_Role_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [Role] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_RoleStaff_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [StaffSettings_Operation] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [DoubleClickVisitCustomerToStartInvite] bit NOT NULL,
    [AutoRemoveOfflineCustomer] bit NOT NULL,
    [AutoRemoveOfflineCustomerMinute] int NOT NULL,
    [AutoTurnStatusIntoLeaving] bit NOT NULL,
    [AutoTurnStatusIntoLeavingMinute] int NOT NULL,
    CONSTRAINT [PK_StaffSettings_Operation] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StaffSettings_Operation_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_StaffSettings_Operation_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Customer] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Gender] int NOT NULL,
    [CustomerCategoryId] uniqueidentifier NULL,
    [CustomerImportentLevelId] uniqueidentifier NULL,
    [Remark] nvarchar(500) NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Customer_CustomerCategory_CustomerCategoryId] FOREIGN KEY ([CustomerCategoryId]) REFERENCES [CustomerCategory] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Customer_CustomerImportentLevel_CustomerImportentLevelId] FOREIGN KEY ([CustomerImportentLevelId]) REFERENCES [CustomerImportentLevel] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Customer_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Customer_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [QuicklyReply] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [QuicklyReplyCategoryId] uniqueidentifier NOT NULL,
    [OrderNumber] int NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Content] nvarchar(1000) NOT NULL,
    CONSTRAINT [PK_QuicklyReply] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuicklyReply_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_QuicklyReply_QuicklyReplyCategory_QuicklyReplyCategoryId] FOREIGN KEY ([QuicklyReplyCategoryId]) REFERENCES [QuicklyReplyCategory] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Contact] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    [CreatedTime] datetime2 NOT NULL,
    [LatestUpdatedStaffId] uniqueidentifier NOT NULL,
    [LatestUpdateTime] datetime2 NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Gender] int NOT NULL,
    [Country] nvarchar(100) NULL,
    [Province] nvarchar(100) NULL,
    [City] nvarchar(100) NULL,
    [Email] nvarchar(100) NULL,
    [QQ] nvarchar(100) NULL,
    [Telphone] nvarchar(50) NULL,
    [Cellphone] nvarchar(50) NULL,
    [Company] nvarchar(100) NULL,
    [Address] nvarchar(200) NULL,
    [Remark] nvarchar(500) NULL,
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Contact_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Contact_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Contact_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [LeaveMessage] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Gender] int NOT NULL,
    [PhoneNumber] nvarchar(50) NULL,
    [Email] nvarchar(100) NULL,
    [Content] nvarchar(500) NULL,
    [Processed] bit NOT NULL,
    [ProcessedRemark] nvarchar(500) NULL,
    [ProcessedStaffId] uniqueidentifier NULL,
    [CreateTime] datetime2 NOT NULL,
    [ProcessedTime] datetime2 NULL,
    CONSTRAINT [PK_LeaveMessage] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_LeaveMessage_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_LeaveMessage_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_LeaveMessage_Staff_ProcessedStaffId] FOREIGN KEY ([ProcessedStaffId]) REFERENCES [Staff] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_LeaveMessage_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Session] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [StartTime] datetime2 NOT NULL,
    [EndTime] datetime2 NULL,
    [DurationSeconds] int NULL,
    [StaffId] uniqueidentifier NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    [StartType] int NOT NULL,
    [StaffMessageCount] int NOT NULL,
    [CustomerMessageCount] int NOT NULL,
    [CustomerIP] nvarchar(20) NULL,
    [CustomerIPDistrict] nvarchar(200) NULL,
    [Remark] nvarchar(500) NULL,
    CONSTRAINT [PK_Session] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Session_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Session_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Session_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Session_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [DialogMessage] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [SessionId] uniqueidentifier NOT NULL,
    [Type] int NOT NULL,
    [Content] nvarchar(1000) NULL,
    [StaffId] uniqueidentifier NULL,
    [CustomerId] uniqueidentifier NULL,
    [SentTime] datetime2 NOT NULL,
    CONSTRAINT [PK_DialogMessage] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DialogMessage_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_DialogMessage_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_DialogMessage_Session_SessionId] FOREIGN KEY ([SessionId]) REFERENCES [Session] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_DialogMessage_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_DialogMessage_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Contact_CustomerId] ON [Contact] ([CustomerId]);

GO

CREATE INDEX [IX_Contact_DomainId] ON [Contact] ([DomainId]);

GO

CREATE INDEX [IX_Contact_SiteId] ON [Contact] ([SiteId]);

GO

CREATE INDEX [IX_Customer_CustomerCategoryId] ON [Customer] ([CustomerCategoryId]);

GO

CREATE INDEX [IX_Customer_CustomerImportentLevelId] ON [Customer] ([CustomerImportentLevelId]);

GO

CREATE INDEX [IX_Customer_DomainId] ON [Customer] ([DomainId]);

GO

CREATE INDEX [IX_Customer_SiteId] ON [Customer] ([SiteId]);

GO

CREATE INDEX [IX_CustomerCategory_DomainId] ON [CustomerCategory] ([DomainId]);

GO

CREATE INDEX [IX_CustomerCategory_SiteId] ON [CustomerCategory] ([SiteId]);

GO

CREATE INDEX [IX_CustomerCount_DomainId] ON [CustomerCount] ([DomainId]);

GO

CREATE INDEX [IX_CustomerCount_SiteId] ON [CustomerCount] ([SiteId]);

GO

CREATE INDEX [IX_CustomerImportentLevel_DomainId] ON [CustomerImportentLevel] ([DomainId]);

GO

CREATE INDEX [IX_CustomerImportentLevel_SiteId] ON [CustomerImportentLevel] ([SiteId]);

GO

CREATE INDEX [IX_DialogMessage_CustomerId] ON [DialogMessage] ([CustomerId]);

GO

CREATE INDEX [IX_DialogMessage_DomainId] ON [DialogMessage] ([DomainId]);

GO

CREATE INDEX [IX_DialogMessage_SessionId] ON [DialogMessage] ([SessionId]);

GO

CREATE INDEX [IX_DialogMessage_SiteId] ON [DialogMessage] ([SiteId]);

GO

CREATE INDEX [IX_DialogMessage_StaffId] ON [DialogMessage] ([StaffId]);

GO

CREATE INDEX [IX_Dictionary_DomainId] ON [Dictionary] ([DomainId]);

GO

CREATE INDEX [IX_DictionaryItem_DictionaryId] ON [DictionaryItem] ([DictionaryId]);

GO

CREATE INDEX [IX_DictionaryItem_DomainId] ON [DictionaryItem] ([DomainId]);

GO

CREATE INDEX [IX_LeaveMessage_CustomerId] ON [LeaveMessage] ([CustomerId]);

GO

CREATE INDEX [IX_LeaveMessage_DomainId] ON [LeaveMessage] ([DomainId]);

GO

CREATE INDEX [IX_LeaveMessage_ProcessedStaffId] ON [LeaveMessage] ([ProcessedStaffId]);

GO

CREATE INDEX [IX_LeaveMessage_SiteId] ON [LeaveMessage] ([SiteId]);

GO

CREATE INDEX [IX_Organization_DomainId] ON [Organization] ([DomainId]);

GO

CREATE INDEX [IX_Organization_ParentId] ON [Organization] ([ParentId]);

GO

CREATE INDEX [IX_QuicklyReply_DomainId] ON [QuicklyReply] ([DomainId]);

GO

CREATE INDEX [IX_QuicklyReply_QuicklyReplyCategoryId] ON [QuicklyReply] ([QuicklyReplyCategoryId]);

GO

CREATE INDEX [IX_QuicklyReplyCategory_DomainId] ON [QuicklyReplyCategory] ([DomainId]);

GO

CREATE INDEX [IX_QuicklyReplyCategory_StaffId] ON [QuicklyReplyCategory] ([StaffId]);

GO

CREATE INDEX [IX_Role_DomainId] ON [Role] ([DomainId]);

GO

CREATE INDEX [IX_RoleAuthorization_DomainId] ON [RoleAuthorization] ([DomainId]);

GO

CREATE INDEX [IX_RoleAuthorization_RoleId] ON [RoleAuthorization] ([RoleId]);

GO

CREATE INDEX [IX_RoleStaff_DomainId] ON [RoleStaff] ([DomainId]);

GO

CREATE INDEX [IX_RoleStaff_RoleId] ON [RoleStaff] ([RoleId]);

GO

CREATE INDEX [IX_RoleStaff_StaffId] ON [RoleStaff] ([StaffId]);

GO

CREATE INDEX [IX_Session_CustomerId] ON [Session] ([CustomerId]);

GO

CREATE INDEX [IX_Session_DomainId] ON [Session] ([DomainId]);

GO

CREATE INDEX [IX_Session_SiteId] ON [Session] ([SiteId]);

GO

CREATE INDEX [IX_Session_StaffId] ON [Session] ([StaffId]);

GO

CREATE INDEX [IX_Site_DomainId] ON [Site] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_Misc_DomainId] ON [SiteSettings_Misc] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_Misc_SiteId] ON [SiteSettings_Misc] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatInvitePopupStyle_DomainId] ON [SiteSettings_MobileWebChatInvitePopupStyle] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatInvitePopupStyle_SiteId] ON [SiteSettings_MobileWebChatInvitePopupStyle] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatInvitingWords_DomainId] ON [SiteSettings_MobileWebChatInvitingWords] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatInvitingWords_SiteId] ON [SiteSettings_MobileWebChatInvitingWords] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatStyle_DomainId] ON [SiteSettings_MobileWebChatStyle] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatStyle_SiteId] ON [SiteSettings_MobileWebChatStyle] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebFloatIcon_DomainId] ON [SiteSettings_MobileWebFloatIcon] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebFloatIcon_SiteId] ON [SiteSettings_MobileWebFloatIcon] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebLeaveMessage_DomainId] ON [SiteSettings_MobileWebLeaveMessage] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebLeaveMessage_SiteId] ON [SiteSettings_MobileWebLeaveMessage] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatAd_DomainId] ON [SiteSettings_WebChatAd] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatInvite_DomainId] ON [SiteSettings_WebChatInvite] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatInvite_SiteId] ON [SiteSettings_WebChatInvite] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatInvitePopupStyle_DomainId] ON [SiteSettings_WebChatInvitePopupStyle] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatInvitePopupStyle_SiteId] ON [SiteSettings_WebChatInvitePopupStyle] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatInvitingWords_DomainId] ON [SiteSettings_WebChatInvitingWords] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatInvitingWords_SiteId] ON [SiteSettings_WebChatInvitingWords] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatOpeningGreetings_DomainId] ON [SiteSettings_WebChatOpeningGreetings] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatOpeningGreetings_SiteId] ON [SiteSettings_WebChatOpeningGreetings] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatStyle_DomainId] ON [SiteSettings_WebChatStyle] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebChatStyle_SiteId] ON [SiteSettings_WebChatStyle] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebFloatIcon_DomainId] ON [SiteSettings_WebFloatIcon] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebFloatIcon_SiteId] ON [SiteSettings_WebFloatIcon] ([SiteId]);

GO

CREATE INDEX [IX_SiteSettings_WebLeaveMessage_DomainId] ON [SiteSettings_WebLeaveMessage] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_WebLeaveMessage_SiteId] ON [SiteSettings_WebLeaveMessage] ([SiteId]);

GO

CREATE INDEX [IX_Staff_DomainId] ON [Staff] ([DomainId]);

GO

CREATE INDEX [IX_Staff_OrganizationId] ON [Staff] ([OrganizationId]);

GO

CREATE INDEX [IX_StaffSettings_Operation_DomainId] ON [StaffSettings_Operation] ([DomainId]);

GO

CREATE INDEX [IX_StaffSettings_Operation_StaffId] ON [StaffSettings_Operation] ([StaffId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201127083607_20201127a', N'3.1.10');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[QuicklyReply]') AND [c].[name] = N'SiteId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [QuicklyReply] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [QuicklyReply] DROP COLUMN [SiteId];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201130065812_20201130a', N'3.1.10');

GO

DROP TABLE [QuicklyReply];

GO

CREATE TABLE [QuicklyReplyItem] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [QuicklyReplyCategoryId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [OrderNumber] int NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Content] nvarchar(1000) NOT NULL,
    CONSTRAINT [PK_QuicklyReplyItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_QuicklyReplyItem_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_QuicklyReplyItem_QuicklyReplyCategory_QuicklyReplyCategoryId] FOREIGN KEY ([QuicklyReplyCategoryId]) REFERENCES [QuicklyReplyCategory] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_QuicklyReplyItem_DomainId] ON [QuicklyReplyItem] ([DomainId]);

GO

CREATE INDEX [IX_QuicklyReplyItem_QuicklyReplyCategoryId] ON [QuicklyReplyItem] ([QuicklyReplyCategoryId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201130160439_20201201a', N'3.1.10');

GO

ALTER TABLE [SiteSettings_Misc] ADD [WebChatAddress] nvarchar(500) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201209142422_20201209a', N'3.1.10');

GO

CREATE TABLE [StaffPersonalSettings_Remind] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [NewCustomer_Bubble] bit NOT NULL,
    [NewCustomer_ShowView] bit NOT NULL,
    [NewCustomer_Sound] bit NOT NULL,
    [NewMessage_Bubble] bit NOT NULL,
    [NewMessage_ShowView] bit NOT NULL,
    [NewMessage_Sound] bit NOT NULL,
    [NewSession_Bubble] bit NOT NULL,
    [NewSession_ShowView] bit NOT NULL,
    [NewSession_Sound] bit NOT NULL,
    CONSTRAINT [PK_StaffPersonalSettings_Remind] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StaffPersonalSettings_Remind_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_StaffPersonalSettings_Remind_DomainId] ON [StaffPersonalSettings_Remind] ([DomainId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201210042118_20201210a', N'3.1.10');

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SiteSettings_WebChatOpeningGreetings]') AND [c].[name] = N'ChatGreetings');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [SiteSettings_WebChatOpeningGreetings] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [SiteSettings_WebChatOpeningGreetings] DROP COLUMN [ChatGreetings];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SiteSettings_WebChatOpeningGreetings]') AND [c].[name] = N'MiniChatGreetings');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [SiteSettings_WebChatOpeningGreetings] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [SiteSettings_WebChatOpeningGreetings] DROP COLUMN [MiniChatGreetings];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SiteSettings_WebChatOpeningGreetings]') AND [c].[name] = N'NoStaffOnlineGreetings');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [SiteSettings_WebChatOpeningGreetings] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [SiteSettings_WebChatOpeningGreetings] DROP COLUMN [NoStaffOnlineGreetings];

GO

ALTER TABLE [SiteSettings_WebChatOpeningGreetings] ADD [Greetings] nvarchar(4000) NULL;

GO

CREATE TABLE [SiteSettings_MobileWebChatOpeningGreetings] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Greetings] nvarchar(4000) NULL,
    CONSTRAINT [PK_SiteSettings_MobileWebChatOpeningGreetings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_MobileWebChatOpeningGreetings_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_MobileWebChatOpeningGreetings_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_StaffPersonalSettings_Remind_StaffId] ON [StaffPersonalSettings_Remind] ([StaffId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatOpeningGreetings_DomainId] ON [SiteSettings_MobileWebChatOpeningGreetings] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_MobileWebChatOpeningGreetings_SiteId] ON [SiteSettings_MobileWebChatOpeningGreetings] ([SiteId]);

GO

ALTER TABLE [StaffPersonalSettings_Remind] ADD CONSTRAINT [FK_StaffPersonalSettings_Remind_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201211063241_20201211a', N'3.1.10');

GO

CREATE TABLE [StaffPersonalSettings_MobileWebChatOpeningGreetings] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [Greetings] nvarchar(4000) NULL,
    CONSTRAINT [PK_StaffPersonalSettings_MobileWebChatOpeningGreetings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StaffPersonalSettings_MobileWebChatOpeningGreetings_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StaffPersonalSettings_MobileWebChatOpeningGreetings_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StaffPersonalSettings_MobileWebChatOpeningGreetings_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [StaffPersonalSettings_WebChatOpeningGreetings] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [Greetings] nvarchar(4000) NULL,
    CONSTRAINT [PK_StaffPersonalSettings_WebChatOpeningGreetings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StaffPersonalSettings_WebChatOpeningGreetings_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StaffPersonalSettings_WebChatOpeningGreetings_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StaffPersonalSettings_WebChatOpeningGreetings_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_StaffPersonalSettings_MobileWebChatOpeningGreetings_DomainId] ON [StaffPersonalSettings_MobileWebChatOpeningGreetings] ([DomainId]);

GO

CREATE INDEX [IX_StaffPersonalSettings_MobileWebChatOpeningGreetings_SiteId] ON [StaffPersonalSettings_MobileWebChatOpeningGreetings] ([SiteId]);

GO

CREATE INDEX [IX_StaffPersonalSettings_MobileWebChatOpeningGreetings_StaffId] ON [StaffPersonalSettings_MobileWebChatOpeningGreetings] ([StaffId]);

GO

CREATE INDEX [IX_StaffPersonalSettings_WebChatOpeningGreetings_DomainId] ON [StaffPersonalSettings_WebChatOpeningGreetings] ([DomainId]);

GO

CREATE INDEX [IX_StaffPersonalSettings_WebChatOpeningGreetings_SiteId] ON [StaffPersonalSettings_WebChatOpeningGreetings] ([SiteId]);

GO

CREATE INDEX [IX_StaffPersonalSettings_WebChatOpeningGreetings_StaffId] ON [StaffPersonalSettings_WebChatOpeningGreetings] ([StaffId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201211085800_20201211b', N'3.1.10');

GO

ALTER TABLE [DialogMessage] ADD [SentBySystem] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201212111123_20201212a', N'3.1.10');

GO

CREATE TABLE [RobotItem] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [ParentId] uniqueidentifier NULL,
    [IdPath] nvarchar(max) NOT NULL,
    [Title] nvarchar(100) NOT NULL,
    [Content] nvarchar(4000) NULL,
    [NumericalOrder] int NOT NULL,
    CONSTRAINT [PK_RobotItem] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RobotItem_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_RobotItem_RobotItem_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [RobotItem] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_RobotItem_DomainId] ON [RobotItem] ([DomainId]);

GO

CREATE INDEX [IX_RobotItem_ParentId] ON [RobotItem] ([ParentId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201220145742_20201220a', N'3.1.10');

GO

ALTER TABLE [RobotItem] ADD [SiteId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

CREATE INDEX [IX_RobotItem_SiteId] ON [RobotItem] ([SiteId]);

GO

ALTER TABLE [RobotItem] ADD CONSTRAINT [FK_RobotItem_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201222145808_20201222a', N'3.1.10');

GO

DROP TABLE [SiteSettings_MobileWebChatInvitePopupStyle];

GO

DROP TABLE [SiteSettings_MobileWebChatInvitingWords];

GO

DROP TABLE [SiteSettings_WebChatInvite];

GO

DROP TABLE [SiteSettings_WebChatInvitePopupStyle];

GO

DROP TABLE [SiteSettings_WebChatInvitingWords];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201223035044_20201223a', N'3.1.10');

GO

CREATE TABLE [SocketClientConnectLog] (
    [Id] uniqueidentifier NOT NULL,
    [IP] nvarchar(15) NOT NULL,
    [ConnectedTime] datetime2 NOT NULL,
    [DisconnectedTime] datetime2 NULL,
    [ReceivedPackageCount] int NOT NULL,
    [Connected] bit NOT NULL,
    [Questionable] bit NOT NULL,
    CONSTRAINT [PK_SocketClientConnectLog] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201224161657_20201224a', N'3.1.10');

GO

ALTER TABLE [SocketClientConnectLog] ADD [ConnectMessageReceived] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201225170051_20201226a', N'3.1.10');

GO

CREATE TABLE [BlockedIP] (
    [Id] uniqueidentifier NOT NULL,
    [IP] nvarchar(15) NOT NULL,
    [BlockedTime] datetime2 NOT NULL,
    [Description] nvarchar(500) NULL,
    CONSTRAINT [PK_BlockedIP] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201228075139_20201228a', N'3.1.10');

GO

ALTER TABLE [SocketClientConnectLog] ADD [QuestionableDescription] nvarchar(500) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201230062049_20201230a', N'3.1.10');

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveMessage]') AND [c].[name] = N'Email');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [LeaveMessage] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [LeaveMessage] DROP COLUMN [Email];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveMessage]') AND [c].[name] = N'Gender');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [LeaveMessage] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [LeaveMessage] DROP COLUMN [Gender];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveMessage]') AND [c].[name] = N'Name');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [LeaveMessage] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [LeaveMessage] DROP COLUMN [Name];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveMessage]') AND [c].[name] = N'PhoneNumber');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [LeaveMessage] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [LeaveMessage] DROP COLUMN [PhoneNumber];

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[LeaveMessage]') AND [c].[name] = N'ProcessedRemark');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [LeaveMessage] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [LeaveMessage] ALTER COLUMN [ProcessedRemark] nvarchar(1000) NULL;

GO

CREATE TABLE [SiteSettings_LeaveMessageContentTemplate] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [ContentTemplate] nvarchar(500) NULL,
    CONSTRAINT [PK_SiteSettings_LeaveMessageContentTemplate] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_LeaveMessageContentTemplate_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_LeaveMessageContentTemplate_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_SiteSettings_LeaveMessageContentTemplate_DomainId] ON [SiteSettings_LeaveMessageContentTemplate] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_LeaveMessageContentTemplate_SiteId] ON [SiteSettings_LeaveMessageContentTemplate] ([SiteId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201230103648_20201230b', N'3.1.10');

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SocketClientConnectLog]') AND [c].[name] = N'ConnectMessageReceived');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [SocketClientConnectLog] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [SocketClientConnectLog] DROP COLUMN [ConnectMessageReceived];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RobotItem]') AND [c].[name] = N'NumericalOrder');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [RobotItem] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [RobotItem] ALTER COLUMN [NumericalOrder] bigint NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210101061259_20210101a', N'3.1.10');

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[QuicklyReplyItem]') AND [c].[name] = N'OrderNumber');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [QuicklyReplyItem] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [QuicklyReplyItem] DROP COLUMN [OrderNumber];

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[QuicklyReplyCategory]') AND [c].[name] = N'OrderNumber');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [QuicklyReplyCategory] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [QuicklyReplyCategory] DROP COLUMN [OrderNumber];

GO

ALTER TABLE [QuicklyReplyItem] ADD [NumericalOrder] bigint NOT NULL DEFAULT CAST(0 AS bigint);

GO

ALTER TABLE [QuicklyReplyCategory] ADD [NumericalOrder] bigint NOT NULL DEFAULT CAST(0 AS bigint);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210101074412_20210101b', N'3.1.10');

GO

ALTER TABLE [LeaveMessage] ADD [ExtensionField1] nvarchar(100) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210104024501_20210104a', N'3.1.10');

GO

ALTER TABLE [LeaveMessage] ADD [ContactInformation] nvarchar(100) NULL;

GO

ALTER TABLE [LeaveMessage] ADD [ExtensionField2] nvarchar(100) NULL;

GO

ALTER TABLE [LeaveMessage] ADD [ExtensionField3] nvarchar(100) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210104071023_20210104b', N'3.1.10');

GO

ALTER TABLE [Customer] ADD [Blocked] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [Customer] ADD [BlockedByStaffId] uniqueidentifier NULL;

GO

ALTER TABLE [Customer] ADD [BlockedTime] datetime2 NULL;

GO

CREATE INDEX [IX_Customer_BlockedByStaffId] ON [Customer] ([BlockedByStaffId]);

GO

ALTER TABLE [Customer] ADD CONSTRAINT [FK_Customer_Staff_BlockedByStaffId] FOREIGN KEY ([BlockedByStaffId]) REFERENCES [Staff] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210106090343_20210106a', N'3.1.10');

GO

ALTER TABLE [LeaveMessage] ADD [Name] nvarchar(50) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210107020914_20210107a', N'3.1.10');

GO

ALTER TABLE [Staff] ADD [LastLoginIPAddress] nvarchar(max) NULL;

GO

ALTER TABLE [Staff] ADD [LastLoginLocation] nvarchar(max) NULL;

GO

ALTER TABLE [Staff] ADD [LastLoginTime] datetime2 NULL;

GO

CREATE TABLE [StaffLoginHistory] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    [LoginTime] datetime2 NOT NULL,
    [LogoutTime] datetime2 NULL,
    [DurationMinutes] int NULL,
    [IPAddress] nvarchar(max) NULL,
    [Location] nvarchar(max) NULL,
    [SessionCount] int NULL,
    [SentMessageCount] int NULL,
    [ReceivedMessageCount] int NULL,
    CONSTRAINT [PK_StaffLoginHistory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_StaffLoginHistory_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_StaffLoginHistory_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_StaffLoginHistory_DomainId] ON [StaffLoginHistory] ([DomainId]);

GO

CREATE INDEX [IX_StaffLoginHistory_StaffId] ON [StaffLoginHistory] ([StaffId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210118144455_20210118a', N'3.1.10');

GO

ALTER TABLE [Staff] ADD [Online] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210118150851_20210118b', N'3.1.10');

GO

CREATE TABLE [ClientException] (
    [Id] uniqueidentifier NOT NULL,
    [ReportTime] datetime2 NOT NULL,
    [IP] nvarchar(15) NOT NULL,
    [SiteCode] nvarchar(100) NULL,
    [StaffId] uniqueidentifier NULL,
    [Message] nvarchar(500) NULL,
    [Detail] nvarchar(max) NULL,
    CONSTRAINT [PK_ClientException] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210122022026_20210122a', N'3.1.10');

GO

ALTER TABLE [Domain] ADD [StaffLastLoginIPAddress] nvarchar(max) NULL;

GO

ALTER TABLE [Domain] ADD [StaffLastLoginLocation] nvarchar(max) NULL;

GO

ALTER TABLE [Domain] ADD [StaffLastLoginTime] datetime2 NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210224030044_20210224a', N'3.1.10');

GO

ALTER TABLE [StaffLoginHistory] DROP CONSTRAINT [FK_StaffLoginHistory_Domain_DomainId];

GO

ALTER TABLE [StaffLoginHistory] ADD [SiteId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [Site] ADD [StaffLastLoginIPAddress] nvarchar(max) NULL;

GO

ALTER TABLE [Site] ADD [StaffLastLoginLocation] nvarchar(max) NULL;

GO

ALTER TABLE [Site] ADD [StaffLastLoginTime] datetime2 NULL;

GO

CREATE INDEX [IX_StaffLoginHistory_SiteId] ON [StaffLoginHistory] ([SiteId]);

GO

ALTER TABLE [StaffLoginHistory] ADD CONSTRAINT [FK_StaffLoginHistory_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [StaffLoginHistory] ADD CONSTRAINT [FK_StaffLoginHistory_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210224035211_20210224b', N'3.1.10');

GO

ALTER TABLE [DialogMessage] ADD [Taboo] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [DialogMessage] ADD [TabooWords] nvarchar(max) NULL;

GO

CREATE TABLE [TabooWords] (
    [Id] uniqueidentifier NOT NULL,
    [Words] nvarchar(50) NULL,
    CONSTRAINT [PK_TabooWords] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210224074336_20210224c', N'3.1.10');

GO

ALTER TABLE [SiteSettings_Misc] ADD [CustomerSideHistory] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210228080930_20210228a', N'3.1.10');

GO

ALTER TABLE [SiteSettings_Misc] ADD [LoadingMode] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Customer] ADD [ExternalData] nvarchar(2000) NULL;

GO

ALTER TABLE [Customer] ADD [ExternalId] nvarchar(50) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210302031317_20210302a', N'3.1.10');

GO

ALTER TABLE [Customer] ADD [ExternalName] nvarchar(50) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210302055059_20210302b', N'3.1.10');

GO

ALTER TABLE [Session] ADD [Taboo] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [Session] ADD [TabooWords] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210303034044_20210303a', N'3.1.10');

GO

CREATE TABLE [CustomerWebpageVisitationTrack] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [CustomerId] uniqueidentifier NOT NULL,
    [Url] nvarchar(1000) NOT NULL,
    [Title] nvarchar(100) NOT NULL,
    [VisitedTime] datetime2 NOT NULL,
    CONSTRAINT [PK_CustomerWebpageVisitationTrack] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_CustomerWebpageVisitationTrack_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CustomerWebpageVisitationTrack_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_CustomerWebpageVisitationTrack_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_CustomerWebpageVisitationTrack_CustomerId] ON [CustomerWebpageVisitationTrack] ([CustomerId]);

GO

CREATE INDEX [IX_CustomerWebpageVisitationTrack_DomainId] ON [CustomerWebpageVisitationTrack] ([DomainId]);

GO

CREATE INDEX [IX_CustomerWebpageVisitationTrack_SiteId] ON [CustomerWebpageVisitationTrack] ([SiteId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210415153611_20210415a', N'3.1.10');

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Session]') AND [c].[name] = N'TabooWords');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Session] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [Session] ALTER COLUMN [TabooWords] nvarchar(50) NULL;

GO

ALTER TABLE [Session] ADD [CustomerFillInFieldBeforeStart1] nvarchar(100) NULL;

GO

ALTER TABLE [Session] ADD [CustomerFillInFieldBeforeStart1_Title] nvarchar(100) NULL;

GO

ALTER TABLE [Session] ADD [CustomerFillInFieldBeforeStart2] nvarchar(100) NULL;

GO

ALTER TABLE [Session] ADD [CustomerFillInFieldBeforeStart2_Title] nvarchar(100) NULL;

GO

ALTER TABLE [Session] ADD [CustomerFillInFieldBeforeStart3] nvarchar(100) NULL;

GO

ALTER TABLE [Session] ADD [CustomerFillInFieldBeforeStart3_Title] nvarchar(100) NULL;

GO

ALTER TABLE [Session] ADD [SkillGroupId] uniqueidentifier NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[DialogMessage]') AND [c].[name] = N'TabooWords');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [DialogMessage] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [DialogMessage] ALTER COLUMN [TabooWords] nvarchar(50) NULL;

GO

CREATE TABLE [SiteSettings_ChatMisc] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [CustomerFillInFieldBeforeStart1] bit NOT NULL,
    [CustomerFillInFieldBeforeStart1_Title] nvarchar(100) NULL,
    [CustomerFillInFieldBeforeStart2] bit NOT NULL,
    [CustomerFillInFieldBeforeStart2_Title] nvarchar(100) NULL,
    [CustomerFillInFieldBeforeStart3] bit NOT NULL,
    [CustomerFillInFieldBeforeStart3_Title] nvarchar(100) NULL,
    CONSTRAINT [PK_SiteSettings_ChatMisc] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_ChatMisc_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_ChatMisc_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [SkillGroup] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [DisplayNameForCustomer] nvarchar(100) NOT NULL,
    [Remark] nvarchar(500) NULL,
    CONSTRAINT [PK_SkillGroup] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SkillGroup_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SkillGroup_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SkillGroupStaff] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SkillGroupId] uniqueidentifier NOT NULL,
    [StaffId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_SkillGroupStaff] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SkillGroupStaff_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SkillGroupStaff_SkillGroup_SkillGroupId] FOREIGN KEY ([SkillGroupId]) REFERENCES [SkillGroup] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SkillGroupStaff_Staff_StaffId] FOREIGN KEY ([StaffId]) REFERENCES [Staff] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_SiteSettings_ChatMisc_DomainId] ON [SiteSettings_ChatMisc] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_ChatMisc_SiteId] ON [SiteSettings_ChatMisc] ([SiteId]);

GO

CREATE INDEX [IX_SkillGroup_DomainId] ON [SkillGroup] ([DomainId]);

GO

CREATE INDEX [IX_SkillGroup_SiteId] ON [SkillGroup] ([SiteId]);

GO

CREATE INDEX [IX_SkillGroupStaff_DomainId] ON [SkillGroupStaff] ([DomainId]);

GO

CREATE INDEX [IX_SkillGroupStaff_SkillGroupId] ON [SkillGroupStaff] ([SkillGroupId]);

GO

CREATE INDEX [IX_SkillGroupStaff_StaffId] ON [SkillGroupStaff] ([StaffId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210501061533_20210501a', N'3.1.10');

GO

ALTER TABLE [SkillGroup] ADD [NumericalOrder] bigint NOT NULL DEFAULT CAST(0 AS bigint);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210501092809_20210501b', N'3.1.10');

GO

CREATE TABLE [SkillGroupSettings] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Enabled] bit NOT NULL,
    CONSTRAINT [PK_SkillGroupSettings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SkillGroupSettings_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SkillGroupSettings_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_SkillGroupSettings_DomainId] ON [SkillGroupSettings] ([DomainId]);

GO

CREATE INDEX [IX_SkillGroupSettings_SiteId] ON [SkillGroupSettings] ([SiteId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210503022000_202105003a', N'3.1.10');

GO

CREATE INDEX [IX_Session_SkillGroupId] ON [Session] ([SkillGroupId]);

GO

ALTER TABLE [Session] ADD CONSTRAINT [FK_Session_SkillGroup_SkillGroupId] FOREIGN KEY ([SkillGroupId]) REFERENCES [SkillGroup] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210506090025_20210503b', N'3.1.10');

GO

ALTER TABLE [Session] DROP CONSTRAINT [FK_Session_SkillGroup_SkillGroupId];

GO

ALTER TABLE [Session] ADD CONSTRAINT [FK_Session_SkillGroup_SkillGroupId] FOREIGN KEY ([SkillGroupId]) REFERENCES [SkillGroup] ([Id]) ON DELETE SET NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210506090804_20210503c', N'3.1.10');

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart1_Description] nvarchar(200) NULL;

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart1_MultipleRow] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart2_Description] nvarchar(200) NULL;

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart2_MultipleRow] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart3_Description] nvarchar(200) NULL;

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart3_MultipleRow] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210511022215_20210511a', N'3.1.10');

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart1_Required] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart2_Required] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [SiteSettings_ChatMisc] ADD [CustomerFillInFieldBeforeStart3_Required] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210511031113_20210511b', N'3.1.10');

GO

ALTER TABLE [Customer] ADD [CreatedTime] datetime2 NULL;

GO

ALTER TABLE [Customer] ADD [LastDialogueTime] datetime2 NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210521143231_20210521a', N'3.1.10');

GO

ALTER TABLE [Customer] ADD [AnyDialogue] bit NOT NULL DEFAULT CAST(0 AS bit);

GO

ALTER TABLE [Customer] ADD [LastDialogueSessionStartType] int NULL;

GO

ALTER TABLE [Customer] ADD [LastDialogueStaffId] uniqueidentifier NULL;

GO

CREATE INDEX [IX_Customer_LastDialogueStaffId] ON [Customer] ([LastDialogueStaffId]);

GO

ALTER TABLE [Customer] ADD CONSTRAINT [FK_Customer_Staff_LastDialogueStaffId] FOREIGN KEY ([LastDialogueStaffId]) REFERENCES [Staff] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210522055759_20210522a', N'3.1.10');

GO

CREATE TABLE [SiteSettings_FakeCustomerWaitingQueue] (
    [Id] uniqueidentifier NOT NULL,
    [DomainId] uniqueidentifier NOT NULL,
    [SiteId] uniqueidentifier NOT NULL,
    [Enabled] bit NOT NULL,
    CONSTRAINT [PK_SiteSettings_FakeCustomerWaitingQueue] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SiteSettings_FakeCustomerWaitingQueue_Domain_DomainId] FOREIGN KEY ([DomainId]) REFERENCES [Domain] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_SiteSettings_FakeCustomerWaitingQueue_Site_SiteId] FOREIGN KEY ([SiteId]) REFERENCES [Site] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_SiteSettings_FakeCustomerWaitingQueue_DomainId] ON [SiteSettings_FakeCustomerWaitingQueue] ([DomainId]);

GO

CREATE INDEX [IX_SiteSettings_FakeCustomerWaitingQueue_SiteId] ON [SiteSettings_FakeCustomerWaitingQueue] ([SiteId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210608063023_20210608a', N'3.1.10');

GO

