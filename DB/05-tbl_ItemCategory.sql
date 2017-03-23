USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_ItemCategory]    Script Date: 2/3/2017 2:05:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ItemCategory](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemCategoryCode] [nvarchar](6) NOT NULL,
	[ItemCategoryNameAr] [nvarchar](255) NULL,
	[ItemCategoryNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_ItemCategorys] PRIMARY KEY CLUSTERED 
(
	[ItemCategoryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_ItemCategory]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemCategory_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_ItemCategory] CHECK CONSTRAINT [FK_tbl_ItemCategory_tbl_Company]
GO


