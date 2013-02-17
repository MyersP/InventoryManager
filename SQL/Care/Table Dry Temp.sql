USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_DryTemp]    Script Date: 2/6/2013 10:07:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_DryTemp](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[DryTemp] [nvarchar](50) NULL
) ON [PRIMARY]

GO


-- drop table [tlkp_DryTemp]