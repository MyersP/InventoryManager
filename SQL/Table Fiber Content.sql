USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_FiberContent]    Script Date: 2/6/2013 9:29:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_FiberContent](
	[FiberID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FiberTypeID] [int] NULL,
	[FiberPercentageID] [int] NULL
) ON [PRIMARY]

GO
/*

drop table [tbl_FiberContent]

*/