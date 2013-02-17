USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_GarmentLayers]    Script Date: 2/6/2013 10:17:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_GarmentLayers](
	[LayerID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[GarmentLayer] [nvarchar](50) NULL
) ON [PRIMARY]

GO
-- drop table [tlkp_GarmentLayers]


