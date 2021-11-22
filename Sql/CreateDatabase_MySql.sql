CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(95) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
);

CREATE TABLE `BlockedIP` (
    `Id` char(36) NOT NULL,
    `IP` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `BlockedTime` datetime(6) NOT NULL,
    `Description` varchar(500) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_BlockedIP` PRIMARY KEY (`Id`)
);

CREATE TABLE `ClientException` (
    `Id` char(36) NOT NULL,
    `ReportTime` datetime(6) NOT NULL,
    `IP` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `SiteCode` varchar(100) CHARACTER SET utf8mb4 NULL,
    `StaffId` char(36) NULL,
    `Message` varchar(500) CHARACTER SET utf8mb4 NULL,
    `Detail` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_ClientException` PRIMARY KEY (`Id`)
);

CREATE TABLE `Domain` (
    `Id` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `ContactPerson` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(200) CHARACTER SET utf8mb4 NULL,
    `Cellphone` varchar(11) CHARACTER SET utf8mb4 NULL,
    `MaxSiteCount` int NOT NULL,
    `MaxStaffCount` int NOT NULL,
    `CreateTime` datetime(6) NOT NULL,
    `Removed` tinyint(1) NOT NULL,
    `StaffLastLoginTime` datetime(6) NULL,
    `StaffLastLoginIPAddress` longtext CHARACTER SET utf8mb4 NULL,
    `StaffLastLoginLocation` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Domain` PRIMARY KEY (`Id`)
);

CREATE TABLE `PublishedClientVersion` (
    `Id` char(36) NOT NULL,
    `Type` longtext CHARACTER SET utf8mb4 NULL,
    `Version` longtext CHARACTER SET utf8mb4 NULL,
    `Url` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_PublishedClientVersion` PRIMARY KEY (`Id`)
);

CREATE TABLE `SocketClientConnectLog` (
    `Id` char(36) NOT NULL,
    `IP` varchar(15) CHARACTER SET utf8mb4 NOT NULL,
    `ConnectedTime` datetime(6) NOT NULL,
    `DisconnectedTime` datetime(6) NULL,
    `ReceivedPackageCount` int NOT NULL,
    `Connected` tinyint(1) NOT NULL,
    `Questionable` tinyint(1) NOT NULL,
    `QuestionableDescription` varchar(500) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SocketClientConnectLog` PRIMARY KEY (`Id`)
);

CREATE TABLE `TabooWords` (
    `Id` char(36) NOT NULL,
    `Words` varchar(50) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_TabooWords` PRIMARY KEY (`Id`)
);

