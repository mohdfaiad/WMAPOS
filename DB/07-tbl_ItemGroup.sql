USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_ItemGroup]    Script Date: 2/3/2017 2:06:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ItemGroup](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemGroupCode] [nvarchar](6) NOT NULL,
	[ItemGroupNameAr] [nvarchar](255) NULL,
	[ItemGroupNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_ItemGroups] PRIMARY KEY CLUSTERED 
(
	[ItemGroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_ItemGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemGroup_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_ItemGroup] CHECK CONSTRAINT [FK_tbl_ItemGroup_tbl_Company]
GO


