USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tblmm_GarmentEras]    Script Date: 2/6/2013 9:30:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblmm_GarmentEras](
	[GarmentEraID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[EraID] [int] NULL,
	[GarmentID] [int] NULL
) ON [PRIMARY]

GO
/*

drop table [tblmm_GarmentEras]

select * from [tblmm_GarmentEras]
*/