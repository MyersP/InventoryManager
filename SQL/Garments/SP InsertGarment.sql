USE InventoryManagement;
SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON 
GO

IF OBJECT_ID ( 'CreateGarment', 'P' ) IS NOT NULL 
    DROP PROCEDURE CreateGarment;
GO
-- =============================================
-- Author:		<Author Paul Myers>
-- Create date: <Create Date 2-16-13>
-- Description:	<Description This is a way to insert a garment and all its associated properties>
-- =============================================
CREATE PROCEDURE  CreateGarment
	@GarmentNameID int, 
	@GarmentLocationID int,
	@GarmentGenderID int,
	@GarmentLayerID int,
	@PatternCompaniesID int,  
	@CustomerID int,
	@GarmentMeasurementsID int,
	@GarmentStoredID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO dbo.tbl_Garment (
		GarmentNameID, 
		GarmentLocationID,
		GarmentGenderID,
		GarmentLayerID,
		PatternCompaniesID,  
		CustomerID,
		GarmentMeasurementsID,
		GarmentStoredID)
	VALUES(
		@GarmentNameID, 
		@GarmentLocationID,
		@GarmentGenderID,
		@GarmentLayerID,
		@PatternCompaniesID,  
		@CustomerID,
		@GarmentMeasurementsID,
		@GarmentStoredID
	)
END
GO

