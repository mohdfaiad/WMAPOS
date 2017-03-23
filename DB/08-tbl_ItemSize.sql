USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_ItemSize]    Script Date: 2/3/2017 2:06:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ItemSize](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemSizeCode] [nvarchar](6) NOT NULL,
	[ItemSizeNameAr] [nvarchar](255) NULL,
	[ItemSizeNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_ItemSizes] PRIMARY KEY CLUSTERED 
(
	[ItemSizeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_ItemSize]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemSize_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_ItemSize] CHECK CONSTRAINT [FK_tbl_ItemSize_tbl_Company]
GO


