USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_Fabric]    Script Date: 2/6/2013 9:29:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Fabric](
	[FabricID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CareID] [int] NULL,
	[Quantity] [int] NULL,
	[WeaveID] [int] NULL
) ON [PRIMARY]

GO

/*

drop table [tbl_Fabric]

*/