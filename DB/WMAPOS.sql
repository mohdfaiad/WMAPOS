USE [master]
GO
/****** Object:  Database [WMAPOS]    Script Date: 02/13/2017 23:46:43 ******/
CREATE DATABASE [WMAPOS] ON  PRIMARY 
( NAME = N'WMAPOS', FILENAME = N'E:\Work\POS\DB\WMAPOS.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WMAPOS_log', FILENAME = N'E:\Work\POS\DB\WMAPOS_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WMAPOS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WMAPOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WMAPOS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [WMAPOS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [WMAPOS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [WMAPOS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [WMAPOS] SET ARITHABORT OFF
GO
ALTER DATABASE [WMAPOS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [WMAPOS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [WMAPOS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [WMAPOS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [WMAPOS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [WMAPOS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [WMAPOS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [WMAPOS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [WMAPOS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [WMAPOS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [WMAPOS] SET  DISABLE_BROKER
GO
ALTER DATABASE [WMAPOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [WMAPOS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [WMAPOS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [WMAPOS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [WMAPOS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [WMAPOS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [WMAPOS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [WMAPOS] SET  READ_WRITE
GO
ALTER DATABASE [WMAPOS] SET RECOVERY FULL
GO
ALTER DATABASE [WMAPOS] SET  MULTI_USER
GO
ALTER DATABASE [WMAPOS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [WMAPOS] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'WMAPOS', N'ON'
GO
USE [WMAPOS]
GO
/****** Object:  Table [dbo].[tbl_UserGroup]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_UserGroup](
	[GroupCode] [nvarchar](10) NOT NULL,
	[GroupNameA] [nvarchar](75) NULL,
	[GroupNameE] [nvarchar](75) NULL,
	[GroupStatus] [char](1) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_USERGROUP] PRIMARY KEY CLUSTERED 
(
	[GroupCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_POS_Definition]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_POS_Definition](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[POSCode] [nvarchar](4) NOT NULL,
	[POSNameAr] [nvarchar](75) NULL,
	[POSNameEn] [nvarchar](75) NULL,
	[CashCode] [nvarchar](4) NULL,
	[BankCode] [nvarchar](4) NULL,
	[OpenBalance] [decimal](18, 4) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_POS_Definition] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[POSCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemUnit]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemUnit](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemUnitCode] [nvarchar](6) NOT NULL,
	[ItemUnitDescA] [nvarchar](75) NULL,
	[ItemUnitDescE] [nvarchar](75) NULL,
	[UnitTransCode] [nvarchar](6) NULL,
	[UnitTransValue] [decimal](18, 4) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_ItemUnit] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemUnitCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemPrices]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemPrices](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemService] [nvarchar](3) NOT NULL,
	[ItemCode] [nvarchar](20) NOT NULL,
	[PolicyCode] [nvarchar](4) NOT NULL,
	[ItemUnit] [nvarchar](6) NOT NULL,
	[PriceValue] [decimal](18, 4) NULL,
	[PriceRatio] [decimal](18, 4) NULL,
	[DiscountRatio] [decimal](18, 4) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemPrices] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemService] ASC,
	[ItemCode] ASC,
	[PolicyCode] ASC,
	[ItemUnit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemPolicies]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemPolicies](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[PolicyCode] [nvarchar](4) NOT NULL,
	[PolicyNameAr] [nvarchar](20) NULL,
	[PolicyNameEn] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemPolicies] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[PolicyCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemGroupSections]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemGroupSections](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[SectionCode] [nvarchar](6) NOT NULL,
	[SectionNameA] [nvarchar](75) NULL,
	[SectionNameE] [nvarchar](75) NULL,
	[PrinterPath] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemGroupSections] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[SectionCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Currency]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Currency](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[CurrencyCode] [nvarchar](3) NOT NULL,
	[CurrencyNameA] [nvarchar](25) NULL,
	[CurrencyNameE] [nvarchar](25) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[CurrencyCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Company](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[CompanyNameAr] [nvarchar](250) NULL,
	[CompanyNameEn] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Branch]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Branch](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[BranchCode] [nvarchar](4) NOT NULL,
	[BranchNameAr] [nvarchar](250) NULL,
	[BranchNameEn] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Branch] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[BranchCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemGroup]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemGroup](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemGroupCode] [nvarchar](6) NOT NULL,
	[ItemGroupNameAr] [nvarchar](255) NULL,
	[ItemGroupNameEn] [nvarchar](255) NULL,
	[SectionCode] [nvarchar](6) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemGroups] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemGroupCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemType]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemType](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemTypeCode] [nvarchar](6) NOT NULL,
	[ItemTypeNameAr] [nvarchar](255) NULL,
	[ItemTypeNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemTypes] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemTypeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemSize]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemSize](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemSizeCode] [nvarchar](6) NOT NULL,
	[ItemSizeNameAr] [nvarchar](255) NULL,
	[ItemSizeNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemSizes] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemSizeCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemColor]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemColor](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemColorCode] [nvarchar](6) NOT NULL,
	[ItemColorNameAr] [nvarchar](255) NULL,
	[ItemColorNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemColors] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemColorCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemCategory]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemCategory](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemCategoryCode] [nvarchar](6) NOT NULL,
	[ItemCategoryNameAr] [nvarchar](255) NULL,
	[ItemCategoryNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemCategorys] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemCategoryCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_VendorGroup]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_VendorGroup](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[VendorGroupCode] [nvarchar](6) NOT NULL,
	[VendoreNameAr] [nvarchar](255) NULL,
	[VendoreNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_VendorGroup] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[VendorGroupCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Users]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Users](
	[UserID] [nvarchar](75) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[FullNameA] [nvarchar](250) NULL,
	[FullNameE] [nvarchar](250) NULL,
	[GroupCode] [nvarchar](10) NULL,
	[UserStatus] [nvarchar](1) NULL,
	[IsCasher] [bit] NULL,
	[CreatedBy] [nvarchar](10) NULL,
	[CreatedDate] [datetime] NULL,
	[ModefiedBy] [nvarchar](10) NULL,
	[ModefiedDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CustomerGroup]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CustomerGroup](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[CustomerGroupCode] [nvarchar](6) NOT NULL,
	[CustomerGroupNameAr] [nvarchar](255) NULL,
	[CustomerGroupNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_CustomerGroup] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[CustomerGroupCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_CurrencyExch]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CurrencyExch](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[CurrencyCode] [nvarchar](3) NOT NULL,
	[BaseCurrencyCode] [nvarchar](3) NOT NULL,
	[ExchangeRate] [decimal](18, 6) NULL,
 CONSTRAINT [PK_tbl_CurrencyExch] PRIMARY KEY CLUSTERED 
(
	[CurrencyCode] ASC,
	[CompanyCode] ASC,
	[BaseCurrencyCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_WareHouse]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_WareHouse](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[WareHouseCode] [nvarchar](6) NOT NULL,
	[WareHouseNameAr] [nvarchar](250) NULL,
	[WareHouseNameEn] [nvarchar](250) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_WareHouse] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[WareHouseCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Vendors]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Vendors](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[VendoreCode] [nvarchar](6) NOT NULL,
	[VendoreGroupCode] [nvarchar](6) NULL,
	[VendoreNameAr] [nvarchar](250) NULL,
	[VendoreNameEn] [nvarchar](250) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Vendors] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[VendoreCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_operators]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_operators](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[OperatorCode] [nvarchar](6) NOT NULL,
	[OperatorNameAr] [nvarchar](255) NULL,
	[OperatorNameEn] [nvarchar](255) NULL,
	[UserID] [nvarchar](75) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_operator] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[OperatorCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Cutomers]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Cutomers](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[CustomerCode] [nvarchar](6) NOT NULL,
	[CustomerGroupCode] [nvarchar](6) NULL,
	[CustomerGroupNameAr] [nvarchar](255) NULL,
	[CustomerGroupNameEn] [nvarchar](255) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Cutomers] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[CustomerCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ItemDefinition]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ItemDefinition](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemCode] [nvarchar](25) NOT NULL,
	[ItemService] [nvarchar](3) NOT NULL,
	[ItemNameAr] [nvarchar](255) NULL,
	[ItemNameEn] [nvarchar](255) NULL,
	[ItemGroupCode] [nvarchar](6) NULL,
	[ItemTypeCode] [nvarchar](6) NULL,
	[ItemCategoryCode] [nvarchar](6) NULL,
	[ItemUnitCode] [nvarchar](6) NULL,
	[MaxDiscountRatio] [decimal](18, 4) NULL,
	[MinQuantity] [decimal](18, 4) NULL,
	[MaxQuantity] [decimal](18, 4) NULL,
	[ReOrderQuantity] [decimal](18, 4) NULL,
	[ItemVendorCode] [nvarchar](50) NULL,
	[OriginalItemCode] [nvarchar](20) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_ItemDefinition] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemCode] ASC,
	[ItemService] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Barcodes]    Script Date: 02/13/2017 23:46:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Barcodes](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemCode] [nvarchar](25) NOT NULL,
	[ItemService] [nvarchar](3) NOT NULL,
	[Barcode] [nvarchar](30) NOT NULL,
	[Status] [nvarchar](1) NULL,
	[ItemUnit] [nvarchar](6) NULL,
	[UnitTransValue] [decimal](18, 4) NULL,
	[Price] [decimal](18, 4) NULL,
	[ItemColorCode] [nvarchar](6) NULL,
	[ItemSizeCode] [nvarchar](6) NULL,
	[DiscountRatio] [decimal](18, 4) NULL,
	[DiscountValue] [decimal](18, 4) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
 CONSTRAINT [PK_Barcodes] PRIMARY KEY CLUSTERED 
(
	[CompanyCode] ASC,
	[ItemCode] ASC,
	[ItemService] ASC,
	[Barcode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_tbl_User_IsCasher]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Users] ADD  CONSTRAINT [DF_tbl_User_IsCasher]  DEFAULT ((0)) FOR [IsCasher]
GO
/****** Object:  ForeignKey [FK_tbl_Branch_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Branch]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Branch_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_Branch] CHECK CONSTRAINT [FK_tbl_Branch_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemGroup_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemGroup_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_ItemGroup] CHECK CONSTRAINT [FK_tbl_ItemGroup_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemGroup_tbl_ItemGroupSections]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemGroup_tbl_ItemGroupSections] FOREIGN KEY([CompanyCode], [SectionCode])
REFERENCES [dbo].[tbl_ItemGroupSections] ([CompanyCode], [SectionCode])
GO
ALTER TABLE [dbo].[tbl_ItemGroup] CHECK CONSTRAINT [FK_tbl_ItemGroup_tbl_ItemGroupSections]
GO
/****** Object:  ForeignKey [FK_tbl_ItemType_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemType]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemType_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_ItemType] CHECK CONSTRAINT [FK_tbl_ItemType_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemSize_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemSize]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemSize_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_ItemSize] CHECK CONSTRAINT [FK_tbl_ItemSize_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemColor_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemColor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemColor_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_ItemColor] CHECK CONSTRAINT [FK_tbl_ItemColor_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemCategory_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemCategory]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemCategory_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_ItemCategory] CHECK CONSTRAINT [FK_tbl_ItemCategory_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemCategory_tbl_ItemCategory]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemCategory]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemCategory_tbl_ItemCategory] FOREIGN KEY([CompanyCode], [ItemCategoryCode])
REFERENCES [dbo].[tbl_ItemCategory] ([CompanyCode], [ItemCategoryCode])
GO
ALTER TABLE [dbo].[tbl_ItemCategory] CHECK CONSTRAINT [FK_tbl_ItemCategory_tbl_ItemCategory]
GO
/****** Object:  ForeignKey [FK_tbl_VendorGroup_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_VendorGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VendorGroup_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_VendorGroup] CHECK CONSTRAINT [FK_tbl_VendorGroup_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_Users_tbl_UserGroup]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Users]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Users_tbl_UserGroup] FOREIGN KEY([GroupCode])
REFERENCES [dbo].[tbl_UserGroup] ([GroupCode])
GO
ALTER TABLE [dbo].[tbl_Users] CHECK CONSTRAINT [FK_tbl_Users_tbl_UserGroup]
GO
/****** Object:  ForeignKey [FK_tbl_CustomerGroup_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_CustomerGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CustomerGroup_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_CustomerGroup] CHECK CONSTRAINT [FK_tbl_CustomerGroup_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_CurrencyExch_Currency]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_CurrencyExch]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CurrencyExch_Currency] FOREIGN KEY([CompanyCode], [CurrencyCode])
REFERENCES [dbo].[tbl_Currency] ([CompanyCode], [CurrencyCode])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_CurrencyExch] CHECK CONSTRAINT [FK_tbl_CurrencyExch_Currency]
GO
/****** Object:  ForeignKey [FK_tbl_WareHouse_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_WareHouse]  WITH CHECK ADD  CONSTRAINT [FK_tbl_WareHouse_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_WareHouse] CHECK CONSTRAINT [FK_tbl_WareHouse_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_Vendors_tbl_VendorGroup]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Vendors]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Vendors_tbl_VendorGroup] FOREIGN KEY([CompanyCode], [VendoreGroupCode])
REFERENCES [dbo].[tbl_VendorGroup] ([CompanyCode], [VendorGroupCode])
GO
ALTER TABLE [dbo].[tbl_Vendors] CHECK CONSTRAINT [FK_tbl_Vendors_tbl_VendorGroup]
GO
/****** Object:  ForeignKey [FK_tbl_operators_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_operators]  WITH CHECK ADD  CONSTRAINT [FK_tbl_operators_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_operators] CHECK CONSTRAINT [FK_tbl_operators_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_operators_tbl_Users]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_operators]  WITH CHECK ADD  CONSTRAINT [FK_tbl_operators_tbl_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[tbl_Users] ([UserID])
GO
ALTER TABLE [dbo].[tbl_operators] CHECK CONSTRAINT [FK_tbl_operators_tbl_Users]
GO
/****** Object:  ForeignKey [FK_tbl_Cutomers_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Cutomers]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Cutomers_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_Cutomers] CHECK CONSTRAINT [FK_tbl_Cutomers_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_Cutomers_tbl_CustomerGroup]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Cutomers]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Cutomers_tbl_CustomerGroup] FOREIGN KEY([CompanyCode], [CustomerGroupCode])
REFERENCES [dbo].[tbl_CustomerGroup] ([CompanyCode], [CustomerGroupCode])
GO
ALTER TABLE [dbo].[tbl_Cutomers] CHECK CONSTRAINT [FK_tbl_Cutomers_tbl_CustomerGroup]
GO
/****** Object:  ForeignKey [FK_tbl_ItemDefinition_tbl_Company]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO
ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_Company]
GO
/****** Object:  ForeignKey [FK_tbl_ItemDefinition_tbl_ItemCategory]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemCategory] FOREIGN KEY([CompanyCode], [ItemCategoryCode])
REFERENCES [dbo].[tbl_ItemCategory] ([CompanyCode], [ItemCategoryCode])
GO
ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemCategory]
GO
/****** Object:  ForeignKey [FK_tbl_ItemDefinition_tbl_ItemGroup]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemGroup] FOREIGN KEY([CompanyCode], [ItemGroupCode])
REFERENCES [dbo].[tbl_ItemGroup] ([CompanyCode], [ItemGroupCode])
GO
ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemGroup]
GO
/****** Object:  ForeignKey [FK_tbl_ItemDefinition_tbl_ItemType]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemType] FOREIGN KEY([CompanyCode], [ItemTypeCode])
REFERENCES [dbo].[tbl_ItemType] ([CompanyCode], [ItemTypeCode])
GO
ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemType]
GO
/****** Object:  ForeignKey [FK_tbl_ItemDefinition_tbl_ItemUnit]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemUnit] FOREIGN KEY([CompanyCode], [ItemUnitCode])
REFERENCES [dbo].[tbl_ItemUnit] ([CompanyCode], [ItemUnitCode])
GO
ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemUnit]
GO
/****** Object:  ForeignKey [FK_tbl_Barcodes_tbl_Barcodes]    Script Date: 02/13/2017 23:46:45 ******/
ALTER TABLE [dbo].[tbl_Barcodes]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Barcodes_tbl_Barcodes] FOREIGN KEY([CompanyCode], [ItemCode], [ItemService])
REFERENCES [dbo].[tbl_ItemDefinition] ([CompanyCode], [ItemCode], [ItemService])
GO
ALTER TABLE [dbo].[tbl_Barcodes] CHECK CONSTRAINT [FK_tbl_Barcodes_tbl_Barcodes]
GO