CREATE TABLE `Dictionary` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Key` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Dictionary` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Dictionary_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Organization` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `ParentId` char(36) NULL,
    `IdPath` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `NumericalOrder` int NOT NULL,
    `Removed` tinyint(1) NOT NULL,
    CONSTRAINT `PK_Organization` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Organization_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Organization_Organization_ParentId` FOREIGN KEY (`ParentId`) REFERENCES `Organization` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Role` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Role` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Role_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Site` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `Code` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `CreateTime` datetime(6) NOT NULL,
    `Removed` tinyint(1) NOT NULL,
    `StaffLastLoginTime` datetime(6) NULL,
    `StaffLastLoginIPAddress` longtext CHARACTER SET utf8mb4 NULL,
    `StaffLastLoginLocation` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Site` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Site_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `SiteSettings_WebChatAd` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `ImageUrl` longtext CHARACTER SET utf8mb4 NULL,
    `LinkUrl` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_WebChatAd` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_WebChatAd_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `DictionaryItem` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `DictionaryId` char(36) NOT NULL,
    `Text` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Value` int NOT NULL,
    `NumericalOrder` int NOT NULL,
    CONSTRAINT `PK_DictionaryItem` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_DictionaryItem_Dictionary_DictionaryId` FOREIGN KEY (`DictionaryId`) REFERENCES `Dictionary` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_DictionaryItem_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Staff` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `OrganizationId` char(36) NOT NULL,
    `Account` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Password` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `NickName` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Gender` int NOT NULL,
    `Email` varchar(100) CHARACTER SET utf8mb4 NULL,
    `QQ` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Telphone` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Cellphone` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Remark` varchar(500) CHARACTER SET utf8mb4 NULL,
    `CreateTime` datetime(6) NOT NULL,
    `DomainAdmin` tinyint(1) NOT NULL,
    `Removed` tinyint(1) NOT NULL,
    `Online` tinyint(1) NOT NULL,
    `LastLoginTime` datetime(6) NULL,
    `LastLoginIPAddress` longtext CHARACTER SET utf8mb4 NULL,
    `LastLoginLocation` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Staff` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Staff_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Staff_Organization_OrganizationId` FOREIGN KEY (`OrganizationId`) REFERENCES `Organization` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `RoleAuthorization` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `RoleId` char(36) NOT NULL,
    `AuthorizationKey` varchar(100) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_RoleAuthorization` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_RoleAuthorization_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_RoleAuthorization_Role_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `Role` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `CustomerCategory` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Color` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_CustomerCategory` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CustomerCategory_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_CustomerCategory_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `CustomerCount` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Country` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Province` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `City` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Count` int NOT NULL,
    CONSTRAINT `PK_CustomerCount` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CustomerCount_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_CustomerCount_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `CustomerImportentLevel` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Color` varchar(10) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_CustomerImportentLevel` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CustomerImportentLevel_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_CustomerImportentLevel_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `RobotItem` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `ParentId` char(36) NULL,
    `IdPath` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Title` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Content` longtext CHARACTER SET utf8mb4 NULL,
    `NumericalOrder` bigint NOT NULL,
    CONSTRAINT `PK_RobotItem` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_RobotItem_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_RobotItem_RobotItem_ParentId` FOREIGN KEY (`ParentId`) REFERENCES `RobotItem` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_RobotItem_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_ChatMisc` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `CustomerFillInFieldBeforeStart1` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart1_MultipleRow` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart1_Required` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart1_Title` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart1_Description` varchar(200) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart2` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart2_MultipleRow` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart2_Required` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart2_Title` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart2_Description` varchar(200) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart3` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart3_MultipleRow` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart3_Required` tinyint(1) NOT NULL,
    `CustomerFillInFieldBeforeStart3_Title` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart3_Description` varchar(200) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_ChatMisc` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_ChatMisc_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_ChatMisc_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_FakeCustomerWaitingQueue` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Enabled` tinyint(1) NOT NULL,
    CONSTRAINT `PK_SiteSettings_FakeCustomerWaitingQueue` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_FakeCustomerWaitingQueue_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_FakeCustomerWaitingQueue_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_LeaveMessageContentTemplate` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `ContentTemplate` varchar(500) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_LeaveMessageContentTemplate` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_LeaveMessageContentTemplate_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_LeaveMessageContentTemplate_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_Misc` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `DomainAddress` varchar(500) CHARACTER SET utf8mb4 NULL,
    `WebChatAddress` varchar(500) CHARACTER SET utf8mb4 NULL,
    `LoadingMode` int NOT NULL,
    `CustomerSideHistory` int NOT NULL,
    CONSTRAINT `PK_SiteSettings_Misc` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_Misc_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_Misc_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_MobileWebChatOpeningGreetings` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Greetings` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_MobileWebChatOpeningGreetings` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_MobileWebChatOpeningGreetings_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_MobileWebChatOpeningGreetings_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_MobileWebChatStyle` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `ChatWindowTitle` varchar(100) CHARACTER SET utf8mb4 NULL,
    `LogoImage` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `ThemeGeneralColor` varchar(10) CHARACTER SET utf8mb4 NULL,
    `ThemeSecondaryColor` varchar(10) CHARACTER SET utf8mb4 NULL,
    `ButtonColor` varchar(10) CHARACTER SET utf8mb4 NULL,
    `LogoAndTitleDisplayMode` int NOT NULL,
    CONSTRAINT `PK_SiteSettings_MobileWebChatStyle` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_MobileWebChatStyle_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_MobileWebChatStyle_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_MobileWebFloatIcon` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Position` int NOT NULL,
    `Visiblity` int NOT NULL,
    `ImageStaffOnline` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `ImageStaffOffline` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `Width` int NOT NULL,
    `Height` int NOT NULL,
    `HorizontalMargin` int NOT NULL,
    `VerticalMargin` int NOT NULL,
    CONSTRAINT `PK_SiteSettings_MobileWebFloatIcon` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_MobileWebFloatIcon_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_MobileWebFloatIcon_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_MobileWebLeaveMessage` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Notice` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_MobileWebLeaveMessage` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_MobileWebLeaveMessage_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_MobileWebLeaveMessage_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_WebChatOpeningGreetings` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Greetings` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_WebChatOpeningGreetings` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_WebChatOpeningGreetings_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_WebChatOpeningGreetings_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_WebChatStyle` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `ChatWindowTitle` varchar(100) CHARACTER SET utf8mb4 NULL,
    `LogoImage` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `BackgroundImage` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `ThemeGeneralColor` varchar(10) CHARACTER SET utf8mb4 NULL,
    `ThemeSecondaryColor` varchar(10) CHARACTER SET utf8mb4 NULL,
    `ButtonColor` varchar(10) CHARACTER SET utf8mb4 NULL,
    `ChatWindowOpenMode` int NOT NULL,
    `LogoAndTitleDisplayMode` int NOT NULL,
    CONSTRAINT `PK_SiteSettings_WebChatStyle` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_WebChatStyle_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_WebChatStyle_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_WebFloatIcon` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Position` int NOT NULL,
    `Visiblity` int NOT NULL,
    `ImageStaffOnline` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `ImageStaffOffline` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `Width` int NOT NULL,
    `Height` int NOT NULL,
    `HorizontalMargin` int NOT NULL,
    `VerticalMargin` int NOT NULL,
    CONSTRAINT `PK_SiteSettings_WebFloatIcon` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_WebFloatIcon_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_WebFloatIcon_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SiteSettings_WebLeaveMessage` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Notice` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_SiteSettings_WebLeaveMessage` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SiteSettings_WebLeaveMessage_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SiteSettings_WebLeaveMessage_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `SkillGroup` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `DisplayNameForCustomer` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Remark` varchar(500) CHARACTER SET utf8mb4 NULL,
    `NumericalOrder` bigint NOT NULL,
    CONSTRAINT `PK_SkillGroup` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SkillGroup_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SkillGroup_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `SkillGroupSettings` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Enabled` tinyint(1) NOT NULL,
    CONSTRAINT `PK_SkillGroupSettings` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SkillGroupSettings_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SkillGroupSettings_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `QuicklyReplyCategory` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `StaffId` char(36) NOT NULL,
    `NumericalOrder` bigint NOT NULL,
    CONSTRAINT `PK_QuicklyReplyCategory` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_QuicklyReplyCategory_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_QuicklyReplyCategory_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `RoleStaff` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `RoleId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    CONSTRAINT `PK_RoleStaff` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_RoleStaff_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_RoleStaff_Role_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `Role` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_RoleStaff_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `StaffLoginHistory` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `LoginTime` datetime(6) NOT NULL,
    `LogoutTime` datetime(6) NULL,
    `DurationMinutes` int NULL,
    `IPAddress` longtext CHARACTER SET utf8mb4 NULL,
    `Location` longtext CHARACTER SET utf8mb4 NULL,
    `SessionCount` int NULL,
    `SentMessageCount` int NULL,
    `ReceivedMessageCount` int NULL,
    CONSTRAINT `PK_StaffLoginHistory` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StaffLoginHistory_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_StaffLoginHistory_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_StaffLoginHistory_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `StaffPersonalSettings_MobileWebChatOpeningGreetings` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    `Greetings` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_StaffPersonalSettings_MobileWebChatOpeningGreetings` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StaffPersonalSettings_MobileWebChatOpeningGreetings_Domain_D~` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_StaffPersonalSettings_MobileWebChatOpeningGreetings_Site_Sit~` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_StaffPersonalSettings_MobileWebChatOpeningGreetings_Staff_St~` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `StaffPersonalSettings_Remind` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    `NewCustomer_Bubble` tinyint(1) NOT NULL,
    `NewCustomer_ShowView` tinyint(1) NOT NULL,
    `NewCustomer_Sound` tinyint(1) NOT NULL,
    `NewMessage_Bubble` tinyint(1) NOT NULL,
    `NewMessage_ShowView` tinyint(1) NOT NULL,
    `NewMessage_Sound` tinyint(1) NOT NULL,
    `NewSession_Bubble` tinyint(1) NOT NULL,
    `NewSession_ShowView` tinyint(1) NOT NULL,
    `NewSession_Sound` tinyint(1) NOT NULL,
    CONSTRAINT `PK_StaffPersonalSettings_Remind` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StaffPersonalSettings_Remind_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_StaffPersonalSettings_Remind_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `StaffPersonalSettings_WebChatOpeningGreetings` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    `Greetings` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_StaffPersonalSettings_WebChatOpeningGreetings` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StaffPersonalSettings_WebChatOpeningGreetings_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_StaffPersonalSettings_WebChatOpeningGreetings_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_StaffPersonalSettings_WebChatOpeningGreetings_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `StaffSettings_Operation` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    `DoubleClickVisitCustomerToStartInvite` tinyint(1) NOT NULL,
    `AutoRemoveOfflineCustomer` tinyint(1) NOT NULL,
    `AutoRemoveOfflineCustomerMinute` int NOT NULL,
    `AutoTurnStatusIntoLeaving` tinyint(1) NOT NULL,
    `AutoTurnStatusIntoLeavingMinute` int NOT NULL,
    CONSTRAINT `PK_StaffSettings_Operation` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_StaffSettings_Operation_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_StaffSettings_Operation_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Customer` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Gender` int NOT NULL,
    `CustomerCategoryId` char(36) NULL,
    `CustomerImportentLevelId` char(36) NULL,
    `Remark` varchar(500) CHARACTER SET utf8mb4 NULL,
    `Blocked` tinyint(1) NOT NULL,
    `BlockedByStaffId` char(36) NULL,
    `BlockedTime` datetime(6) NULL,
    `ExternalId` varchar(50) CHARACTER SET utf8mb4 NULL,
    `ExternalName` varchar(50) CHARACTER SET utf8mb4 NULL,
    `ExternalData` varchar(2000) CHARACTER SET utf8mb4 NULL,
    `CreatedTime` datetime(6) NULL,
    `LastDialogueTime` datetime(6) NULL,
    `AnyDialogue` tinyint(1) NOT NULL,
    `LastDialogueStaffId` char(36) NULL,
    `LastDialogueSessionStartType` int NULL,
    CONSTRAINT `PK_Customer` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Customer_Staff_BlockedByStaffId` FOREIGN KEY (`BlockedByStaffId`) REFERENCES `Staff` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Customer_CustomerCategory_CustomerCategoryId` FOREIGN KEY (`CustomerCategoryId`) REFERENCES `CustomerCategory` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Customer_CustomerImportentLevel_CustomerImportentLevelId` FOREIGN KEY (`CustomerImportentLevelId`) REFERENCES `CustomerImportentLevel` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Customer_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Customer_Staff_LastDialogueStaffId` FOREIGN KEY (`LastDialogueStaffId`) REFERENCES `Staff` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Customer_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `SkillGroupStaff` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SkillGroupId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    CONSTRAINT `PK_SkillGroupStaff` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_SkillGroupStaff_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_SkillGroupStaff_SkillGroup_SkillGroupId` FOREIGN KEY (`SkillGroupId`) REFERENCES `SkillGroup` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_SkillGroupStaff_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `QuicklyReplyItem` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `QuicklyReplyCategoryId` char(36) NOT NULL,
    `StaffId` char(36) NOT NULL,
    `NumericalOrder` bigint NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Content` varchar(1000) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_QuicklyReplyItem` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_QuicklyReplyItem_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_QuicklyReplyItem_QuicklyReplyCategory_QuicklyReplyCategoryId` FOREIGN KEY (`QuicklyReplyCategoryId`) REFERENCES `QuicklyReplyCategory` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Contact` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `CustomerId` char(36) NOT NULL,
    `CreatedTime` datetime(6) NOT NULL,
    `LatestUpdatedStaffId` char(36) NOT NULL,
    `LatestUpdateTime` datetime(6) NOT NULL,
    `Name` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `Gender` int NOT NULL,
    `Country` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Province` varchar(100) CHARACTER SET utf8mb4 NULL,
    `City` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Email` varchar(100) CHARACTER SET utf8mb4 NULL,
    `QQ` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Telphone` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Cellphone` varchar(50) CHARACTER SET utf8mb4 NULL,
    `Company` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Address` varchar(200) CHARACTER SET utf8mb4 NULL,
    `Remark` varchar(500) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Contact` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Contact_Customer_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customer` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Contact_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Contact_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `CustomerWebpageVisitationTrack` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `CustomerId` char(36) NOT NULL,
    `Url` varchar(1000) CHARACTER SET utf8mb4 NOT NULL,
    `Title` varchar(100) CHARACTER SET utf8mb4 NOT NULL,
    `VisitedTime` datetime(6) NOT NULL,
    CONSTRAINT `PK_CustomerWebpageVisitationTrack` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_CustomerWebpageVisitationTrack_Customer_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customer` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_CustomerWebpageVisitationTrack_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_CustomerWebpageVisitationTrack_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `LeaveMessage` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `CustomerId` char(36) NOT NULL,
    `ExtensionField1` varchar(100) CHARACTER SET utf8mb4 NULL,
    `ExtensionField2` varchar(100) CHARACTER SET utf8mb4 NULL,
    `ExtensionField3` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Name` varchar(50) CHARACTER SET utf8mb4 NULL,
    `ContactInformation` varchar(100) CHARACTER SET utf8mb4 NULL,
    `Content` varchar(500) CHARACTER SET utf8mb4 NULL,
    `Processed` tinyint(1) NOT NULL,
    `ProcessedRemark` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `ProcessedStaffId` char(36) NULL,
    `CreateTime` datetime(6) NOT NULL,
    `ProcessedTime` datetime(6) NULL,
    CONSTRAINT `PK_LeaveMessage` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_LeaveMessage_Customer_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customer` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_LeaveMessage_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_LeaveMessage_Staff_ProcessedStaffId` FOREIGN KEY (`ProcessedStaffId`) REFERENCES `Staff` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_LeaveMessage_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Session` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `StartTime` datetime(6) NOT NULL,
    `EndTime` datetime(6) NULL,
    `DurationSeconds` int NULL,
    `StaffId` char(36) NULL,
    `CustomerId` char(36) NOT NULL,
    `StartType` int NOT NULL,
    `StaffMessageCount` int NOT NULL,
    `CustomerMessageCount` int NOT NULL,
    `CustomerIP` varchar(20) CHARACTER SET utf8mb4 NULL,
    `CustomerIPDistrict` varchar(200) CHARACTER SET utf8mb4 NULL,
    `Remark` varchar(500) CHARACTER SET utf8mb4 NULL,
    `Taboo` tinyint(1) NOT NULL,
    `TabooWords` varchar(50) CHARACTER SET utf8mb4 NULL,
    `SkillGroupId` char(36) NULL,
    `CustomerFillInFieldBeforeStart1` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart1_Title` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart2` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart2_Title` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart3` varchar(100) CHARACTER SET utf8mb4 NULL,
    `CustomerFillInFieldBeforeStart3_Title` varchar(100) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Session` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Session_Customer_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customer` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_Session_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Session_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Session_SkillGroup_SkillGroupId` FOREIGN KEY (`SkillGroupId`) REFERENCES `SkillGroup` (`Id`) ON DELETE SET NULL,
    CONSTRAINT `FK_Session_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `DialogMessage` (
    `Id` char(36) NOT NULL,
    `DomainId` char(36) NOT NULL,
    `SiteId` char(36) NOT NULL,
    `SessionId` char(36) NOT NULL,
    `Type` int NOT NULL,
    `Content` varchar(1000) CHARACTER SET utf8mb4 NULL,
    `StaffId` char(36) NULL,
    `CustomerId` char(36) NULL,
    `SentBySystem` tinyint(1) NOT NULL,
    `SentTime` datetime(6) NOT NULL,
    `Taboo` tinyint(1) NOT NULL,
    `TabooWords` varchar(50) CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_DialogMessage` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_DialogMessage_Customer_CustomerId` FOREIGN KEY (`CustomerId`) REFERENCES `Customer` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_DialogMessage_Domain_DomainId` FOREIGN KEY (`DomainId`) REFERENCES `Domain` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_DialogMessage_Session_SessionId` FOREIGN KEY (`SessionId`) REFERENCES `Session` (`Id`) ON DELETE CASCADE,
    CONSTRAINT `FK_DialogMessage_Site_SiteId` FOREIGN KEY (`SiteId`) REFERENCES `Site` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_DialogMessage_Staff_StaffId` FOREIGN KEY (`StaffId`) REFERENCES `Staff` (`Id`) ON DELETE RESTRICT
);

