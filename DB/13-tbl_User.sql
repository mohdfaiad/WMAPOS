USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_User]    Script Date: 2/3/2017 2:06:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_User](
	[UserID] [nvarchar](10) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[FullNameA] [nvarchar](250) NULL,
	[FullNameE] [nvarchar](250) NULL,
	[IsCasher] [bit] NULL CONSTRAINT [DF_tbl_User_IsCasher]  DEFAULT ((0)),
	[EnteredBy] [nvarchar](10) NULL,
	[EntryDate] [datetime] NULL,
	[ModefiedBy] [nvarchar](10) NULL,
	[ModefiedDate] [datetime] NULL
) ON [PRIMARY]

GO


