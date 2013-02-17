USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_GarmentGender]    Script Date: 2/6/2013 10:15:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_GarmentGender](
	[GenderID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[GarmentGender] [nvarchar](50) NULL
) ON [PRIMARY]

GO
-- drop table [tlkp_GarmentGender]

