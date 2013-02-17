USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tblmm_TrimContent]    Script Date: 2/6/2013 9:30:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblmm_TrimContent](
	[TrimContentID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FiberContentID] [int] NULL,
	[TrimID] [int] NULL
) ON [PRIMARY]

GO
--drop table [tblmm_TrimContent]
