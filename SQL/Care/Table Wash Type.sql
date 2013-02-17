USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_WashType]    Script Date: 2/6/2013 10:51:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_WashType](
	[ID] [int]  IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[WashType] [nvarchar](50) NULL
) ON [PRIMARY]

GO


-- drop table [tlkp_WashType]