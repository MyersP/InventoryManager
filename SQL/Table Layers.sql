USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_Layers]    Script Date: 2/6/2013 10:17:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_Layers](
	[LayerID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Layer] [nvarchar](50) NULL
) ON [PRIMARY]

GO

/*

 drop table [tlkp_Layers]


 */