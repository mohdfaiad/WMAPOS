USE [WMAPOS]
GO

/****** Object:  Table [dbo].[tbl_Branch]    Script Date: 2/3/2017 2:05:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Branch](
	[CompanyCode] [nvarchar](4) NOT NULL,
	[BranchCode] [nvarchar](4) NOT NULL,
	[BranchNameAr] [nvarchar](250) NULL,
	[BranchNameEn] [nvarchar](250) NULL,
 CONSTRAINT [PK_tbl_Branch] PRIMARY KEY CLUSTERED 
(
	[BranchCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbl_Branch]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Branch_tbl_Company] FOREIGN KEY([CompanyCode])
REFERENCES [dbo].[tbl_Company] ([CompanyCode])
GO

ALTER TABLE [dbo].[tbl_Branch] CHECK CONSTRAINT [FK_tbl_Branch_tbl_Company]
GO


