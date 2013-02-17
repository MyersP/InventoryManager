USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_FiberType]    Script Date: 2/6/2013 10:13:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_FiberType](
	[FiberID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FiberType] [nvarchar](50) NULL
) ON [PRIMARY]

GO

/*

drop table [tlkp_FiberType]

*/
