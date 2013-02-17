USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_BleachType]    Script Date: 2/6/2013 9:30:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_BleachType](
	[ID] [int]IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[BleachType] [nvarchar](50) NULL
) ON [PRIMARY]

GO
--drop table [tlkp_BleachType]