CREATE INDEX `IX_Contact_CustomerId` ON `Contact` (`CustomerId`);

CREATE INDEX `IX_Contact_DomainId` ON `Contact` (`DomainId`);

CREATE INDEX `IX_Contact_SiteId` ON `Contact` (`SiteId`);

CREATE INDEX `IX_Customer_BlockedByStaffId` ON `Customer` (`BlockedByStaffId`);

CREATE INDEX `IX_Customer_CustomerCategoryId` ON `Customer` (`CustomerCategoryId`);

CREATE INDEX `IX_Customer_CustomerImportentLevelId` ON `Customer` (`CustomerImportentLevelId`);

CREATE INDEX `IX_Customer_DomainId` ON `Customer` (`DomainId`);

CREATE INDEX `IX_Customer_LastDialogueStaffId` ON `Customer` (`LastDialogueStaffId`);

CREATE INDEX `IX_Customer_SiteId` ON `Customer` (`SiteId`);

CREATE INDEX `IX_CustomerCategory_DomainId` ON `CustomerCategory` (`DomainId`);

CREATE INDEX `IX_CustomerCategory_SiteId` ON `CustomerCategory` (`SiteId`);

CREATE INDEX `IX_CustomerCount_DomainId` ON `CustomerCount` (`DomainId`);

