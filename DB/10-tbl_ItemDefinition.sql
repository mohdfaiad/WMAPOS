USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_ItemDefinition]    Script Date: 2/3/2017 2:05:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_ItemDefinition](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[ItemCode] [nvarchar](6) NOT NULL,
	[ItemNameAr] [nvarchar](255) NULL,
	[ItemNameEn] [nvarchar](255) NULL,
	[ItemGroupCode] [nvarchar](6) NOT NULL,
	[ItemTypeCode] [nvarchar](6) NOT NULL,
	[ItemCategoryCode] [nvarchar](6) NOT NULL,
	[ItemSizeCode] [nvarchar](6) NOT NULL,
	[ItemColorCode] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_tbl_ItemDefinition] PRIMARY KEY CLUSTERED 
(
	[ItemCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_Company]
GO

ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemCategory] FOREIGN KEY([ItemCategoryCode])
REFERENCES [dbo].[tbl_ItemCategory] ([ItemCategoryCode])
GO

ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemCategory]
GO

ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemColor] FOREIGN KEY([ItemColorCode])
REFERENCES [dbo].[tbl_ItemColor] ([ItemColorCode])
GO

ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemColor]
GO

ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemGroup] FOREIGN KEY([ItemGroupCode])
REFERENCES [dbo].[tbl_ItemGroup] ([ItemGroupCode])
GO

ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemGroup]
GO

ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemSize] FOREIGN KEY([ItemSizeCode])
REFERENCES [dbo].[tbl_ItemSize] ([ItemSizeCode])
GO

ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemSize]
GO

ALTER TABLE [dbo].[tbl_ItemDefinition]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemType] FOREIGN KEY([ItemTypeCode])
REFERENCES [dbo].[tbl_ItemType] ([ItemTypeCode])
GO

ALTER TABLE [dbo].[tbl_ItemDefinition] CHECK CONSTRAINT [FK_tbl_ItemDefinition_tbl_ItemType]
GO


