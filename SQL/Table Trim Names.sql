USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_TrimNames]    Script Date: 2/6/2013 9:30:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_TrimNames](
	[TrimNameID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[TrimName] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/*

drop table [tlkp_TrimNames]

*/