USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_Inventory_Location]    Script Date: 2/6/2013 9:30:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Inventory_Location](
	[InvID] [int]   IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvLocationID] [int] NULL,
	[InvBoxNumber] [nvarchar](50) NULL,
	[invBagged] [bit] NOT NULL
) ON [PRIMARY]

GO

--drop table [tbl_Inventory_Location]