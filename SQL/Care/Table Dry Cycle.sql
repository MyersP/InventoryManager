USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_DryCycle]    Script Date: 2/6/2013 10:04:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_DryCycle](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[DryCycle] [nvarchar](50) NULL
) ON [PRIMARY]

GO

--drop table [tlkp_DryCycle]
