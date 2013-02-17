USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_CustomerSizes]    Script Date: 2/6/2013 10:03:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_CustomerSizes](
	[CustomerSizeID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[SizeID] [int] NULL,
	[CustomerID] [int] NULL,
	[date] [datetime] NOT NULL
) ON [PRIMARY]

GO

--drop table [tlkp_CustomerSizes]