CREATE INDEX `IX_CustomerCount_SiteId` ON `CustomerCount` (`SiteId`);

CREATE INDEX `IX_CustomerImportentLevel_DomainId` ON `CustomerImportentLevel` (`DomainId`);

CREATE INDEX `IX_CustomerImportentLevel_SiteId` ON `CustomerImportentLevel` (`SiteId`);

CREATE INDEX `IX_CustomerWebpageVisitationTrack_CustomerId` ON `CustomerWebpageVisitationTrack` (`CustomerId`);

CREATE INDEX `IX_CustomerWebpageVisitationTrack_DomainId` ON `CustomerWebpageVisitationTrack` (`DomainId`);

CREATE INDEX `IX_CustomerWebpageVisitationTrack_SiteId` ON `CustomerWebpageVisitationTrack` (`SiteId`);

CREATE INDEX `IX_DialogMessage_CustomerId` ON `DialogMessage` (`CustomerId`);

CREATE INDEX `IX_DialogMessage_DomainId` ON `DialogMessage` (`DomainId`);

CREATE INDEX `IX_DialogMessage_SessionId` ON `DialogMessage` (`SessionId`);

CREATE INDEX `IX_DialogMessage_SiteId` ON `DialogMessage` (`SiteId`);

CREATE INDEX `IX_DialogMessage_StaffId` ON `DialogMessage` (`StaffId`);

