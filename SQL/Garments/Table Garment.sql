USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_Garment]    Script Date: 2/16/2013 1:03:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Garment](
	[GarmentID] [int] IDENTITY(1,1) NOT NULL,
	[PatternCompaniesID] [int] NULL,
	[GarmentNameID] [int] NULL,
	[GarmentLocationID] [int] NULL,
	[GarmentGenderID] [int] NULL,
	[GarmentLayerID] [int] NULL,
	[GarmentStoredID] [int] NULL,
	[CustomerID] [int] NULL,
	[GarmentMeasurementsID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[GarmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--ALTER TABLE [dbo].[tbl_Garment]  WITH CHECK ADD  CONSTRAINT [FK_Garment_TrimID] FOREIGN KEY([TrimID])
--REFERENCES [dbo].[tblmm_Trim] ([TrimID])
--GO

--ALTER TABLE [dbo].[tbl_Garment] CHECK CONSTRAINT [FK_Garment_TrimID]
--GO
/*

drop table [tbl_Garment]

*/