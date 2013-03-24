USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_Care]    Script Date: 2/6/2013 10:01:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_Care](
	[CareID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[WashWring] [bit] NOT NULL,
	[Bleach] [int] NULL,
	[Iron] [bit] NOT NULL,
	[IronSteam] [bit] NOT NULL,
	[DryTempID] [int] NULL,
	[IronTempID] [int] NULL,
	[DryCycleID] [int] NULL,
	[WashTempID] [int] NULL,
	[WashTypeID] [int] NULL
) ON [PRIMARY]

GO
/*

drop table [tlkp_Care]

*/