CREATE INDEX `IX_Dictionary_DomainId` ON `Dictionary` (`DomainId`);

CREATE INDEX `IX_DictionaryItem_DictionaryId` ON `DictionaryItem` (`DictionaryId`);

CREATE INDEX `IX_DictionaryItem_DomainId` ON `DictionaryItem` (`DomainId`);

CREATE INDEX `IX_LeaveMessage_CustomerId` ON `LeaveMessage` (`CustomerId`);

CREATE INDEX `IX_LeaveMessage_DomainId` ON `LeaveMessage` (`DomainId`);

CREATE INDEX `IX_LeaveMessage_ProcessedStaffId` ON `LeaveMessage` (`ProcessedStaffId`);

CREATE INDEX `IX_LeaveMessage_SiteId` ON `LeaveMessage` (`SiteId`);

CREATE INDEX `IX_Organization_DomainId` ON `Organization` (`DomainId`);

CREATE INDEX `IX_Organization_ParentId` ON `Organization` (`ParentId`);

CREATE INDEX `IX_QuicklyReplyCategory_DomainId` ON `QuicklyReplyCategory` (`DomainId`);

CREATE INDEX `IX_QuicklyReplyCategory_StaffId` ON `QuicklyReplyCategory` (`StaffId`);

CREATE INDEX `IX_QuicklyReplyItem_DomainId` ON `QuicklyReplyItem` (`DomainId`);

