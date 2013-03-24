USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_FiberPercent]    Script Date: 2/6/2013 10:09:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_FiberPercent](
	[PercentID] [int]  IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Percent] [int] NULL
) ON [PRIMARY]

GO
/*

 drop table [tlkp_FiberPercent]

 */

