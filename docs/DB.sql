USE [master]
GO
/****** Object:  Database [MM]    Script Date: 6/30/2020 8:25:06 AM ******/
CREATE DATABASE [MM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MM_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MM] SET ARITHABORT OFF 
GO
ALTER DATABASE [MM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MM] SET RECOVERY FULL 
GO
ALTER DATABASE [MM] SET  MULTI_USER 
GO
ALTER DATABASE [MM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MM', N'ON'
GO
ALTER DATABASE [MM] SET QUERY_STORE = OFF
GO
USE [MM]
GO
/****** Object:  Schema [Audit]    Script Date: 6/30/2020 8:25:09 AM ******/
CREATE SCHEMA [Audit]
GO
/****** Object:  Schema [Client]    Script Date: 6/30/2020 8:25:09 AM ******/
CREATE SCHEMA [Client]
GO
/****** Object:  Schema [Common]    Script Date: 6/30/2020 8:25:09 AM ******/
CREATE SCHEMA [Common]
GO
/****** Object:  Schema [Core]    Script Date: 6/30/2020 8:25:09 AM ******/
CREATE SCHEMA [Core]
GO
/****** Object:  Schema [Member]    Script Date: 6/30/2020 8:25:09 AM ******/
CREATE SCHEMA [Member]
GO
/****** Object:  Table [Audit].[ClientUserLoginAudit]    Script Date: 6/30/2020 8:25:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[ClientUserLoginAudit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientUserId] [int] NOT NULL,
	[LoginTime] [int] NOT NULL,
	[LogoutTime] [datetime] NULL,
 CONSTRAINT [PK_ClientUserLoginAudit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Audit].[CoreUserLogin]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[CoreUserLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CoreUserId] [int] NOT NULL,
	[LoginTime] [int] NOT NULL,
	[LogoutTime] [datetime] NULL,
 CONSTRAINT [PK_CoreUserLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Audit].[MemberLogin]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Audit].[MemberLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ContactUserId] [int] NOT NULL,
	[LoginTime] [int] NOT NULL,
	[LogoutTime] [datetime] NULL,
 CONSTRAINT [PK_MemberLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Affliation]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Affliation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Affliation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[BillingCommunication]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[BillingCommunication](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[BillingId] [int] NOT NULL,
	[Reminder1Sent] [bit] NULL,
	[Reminder1SentDate] [datetime] NULL,
	[Reminder1ScheduledDate] [datetime] NULL,
	[Reminder2Sent] [bit] NULL,
	[Reminder2SentDate] [datetime] NULL,
	[Reminder2ScheduledDate] [datetime] NULL,
	[Reminder3Sent] [bit] NULL,
	[Reminder3SentDate] [datetime] NULL,
	[Reminder3ScheduledDate] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_BillingCommunication] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Client]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientTypeId] [int] NOT NULL,
	[AgreedToTerms] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateSettingId] [int] NULL,
	[TimeFormatId] [int] NULL,
	[TimeZoneId] [int] NULL,
	[CurrencyId] [int] NULL,
	[CurrencyDecimalPlaces] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientAccountType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientAccountType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientAccountType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientAddress]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientUserId] [int] NULL,
	[ClientId] [int] NULL,
	[AddressTypeId] [int] NOT NULL,
	[AddressLine1] [nvarchar](100) NULL,
	[AddressLine2] [nvarchar](100) NULL,
	[BuidlingName] [nvarchar](100) NULL,
	[ComplexName] [nvarchar](100) NULL,
	[StreetName] [nvarchar](100) NULL,
	[CityId] [int] NULL,
	[StateId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
	[PostalCode] [nvarchar](50) NULL,
	[PrimaryContactNo] [nvarchar](50) NULL,
	[SecondaryContactNo] [nvarchar](50) NULL,
	[PrimaryEmail] [nvarchar](50) NULL,
	[SecondaryEmail] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](50) NULL,
	[GPSCoordinates] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientAddressType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientAddressType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientAddressType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientBankingDetail]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientBankingDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[AccountTypeId] [int] NOT NULL,
	[BankName] [nvarchar](50) NOT NULL,
	[BranchName] [nvarchar](100) NOT NULL,
	[AccountNumber] [nvarchar](50) NOT NULL,
	[RoutingCode] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientBankingDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientBilling]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientBilling](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NULL,
	[ClientId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[PaymentGatewayId] [int] NOT NULL,
	[PaymentDueDate] [datetime] NULL,
	[PaidDate] [datetime] NULL,
	[PaymentItem] [nvarchar](200) NOT NULL,
	[PaymentAmount] [decimal](18, 3) NOT NULL,
	[PaidAmount] [decimal](18, 3) NULL,
	[CommentsForPayer] [nvarchar](1000) NULL,
	[InternalNotes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientBilling] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientPermission]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientPermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientRole]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientRolePermissionXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientRolePermissionXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[Permissionid] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientRolePermissionXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientUser]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EmailActivated] [bit] NOT NULL,
	[PrimaryContact] [bit] NOT NULL,
	[BillingContact] [bit] NOT NULL,
	[DesignationId] [int] NULL,
	[RoleId] [int] NOT NULL,
	[ReferralTypeId] [int] NULL,
	[Notes] [nvarchar](1000) NOT NULL,
	[GenderId] [int] NOT NULL,
	[IsInternalUser] [bit] NOT NULL,
	[TermsAccepted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ClientUserRoleXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ClientUserRoleXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientUserid] [int] NOT NULL,
	[ClientRoleId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientUserRoleXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CommunicationPreference]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CommunicationPreference](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[CommunicationTypeId] [int] NOT NULL,
	[PreferredTimeFrom] [time](7) NULL,
	[PreferredTimeTo] [time](7) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CommunicationPreference] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CommunicationType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CommunicationType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CommunicationType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CommunicationTypeDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CommunicationTypeDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CommunicationTypeDefault] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CorrespondenceType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CorrespondenceType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CorrespondenceType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CPD]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CPD](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[CPDEarned] [int] NOT NULL,
	[CPDAwardedById] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CPD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CPDMemberCategorySetUp]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CPDMemberCategorySetUp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[MemberCategoryId] [int] NULL,
	[CPDCount] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CPDMemberCategorySetUp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CPDMemberLevelSetUp]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CPDMemberLevelSetUp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[MemberLevelId] [int] NULL,
	[CPDCount] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CPDMemberLevelSetUp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CPDMemberTeamSetUp]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CPDMemberTeamSetUp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[MemberTeamId] [int] NULL,
	[CPDCount] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CPDMemberTeamSetUp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CPDMemberTypeSetUp]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CPDMemberTypeSetUp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[MemberTypeId] [int] NULL,
	[CPDCount] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CPDMemberTypeSetUp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CustomField]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CustomField](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[TablePrimaryKeyValue] [int] NOT NULL,
	[Int1] [int] SPARSE  NULL,
	[Int2] [int] SPARSE  NULL,
	[Int3] [int] SPARSE  NULL,
	[Int4] [int] SPARSE  NULL,
	[Int5] [int] SPARSE  NULL,
	[Int6] [int] SPARSE  NULL,
	[Int7] [int] SPARSE  NULL,
	[Int8] [int] SPARSE  NULL,
	[Int9] [int] SPARSE  NULL,
	[Int10] [int] SPARSE  NULL,
	[Int11] [int] SPARSE  NULL,
	[Int12] [int] SPARSE  NULL,
	[Int13] [int] SPARSE  NULL,
	[Int14] [int] SPARSE  NULL,
	[Int15] [int] SPARSE  NULL,
	[Int16] [int] SPARSE  NULL,
	[Int17] [int] SPARSE  NULL,
	[Int18] [int] SPARSE  NULL,
	[Int19] [int] SPARSE  NULL,
	[Int20] [int] SPARSE  NULL,
	[Int21] [int] SPARSE  NULL,
	[Int22] [int] SPARSE  NULL,
	[Int23] [int] SPARSE  NULL,
	[Int24] [int] SPARSE  NULL,
	[Int25] [int] SPARSE  NULL,
	[Int26] [int] SPARSE  NULL,
	[Int27] [int] SPARSE  NULL,
	[Int28] [int] SPARSE  NULL,
	[Int29] [int] SPARSE  NULL,
	[Int30] [int] SPARSE  NULL,
	[Int31] [int] SPARSE  NULL,
	[Int32] [int] SPARSE  NULL,
	[Int33] [int] SPARSE  NULL,
	[Int34] [int] SPARSE  NULL,
	[Int35] [int] SPARSE  NULL,
	[Int36] [int] SPARSE  NULL,
	[Int37] [int] SPARSE  NULL,
	[Int38] [int] SPARSE  NULL,
	[Int39] [int] SPARSE  NULL,
	[Int40] [int] SPARSE  NULL,
	[Int41] [int] SPARSE  NULL,
	[Int42] [int] SPARSE  NULL,
	[Int43] [int] SPARSE  NULL,
	[Int44] [int] SPARSE  NULL,
	[Int45] [int] SPARSE  NULL,
	[Int46] [int] SPARSE  NULL,
	[Int47] [int] SPARSE  NULL,
	[Int48] [int] SPARSE  NULL,
	[Int49] [int] SPARSE  NULL,
	[Int50] [int] SPARSE  NULL,
	[Int51] [int] SPARSE  NULL,
	[Int52] [int] SPARSE  NULL,
	[Int53] [int] SPARSE  NULL,
	[Int54] [int] SPARSE  NULL,
	[Int55] [int] SPARSE  NULL,
	[Int56] [int] SPARSE  NULL,
	[Int57] [int] SPARSE  NULL,
	[Int58] [int] SPARSE  NULL,
	[Int59] [int] SPARSE  NULL,
	[Int60] [int] SPARSE  NULL,
	[Int61] [int] SPARSE  NULL,
	[Int62] [int] SPARSE  NULL,
	[Int63] [int] SPARSE  NULL,
	[Int64] [int] SPARSE  NULL,
	[Int65] [int] SPARSE  NULL,
	[Int66] [int] SPARSE  NULL,
	[Int67] [int] SPARSE  NULL,
	[Int68] [int] SPARSE  NULL,
	[Int69] [int] SPARSE  NULL,
	[Int70] [int] SPARSE  NULL,
	[Int71] [int] SPARSE  NULL,
	[Int72] [int] SPARSE  NULL,
	[Int73] [int] SPARSE  NULL,
	[Int74] [int] SPARSE  NULL,
	[Int75] [int] SPARSE  NULL,
	[Int76] [int] SPARSE  NULL,
	[Int77] [int] SPARSE  NULL,
	[Int78] [int] SPARSE  NULL,
	[Int79] [int] SPARSE  NULL,
	[Int80] [int] SPARSE  NULL,
	[Int81] [int] SPARSE  NULL,
	[Int82] [int] SPARSE  NULL,
	[Int83] [int] SPARSE  NULL,
	[Int84] [int] SPARSE  NULL,
	[Int85] [int] SPARSE  NULL,
	[Int86] [int] SPARSE  NULL,
	[Int87] [int] SPARSE  NULL,
	[Int88] [int] SPARSE  NULL,
	[Int89] [int] SPARSE  NULL,
	[Int90] [int] SPARSE  NULL,
	[Int91] [int] SPARSE  NULL,
	[Int92] [int] SPARSE  NULL,
	[Int93] [int] SPARSE  NULL,
	[Int94] [int] SPARSE  NULL,
	[Int95] [int] SPARSE  NULL,
	[Int96] [int] SPARSE  NULL,
	[Int97] [int] SPARSE  NULL,
	[Int98] [int] SPARSE  NULL,
	[Int99] [int] SPARSE  NULL,
	[Int100] [int] SPARSE  NULL,
	[lookup1] [int] SPARSE  NULL,
	[lookup2] [int] SPARSE  NULL,
	[lookup3] [int] SPARSE  NULL,
	[lookup4] [int] SPARSE  NULL,
	[lookup5] [int] SPARSE  NULL,
	[lookup6] [int] SPARSE  NULL,
	[lookup7] [int] SPARSE  NULL,
	[lookup8] [int] SPARSE  NULL,
	[lookup9] [int] SPARSE  NULL,
	[lookup10] [int] SPARSE  NULL,
	[lookup11] [int] SPARSE  NULL,
	[lookup12] [int] SPARSE  NULL,
	[lookup13] [int] SPARSE  NULL,
	[lookup14] [int] SPARSE  NULL,
	[lookup15] [int] SPARSE  NULL,
	[lookup16] [int] SPARSE  NULL,
	[lookup17] [int] SPARSE  NULL,
	[lookup18] [int] SPARSE  NULL,
	[lookup19] [int] SPARSE  NULL,
	[lookup20] [int] SPARSE  NULL,
	[lookup21] [int] SPARSE  NULL,
	[lookup22] [int] SPARSE  NULL,
	[lookup23] [int] SPARSE  NULL,
	[lookup24] [int] SPARSE  NULL,
	[lookup25] [int] SPARSE  NULL,
	[lookup26] [int] SPARSE  NULL,
	[lookup27] [int] SPARSE  NULL,
	[lookup28] [int] SPARSE  NULL,
	[lookup29] [int] SPARSE  NULL,
	[lookup30] [int] SPARSE  NULL,
	[lookup31] [int] SPARSE  NULL,
	[lookup32] [int] SPARSE  NULL,
	[lookup33] [int] SPARSE  NULL,
	[lookup34] [int] SPARSE  NULL,
	[lookup35] [int] SPARSE  NULL,
	[lookup36] [int] SPARSE  NULL,
	[lookup37] [int] SPARSE  NULL,
	[lookup38] [int] SPARSE  NULL,
	[lookup39] [int] SPARSE  NULL,
	[lookup40] [int] SPARSE  NULL,
	[lookup41] [int] SPARSE  NULL,
	[lookup42] [int] SPARSE  NULL,
	[lookup43] [int] SPARSE  NULL,
	[lookup44] [int] SPARSE  NULL,
	[lookup45] [int] SPARSE  NULL,
	[lookup46] [int] SPARSE  NULL,
	[lookup47] [int] SPARSE  NULL,
	[lookup48] [int] SPARSE  NULL,
	[lookup49] [int] SPARSE  NULL,
	[lookup50] [int] SPARSE  NULL,
	[lookup51] [int] SPARSE  NULL,
	[lookup52] [int] SPARSE  NULL,
	[lookup53] [int] SPARSE  NULL,
	[lookup54] [int] SPARSE  NULL,
	[lookup55] [int] SPARSE  NULL,
	[lookup56] [int] SPARSE  NULL,
	[lookup57] [int] SPARSE  NULL,
	[lookup58] [int] SPARSE  NULL,
	[lookup59] [int] SPARSE  NULL,
	[lookup60] [int] SPARSE  NULL,
	[lookup61] [int] SPARSE  NULL,
	[lookup62] [int] SPARSE  NULL,
	[lookup63] [int] SPARSE  NULL,
	[lookup64] [int] SPARSE  NULL,
	[lookup65] [int] SPARSE  NULL,
	[lookup66] [int] SPARSE  NULL,
	[lookup67] [int] SPARSE  NULL,
	[lookup68] [int] SPARSE  NULL,
	[lookup69] [int] SPARSE  NULL,
	[lookup70] [int] SPARSE  NULL,
	[lookup71] [int] SPARSE  NULL,
	[lookup72] [int] SPARSE  NULL,
	[lookup73] [int] SPARSE  NULL,
	[lookup74] [int] SPARSE  NULL,
	[lookup75] [int] SPARSE  NULL,
	[lookup76] [int] SPARSE  NULL,
	[lookup77] [int] SPARSE  NULL,
	[lookup78] [int] SPARSE  NULL,
	[lookup79] [int] SPARSE  NULL,
	[lookup80] [int] SPARSE  NULL,
	[lookup81] [int] SPARSE  NULL,
	[lookup82] [int] SPARSE  NULL,
	[lookup83] [int] SPARSE  NULL,
	[lookup84] [int] SPARSE  NULL,
	[lookup85] [int] SPARSE  NULL,
	[lookup86] [int] SPARSE  NULL,
	[lookup87] [int] SPARSE  NULL,
	[lookup88] [int] SPARSE  NULL,
	[lookup89] [int] SPARSE  NULL,
	[lookup90] [int] SPARSE  NULL,
	[lookup91] [int] SPARSE  NULL,
	[lookup92] [int] SPARSE  NULL,
	[lookup93] [int] SPARSE  NULL,
	[lookup94] [int] SPARSE  NULL,
	[lookup95] [int] SPARSE  NULL,
	[lookup96] [int] SPARSE  NULL,
	[lookup97] [int] SPARSE  NULL,
	[lookup98] [int] SPARSE  NULL,
	[lookup99] [int] SPARSE  NULL,
	[lookup100] [int] SPARSE  NULL,
	[lookup101] [int] SPARSE  NULL,
	[lookup102] [int] SPARSE  NULL,
	[lookup103] [int] SPARSE  NULL,
	[lookup104] [int] SPARSE  NULL,
	[lookup105] [int] SPARSE  NULL,
	[lookup106] [int] SPARSE  NULL,
	[lookup107] [int] SPARSE  NULL,
	[lookup108] [int] SPARSE  NULL,
	[lookup109] [int] SPARSE  NULL,
	[lookup110] [int] SPARSE  NULL,
	[text1] [nvarchar](2000) NULL,
	[text2] [nvarchar](2000) NULL,
	[text3] [nvarchar](2000) NULL,
	[text4] [nvarchar](2000) NULL,
	[text5] [nvarchar](2000) NULL,
	[text6] [nvarchar](2000) NULL,
	[text7] [nvarchar](2000) NULL,
	[text8] [nvarchar](2000) NULL,
	[text9] [nvarchar](2000) NULL,
	[text10] [nvarchar](2000) NULL,
	[text11] [nvarchar](2000) NULL,
	[text12] [nvarchar](2000) NULL,
	[text13] [nvarchar](2000) NULL,
	[text14] [nvarchar](2000) NULL,
	[text15] [nvarchar](2000) NULL,
	[text16] [nvarchar](2000) NULL,
	[text17] [nvarchar](2000) NULL,
	[text18] [nvarchar](2000) NULL,
	[text19] [nvarchar](2000) NULL,
	[text20] [nvarchar](2000) NULL,
	[text21] [nvarchar](2000) NULL,
	[text22] [nvarchar](2000) NULL,
	[text23] [nvarchar](2000) NULL,
	[text24] [nvarchar](2000) NULL,
	[text25] [nvarchar](2000) NULL,
	[text26] [nvarchar](2000) NULL,
	[text27] [nvarchar](2000) NULL,
	[text28] [nvarchar](2000) NULL,
	[text29] [nvarchar](2000) NULL,
	[text30] [nvarchar](2000) NULL,
	[text31] [nvarchar](2000) NULL,
	[text32] [nvarchar](2000) NULL,
	[text33] [nvarchar](2000) NULL,
	[text34] [nvarchar](2000) NULL,
	[text35] [nvarchar](2000) NULL,
	[text36] [nvarchar](2000) NULL,
	[text37] [nvarchar](2000) NULL,
	[text38] [nvarchar](2000) NULL,
	[text39] [nvarchar](2000) NULL,
	[text40] [nvarchar](2000) NULL,
	[text41] [nvarchar](2000) NULL,
	[text42] [nvarchar](2000) NULL,
	[text43] [nvarchar](2000) NULL,
	[text44] [nvarchar](2000) NULL,
	[text45] [nvarchar](2000) NULL,
	[text46] [nvarchar](2000) NULL,
	[text47] [nvarchar](2000) NULL,
	[text48] [nvarchar](2000) NULL,
	[text49] [nvarchar](2000) NULL,
	[text50] [nvarchar](2000) NULL,
	[text51] [nvarchar](2000) NULL,
	[text52] [nvarchar](2000) NULL,
	[text53] [nvarchar](2000) NULL,
	[text54] [nvarchar](2000) NULL,
	[text55] [nvarchar](2000) NULL,
	[text56] [nvarchar](2000) NULL,
	[text57] [nvarchar](2000) NULL,
	[text58] [nvarchar](2000) NULL,
	[text59] [nvarchar](2000) NULL,
	[text60] [nvarchar](2000) NULL,
	[text61] [nvarchar](2000) NULL,
	[text62] [nvarchar](2000) NULL,
	[text63] [nvarchar](2000) NULL,
	[text64] [nvarchar](2000) NULL,
	[text65] [nvarchar](2000) NULL,
	[text66] [nvarchar](2000) NULL,
	[text67] [nvarchar](2000) NULL,
	[text68] [nvarchar](2000) NULL,
	[text69] [nvarchar](2000) NULL,
	[text70] [nvarchar](2000) NULL,
	[text71] [nvarchar](2000) NULL,
	[text72] [nvarchar](2000) NULL,
	[text73] [nvarchar](2000) NULL,
	[text74] [nvarchar](2000) NULL,
	[text75] [nvarchar](2000) NULL,
	[text76] [nvarchar](2000) NULL,
	[text77] [nvarchar](2000) NULL,
	[text78] [nvarchar](2000) NULL,
	[text79] [nvarchar](2000) NULL,
	[text80] [nvarchar](2000) NULL,
	[text81] [nvarchar](2000) NULL,
	[text82] [nvarchar](2000) NULL,
	[text83] [nvarchar](2000) NULL,
	[text84] [nvarchar](2000) NULL,
	[text85] [nvarchar](2000) NULL,
	[text86] [nvarchar](2000) NULL,
	[text87] [nvarchar](2000) NULL,
	[text88] [nvarchar](2000) NULL,
	[text89] [nvarchar](2000) NULL,
	[text90] [nvarchar](2000) NULL,
	[text91] [nvarchar](2000) NULL,
	[text92] [nvarchar](2000) NULL,
	[text93] [nvarchar](2000) NULL,
	[text94] [nvarchar](2000) NULL,
	[text95] [nvarchar](2000) NULL,
	[text96] [nvarchar](2000) NULL,
	[text97] [nvarchar](2000) NULL,
	[text98] [nvarchar](2000) NULL,
	[text99] [nvarchar](2000) NULL,
	[text100] [nvarchar](2000) NULL,
	[datetime1] [datetime] SPARSE  NULL,
	[datetime2] [datetime] SPARSE  NULL,
	[datetime3] [datetime] SPARSE  NULL,
	[datetime4] [datetime] SPARSE  NULL,
	[datetime5] [datetime] SPARSE  NULL,
	[datetime6] [datetime] SPARSE  NULL,
	[datetime7] [datetime] SPARSE  NULL,
	[datetime8] [datetime] SPARSE  NULL,
	[datetime9] [datetime] SPARSE  NULL,
	[datetime10] [datetime] SPARSE  NULL,
	[datetime11] [datetime] SPARSE  NULL,
	[datetime12] [datetime] SPARSE  NULL,
	[datetime13] [datetime] SPARSE  NULL,
	[datetime14] [datetime] SPARSE  NULL,
	[datetime15] [datetime] SPARSE  NULL,
	[datetime16] [datetime] SPARSE  NULL,
	[datetime17] [datetime] SPARSE  NULL,
	[datetime18] [datetime] SPARSE  NULL,
	[datetime19] [datetime] SPARSE  NULL,
	[datetime20] [datetime] SPARSE  NULL,
	[datetime21] [datetime] SPARSE  NULL,
	[datetime22] [datetime] SPARSE  NULL,
	[datetime23] [datetime] SPARSE  NULL,
	[datetime24] [datetime] SPARSE  NULL,
	[datetime25] [datetime] SPARSE  NULL,
	[datetime26] [datetime] SPARSE  NULL,
	[datetime27] [datetime] SPARSE  NULL,
	[datetime28] [datetime] SPARSE  NULL,
	[datetime29] [datetime] SPARSE  NULL,
	[datetime30] [datetime] SPARSE  NULL,
	[datetime31] [datetime] SPARSE  NULL,
	[datetime32] [datetime] SPARSE  NULL,
	[datetime33] [datetime] SPARSE  NULL,
	[datetime34] [datetime] SPARSE  NULL,
	[datetime35] [datetime] SPARSE  NULL,
	[datetime36] [datetime] SPARSE  NULL,
	[datetime37] [datetime] SPARSE  NULL,
	[datetime38] [datetime] SPARSE  NULL,
	[datetime39] [datetime] SPARSE  NULL,
	[datetime40] [datetime] SPARSE  NULL,
	[datetime41] [datetime] SPARSE  NULL,
	[datetime42] [datetime] SPARSE  NULL,
	[datetime43] [datetime] SPARSE  NULL,
	[datetime44] [datetime] SPARSE  NULL,
	[datetime45] [datetime] SPARSE  NULL,
	[datetime46] [datetime] SPARSE  NULL,
	[datetime47] [datetime] SPARSE  NULL,
	[datetime48] [datetime] SPARSE  NULL,
	[datetime49] [datetime] SPARSE  NULL,
	[datetime50] [datetime] SPARSE  NULL,
	[datetime51] [datetime] SPARSE  NULL,
	[datetime52] [datetime] SPARSE  NULL,
	[datetime53] [datetime] SPARSE  NULL,
	[datetime54] [datetime] SPARSE  NULL,
	[datetime55] [datetime] SPARSE  NULL,
	[datetime56] [datetime] SPARSE  NULL,
	[datetime57] [datetime] SPARSE  NULL,
	[datetime58] [datetime] SPARSE  NULL,
	[datetime59] [datetime] SPARSE  NULL,
	[datetime60] [datetime] SPARSE  NULL,
	[datetime61] [datetime] SPARSE  NULL,
	[datetime62] [datetime] SPARSE  NULL,
	[datetime63] [datetime] SPARSE  NULL,
	[datetime64] [datetime] SPARSE  NULL,
	[datetime65] [datetime] SPARSE  NULL,
	[datetime66] [datetime] SPARSE  NULL,
	[datetime67] [datetime] SPARSE  NULL,
	[datetime68] [datetime] SPARSE  NULL,
	[datetime69] [datetime] SPARSE  NULL,
	[datetime70] [datetime] SPARSE  NULL,
	[datetime71] [datetime] SPARSE  NULL,
	[datetime72] [datetime] SPARSE  NULL,
	[datetime73] [datetime] SPARSE  NULL,
	[datetime74] [datetime] SPARSE  NULL,
	[datetime75] [datetime] SPARSE  NULL,
	[datetime76] [datetime] SPARSE  NULL,
	[datetime77] [datetime] SPARSE  NULL,
	[datetime78] [datetime] SPARSE  NULL,
	[datetime79] [datetime] SPARSE  NULL,
	[datetime80] [datetime] SPARSE  NULL,
	[datetime81] [datetime] SPARSE  NULL,
	[datetime82] [datetime] SPARSE  NULL,
	[datetime83] [datetime] SPARSE  NULL,
	[datetime84] [datetime] SPARSE  NULL,
	[datetime85] [datetime] SPARSE  NULL,
	[datetime86] [datetime] SPARSE  NULL,
	[datetime87] [datetime] SPARSE  NULL,
	[datetime88] [datetime] SPARSE  NULL,
	[datetime89] [datetime] SPARSE  NULL,
	[datetime90] [datetime] SPARSE  NULL,
	[datetime91] [datetime] SPARSE  NULL,
	[datetime92] [datetime] SPARSE  NULL,
	[datetime93] [datetime] SPARSE  NULL,
	[datetime94] [datetime] SPARSE  NULL,
	[datetime95] [datetime] SPARSE  NULL,
	[datetime96] [datetime] SPARSE  NULL,
	[datetime97] [datetime] SPARSE  NULL,
	[datetime98] [datetime] SPARSE  NULL,
	[datetime99] [datetime] SPARSE  NULL,
	[datetime100] [datetime] SPARSE  NULL,
	[decimal1] [decimal](18, 2) SPARSE  NULL,
	[decimal2] [decimal](18, 2) SPARSE  NULL,
	[decimal3] [decimal](18, 2) SPARSE  NULL,
	[decimal4] [decimal](18, 2) SPARSE  NULL,
	[decimal5] [decimal](18, 2) SPARSE  NULL,
	[decimal6] [decimal](18, 2) SPARSE  NULL,
	[decimal7] [decimal](18, 2) SPARSE  NULL,
	[decimal8] [decimal](18, 2) SPARSE  NULL,
	[decimal9] [decimal](18, 2) SPARSE  NULL,
	[decimal10] [decimal](18, 2) SPARSE  NULL,
	[decimal11] [decimal](18, 2) SPARSE  NULL,
	[decimal12] [decimal](18, 2) SPARSE  NULL,
	[decimal13] [decimal](18, 2) SPARSE  NULL,
	[decimal14] [decimal](18, 2) SPARSE  NULL,
	[decimal15] [decimal](18, 2) SPARSE  NULL,
	[decimal16] [decimal](18, 2) SPARSE  NULL,
	[decimal17] [decimal](18, 2) SPARSE  NULL,
	[decimal18] [decimal](18, 2) SPARSE  NULL,
	[decimal19] [decimal](18, 2) SPARSE  NULL,
	[decimal20] [decimal](18, 2) SPARSE  NULL,
	[decimal21] [decimal](18, 2) SPARSE  NULL,
	[decimal22] [decimal](18, 2) SPARSE  NULL,
	[decimal23] [decimal](18, 2) SPARSE  NULL,
	[decimal24] [decimal](18, 2) SPARSE  NULL,
	[decimal25] [decimal](18, 2) SPARSE  NULL,
	[decimal26] [decimal](18, 2) SPARSE  NULL,
	[decimal27] [decimal](18, 2) SPARSE  NULL,
	[decimal28] [decimal](18, 2) SPARSE  NULL,
	[decimal29] [decimal](18, 2) SPARSE  NULL,
	[decimal30] [decimal](18, 2) SPARSE  NULL,
	[decimal31] [decimal](18, 2) SPARSE  NULL,
	[decimal32] [decimal](18, 2) SPARSE  NULL,
	[decimal33] [decimal](18, 2) SPARSE  NULL,
	[decimal34] [decimal](18, 2) SPARSE  NULL,
	[decimal35] [decimal](18, 2) SPARSE  NULL,
	[decimal36] [decimal](18, 2) SPARSE  NULL,
	[decimal37] [decimal](18, 2) SPARSE  NULL,
	[decimal38] [decimal](18, 2) SPARSE  NULL,
	[decimal39] [decimal](18, 2) SPARSE  NULL,
	[decimal40] [decimal](18, 2) SPARSE  NULL,
	[decimal41] [decimal](18, 2) SPARSE  NULL,
	[decimal42] [decimal](18, 2) SPARSE  NULL,
	[decimal43] [decimal](18, 2) SPARSE  NULL,
	[decimal44] [decimal](18, 2) SPARSE  NULL,
	[decimal45] [decimal](18, 2) SPARSE  NULL,
	[decimal46] [decimal](18, 2) SPARSE  NULL,
	[decimal47] [decimal](18, 2) SPARSE  NULL,
	[decimal48] [decimal](18, 2) SPARSE  NULL,
	[decimal49] [decimal](18, 2) SPARSE  NULL,
	[decimal50] [decimal](18, 2) SPARSE  NULL,
	[decimal51] [decimal](18, 2) SPARSE  NULL,
	[decimal52] [decimal](18, 2) SPARSE  NULL,
	[decimal53] [decimal](18, 2) SPARSE  NULL,
	[decimal54] [decimal](18, 2) SPARSE  NULL,
	[decimal55] [decimal](18, 2) SPARSE  NULL,
	[decimal56] [decimal](18, 2) SPARSE  NULL,
	[decimal57] [decimal](18, 2) SPARSE  NULL,
	[decimal58] [decimal](18, 2) SPARSE  NULL,
	[decimal59] [decimal](18, 2) SPARSE  NULL,
	[decimal60] [decimal](18, 2) SPARSE  NULL,
	[decimal61] [decimal](18, 2) SPARSE  NULL,
	[decimal62] [decimal](18, 2) SPARSE  NULL,
	[decimal63] [decimal](18, 2) SPARSE  NULL,
	[decimal64] [decimal](18, 2) SPARSE  NULL,
	[decimal65] [decimal](18, 2) SPARSE  NULL,
	[decimal66] [decimal](18, 2) SPARSE  NULL,
	[decimal67] [decimal](18, 2) SPARSE  NULL,
	[decimal68] [decimal](18, 2) SPARSE  NULL,
	[decimal69] [decimal](18, 2) SPARSE  NULL,
	[decimal70] [decimal](18, 2) SPARSE  NULL,
	[decimal71] [decimal](18, 2) SPARSE  NULL,
	[decimal72] [decimal](18, 2) SPARSE  NULL,
	[decimal73] [decimal](18, 2) SPARSE  NULL,
	[decimal74] [decimal](18, 2) SPARSE  NULL,
	[decimal75] [decimal](18, 2) SPARSE  NULL,
	[decimal76] [decimal](18, 2) SPARSE  NULL,
	[decimal77] [decimal](18, 2) SPARSE  NULL,
	[decimal78] [decimal](18, 2) SPARSE  NULL,
	[decimal79] [decimal](18, 2) SPARSE  NULL,
	[decimal80] [decimal](18, 2) SPARSE  NULL,
	[decimal81] [decimal](18, 2) SPARSE  NULL,
	[decimal82] [decimal](18, 2) SPARSE  NULL,
	[decimal83] [decimal](18, 2) SPARSE  NULL,
	[decimal84] [decimal](18, 2) SPARSE  NULL,
	[decimal85] [decimal](18, 2) SPARSE  NULL,
	[decimal86] [decimal](18, 2) SPARSE  NULL,
	[decimal87] [decimal](18, 2) SPARSE  NULL,
	[decimal88] [decimal](18, 2) SPARSE  NULL,
	[decimal89] [decimal](18, 2) SPARSE  NULL,
	[decimal90] [decimal](18, 2) SPARSE  NULL,
	[decimal91] [decimal](18, 2) SPARSE  NULL,
	[decimal92] [decimal](18, 2) SPARSE  NULL,
	[decimal93] [decimal](18, 2) SPARSE  NULL,
	[decimal94] [decimal](18, 2) SPARSE  NULL,
	[decimal95] [decimal](18, 2) SPARSE  NULL,
	[decimal96] [decimal](18, 2) SPARSE  NULL,
	[decimal97] [decimal](18, 2) SPARSE  NULL,
	[decimal98] [decimal](18, 2) SPARSE  NULL,
	[decimal99] [decimal](18, 2) SPARSE  NULL,
	[decimal100] [decimal](18, 2) SPARSE  NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CustomField] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CustomFieldLookUp]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CustomFieldLookUp](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[FieldIndex] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CustomFieldLookUp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[CustomFieldName]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[CustomFieldName](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[FieldIndex] [int] NULL,
	[DataType] [nvarchar](50) NULL,
	[Label] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CustomFieldName] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Designation]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Designation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Designation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Donation]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Donation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[PromotionDetailId] [int] NULL,
	[DonatedOn] [datetime] NOT NULL,
	[DonorNotes] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Donation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EmailCCRule]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EmailCCRule](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmailTypeId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EmailCCRule] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EmailTemplateContent]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EmailTemplateContent](
	[id] [int] NOT NULL,
	[EmailTemplateNameId] [int] NOT NULL,
	[EmailContent] [nvarchar](4000) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EmailTemplateContent] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EmailTemplateName]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EmailTemplateName](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EmailTemplateName] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EmailType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EmailType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EmailType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Equipment]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Equipment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EquipmentCount]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EquipmentCount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EquipmentId] [int] NOT NULL,
	[AvaialbleCount] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EquipmentCount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Event]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Event](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventUniqueName] [nvarchar](20) NOT NULL,
	[InternalOrExternal] [bit] NOT NULL,
	[AddressId] [int] NOT NULL,
	[OrganizerId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[TimeZoneId] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[StartTime] [time](2) NOT NULL,
	[EndTime] [time](2) NOT NULL,
	[RegStartDate] [datetime] NOT NULL,
	[RegStartTime] [time](2) NOT NULL,
	[RegEndDate] [datetime] NOT NULL,
	[RegEndTime] [time](2) NOT NULL,
	[MaxRegistrationsAllowed] [int] NOT NULL,
	[IsCPDEvent] [bit] NOT NULL,
	[IsChargableEvent] [bit] NOT NULL,
	[ShowMaxRegistrationsAllowed] [bit] NOT NULL,
	[AllowGuestRegistrations] [bit] NULL,
	[GuestLimitPerRegistrant] [int] NULL,
	[AllowCancellations] [bit] NOT NULL,
	[CancellationbeforeDays] [int] NULL,
	[Description] [nvarchar](2000) NULL,
	[AllowRegistration] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventAccess]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventAccess](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[AdminOnly] [bit] NULL,
	[Anyone] [bit] NULL,
	[RestrictedList] [bit] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventAccess] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventAttendance]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventAttendance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[AttendanceDate] [datetime] NOT NULL,
	[SignInTime] [time](7) NOT NULL,
	[SingOutTime] [time](7) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventAttendance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventCommunication]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventCommunication](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[Announcement1Sent] [bit] NULL,
	[Announcement1SentDate] [datetime] NULL,
	[Announcement1ScheduledDate] [datetime] NULL,
	[Announcement2Sent] [bit] NULL,
	[Announcement2SentDate] [datetime] NULL,
	[Announcement2ScheduledDate] [datetime] NULL,
	[Announcement3Sent] [bit] NULL,
	[Announcement3SentDate] [datetime] NULL,
	[Announcement3ScheduledDate] [datetime] NULL,
	[Reminder1Sent] [bit] NULL,
	[Reminder1SentDate] [datetime] NULL,
	[Reminder1ScheduledDate] [datetime] NULL,
	[Reminder2Sent] [bit] NULL,
	[Reminder2SentDate] [datetime] NULL,
	[Reminder2ScheduledDate] [datetime] NULL,
	[Reminder3Sent] [bit] NULL,
	[Reminder3SentDate] [datetime] NULL,
	[Reminder3ScheduledDate] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventCommunication] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventCost]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventCost](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[EventCostItemId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Amount] [decimal](10, 3) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventCost] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventCostItem]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventCostItem](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventCostItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventEquipment]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventEquipment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[EquipmentId] [int] NOT NULL,
	[RequiredCount] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventEquipmentRequirement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventMinute]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventMinute](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[Heading] [nvarchar](50) NULL,
	[SubHeading] [nvarchar](50) NULL,
	[Minute] [nvarchar](100) NOT NULL,
	[RaisedBy] [int] NOT NULL,
	[AssignedTo] [int] NOT NULL,
	[MinuteStatusId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventMinute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventMinuteStatus]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventMinuteStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventMinuteStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventPreRequisiteEvent]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventPreRequisiteEvent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[PreRequisiteEventId] [int] NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventPreRequisiteEvent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventRegistration]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventRegistration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[EventResponseTypeId] [int] NOT NULL,
	[Cancelled] [bit] NOT NULL,
	[Paid] [bit] NOT NULL,
	[NumberOfGuests] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventRegistration] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventResponseType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventResponseType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventResponseType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventRestrictionList]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventRestrictionList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[MemberLevelId] [int] NULL,
	[MemberTeamId] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventRestrictionList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventRole]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](500) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[EventRoleClientUserXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[EventRoleClientUserXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientUserId] [int] NOT NULL,
	[EventRoleId] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_EventRoleClientUserXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[FileType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[FileType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_FileType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Invoice]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceCode] [nvarchar](50) NOT NULL,
	[RelatedToId] [int] NULL,
	[RelatedRecordId] [int] NULL,
	[ClientId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[InvoiceStatusId] [int] NOT NULL,
	[PaymentGatewayId] [int] NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[InvoiceItem] [nvarchar](200) NOT NULL,
	[InvoiceAmount] [decimal](18, 2) NOT NULL,
	[CommentsForPayer] [nvarchar](1000) NULL,
	[InternalNotes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[InvoiceSetting]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[InvoiceSetting](
	[id] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[NextInvoiceNumber] [int] NOT NULL,
	[SendInvForPendingPayments] [bit] NOT NULL,
	[CopyInvToOrgContact] [bit] NOT NULL,
	[SendRecToPayer] [bit] NOT NULL,
	[CopyRecToOrgContact] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_InvoiceSetting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[InvoiceStatus]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[InvoiceStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_InvoiceStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[LandingPage]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[LandingPage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[MemberTypeId] [int] NOT NULL,
	[PageId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_LandingPage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MarketingGroup]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MarketingGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MarketingGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MarketingGroupXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MarketingGroupXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[MarketingGroupId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MarketingGroupXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MarketingProfile]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MarketingProfile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MarketingProfile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MarketingProfileXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MarketingProfileXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[MarketingProfileId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MarketingProfileMemberXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Member]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Member](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleId] [int] NOT NULL,
	[ClientId] [int] NOT NULL,
	[MemberBranchId] [int] NULL,
	[OrganizationId] [int] NULL,
	[ReferralTypeId] [int] NULL,
	[OrganizationStructureId] [int] NULL,
	[MemberCode] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EmailActivated] [bit] NOT NULL,
	[JoinDate] [datetime] NOT NULL,
	[NextRenewalDate] [datetime] NOT NULL,
	[MembershipConfirmed] [bit] NOT NULL,
	[ConfirmedDate] [datetime] NOT NULL,
	[MemberStatusId] [int] NULL,
	[MemberLevelId] [int] NULL,
	[MemberTeamId] [int] NULL,
	[MemberTypeId] [int] NOT NULL,
	[GenderId] [int] NOT NULL,
	[Photo] [image] NULL,
	[Notes] [nvarchar](1000) NULL,
	[IsBillingContact] [bit] NOT NULL,
	[IsBranchContact] [bit] NOT NULL,
	[TermAccepted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberAddress]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NULL,
	[OrganizationId] [int] NULL,
	[BranchId] [int] NULL,
	[AddressTypeId] [int] NOT NULL,
	[AddressLine1] [nvarchar](100) NULL,
	[AddressLine2] [nvarchar](100) NULL,
	[BuidlingName] [nvarchar](100) NULL,
	[ComplexName] [nvarchar](100) NULL,
	[StreetName] [nvarchar](100) NULL,
	[CityId] [int] NULL,
	[StateId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
	[PostalCode] [nvarchar](50) NULL,
	[PrimaryContactNo] [nvarchar](50) NULL,
	[SecondaryContactNo] [nvarchar](50) NULL,
	[PrimaryEmail] [nvarchar](50) NULL,
	[SecondaryEmail] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](50) NULL,
	[GPSCoordinates] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberAffliationXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberAffliationXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NULL,
	[AffliationId] [int] NULL,
	[MemberSpecificAffliationName] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[AffliatedFrom] [datetime] NOT NULL,
	[AffliatedTill] [datetime] NOT NULL,
	[isActiveAffliatedNow] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberAffliationXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberBankingDetail]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberBankingDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[AccountTypeId] [int] NOT NULL,
	[BankName] [nvarchar](50) NULL,
	[BranchName] [nvarchar](100) NOT NULL,
	[AccountNumber] [nvarchar](50) NOT NULL,
	[RoutingCode] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberBankingDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberBranch]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberBranch](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrganizationId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberBranch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberCategory]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberCodeGenerator]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberCodeGenerator](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Prefix] [nvarchar](50) NULL,
	[LastNumber] [int] NULL,
	[Suffix] [nvarchar](50) NULL,
	[CodeGenerationRule] [nvarchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberCodeGenerator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberCommunicationPreference]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberCommunicationPreference](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[CommunicationTypeId] [int] NOT NULL,
	[PreferredTimeFrom] [time](7) NULL,
	[PreferredTimeTo] [time](7) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberCommunicationPreference] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberFile]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberFile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[FileTypeId] [int] NOT NULL,
	[FileContent] [varbinary](max) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberLevel]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberLevel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberLevel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberPlanHistory]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberPlanHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NULL,
	[OrganizationId] [int] NULL,
	[MemberPlanDetailId] [int] NOT NULL,
	[IsCurrentPlan] [bit] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Notes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MembershipHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberQualificationXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberQualificationXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[QualificationId] [int] NULL,
	[MemberSpecificQualificationName] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[QualificationFrom] [datetime] NOT NULL,
	[QualificationTill] [datetime] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberQualificationXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberStatus]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberTeam]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberTeam](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberTeam] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[MemberType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[MemberType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[MemberCategoryId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Organization]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Organization](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Acronym] [nvarchar](50) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[WebSite] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[OrganizationStructure]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[OrganizationStructure](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[LevelOfMember] [int] NOT NULL,
	[MaximumNumber] [int] NOT NULL,
	[MaximumTimeInYears] [int] NULL,
	[ShowMaximumTimeInYears] [bit] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_OrganizationStructure] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Page]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Page](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Page] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PaymentGateway]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PaymentGateway](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[ClientIdForMerchant] [nvarchar](100) NULL,
	[ClientPasswordForMerchant] [nvarchar](100) NULL,
	[ClientAPICodeForMerchant] [nvarchar](100) NULL,
	[MerchantNumber] [nvarchar](100) NULL,
	[MerchantName] [nvarchar](100) NULL,
	[MerchantLocation] [nvarchar](100) NULL,
	[CommisionPercentage] [decimal](6, 3) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PaymentGateway] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PaymentSetting]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PaymentSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NULL,
	[CurrencyId] [int] NULL,
	[GeneralInstructions] [nvarchar](2000) NULL,
	[EventsInstructions] [nvarchar](2000) NULL,
	[ApplicationInstructions] [nvarchar](2000) NULL,
	[ClientPayPalConnectionModeId] [int] NULL,
	[PayPalAccountId] [nvarchar](200) NULL,
	[PayPalPDTIdentityToken] [nvarchar](200) NULL,
	[DefaultCountryId] [int] NULL,
	[PayPalAPIUserName] [nvarchar](50) NULL,
	[PayPalAPIPassword] [nvarchar](50) NULL,
	[PayPalAPISignature] [nvarchar](200) NULL,
	[PayPalPreferredPaymentGatewayId] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PaymentSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PaymentSettingAllowedCard]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PaymentSettingAllowedCard](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PaymentSettingId] [int] NOT NULL,
	[PaymentCardId] [int] NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PaymentSettingAllowedCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PayPalConnectionMode]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PayPalConnectionMode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PayPalConnectionMode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PayPalPreferredPaymentGateway]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PayPalPreferredPaymentGateway](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PayPalPreferredPaymentGateway] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PlanCanChangeToXref]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PlanCanChangeToXref](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FromPlanMasterId] [int] NOT NULL,
	[ToPlanMasterId] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberPlanCanChangeTo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PlanDetail]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PlanDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlanMasterId] [int] NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[PlanFrequencyId] [int] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PlanDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PlanFrequency]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PlanFrequency](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PlanFrequency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PlanMaster]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PlanMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[MemberCategoryId] [int] NOT NULL,
	[IsLimited] [bit] NULL,
	[LimitToMemberCount] [int] NULL,
	[ApplyTaxSettings] [bit] NOT NULL,
	[PaymentMethodId] [int] NOT NULL,
	[CanPublicApply] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PlanMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PromotionDetail]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PromotionDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionMasterId] [int] NOT NULL,
	[MemberTypeId] [int] NULL,
	[MemberLevelId] [int] NULL,
	[DiscountPercentage] [decimal](9, 3) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PromotionDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PromotionMaster]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PromotionMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Description] [nvarchar](1000) NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[BenefitStartDate] [datetime] NOT NULL,
	[BenefitEndDate] [datetime] NOT NULL,
	[IsActive] [datetime] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PromotionMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PromotionResponse]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PromotionResponse](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PromotionMasterId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[PromotionResponseType] [int] NOT NULL,
	[ResponseDate] [datetime] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PromotionResponse] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[PromotionResponseType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[PromotionResponseType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PromotionResponseType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Qualification]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Qualification](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Qualification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[ReferralType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[ReferralType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ReferralType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Refund]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Refund](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NULL,
	[ClientId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[PaymentGatewayId] [int] NOT NULL,
	[RelatedToId] [int] NULL,
	[RelatedRecordId] [int] NULL,
	[RefundDate] [datetime] NOT NULL,
	[RefundItem] [nvarchar](200) NOT NULL,
	[RefundAmount] [decimal](18, 2) NOT NULL,
	[CommentsForPayer] [nvarchar](1000) NULL,
	[InternalNotes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Refund] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[RelatedTo]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[RelatedTo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Description] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_RelatedTo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Tag]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Tag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelatedToId] [int] NOT NULL,
	[RelatedRecordId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Tax]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Tax](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TaxCode] [nvarchar](50) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Rate] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Tax] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[TaxPolicy]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[TaxPolicy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_TaxPolicy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[TaxScope]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[TaxScope](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[TaxScopeCode] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_TaxScope] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Client].[Theme]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Client].[Theme](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[ThemeNumber] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Theme] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[AddressTypeDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[AddressTypeDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_AddressTypeDefault] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[City]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateId] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[Country]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](5) NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[Currency]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[Currency](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](3) NOT NULL,
	[Symbol] [nvarchar](10) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[DateSetting]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[DateSetting](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_DateSetting] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[FileTypeDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[FileTypeDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CommonFileType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[Gender]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[MemberStatusDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[MemberStatusDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_MemberStatusDefault] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[PaymentCardDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[PaymentCardDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CommonPaymentCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[PaymentGatewayDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[PaymentGatewayDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[MerchantNumber] [nvarchar](100) NULL,
	[MerchantName] [nvarchar](100) NULL,
	[MerchantLocation] [nvarchar](100) NULL,
	[CommisionPercentage] [decimal](6, 3) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_PaymentGatewayDefault] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[QualificationDefault]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[QualificationDefault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_QualificationDefault] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[State]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryId] [int] NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[TimeFormat]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[TimeFormat](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_TimeFormat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[TimeZone]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[TimeZone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_TimeZone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Common].[Title]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Common].[Title](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](200) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Title] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[ClientPlanHistory]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[ClientPlanHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClientId] [int] NOT NULL,
	[BillingUserId] [int] NOT NULL,
	[CorePlanDetailId] [int] NOT NULL,
	[IsCurrentPlan] [bit] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Notes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ClientPlanHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreAccountType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreAccountType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreAccountType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreAddress]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CoreUserId] [int] NULL,
	[CoreAddressTypeId] [int] NOT NULL,
	[AddressLine1] [nvarchar](100) NULL,
	[AddressLine2] [nvarchar](100) NULL,
	[BuidlingName] [nvarchar](100) NULL,
	[ComplexName] [nvarchar](100) NULL,
	[StreetName] [nvarchar](100) NULL,
	[CityId] [int] NULL,
	[StateId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
	[PostalCode] [nvarchar](50) NULL,
	[PrimaryContactNo] [nvarchar](50) NULL,
	[SecondaryContactNo] [nvarchar](50) NULL,
	[PrimaryEmail] [nvarchar](50) NULL,
	[SecondaryEmail] [nvarchar](50) NULL,
	[FaxNumber] [nvarchar](50) NULL,
	[GPSCoordinates] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreAddressType]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreAddressType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreAddressType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreBankingDetail]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreBankingDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountTypeId] [int] NULL,
	[BankName] [nvarchar](50) NULL,
	[BranchName] [nvarchar](100) NOT NULL,
	[AccountNumber] [nvarchar](50) NOT NULL,
	[RoutingCode] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreBankingDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreBilling]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreBilling](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NULL,
	[ClientId] [int] NOT NULL,
	[CoreRelatedToId] [int] NOT NULL,
	[CoreRelatedRecordId] [int] NOT NULL,
	[CorePaymentGatewayId] [int] NOT NULL,
	[PaymentDueDate] [datetime] NULL,
	[PaidDate] [datetime] NULL,
	[PaymentItem] [nvarchar](200) NOT NULL,
	[PaymentAmount] [decimal](18, 3) NOT NULL,
	[PaidAmount] [decimal](18, 3) NULL,
	[CommentsForPayer] [nvarchar](1000) NULL,
	[InternalNotes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreBilling] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreInvoice]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreInvoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceCode] [nvarchar](50) NOT NULL,
	[CoreRelatedToId] [int] NULL,
	[RelatedRecordId] [int] NULL,
	[ClientId] [int] NOT NULL,
	[CoreInvoiceStatusId] [int] NOT NULL,
	[CorePaymentGatewayId] [int] NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[InvoiceItem] [nvarchar](200) NOT NULL,
	[InvoiceAmount] [decimal](18, 2) NOT NULL,
	[CommentsForPayer] [nvarchar](1000) NULL,
	[InternalNotes] [nvarchar](1000) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreInvoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreInvoiceStatus]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreInvoiceStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreInvoiceStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CorePaymentGateway]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CorePaymentGateway](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[IdForMerchant] [nvarchar](100) NULL,
	[PasswordForMerchant] [nvarchar](100) NULL,
	[APICodeForMerchant] [nvarchar](100) NULL,
	[MerchantNumber] [nvarchar](100) NULL,
	[MerchantName] [nvarchar](100) NULL,
	[MerchantLocation] [nvarchar](100) NULL,
	[CommisionPercentage] [decimal](6, 3) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CorePaymentGateway] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CorePermission]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CorePermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CorePermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CorePlanDetail]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CorePlanDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CorePlanMasterId] [int] NOT NULL,
	[CurrencyId] [int] NOT NULL,
	[CorePlanFrequencyId] [int] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_CorePlanDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CorePlanFrequency]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CorePlanFrequency](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_CorePlanFrequency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CorePlanMaster]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CorePlanMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[NumberOfContacts] [int] NOT NULL,
	[MaximumStorage] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_CorePlanMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreRelatedTo]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreRelatedTo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NULL,
	[Description] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreRelatedTo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreRole]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreRolePermissionXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreRolePermissionXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CoreRoleId] [int] NOT NULL,
	[CorePermissionid] [int] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreRolePermissionXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreUser]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TitleId] [int] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[EmailActivated] [bit] NOT NULL,
	[Notes] [nvarchar](1000) NOT NULL,
	[GenderId] [int] NOT NULL,
	[IsInternalUser] [bit] NOT NULL,
	[TermsAccepted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Core].[CoreUserRoleXRef]    Script Date: 6/30/2020 8:25:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Core].[CoreUserRoleXRef](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CoreUserId] [int] NOT NULL,
	[CoreRoleId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[ModifiedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_CoreUserRoleXRef] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [Client].[Affliation]  WITH CHECK ADD  CONSTRAINT [FK_Affliation_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Affliation] CHECK CONSTRAINT [FK_Affliation_Client]
GO
ALTER TABLE [Client].[BillingCommunication]  WITH CHECK ADD  CONSTRAINT [FK_BillingCommunication_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[BillingCommunication] CHECK CONSTRAINT [FK_BillingCommunication_Client]
GO
ALTER TABLE [Client].[BillingCommunication]  WITH CHECK ADD  CONSTRAINT [FK_PaymentCommunication_Payment] FOREIGN KEY([Id])
REFERENCES [Client].[ClientBilling] ([Id])
GO
ALTER TABLE [Client].[BillingCommunication] CHECK CONSTRAINT [FK_PaymentCommunication_Payment]
GO
ALTER TABLE [Client].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_ClientType] FOREIGN KEY([ClientTypeId])
REFERENCES [Client].[ClientType] ([Id])
GO
ALTER TABLE [Client].[Client] CHECK CONSTRAINT [FK_Client_ClientType]
GO
ALTER TABLE [Client].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [Common].[Currency] ([Id])
GO
ALTER TABLE [Client].[Client] CHECK CONSTRAINT [FK_Client_Currency]
GO
ALTER TABLE [Client].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_DateSetting] FOREIGN KEY([DateSettingId])
REFERENCES [Common].[DateSetting] ([Id])
GO
ALTER TABLE [Client].[Client] CHECK CONSTRAINT [FK_Client_DateSetting]
GO
ALTER TABLE [Client].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_TimeFormat] FOREIGN KEY([TimeFormatId])
REFERENCES [Common].[TimeFormat] ([Id])
GO
ALTER TABLE [Client].[Client] CHECK CONSTRAINT [FK_Client_TimeFormat]
GO
ALTER TABLE [Client].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_TimeZone] FOREIGN KEY([TimeZoneId])
REFERENCES [Common].[TimeZone] ([Id])
GO
ALTER TABLE [Client].[Client] CHECK CONSTRAINT [FK_Client_TimeZone]
GO
ALTER TABLE [Client].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [FK_Address_AddressType] FOREIGN KEY([AddressTypeId])
REFERENCES [Client].[ClientAddressType] ([Id])
GO
ALTER TABLE [Client].[ClientAddress] CHECK CONSTRAINT [FK_Address_AddressType]
GO
ALTER TABLE [Client].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [FK_Address_City] FOREIGN KEY([CityId])
REFERENCES [Common].[City] ([Id])
GO
ALTER TABLE [Client].[ClientAddress] CHECK CONSTRAINT [FK_Address_City]
GO
ALTER TABLE [Client].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [FK_Address_Country] FOREIGN KEY([CountryId])
REFERENCES [Common].[Country] ([Id])
GO
ALTER TABLE [Client].[ClientAddress] CHECK CONSTRAINT [FK_Address_Country]
GO
ALTER TABLE [Client].[ClientAddress]  WITH CHECK ADD  CONSTRAINT [FK_Address_State] FOREIGN KEY([StateId])
REFERENCES [Common].[State] ([Id])
GO
ALTER TABLE [Client].[ClientAddress] CHECK CONSTRAINT [FK_Address_State]
GO
ALTER TABLE [Client].[ClientBankingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BankingDetail_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[ClientBankingDetail] CHECK CONSTRAINT [FK_BankingDetail_Client]
GO
ALTER TABLE [Client].[ClientBankingDetail]  WITH CHECK ADD  CONSTRAINT [FK_ClientBankingDetail_ClientAccountType] FOREIGN KEY([AccountTypeId])
REFERENCES [Client].[ClientAccountType] ([Id])
GO
ALTER TABLE [Client].[ClientBankingDetail] CHECK CONSTRAINT [FK_ClientBankingDetail_ClientAccountType]
GO
ALTER TABLE [Client].[ClientBilling]  WITH CHECK ADD  CONSTRAINT [FK_ClientBilling_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[ClientBilling] CHECK CONSTRAINT [FK_ClientBilling_RelatedTo]
GO
ALTER TABLE [Client].[ClientBilling]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[ClientBilling] CHECK CONSTRAINT [FK_Payment_Client]
GO
ALTER TABLE [Client].[ClientBilling]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Invoice] FOREIGN KEY([InvoiceId])
REFERENCES [Client].[Invoice] ([Id])
GO
ALTER TABLE [Client].[ClientBilling] CHECK CONSTRAINT [FK_Payment_Invoice]
GO
ALTER TABLE [Client].[ClientBilling]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[ClientBilling] CHECK CONSTRAINT [FK_Payment_Member]
GO
ALTER TABLE [Client].[ClientBilling]  WITH CHECK ADD  CONSTRAINT [FK_Payment_PaymentGateway] FOREIGN KEY([PaymentGatewayId])
REFERENCES [Client].[PaymentGateway] ([Id])
GO
ALTER TABLE [Client].[ClientBilling] CHECK CONSTRAINT [FK_Payment_PaymentGateway]
GO
ALTER TABLE [Client].[ClientPermission]  WITH CHECK ADD  CONSTRAINT [FK_Permission_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[ClientPermission] CHECK CONSTRAINT [FK_Permission_Client]
GO
ALTER TABLE [Client].[ClientRole]  WITH CHECK ADD  CONSTRAINT [FK_Role_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[ClientRole] CHECK CONSTRAINT [FK_Role_Client]
GO
ALTER TABLE [Client].[ClientRolePermissionXRef]  WITH CHECK ADD  CONSTRAINT [FK_RolePermissionXRef_Permission] FOREIGN KEY([Permissionid])
REFERENCES [Client].[ClientPermission] ([Id])
GO
ALTER TABLE [Client].[ClientRolePermissionXRef] CHECK CONSTRAINT [FK_RolePermissionXRef_Permission]
GO
ALTER TABLE [Client].[ClientRolePermissionXRef]  WITH CHECK ADD  CONSTRAINT [FK_RolePermissionXRef_Role] FOREIGN KEY([RoleId])
REFERENCES [Client].[ClientRole] ([Id])
GO
ALTER TABLE [Client].[ClientRolePermissionXRef] CHECK CONSTRAINT [FK_RolePermissionXRef_Role]
GO
ALTER TABLE [Client].[ClientUser]  WITH CHECK ADD  CONSTRAINT [FK_ClientUser_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[ClientUser] CHECK CONSTRAINT [FK_ClientUser_Client]
GO
ALTER TABLE [Client].[ClientUser]  WITH CHECK ADD  CONSTRAINT [FK_ClientUser_Designation] FOREIGN KEY([DesignationId])
REFERENCES [Client].[Designation] ([Id])
GO
ALTER TABLE [Client].[ClientUser] CHECK CONSTRAINT [FK_ClientUser_Designation]
GO
ALTER TABLE [Client].[ClientUser]  WITH CHECK ADD  CONSTRAINT [FK_ClientUser_Gender] FOREIGN KEY([GenderId])
REFERENCES [Common].[Gender] ([Id])
GO
ALTER TABLE [Client].[ClientUser] CHECK CONSTRAINT [FK_ClientUser_Gender]
GO
ALTER TABLE [Client].[ClientUser]  WITH CHECK ADD  CONSTRAINT [FK_ClientUser_ReferralType] FOREIGN KEY([ReferralTypeId])
REFERENCES [Client].[ReferralType] ([Id])
GO
ALTER TABLE [Client].[ClientUser] CHECK CONSTRAINT [FK_ClientUser_ReferralType]
GO
ALTER TABLE [Client].[ClientUser]  WITH CHECK ADD  CONSTRAINT [FK_ClientUser_Role] FOREIGN KEY([RoleId])
REFERENCES [Client].[ClientRole] ([Id])
GO
ALTER TABLE [Client].[ClientUser] CHECK CONSTRAINT [FK_ClientUser_Role]
GO
ALTER TABLE [Client].[ClientUser]  WITH CHECK ADD  CONSTRAINT [FK_ClientUser_Title] FOREIGN KEY([TitleId])
REFERENCES [Common].[Title] ([Id])
GO
ALTER TABLE [Client].[ClientUser] CHECK CONSTRAINT [FK_ClientUser_Title]
GO
ALTER TABLE [Client].[ClientUserRoleXRef]  WITH CHECK ADD  CONSTRAINT [FK_ClientUserRole_ClientUser] FOREIGN KEY([ClientUserid])
REFERENCES [Client].[ClientUser] ([Id])
GO
ALTER TABLE [Client].[ClientUserRoleXRef] CHECK CONSTRAINT [FK_ClientUserRole_ClientUser]
GO
ALTER TABLE [Client].[ClientUserRoleXRef]  WITH CHECK ADD  CONSTRAINT [FK_ClientUserRole_Role] FOREIGN KEY([ClientRoleId])
REFERENCES [Client].[ClientRole] ([Id])
GO
ALTER TABLE [Client].[ClientUserRoleXRef] CHECK CONSTRAINT [FK_ClientUserRole_Role]
GO
ALTER TABLE [Client].[CommunicationPreference]  WITH CHECK ADD  CONSTRAINT [FK_CommunicationPreference_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[CommunicationPreference] CHECK CONSTRAINT [FK_CommunicationPreference_Client]
GO
ALTER TABLE [Client].[CommunicationPreference]  WITH CHECK ADD  CONSTRAINT [FK_CommunicationPreference_CommunicationType] FOREIGN KEY([CommunicationTypeId])
REFERENCES [Client].[CommunicationType] ([Id])
GO
ALTER TABLE [Client].[CommunicationPreference] CHECK CONSTRAINT [FK_CommunicationPreference_CommunicationType]
GO
ALTER TABLE [Client].[CommunicationType]  WITH CHECK ADD  CONSTRAINT [FK_CommunicationType_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[CommunicationType] CHECK CONSTRAINT [FK_CommunicationType_Client]
GO
ALTER TABLE [Client].[CorrespondenceType]  WITH CHECK ADD  CONSTRAINT [FK_CorrespondenceType_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[CorrespondenceType] CHECK CONSTRAINT [FK_CorrespondenceType_Client]
GO
ALTER TABLE [Client].[CPD]  WITH CHECK ADD  CONSTRAINT [FK_CPD_ClientUser] FOREIGN KEY([CPDAwardedById])
REFERENCES [Client].[ClientUser] ([Id])
GO
ALTER TABLE [Client].[CPD] CHECK CONSTRAINT [FK_CPD_ClientUser]
GO
ALTER TABLE [Client].[CPD]  WITH CHECK ADD  CONSTRAINT [FK_CPD_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[CPD] CHECK CONSTRAINT [FK_CPD_Member]
GO
ALTER TABLE [Client].[CPD]  WITH CHECK ADD  CONSTRAINT [FK_CPD_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[CPD] CHECK CONSTRAINT [FK_CPD_RelatedTo]
GO
ALTER TABLE [Client].[CPDMemberCategorySetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberCategorySetUp_MemberCategory] FOREIGN KEY([MemberCategoryId])
REFERENCES [Client].[MemberCategory] ([Id])
GO
ALTER TABLE [Client].[CPDMemberCategorySetUp] CHECK CONSTRAINT [FK_CPDMemberCategorySetUp_MemberCategory]
GO
ALTER TABLE [Client].[CPDMemberCategorySetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberCategorySetUp_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[CPDMemberCategorySetUp] CHECK CONSTRAINT [FK_CPDMemberCategorySetUp_RelatedTo]
GO
ALTER TABLE [Client].[CPDMemberLevelSetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberLevelSetUp_MemberLevel] FOREIGN KEY([MemberLevelId])
REFERENCES [Client].[MemberLevel] ([Id])
GO
ALTER TABLE [Client].[CPDMemberLevelSetUp] CHECK CONSTRAINT [FK_CPDMemberLevelSetUp_MemberLevel]
GO
ALTER TABLE [Client].[CPDMemberLevelSetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberLevelSetUp_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[CPDMemberLevelSetUp] CHECK CONSTRAINT [FK_CPDMemberLevelSetUp_RelatedTo]
GO
ALTER TABLE [Client].[CPDMemberTeamSetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberTeamSetUp_MemberTeam] FOREIGN KEY([MemberTeamId])
REFERENCES [Client].[MemberTeam] ([Id])
GO
ALTER TABLE [Client].[CPDMemberTeamSetUp] CHECK CONSTRAINT [FK_CPDMemberTeamSetUp_MemberTeam]
GO
ALTER TABLE [Client].[CPDMemberTeamSetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberTeamSetUp_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[CPDMemberTeamSetUp] CHECK CONSTRAINT [FK_CPDMemberTeamSetUp_RelatedTo]
GO
ALTER TABLE [Client].[CPDMemberTypeSetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberTypeSetUp_MemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [Client].[MemberType] ([Id])
GO
ALTER TABLE [Client].[CPDMemberTypeSetUp] CHECK CONSTRAINT [FK_CPDMemberTypeSetUp_MemberType]
GO
ALTER TABLE [Client].[CPDMemberTypeSetUp]  WITH CHECK ADD  CONSTRAINT [FK_CPDMemberTypeSetUp_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[CPDMemberTypeSetUp] CHECK CONSTRAINT [FK_CPDMemberTypeSetUp_RelatedTo]
GO
ALTER TABLE [Client].[CustomField]  WITH CHECK ADD  CONSTRAINT [FK_CustomField_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[CustomField] CHECK CONSTRAINT [FK_CustomField_Client]
GO
ALTER TABLE [Client].[CustomFieldLookUp]  WITH CHECK ADD  CONSTRAINT [FK_CustomFieldLookUp_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[CustomFieldLookUp] CHECK CONSTRAINT [FK_CustomFieldLookUp_Client]
GO
ALTER TABLE [Client].[CustomFieldName]  WITH CHECK ADD  CONSTRAINT [FK_CustomFieldName_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[CustomFieldName] CHECK CONSTRAINT [FK_CustomFieldName_Client]
GO
ALTER TABLE [Client].[Donation]  WITH CHECK ADD  CONSTRAINT [FK_Donation_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Donation] CHECK CONSTRAINT [FK_Donation_Client]
GO
ALTER TABLE [Client].[Donation]  WITH CHECK ADD  CONSTRAINT [FK_Donation_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[Donation] CHECK CONSTRAINT [FK_Donation_Member]
GO
ALTER TABLE [Client].[Donation]  WITH CHECK ADD  CONSTRAINT [FK_Donation_PromotionDetail] FOREIGN KEY([PromotionDetailId])
REFERENCES [Client].[PromotionDetail] ([Id])
GO
ALTER TABLE [Client].[Donation] CHECK CONSTRAINT [FK_Donation_PromotionDetail]
GO
ALTER TABLE [Client].[EmailCCRule]  WITH CHECK ADD  CONSTRAINT [FK_EmailCCRule_EmailType] FOREIGN KEY([EmailTypeId])
REFERENCES [Client].[EmailType] ([id])
GO
ALTER TABLE [Client].[EmailCCRule] CHECK CONSTRAINT [FK_EmailCCRule_EmailType]
GO
ALTER TABLE [Client].[EmailCCRule]  WITH CHECK ADD  CONSTRAINT [FK_EmailCCRule_Role] FOREIGN KEY([RoleId])
REFERENCES [Client].[ClientRole] ([Id])
GO
ALTER TABLE [Client].[EmailCCRule] CHECK CONSTRAINT [FK_EmailCCRule_Role]
GO
ALTER TABLE [Client].[EmailTemplateContent]  WITH CHECK ADD  CONSTRAINT [FK_EmailTemplateContent_EmailTemplateName] FOREIGN KEY([EmailTemplateNameId])
REFERENCES [Client].[EmailTemplateName] ([id])
GO
ALTER TABLE [Client].[EmailTemplateContent] CHECK CONSTRAINT [FK_EmailTemplateContent_EmailTemplateName]
GO
ALTER TABLE [Client].[EmailTemplateName]  WITH CHECK ADD  CONSTRAINT [FK_EmailTemplateName_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[EmailTemplateName] CHECK CONSTRAINT [FK_EmailTemplateName_Client]
GO
ALTER TABLE [Client].[EmailType]  WITH CHECK ADD  CONSTRAINT [FK_EmailType_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[EmailType] CHECK CONSTRAINT [FK_EmailType_Client]
GO
ALTER TABLE [Client].[Equipment]  WITH CHECK ADD  CONSTRAINT [FK_Equipment_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Equipment] CHECK CONSTRAINT [FK_Equipment_Client]
GO
ALTER TABLE [Client].[EquipmentCount]  WITH CHECK ADD  CONSTRAINT [FK_EquipmentCount_Equipment] FOREIGN KEY([EquipmentId])
REFERENCES [Client].[Equipment] ([Id])
GO
ALTER TABLE [Client].[EquipmentCount] CHECK CONSTRAINT [FK_EquipmentCount_Equipment]
GO
ALTER TABLE [Client].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Event] CHECK CONSTRAINT [FK_Event_Client]
GO
ALTER TABLE [Client].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_ClientAddress] FOREIGN KEY([AddressId])
REFERENCES [Client].[ClientAddress] ([Id])
GO
ALTER TABLE [Client].[Event] CHECK CONSTRAINT [FK_Event_ClientAddress]
GO
ALTER TABLE [Client].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_ClientUser] FOREIGN KEY([OrganizerId])
REFERENCES [Client].[ClientUser] ([Id])
GO
ALTER TABLE [Client].[Event] CHECK CONSTRAINT [FK_Event_ClientUser]
GO
ALTER TABLE [Client].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_TimeZone] FOREIGN KEY([TimeZoneId])
REFERENCES [Common].[TimeZone] ([Id])
GO
ALTER TABLE [Client].[Event] CHECK CONSTRAINT [FK_Event_TimeZone]
GO
ALTER TABLE [Client].[EventAccess]  WITH CHECK ADD  CONSTRAINT [FK_EventAccess_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventAccess] CHECK CONSTRAINT [FK_EventAccess_Event]
GO
ALTER TABLE [Client].[EventAttendance]  WITH CHECK ADD  CONSTRAINT [FK_EventAttendance_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventAttendance] CHECK CONSTRAINT [FK_EventAttendance_Event]
GO
ALTER TABLE [Client].[EventAttendance]  WITH CHECK ADD  CONSTRAINT [FK_EventAttendance_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[EventAttendance] CHECK CONSTRAINT [FK_EventAttendance_Member]
GO
ALTER TABLE [Client].[EventCommunication]  WITH CHECK ADD  CONSTRAINT [FK_EventCommunication_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventCommunication] CHECK CONSTRAINT [FK_EventCommunication_Event]
GO
ALTER TABLE [Client].[EventEquipment]  WITH CHECK ADD  CONSTRAINT [FK_EventEquipmentRequirement_Equipment] FOREIGN KEY([EquipmentId])
REFERENCES [Client].[Equipment] ([Id])
GO
ALTER TABLE [Client].[EventEquipment] CHECK CONSTRAINT [FK_EventEquipmentRequirement_Equipment]
GO
ALTER TABLE [Client].[EventEquipment]  WITH CHECK ADD  CONSTRAINT [FK_EventEquipmentRequirement_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventEquipment] CHECK CONSTRAINT [FK_EventEquipmentRequirement_Event]
GO
ALTER TABLE [Client].[EventMinute]  WITH CHECK ADD  CONSTRAINT [FK_EventMinute_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventMinute] CHECK CONSTRAINT [FK_EventMinute_Event]
GO
ALTER TABLE [Client].[EventMinute]  WITH CHECK ADD  CONSTRAINT [FK_EventMinute_EventMinuteStatus] FOREIGN KEY([MinuteStatusId])
REFERENCES [Client].[EventMinuteStatus] ([Id])
GO
ALTER TABLE [Client].[EventMinute] CHECK CONSTRAINT [FK_EventMinute_EventMinuteStatus]
GO
ALTER TABLE [Client].[EventPreRequisiteEvent]  WITH CHECK ADD  CONSTRAINT [FK_EventPreRequisiteEvent_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventPreRequisiteEvent] CHECK CONSTRAINT [FK_EventPreRequisiteEvent_Event]
GO
ALTER TABLE [Client].[EventPreRequisiteEvent]  WITH CHECK ADD  CONSTRAINT [FK_EventPreRequisiteEvent_PreRequisiteEventId_Event] FOREIGN KEY([PreRequisiteEventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventPreRequisiteEvent] CHECK CONSTRAINT [FK_EventPreRequisiteEvent_PreRequisiteEventId_Event]
GO
ALTER TABLE [Client].[EventRegistration]  WITH CHECK ADD  CONSTRAINT [FK_EventRegistration_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventRegistration] CHECK CONSTRAINT [FK_EventRegistration_Event]
GO
ALTER TABLE [Client].[EventRegistration]  WITH CHECK ADD  CONSTRAINT [FK_EventRegistration_EventResponseType] FOREIGN KEY([EventResponseTypeId])
REFERENCES [Client].[EventResponseType] ([Id])
GO
ALTER TABLE [Client].[EventRegistration] CHECK CONSTRAINT [FK_EventRegistration_EventResponseType]
GO
ALTER TABLE [Client].[EventRegistration]  WITH CHECK ADD  CONSTRAINT [FK_EventRegistration_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[EventRegistration] CHECK CONSTRAINT [FK_EventRegistration_Member]
GO
ALTER TABLE [Client].[EventRestrictionList]  WITH CHECK ADD  CONSTRAINT [FK_EventRestrictionList_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventRestrictionList] CHECK CONSTRAINT [FK_EventRestrictionList_Event]
GO
ALTER TABLE [Client].[EventRestrictionList]  WITH CHECK ADD  CONSTRAINT [FK_EventRestrictionList_MemberLevel] FOREIGN KEY([MemberLevelId])
REFERENCES [Client].[MemberLevel] ([Id])
GO
ALTER TABLE [Client].[EventRestrictionList] CHECK CONSTRAINT [FK_EventRestrictionList_MemberLevel]
GO
ALTER TABLE [Client].[EventRestrictionList]  WITH CHECK ADD  CONSTRAINT [FK_EventRestrictionList_MemberTeam] FOREIGN KEY([MemberTeamId])
REFERENCES [Client].[MemberTeam] ([Id])
GO
ALTER TABLE [Client].[EventRestrictionList] CHECK CONSTRAINT [FK_EventRestrictionList_MemberTeam]
GO
ALTER TABLE [Client].[EventRole]  WITH CHECK ADD  CONSTRAINT [FK_EventRole_Event] FOREIGN KEY([EventId])
REFERENCES [Client].[Event] ([Id])
GO
ALTER TABLE [Client].[EventRole] CHECK CONSTRAINT [FK_EventRole_Event]
GO
ALTER TABLE [Client].[EventRoleClientUserXRef]  WITH CHECK ADD  CONSTRAINT [FK_EventRoleClientUserXRef_ClientUser] FOREIGN KEY([ClientUserId])
REFERENCES [Client].[ClientUser] ([Id])
GO
ALTER TABLE [Client].[EventRoleClientUserXRef] CHECK CONSTRAINT [FK_EventRoleClientUserXRef_ClientUser]
GO
ALTER TABLE [Client].[EventRoleClientUserXRef]  WITH CHECK ADD  CONSTRAINT [FK_EventRoleClientUserXRef_EventRole] FOREIGN KEY([EventRoleId])
REFERENCES [Client].[EventRole] ([Id])
GO
ALTER TABLE [Client].[EventRoleClientUserXRef] CHECK CONSTRAINT [FK_EventRoleClientUserXRef_EventRole]
GO
ALTER TABLE [Client].[FileType]  WITH CHECK ADD  CONSTRAINT [FK_FileType_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[FileType] CHECK CONSTRAINT [FK_FileType_Client]
GO
ALTER TABLE [Client].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Invoice] CHECK CONSTRAINT [FK_Invoice_Client]
GO
ALTER TABLE [Client].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_InvoiceStatus] FOREIGN KEY([InvoiceStatusId])
REFERENCES [Client].[InvoiceStatus] ([Id])
GO
ALTER TABLE [Client].[Invoice] CHECK CONSTRAINT [FK_Invoice_InvoiceStatus]
GO
ALTER TABLE [Client].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[Invoice] CHECK CONSTRAINT [FK_Invoice_Member]
GO
ALTER TABLE [Client].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_PaymentGateway] FOREIGN KEY([PaymentGatewayId])
REFERENCES [Client].[PaymentGateway] ([Id])
GO
ALTER TABLE [Client].[Invoice] CHECK CONSTRAINT [FK_Invoice_PaymentGateway]
GO
ALTER TABLE [Client].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[Invoice] CHECK CONSTRAINT [FK_Invoice_RelatedTo]
GO
ALTER TABLE [Client].[InvoiceSetting]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceSetting_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[InvoiceSetting] CHECK CONSTRAINT [FK_InvoiceSetting_Client]
GO
ALTER TABLE [Client].[LandingPage]  WITH CHECK ADD  CONSTRAINT [FK_LandingPage_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[LandingPage] CHECK CONSTRAINT [FK_LandingPage_Client]
GO
ALTER TABLE [Client].[LandingPage]  WITH CHECK ADD  CONSTRAINT [FK_LandingPage_MemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [Client].[MemberType] ([Id])
GO
ALTER TABLE [Client].[LandingPage] CHECK CONSTRAINT [FK_LandingPage_MemberType]
GO
ALTER TABLE [Client].[LandingPage]  WITH CHECK ADD  CONSTRAINT [FK_LandingPage_Page] FOREIGN KEY([PageId])
REFERENCES [Client].[Page] ([Id])
GO
ALTER TABLE [Client].[LandingPage] CHECK CONSTRAINT [FK_LandingPage_Page]
GO
ALTER TABLE [Client].[MarketingGroup]  WITH CHECK ADD  CONSTRAINT [FK_MarketingGroup_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MarketingGroup] CHECK CONSTRAINT [FK_MarketingGroup_Client]
GO
ALTER TABLE [Client].[MarketingGroupXRef]  WITH CHECK ADD  CONSTRAINT [FK_MarketingGroupXRef_MarketingGroup] FOREIGN KEY([MarketingGroupId])
REFERENCES [Client].[MarketingGroup] ([Id])
GO
ALTER TABLE [Client].[MarketingGroupXRef] CHECK CONSTRAINT [FK_MarketingGroupXRef_MarketingGroup]
GO
ALTER TABLE [Client].[MarketingGroupXRef]  WITH CHECK ADD  CONSTRAINT [FK_MarketingGroupXRef_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MarketingGroupXRef] CHECK CONSTRAINT [FK_MarketingGroupXRef_Member]
GO
ALTER TABLE [Client].[MarketingProfile]  WITH CHECK ADD  CONSTRAINT [FK_MarketingProfile_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MarketingProfile] CHECK CONSTRAINT [FK_MarketingProfile_Client]
GO
ALTER TABLE [Client].[MarketingProfileXRef]  WITH CHECK ADD  CONSTRAINT [FK_MarketingProfileXRef_MarketingProfile] FOREIGN KEY([MarketingProfileId])
REFERENCES [Client].[MarketingProfile] ([Id])
GO
ALTER TABLE [Client].[MarketingProfileXRef] CHECK CONSTRAINT [FK_MarketingProfileXRef_MarketingProfile]
GO
ALTER TABLE [Client].[MarketingProfileXRef]  WITH CHECK ADD  CONSTRAINT [FK_MarketingProfileXRef_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MarketingProfileXRef] CHECK CONSTRAINT [FK_MarketingProfileXRef_Member]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_Client]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_Gender] FOREIGN KEY([GenderId])
REFERENCES [Common].[Gender] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_Gender]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberBranch] FOREIGN KEY([MemberBranchId])
REFERENCES [Client].[MemberBranch] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_MemberBranch]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberLevel] FOREIGN KEY([MemberLevelId])
REFERENCES [Client].[MemberLevel] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_MemberLevel]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberStatus] FOREIGN KEY([MemberStatusId])
REFERENCES [Client].[MemberStatus] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_MemberStatus]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberTeam] FOREIGN KEY([MemberTeamId])
REFERENCES [Client].[MemberTeam] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_MemberTeam]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_MemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [Client].[MemberType] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_MemberType]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [Client].[Organization] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_Organization]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_OrganizationStructure] FOREIGN KEY([OrganizationStructureId])
REFERENCES [Client].[OrganizationStructure] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_OrganizationStructure]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_ReferralType] FOREIGN KEY([ReferralTypeId])
REFERENCES [Client].[ReferralType] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_ReferralType]
GO
ALTER TABLE [Client].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_Title] FOREIGN KEY([TitleId])
REFERENCES [Common].[Title] ([Id])
GO
ALTER TABLE [Client].[Member] CHECK CONSTRAINT [FK_Member_Title]
GO
ALTER TABLE [Client].[MemberAddress]  WITH CHECK ADD  CONSTRAINT [FK_MemberAddress_ClientAddressType] FOREIGN KEY([AddressTypeId])
REFERENCES [Client].[ClientAddressType] ([Id])
GO
ALTER TABLE [Client].[MemberAddress] CHECK CONSTRAINT [FK_MemberAddress_ClientAddressType]
GO
ALTER TABLE [Client].[MemberAddress]  WITH CHECK ADD  CONSTRAINT [FK_MemberAddress_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberAddress] CHECK CONSTRAINT [FK_MemberAddress_Member]
GO
ALTER TABLE [Client].[MemberAddress]  WITH CHECK ADD  CONSTRAINT [FK_MemberAddress_MemberBranch] FOREIGN KEY([BranchId])
REFERENCES [Client].[MemberBranch] ([Id])
GO
ALTER TABLE [Client].[MemberAddress] CHECK CONSTRAINT [FK_MemberAddress_MemberBranch]
GO
ALTER TABLE [Client].[MemberAddress]  WITH CHECK ADD  CONSTRAINT [FK_MemberAddress_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [Client].[Organization] ([Id])
GO
ALTER TABLE [Client].[MemberAddress] CHECK CONSTRAINT [FK_MemberAddress_Organization]
GO
ALTER TABLE [Client].[MemberAffliationXRef]  WITH CHECK ADD  CONSTRAINT [FK_MemberAffliationXRef_Affliation] FOREIGN KEY([AffliationId])
REFERENCES [Client].[Affliation] ([Id])
GO
ALTER TABLE [Client].[MemberAffliationXRef] CHECK CONSTRAINT [FK_MemberAffliationXRef_Affliation]
GO
ALTER TABLE [Client].[MemberAffliationXRef]  WITH CHECK ADD  CONSTRAINT [FK_MemberAffliationXRef_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberAffliationXRef] CHECK CONSTRAINT [FK_MemberAffliationXRef_Member]
GO
ALTER TABLE [Client].[MemberBankingDetail]  WITH CHECK ADD  CONSTRAINT [FK_MemberBankingDetail_ClientAccountType] FOREIGN KEY([AccountTypeId])
REFERENCES [Client].[ClientAccountType] ([Id])
GO
ALTER TABLE [Client].[MemberBankingDetail] CHECK CONSTRAINT [FK_MemberBankingDetail_ClientAccountType]
GO
ALTER TABLE [Client].[MemberBankingDetail]  WITH CHECK ADD  CONSTRAINT [FK_MemberBankingDetail_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberBankingDetail] CHECK CONSTRAINT [FK_MemberBankingDetail_Member]
GO
ALTER TABLE [Client].[MemberBranch]  WITH CHECK ADD  CONSTRAINT [FK_MemberBranch_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [Client].[Organization] ([Id])
GO
ALTER TABLE [Client].[MemberBranch] CHECK CONSTRAINT [FK_MemberBranch_Organization]
GO
ALTER TABLE [Client].[MemberCategory]  WITH CHECK ADD  CONSTRAINT [FK_MemberCategory_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberCategory] CHECK CONSTRAINT [FK_MemberCategory_Client]
GO
ALTER TABLE [Client].[MemberCodeGenerator]  WITH CHECK ADD  CONSTRAINT [FK_MemberCodeGenerator_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberCodeGenerator] CHECK CONSTRAINT [FK_MemberCodeGenerator_Client]
GO
ALTER TABLE [Client].[MemberCommunicationPreference]  WITH CHECK ADD  CONSTRAINT [FK_MemberCommunicationPreference_CommunicationType] FOREIGN KEY([CommunicationTypeId])
REFERENCES [Client].[CommunicationType] ([Id])
GO
ALTER TABLE [Client].[MemberCommunicationPreference] CHECK CONSTRAINT [FK_MemberCommunicationPreference_CommunicationType]
GO
ALTER TABLE [Client].[MemberCommunicationPreference]  WITH CHECK ADD  CONSTRAINT [FK_MemberCommunicationPreference_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberCommunicationPreference] CHECK CONSTRAINT [FK_MemberCommunicationPreference_Member]
GO
ALTER TABLE [Client].[MemberFile]  WITH CHECK ADD  CONSTRAINT [FK_MemberFile_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberFile] CHECK CONSTRAINT [FK_MemberFile_Client]
GO
ALTER TABLE [Client].[MemberFile]  WITH CHECK ADD  CONSTRAINT [FK_MemberFile_FileType] FOREIGN KEY([FileTypeId])
REFERENCES [Client].[FileType] ([Id])
GO
ALTER TABLE [Client].[MemberFile] CHECK CONSTRAINT [FK_MemberFile_FileType]
GO
ALTER TABLE [Client].[MemberFile]  WITH CHECK ADD  CONSTRAINT [FK_MemberFile_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberFile] CHECK CONSTRAINT [FK_MemberFile_Member]
GO
ALTER TABLE [Client].[MemberLevel]  WITH CHECK ADD  CONSTRAINT [FK_MemberLevel_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberLevel] CHECK CONSTRAINT [FK_MemberLevel_Client]
GO
ALTER TABLE [Client].[MemberPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_MemberPlanHistory_PlanDetail] FOREIGN KEY([MemberPlanDetailId])
REFERENCES [Client].[PlanDetail] ([Id])
GO
ALTER TABLE [Client].[MemberPlanHistory] CHECK CONSTRAINT [FK_MemberPlanHistory_PlanDetail]
GO
ALTER TABLE [Client].[MemberPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_MembershipHistory_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberPlanHistory] CHECK CONSTRAINT [FK_MembershipHistory_Member]
GO
ALTER TABLE [Client].[MemberPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_MembershipHistory_Organization] FOREIGN KEY([OrganizationId])
REFERENCES [Client].[Organization] ([Id])
GO
ALTER TABLE [Client].[MemberPlanHistory] CHECK CONSTRAINT [FK_MembershipHistory_Organization]
GO
ALTER TABLE [Client].[MemberPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_MembershipHistory_PlanMaster] FOREIGN KEY([MemberPlanDetailId])
REFERENCES [Client].[PlanMaster] ([Id])
GO
ALTER TABLE [Client].[MemberPlanHistory] CHECK CONSTRAINT [FK_MembershipHistory_PlanMaster]
GO
ALTER TABLE [Client].[MemberQualificationXRef]  WITH CHECK ADD  CONSTRAINT [FK_MemberQualificationXRef_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[MemberQualificationXRef] CHECK CONSTRAINT [FK_MemberQualificationXRef_Member]
GO
ALTER TABLE [Client].[MemberQualificationXRef]  WITH CHECK ADD  CONSTRAINT [FK_MemberQualificationXRef_Qualification] FOREIGN KEY([QualificationId])
REFERENCES [Client].[Qualification] ([Id])
GO
ALTER TABLE [Client].[MemberQualificationXRef] CHECK CONSTRAINT [FK_MemberQualificationXRef_Qualification]
GO
ALTER TABLE [Client].[MemberStatus]  WITH CHECK ADD  CONSTRAINT [FK_MemberStatus_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberStatus] CHECK CONSTRAINT [FK_MemberStatus_Client]
GO
ALTER TABLE [Client].[MemberTeam]  WITH CHECK ADD  CONSTRAINT [FK_MemberTeam_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberTeam] CHECK CONSTRAINT [FK_MemberTeam_Client]
GO
ALTER TABLE [Client].[MemberType]  WITH CHECK ADD  CONSTRAINT [FK_MemberType_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[MemberType] CHECK CONSTRAINT [FK_MemberType_Client]
GO
ALTER TABLE [Client].[MemberType]  WITH CHECK ADD  CONSTRAINT [FK_MemberType_MemberCategory] FOREIGN KEY([MemberCategoryId])
REFERENCES [Client].[MemberCategory] ([Id])
GO
ALTER TABLE [Client].[MemberType] CHECK CONSTRAINT [FK_MemberType_MemberCategory]
GO
ALTER TABLE [Client].[Organization]  WITH CHECK ADD  CONSTRAINT [FK_Organization_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Organization] CHECK CONSTRAINT [FK_Organization_Client]
GO
ALTER TABLE [Client].[OrganizationStructure]  WITH CHECK ADD  CONSTRAINT [FK_OrganizationStructure_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[OrganizationStructure] CHECK CONSTRAINT [FK_OrganizationStructure_Client]
GO
ALTER TABLE [Client].[PaymentGateway]  WITH CHECK ADD  CONSTRAINT [FK_PaymentGateway_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[PaymentGateway] CHECK CONSTRAINT [FK_PaymentGateway_Client]
GO
ALTER TABLE [Client].[PaymentSetting]  WITH CHECK ADD  CONSTRAINT [FK_PaymentSetting_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[PaymentSetting] CHECK CONSTRAINT [FK_PaymentSetting_Client]
GO
ALTER TABLE [Client].[PaymentSetting]  WITH CHECK ADD  CONSTRAINT [FK_PaymentSetting_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [Common].[Currency] ([Id])
GO
ALTER TABLE [Client].[PaymentSetting] CHECK CONSTRAINT [FK_PaymentSetting_Currency]
GO
ALTER TABLE [Client].[PaymentSettingAllowedCard]  WITH CHECK ADD  CONSTRAINT [FK_PaymentSettingAllowedCard_PaymentCard] FOREIGN KEY([PaymentCardId])
REFERENCES [Common].[PaymentCardDefault] ([Id])
GO
ALTER TABLE [Client].[PaymentSettingAllowedCard] CHECK CONSTRAINT [FK_PaymentSettingAllowedCard_PaymentCard]
GO
ALTER TABLE [Client].[PaymentSettingAllowedCard]  WITH CHECK ADD  CONSTRAINT [FK_PaymentSettingAllowedCard_PaymentSetting] FOREIGN KEY([PaymentSettingId])
REFERENCES [Client].[PaymentSetting] ([Id])
GO
ALTER TABLE [Client].[PaymentSettingAllowedCard] CHECK CONSTRAINT [FK_PaymentSettingAllowedCard_PaymentSetting]
GO
ALTER TABLE [Client].[PlanCanChangeToXref]  WITH CHECK ADD  CONSTRAINT [FK_MemberPlanCanChangeTo_PlanMaster] FOREIGN KEY([FromPlanMasterId])
REFERENCES [Client].[PlanMaster] ([Id])
GO
ALTER TABLE [Client].[PlanCanChangeToXref] CHECK CONSTRAINT [FK_MemberPlanCanChangeTo_PlanMaster]
GO
ALTER TABLE [Client].[PlanCanChangeToXref]  WITH CHECK ADD  CONSTRAINT [FK_MemberPlanCanChangeTo_PlanMaster2] FOREIGN KEY([ToPlanMasterId])
REFERENCES [Client].[PlanMaster] ([Id])
GO
ALTER TABLE [Client].[PlanCanChangeToXref] CHECK CONSTRAINT [FK_MemberPlanCanChangeTo_PlanMaster2]
GO
ALTER TABLE [Client].[PlanDetail]  WITH CHECK ADD  CONSTRAINT [FK_PlanDetail_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [Common].[Currency] ([Id])
GO
ALTER TABLE [Client].[PlanDetail] CHECK CONSTRAINT [FK_PlanDetail_Currency]
GO
ALTER TABLE [Client].[PlanDetail]  WITH CHECK ADD  CONSTRAINT [FK_PlanDetail_PlanFrequency] FOREIGN KEY([PlanFrequencyId])
REFERENCES [Client].[PlanFrequency] ([Id])
GO
ALTER TABLE [Client].[PlanDetail] CHECK CONSTRAINT [FK_PlanDetail_PlanFrequency]
GO
ALTER TABLE [Client].[PlanDetail]  WITH CHECK ADD  CONSTRAINT [FK_PlanDetail_PlanMaster] FOREIGN KEY([PlanMasterId])
REFERENCES [Client].[PlanMaster] ([Id])
GO
ALTER TABLE [Client].[PlanDetail] CHECK CONSTRAINT [FK_PlanDetail_PlanMaster]
GO
ALTER TABLE [Client].[PlanFrequency]  WITH CHECK ADD  CONSTRAINT [FK_PlanFrequency_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[PlanFrequency] CHECK CONSTRAINT [FK_PlanFrequency_Client]
GO
ALTER TABLE [Client].[PlanMaster]  WITH CHECK ADD  CONSTRAINT [FK_PlanMaster_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[PlanMaster] CHECK CONSTRAINT [FK_PlanMaster_Client]
GO
ALTER TABLE [Client].[PlanMaster]  WITH CHECK ADD  CONSTRAINT [FK_PlanMaster_MemberCategory] FOREIGN KEY([MemberCategoryId])
REFERENCES [Client].[MemberCategory] ([Id])
GO
ALTER TABLE [Client].[PlanMaster] CHECK CONSTRAINT [FK_PlanMaster_MemberCategory]
GO
ALTER TABLE [Client].[PlanMaster]  WITH CHECK ADD  CONSTRAINT [FK_PlanMaster_PaymentSetting] FOREIGN KEY([PaymentMethodId])
REFERENCES [Client].[PaymentSetting] ([Id])
GO
ALTER TABLE [Client].[PlanMaster] CHECK CONSTRAINT [FK_PlanMaster_PaymentSetting]
GO
ALTER TABLE [Client].[PromotionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PromotionDetail_MemberLevel] FOREIGN KEY([MemberLevelId])
REFERENCES [Client].[MemberLevel] ([Id])
GO
ALTER TABLE [Client].[PromotionDetail] CHECK CONSTRAINT [FK_PromotionDetail_MemberLevel]
GO
ALTER TABLE [Client].[PromotionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PromotionDetail_MemberType] FOREIGN KEY([MemberTypeId])
REFERENCES [Client].[MemberType] ([Id])
GO
ALTER TABLE [Client].[PromotionDetail] CHECK CONSTRAINT [FK_PromotionDetail_MemberType]
GO
ALTER TABLE [Client].[PromotionDetail]  WITH CHECK ADD  CONSTRAINT [FK_PromotionDetail_PromotionMaster] FOREIGN KEY([PromotionMasterId])
REFERENCES [Client].[PromotionMaster] ([Id])
GO
ALTER TABLE [Client].[PromotionDetail] CHECK CONSTRAINT [FK_PromotionDetail_PromotionMaster]
GO
ALTER TABLE [Client].[PromotionMaster]  WITH CHECK ADD  CONSTRAINT [FK_PromotionMaster_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[PromotionMaster] CHECK CONSTRAINT [FK_PromotionMaster_Client]
GO
ALTER TABLE [Client].[PromotionResponse]  WITH CHECK ADD  CONSTRAINT [FK_PromotionResponse_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[PromotionResponse] CHECK CONSTRAINT [FK_PromotionResponse_Member]
GO
ALTER TABLE [Client].[PromotionResponse]  WITH CHECK ADD  CONSTRAINT [FK_PromotionResponse_PromotionMaster] FOREIGN KEY([PromotionMasterId])
REFERENCES [Client].[PromotionMaster] ([Id])
GO
ALTER TABLE [Client].[PromotionResponse] CHECK CONSTRAINT [FK_PromotionResponse_PromotionMaster]
GO
ALTER TABLE [Client].[PromotionResponse]  WITH CHECK ADD  CONSTRAINT [FK_PromotionResponse_PromotionResponseType] FOREIGN KEY([PromotionResponseType])
REFERENCES [Client].[PromotionResponseType] ([Id])
GO
ALTER TABLE [Client].[PromotionResponse] CHECK CONSTRAINT [FK_PromotionResponse_PromotionResponseType]
GO
ALTER TABLE [Client].[Qualification]  WITH CHECK ADD  CONSTRAINT [FK_Qualification_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Qualification] CHECK CONSTRAINT [FK_Qualification_Client]
GO
ALTER TABLE [Client].[Refund]  WITH CHECK ADD  CONSTRAINT [FK_Refund_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Refund] CHECK CONSTRAINT [FK_Refund_Client]
GO
ALTER TABLE [Client].[Refund]  WITH CHECK ADD  CONSTRAINT [FK_Refund_Member] FOREIGN KEY([MemberId])
REFERENCES [Client].[Member] ([Id])
GO
ALTER TABLE [Client].[Refund] CHECK CONSTRAINT [FK_Refund_Member]
GO
ALTER TABLE [Client].[Refund]  WITH CHECK ADD  CONSTRAINT [FK_Refund_PaymentGateway] FOREIGN KEY([PaymentGatewayId])
REFERENCES [Client].[PaymentGateway] ([Id])
GO
ALTER TABLE [Client].[Refund] CHECK CONSTRAINT [FK_Refund_PaymentGateway]
GO
ALTER TABLE [Client].[Refund]  WITH CHECK ADD  CONSTRAINT [FK_Refund_RelatedTo] FOREIGN KEY([RelatedToId])
REFERENCES [Client].[RelatedTo] ([Id])
GO
ALTER TABLE [Client].[Refund] CHECK CONSTRAINT [FK_Refund_RelatedTo]
GO
ALTER TABLE [Client].[Tax]  WITH CHECK ADD  CONSTRAINT [FK_Tax_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Tax] CHECK CONSTRAINT [FK_Tax_Client]
GO
ALTER TABLE [Client].[TaxPolicy]  WITH CHECK ADD  CONSTRAINT [FK_TaxPolicy_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[TaxPolicy] CHECK CONSTRAINT [FK_TaxPolicy_Client]
GO
ALTER TABLE [Client].[TaxScope]  WITH CHECK ADD  CONSTRAINT [FK_TaxScope_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[TaxScope] CHECK CONSTRAINT [FK_TaxScope_Client]
GO
ALTER TABLE [Client].[Theme]  WITH CHECK ADD  CONSTRAINT [FK_Theme_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Client].[Theme] CHECK CONSTRAINT [FK_Theme_Client]
GO
ALTER TABLE [Common].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_State] FOREIGN KEY([StateId])
REFERENCES [Common].[State] ([Id])
GO
ALTER TABLE [Common].[City] CHECK CONSTRAINT [FK_City_State]
GO
ALTER TABLE [Common].[State]  WITH CHECK ADD  CONSTRAINT [FK_State_Country] FOREIGN KEY([CountryId])
REFERENCES [Common].[Country] ([Id])
GO
ALTER TABLE [Common].[State] CHECK CONSTRAINT [FK_State_Country]
GO
ALTER TABLE [Core].[ClientPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_ClientPlanHistory_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Core].[ClientPlanHistory] CHECK CONSTRAINT [FK_ClientPlanHistory_Client]
GO
ALTER TABLE [Core].[ClientPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_ClientPlanHistory_ClientUser] FOREIGN KEY([BillingUserId])
REFERENCES [Client].[ClientUser] ([Id])
GO
ALTER TABLE [Core].[ClientPlanHistory] CHECK CONSTRAINT [FK_ClientPlanHistory_ClientUser]
GO
ALTER TABLE [Core].[ClientPlanHistory]  WITH CHECK ADD  CONSTRAINT [FK_ClientPlanHistory_CorePlanDetail] FOREIGN KEY([CorePlanDetailId])
REFERENCES [Core].[CorePlanDetail] ([Id])
GO
ALTER TABLE [Core].[ClientPlanHistory] CHECK CONSTRAINT [FK_ClientPlanHistory_CorePlanDetail]
GO
ALTER TABLE [Core].[CoreAddress]  WITH CHECK ADD  CONSTRAINT [FK_CoreAddress_City] FOREIGN KEY([CityId])
REFERENCES [Common].[City] ([Id])
GO
ALTER TABLE [Core].[CoreAddress] CHECK CONSTRAINT [FK_CoreAddress_City]
GO
ALTER TABLE [Core].[CoreAddress]  WITH CHECK ADD  CONSTRAINT [FK_CoreAddress_CoreAddressType] FOREIGN KEY([CoreAddressTypeId])
REFERENCES [Core].[CoreAddressType] ([Id])
GO
ALTER TABLE [Core].[CoreAddress] CHECK CONSTRAINT [FK_CoreAddress_CoreAddressType]
GO
ALTER TABLE [Core].[CoreAddress]  WITH CHECK ADD  CONSTRAINT [FK_CoreAddress_Country] FOREIGN KEY([CountryId])
REFERENCES [Common].[Country] ([Id])
GO
ALTER TABLE [Core].[CoreAddress] CHECK CONSTRAINT [FK_CoreAddress_Country]
GO
ALTER TABLE [Core].[CoreAddress]  WITH CHECK ADD  CONSTRAINT [FK_CoreAddress_State] FOREIGN KEY([StateId])
REFERENCES [Common].[State] ([Id])
GO
ALTER TABLE [Core].[CoreAddress] CHECK CONSTRAINT [FK_CoreAddress_State]
GO
ALTER TABLE [Core].[CoreBankingDetail]  WITH CHECK ADD  CONSTRAINT [FK_CoreBankingDetail_CoreAccountType] FOREIGN KEY([AccountTypeId])
REFERENCES [Core].[CoreAccountType] ([Id])
GO
ALTER TABLE [Core].[CoreBankingDetail] CHECK CONSTRAINT [FK_CoreBankingDetail_CoreAccountType]
GO
ALTER TABLE [Core].[CoreBilling]  WITH CHECK ADD  CONSTRAINT [FK_CoreBilling_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Core].[CoreBilling] CHECK CONSTRAINT [FK_CoreBilling_Client]
GO
ALTER TABLE [Core].[CoreBilling]  WITH CHECK ADD  CONSTRAINT [FK_CoreBilling_CoreInvoice] FOREIGN KEY([InvoiceId])
REFERENCES [Core].[CoreInvoice] ([Id])
GO
ALTER TABLE [Core].[CoreBilling] CHECK CONSTRAINT [FK_CoreBilling_CoreInvoice]
GO
ALTER TABLE [Core].[CoreBilling]  WITH CHECK ADD  CONSTRAINT [FK_CoreBilling_CorePaymentGateway] FOREIGN KEY([CorePaymentGatewayId])
REFERENCES [Core].[CorePaymentGateway] ([Id])
GO
ALTER TABLE [Core].[CoreBilling] CHECK CONSTRAINT [FK_CoreBilling_CorePaymentGateway]
GO
ALTER TABLE [Core].[CoreBilling]  WITH CHECK ADD  CONSTRAINT [FK_CoreBilling_CoreRelatedTo] FOREIGN KEY([CoreRelatedToId])
REFERENCES [Core].[CoreRelatedTo] ([Id])
GO
ALTER TABLE [Core].[CoreBilling] CHECK CONSTRAINT [FK_CoreBilling_CoreRelatedTo]
GO
ALTER TABLE [Core].[CoreInvoice]  WITH CHECK ADD  CONSTRAINT [FK_CoreInvoice_Client] FOREIGN KEY([ClientId])
REFERENCES [Client].[Client] ([Id])
GO
ALTER TABLE [Core].[CoreInvoice] CHECK CONSTRAINT [FK_CoreInvoice_Client]
GO
ALTER TABLE [Core].[CoreInvoice]  WITH CHECK ADD  CONSTRAINT [FK_CoreInvoice_CoreInvoiceStatus] FOREIGN KEY([CoreInvoiceStatusId])
REFERENCES [Core].[CoreInvoiceStatus] ([Id])
GO
ALTER TABLE [Core].[CoreInvoice] CHECK CONSTRAINT [FK_CoreInvoice_CoreInvoiceStatus]
GO
ALTER TABLE [Core].[CoreInvoice]  WITH CHECK ADD  CONSTRAINT [FK_CoreInvoice_CorePaymentGateway] FOREIGN KEY([CorePaymentGatewayId])
REFERENCES [Core].[CorePaymentGateway] ([Id])
GO
ALTER TABLE [Core].[CoreInvoice] CHECK CONSTRAINT [FK_CoreInvoice_CorePaymentGateway]
GO
ALTER TABLE [Core].[CoreInvoice]  WITH CHECK ADD  CONSTRAINT [FK_CoreInvoice_CoreRelatedTo] FOREIGN KEY([CoreRelatedToId])
REFERENCES [Core].[CoreRelatedTo] ([Id])
GO
ALTER TABLE [Core].[CoreInvoice] CHECK CONSTRAINT [FK_CoreInvoice_CoreRelatedTo]
GO
ALTER TABLE [Core].[CorePlanDetail]  WITH CHECK ADD  CONSTRAINT [FK_CorePlanDetail_CorePlanFrequency] FOREIGN KEY([CorePlanFrequencyId])
REFERENCES [Core].[CorePlanFrequency] ([Id])
GO
ALTER TABLE [Core].[CorePlanDetail] CHECK CONSTRAINT [FK_CorePlanDetail_CorePlanFrequency]
GO
ALTER TABLE [Core].[CorePlanDetail]  WITH CHECK ADD  CONSTRAINT [FK_CorePlanDetail_CorePlanMaster] FOREIGN KEY([CorePlanMasterId])
REFERENCES [Core].[CorePlanMaster] ([Id])
GO
ALTER TABLE [Core].[CorePlanDetail] CHECK CONSTRAINT [FK_CorePlanDetail_CorePlanMaster]
GO
ALTER TABLE [Core].[CorePlanDetail]  WITH CHECK ADD  CONSTRAINT [FK_CorePlanDetail_Currency] FOREIGN KEY([CurrencyId])
REFERENCES [Common].[Currency] ([Id])
GO
ALTER TABLE [Core].[CorePlanDetail] CHECK CONSTRAINT [FK_CorePlanDetail_Currency]
GO
ALTER TABLE [Core].[CoreRolePermissionXRef]  WITH CHECK ADD  CONSTRAINT [FK_CoreRolePermissionXRef_CorePermission] FOREIGN KEY([CorePermissionid])
REFERENCES [Core].[CorePermission] ([Id])
GO
ALTER TABLE [Core].[CoreRolePermissionXRef] CHECK CONSTRAINT [FK_CoreRolePermissionXRef_CorePermission]
GO
ALTER TABLE [Core].[CoreRolePermissionXRef]  WITH CHECK ADD  CONSTRAINT [FK_CoreRolePermissionXRef_CoreRole] FOREIGN KEY([CoreRoleId])
REFERENCES [Core].[CoreRole] ([Id])
GO
ALTER TABLE [Core].[CoreRolePermissionXRef] CHECK CONSTRAINT [FK_CoreRolePermissionXRef_CoreRole]
GO
ALTER TABLE [Core].[CoreUser]  WITH CHECK ADD  CONSTRAINT [FK_CoreUser_Gender] FOREIGN KEY([GenderId])
REFERENCES [Common].[Gender] ([Id])
GO
ALTER TABLE [Core].[CoreUser] CHECK CONSTRAINT [FK_CoreUser_Gender]
GO
ALTER TABLE [Core].[CoreUser]  WITH CHECK ADD  CONSTRAINT [FK_CoreUser_Title] FOREIGN KEY([TitleId])
REFERENCES [Common].[Title] ([Id])
GO
ALTER TABLE [Core].[CoreUser] CHECK CONSTRAINT [FK_CoreUser_Title]
GO
ALTER TABLE [Core].[CoreUserRoleXRef]  WITH CHECK ADD  CONSTRAINT [FK_CoreUserRoleXRef_CoreRole] FOREIGN KEY([CoreRoleId])
REFERENCES [Core].[CoreRole] ([Id])
GO
ALTER TABLE [Core].[CoreUserRoleXRef] CHECK CONSTRAINT [FK_CoreUserRoleXRef_CoreRole]
GO
ALTER TABLE [Core].[CoreUserRoleXRef]  WITH CHECK ADD  CONSTRAINT [FK_CoreUserRoleXRef_CoreUser] FOREIGN KEY([CoreUserId])
REFERENCES [Core].[CoreUser] ([Id])
GO
ALTER TABLE [Core].[CoreUserRoleXRef] CHECK CONSTRAINT [FK_CoreUserRoleXRef_CoreUser]
GO
USE [master]
GO
ALTER DATABASE [MM] SET  READ_WRITE 
GO
