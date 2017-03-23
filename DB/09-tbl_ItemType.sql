USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_ItemType]    Script Date: 2/3/2017 2:06:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ItemType](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemTypeCode] [nvarchar](6) NOT NULL,
	[ItemTypeNameAr] [nvarchar](255) NULL,
	[ItemTypeNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_ItemTypes] PRIMARY KEY CLUSTERED 
(
	[ItemTypeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_ItemType]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemType_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_ItemType] CHECK CONSTRAINT [FK_tbl_ItemType_tbl_Company]
GO


