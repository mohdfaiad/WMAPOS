USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_operators]    Script Date: 2/3/2017 2:06:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_operators](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[OperatorCode] [nvarchar](6) NOT NULL,
	[OperatorNameAr] [nvarchar](255) NULL,
	[OperatorNameEn] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_operator] PRIMARY KEY CLUSTERED 
(
	[OperatorCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_operators]  WITH CHECK ADD  CONSTRAINT [FK_tbl_operators_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_operators] CHECK CONSTRAINT [FK_tbl_operators_tbl_Company]
GO


