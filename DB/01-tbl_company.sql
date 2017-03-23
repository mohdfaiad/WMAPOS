USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_Company]    Script Date: 2/3/2017 2:05:27 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


