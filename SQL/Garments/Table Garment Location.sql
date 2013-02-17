USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_GarmetLayers]    Script Date: 2/6/2013 10:37:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_GarmentLocation](
	[GarmentLocationID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[GarmentLocation] [nvarchar](50) NULL
) ON [PRIMARY]

GO
--drop table tlkp_GarmentLocation