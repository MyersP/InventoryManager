USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_IronTemp]    Script Date: 2/6/2013 10:41:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_IronTemp](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[IronTemp] [nvarchar](50) NULL
) ON [PRIMARY]

GO

-- drop table [tlkp_IronTemp]
