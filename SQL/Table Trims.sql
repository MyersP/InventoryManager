USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tblmm_Trim]    Script Date: 2/16/2013 1:04:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblmm_Trim](
	[TrimID] [int] IDENTITY(1,1) NOT NULL,
	[TrimNameID] [int] NULL,
	[TrimPositionID] [int] NULL,
	[ColorID] [int] NULL,
	[GarmentID] [int] NULL,
	[StorageID] [int] NULL,
	[WeaveID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TrimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/*

drop table [tblmm_Trim]

select * from [tblmm_Trim]
*/