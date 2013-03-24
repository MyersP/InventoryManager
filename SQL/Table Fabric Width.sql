USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_FabricWidth]    Script Date: 3/23/2013 3:43:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_FabricWidth](
	[WidthID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Width] [int] NULL
) ON [PRIMARY]

GO
/*

drop table [tlkp_FabricWidth]


*/