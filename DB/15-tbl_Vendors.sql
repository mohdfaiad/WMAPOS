USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_Vendors]    Script Date: 2/3/2017 2:06:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Vendors](
	[CompanyCode] [nvarchar](4) NULL,
	[VendoreGroupCode] [nvarchar](6) NULL,
	[VendoreCode] [nvarchar](6) NOT NULL,
	[VendoreNameAr] [nvarchar](250) NULL,
	[VendoreNameEn] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Vendors] PRIMARY KEY CLUSTERED 
(
	[VendoreCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_Vendors]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Vendors_tbl_VendorGroup] FOREIGN KEY([VendoreGroupCode])
REFERENCES [dbo].[tbl_VendorGroup] ([VendorGroupCode])
GO

ALTER TABLE [dbo].[tbl_Vendors] CHECK CONSTRAINT [FK_tbl_Vendors_tbl_VendorGroup]
GO


