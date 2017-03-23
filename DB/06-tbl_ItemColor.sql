USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_ItemColor]    Script Date: 2/3/2017 2:05:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ItemColor](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemColorCode] [nvarchar](6) NOT NULL,
	[ItemColorNameAr] [nvarchar](255) NULL,
	[ItemColorNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_ItemColors] PRIMARY KEY CLUSTERED 
(
	[ItemColorCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_ItemColor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemColor_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_ItemColor] CHECK CONSTRAINT [FK_tbl_ItemColor_tbl_Company]
GO


