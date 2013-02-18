USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_CutNames]    Script Date: 2/6/2013 9:30:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_CutNames](
	[CutNameID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CutName] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/*

drop table [tlkp_CutNames]

*/