CREATE INDEX `IX_QuicklyReplyItem_QuicklyReplyCategoryId` ON `QuicklyReplyItem` (`QuicklyReplyCategoryId`);

CREATE INDEX `IX_RobotItem_DomainId` ON `RobotItem` (`DomainId`);

CREATE INDEX `IX_RobotItem_ParentId` ON `RobotItem` (`ParentId`);

CREATE INDEX `IX_RobotItem_SiteId` ON `RobotItem` (`SiteId`);

CREATE INDEX `IX_Role_DomainId` ON `Role` (`DomainId`);

CREATE INDEX `IX_RoleAuthorization_DomainId` ON `RoleAuthorization` (`DomainId`);

CREATE INDEX `IX_RoleAuthorization_RoleId` ON `RoleAuthorization` (`RoleId`);

CREATE INDEX `IX_RoleStaff_DomainId` ON `RoleStaff` (`DomainId`);

CREATE INDEX `IX_RoleStaff_RoleId` ON `RoleStaff` (`RoleId`);

CREATE INDEX `IX_RoleStaff_StaffId` ON `RoleStaff` (`StaffId`);

CREATE INDEX `IX_Session_CustomerId` ON `Session` (`CustomerId`);

CREATE INDEX `IX_Session_DomainId` ON `Session` (`DomainId`);

