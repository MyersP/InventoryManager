USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_WashTemp]    Script Date: 2/6/2013 10:50:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_WashTemp](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[WashTemp] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO


-- Drop table [tlkp_WashTemp]

