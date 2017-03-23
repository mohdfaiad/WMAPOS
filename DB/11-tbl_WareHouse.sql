USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_WareHouse]    Script Date: 2/3/2017 2:06:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_WareHouse](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[WareHouseCode] [nvarchar](6) NOT NULL,
	[WareHouseNameAr] [nvarchar](250) NULL,
	[WareHouseNameEn] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_WareHouse] PRIMARY KEY CLUSTERED 
(
	[WareHouseCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_WareHouse]  WITH CHECK ADD  CONSTRAINT [FK_tbl_WareHouse_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_WareHouse] CHECK CONSTRAINT [FK_tbl_WareHouse_tbl_Company]
GO