CREATE INDEX `IX_Session_SiteId` ON `Session` (`SiteId`);

CREATE INDEX `IX_Session_SkillGroupId` ON `Session` (`SkillGroupId`);

CREATE INDEX `IX_Session_StaffId` ON `Session` (`StaffId`);

CREATE INDEX `IX_Site_DomainId` ON `Site` (`DomainId`);

CREATE INDEX `IX_SiteSettings_ChatMisc_DomainId` ON `SiteSettings_ChatMisc` (`DomainId`);

CREATE INDEX `IX_SiteSettings_ChatMisc_SiteId` ON `SiteSettings_ChatMisc` (`SiteId`);

CREATE INDEX `IX_SiteSettings_FakeCustomerWaitingQueue_DomainId` ON `SiteSettings_FakeCustomerWaitingQueue` (`DomainId`);

CREATE INDEX `IX_SiteSettings_FakeCustomerWaitingQueue_SiteId` ON `SiteSettings_FakeCustomerWaitingQueue` (`SiteId`);

CREATE INDEX `IX_SiteSettings_LeaveMessageContentTemplate_DomainId` ON `SiteSettings_LeaveMessageContentTemplate` (`DomainId`);

CREATE INDEX `IX_SiteSettings_LeaveMessageContentTemplate_SiteId` ON `SiteSettings_LeaveMessageContentTemplate` (`SiteId`);

CREATE INDEX `IX_SiteSettings_Misc_DomainId` ON `SiteSettings_Misc` (`DomainId`);

CREATE INDEX `IX_SiteSettings_Misc_SiteId` ON `SiteSettings_Misc` (`SiteId`);

CREATE INDEX `IX_SiteSettings_MobileWebChatOpeningGreetings_DomainId` ON `SiteSettings_MobileWebChatOpeningGreetings` (`DomainId`);

CREATE INDEX `IX_SiteSettings_MobileWebChatOpeningGreetings_SiteId` ON `SiteSettings_MobileWebChatOpeningGreetings` (`SiteId`);

CREATE INDEX `IX_SiteSettings_MobileWebChatStyle_DomainId` ON `SiteSettings_MobileWebChatStyle` (`DomainId`);

CREATE INDEX `IX_SiteSettings_MobileWebChatStyle_SiteId` ON `SiteSettings_MobileWebChatStyle` (`SiteId`);

CREATE INDEX `IX_SiteSettings_MobileWebFloatIcon_DomainId` ON `SiteSettings_MobileWebFloatIcon` (`DomainId`);

CREATE INDEX `IX_SiteSettings_MobileWebFloatIcon_SiteId` ON `SiteSettings_MobileWebFloatIcon` (`SiteId`);

CREATE INDEX `IX_SiteSettings_MobileWebLeaveMessage_DomainId` ON `SiteSettings_MobileWebLeaveMessage` (`DomainId`);

CREATE INDEX `IX_SiteSettings_MobileWebLeaveMessage_SiteId` ON `SiteSettings_MobileWebLeaveMessage` (`SiteId`);

CREATE INDEX `IX_SiteSettings_WebChatAd_DomainId` ON `SiteSettings_WebChatAd` (`DomainId`);

CREATE INDEX `IX_SiteSettings_WebChatOpeningGreetings_DomainId` ON `SiteSettings_WebChatOpeningGreetings` (`DomainId`);

