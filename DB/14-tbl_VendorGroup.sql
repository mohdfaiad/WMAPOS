USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_VendorGroup]    Script Date: 2/3/2017 2:06:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_VendorGroup](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[VendorGroupCode] [nvarchar](6) NOT NULL,
	[VendoreNameAr] [nvarchar](255) NULL,
	[VendoreNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_VendorGroup] PRIMARY KEY CLUSTERED 
(
	[VendorGroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_VendorGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_VendorGroup_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_VendorGroup] CHECK CONSTRAINT [FK_tbl_VendorGroup_tbl_Company]
GO


