USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_CustomerGroup]    Script Date: 2/3/2017 2:05:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_CustomerGroup](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[CustomerGroupCode] [nvarchar](6) NOT NULL,
	[CustomerGroupNameAr] [nvarchar](255) NULL,
	[CustomerGroupNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_CustomerGroup] PRIMARY KEY CLUSTERED 
(
	[CustomerGroupCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_CustomerGroup]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CustomerGroup_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_CustomerGroup] CHECK CONSTRAINT [FK_tbl_CustomerGroup_tbl_Company]
GO


