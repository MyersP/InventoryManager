USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tlkp_Color]    Script Date: 2/6/2013 10:23:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tlkp_Color](
	[ColorID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Color] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/*

drop table [tlkp_Color]


*/