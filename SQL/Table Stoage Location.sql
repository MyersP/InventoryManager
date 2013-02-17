USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_Storage_Location]    Script Date: 2/6/2013 10:44:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_Storage_Location](
	[InvLocationID] [int]  IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvLocation] [nvarchar](50) NULL
) ON [PRIMARY]

GO

-- Drop table [tlkp_Storage_Location]