CREATE INDEX `IX_SiteSettings_WebChatOpeningGreetings_SiteId` ON `SiteSettings_WebChatOpeningGreetings` (`SiteId`);

CREATE INDEX `IX_SiteSettings_WebChatStyle_DomainId` ON `SiteSettings_WebChatStyle` (`DomainId`);

CREATE INDEX `IX_SiteSettings_WebChatStyle_SiteId` ON `SiteSettings_WebChatStyle` (`SiteId`);

CREATE INDEX `IX_SiteSettings_WebFloatIcon_DomainId` ON `SiteSettings_WebFloatIcon` (`DomainId`);

CREATE INDEX `IX_SiteSettings_WebFloatIcon_SiteId` ON `SiteSettings_WebFloatIcon` (`SiteId`);

CREATE INDEX `IX_SiteSettings_WebLeaveMessage_DomainId` ON `SiteSettings_WebLeaveMessage` (`DomainId`);

CREATE INDEX `IX_SiteSettings_WebLeaveMessage_SiteId` ON `SiteSettings_WebLeaveMessage` (`SiteId`);

CREATE INDEX `IX_SkillGroup_DomainId` ON `SkillGroup` (`DomainId`);

CREATE INDEX `IX_SkillGroup_SiteId` ON `SkillGroup` (`SiteId`);

CREATE INDEX `IX_SkillGroupSettings_DomainId` ON `SkillGroupSettings` (`DomainId`);

CREATE INDEX `IX_SkillGroupSettings_SiteId` ON `SkillGroupSettings` (`SiteId`);

CREATE INDEX `IX_SkillGroupStaff_DomainId` ON `SkillGroupStaff` (`DomainId`);

CREATE INDEX `IX_SkillGroupStaff_SkillGroupId` ON `SkillGroupStaff` (`SkillGroupId`);

CREATE INDEX `IX_SkillGroupStaff_StaffId` ON `SkillGroupStaff` (`StaffId`);

CREATE INDEX `IX_Staff_DomainId` ON `Staff` (`DomainId`);

CREATE INDEX `IX_Staff_OrganizationId` ON `Staff` (`OrganizationId`);

CREATE INDEX `IX_StaffLoginHistory_DomainId` ON `StaffLoginHistory` (`DomainId`);

CREATE INDEX `IX_StaffLoginHistory_SiteId` ON `StaffLoginHistory` (`SiteId`);

CREATE INDEX `IX_StaffLoginHistory_StaffId` ON `StaffLoginHistory` (`StaffId`);

CREATE INDEX `IX_StaffPersonalSettings_MobileWebChatOpeningGreetings_DomainId` ON `StaffPersonalSettings_MobileWebChatOpeningGreetings` (`DomainId`);

CREATE INDEX `IX_StaffPersonalSettings_MobileWebChatOpeningGreetings_SiteId` ON `StaffPersonalSettings_MobileWebChatOpeningGreetings` (`SiteId`);

CREATE INDEX `IX_StaffPersonalSettings_MobileWebChatOpeningGreetings_StaffId` ON `StaffPersonalSettings_MobileWebChatOpeningGreetings` (`StaffId`);

CREATE INDEX `IX_StaffPersonalSettings_Remind_DomainId` ON `StaffPersonalSettings_Remind` (`DomainId`);

CREATE INDEX `IX_StaffPersonalSettings_Remind_StaffId` ON `StaffPersonalSettings_Remind` (`StaffId`);

CREATE INDEX `IX_StaffPersonalSettings_WebChatOpeningGreetings_DomainId` ON `StaffPersonalSettings_WebChatOpeningGreetings` (`DomainId`);

CREATE INDEX `IX_StaffPersonalSettings_WebChatOpeningGreetings_SiteId` ON `StaffPersonalSettings_WebChatOpeningGreetings` (`SiteId`);

CREATE INDEX `IX_StaffPersonalSettings_WebChatOpeningGreetings_StaffId` ON `StaffPersonalSettings_WebChatOpeningGreetings` (`StaffId`);

CREATE INDEX `IX_StaffSettings_Operation_DomainId` ON `StaffSettings_Operation` (`DomainId`);

CREATE INDEX `IX_StaffSettings_Operation_StaffId` ON `StaffSettings_Operation` (`StaffId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210629155406_20210608a', '3.1.10');

