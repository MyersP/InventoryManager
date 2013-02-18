USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_Patterns]    Script Date: 2/16/2013 1:03:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Patterns](
	[PatternID] [int] IDENTITY(1,1) NOT NULL,
	[PatternNumberID] [int] NULL,
	[PatternNameID] [int] NULL,
	[PatternLocationID] [int] NULL,
	[PatternGenderID] [int] NULL,
	[PatternLayerID] [int] NULL,
	[PatternStoredID] [int] NULL,
	[CustomerID] [int] NULL,
	[PatternMeasurementsID] [int] NULL,
	[PatternNumber] [nvarchar](50) NULL,
	[ManufacturerPatternNumber] [nvarchar](50) NULL,
	[PatternCompany] [nvarchar](50) NULL
PRIMARY KEY CLUSTERED 
(
	[PatternID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/*

drop table [tbl_Patterns]

*/