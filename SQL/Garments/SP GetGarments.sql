


USE InventoryManagement;


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
GO
IF OBJECT_ID ( 'GetGarments', 'P' ) IS NOT NULL 
    DROP PROCEDURE GetGarments;
GO
-- =============================================
-- Author:		<Author Paul Myers>
-- Create date: <Create Date 2-16-13>
-- Description:	<Description This is a way to get a garment and all its associated properties>
-- =============================================
CREATE PROCEDURE  GetGarments
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT g.GarmentID
      ,gr.GarmentRegion
      ,ge.GarmentEra
      ,gu.GarmentUse
      ,pc.PatternCompanies
	  ,cn.CutName	  
      ,i.ItemSource
      ,gn.GarmentName
      ,glo.GarmentLocation
      ,gg.GarmentGender
      ,gla.GarmentLayer
      ,sl.InvLocation
      ,co.FirstName
	  ,co.LastName
      ,g.CareInstructionsID
	  ,g.GarmentMeasurementsID

  FROM dbo.tbl_Garment g

JOIN dbo.tlkp_GarmentRegion gr ON gr.RegionID = g.RegionID
JOIN dbo.tlkp_GarmentEra ge ON ge.EraID = g.EraID
JOIN dbo.tlkp_GarmentUse gu ON gu.UseID = g.UseID
JOIN dbo.tlkp_PatternCompanies pc ON pc.PatternCompaniesID = g.PatternCompaniesID

JOIN dbo.tblmm_Cuts cu ON cu.GarmentID = g.GarmentID
JOIN dbo.tlkp_CutNames cn ON cn.CutNameID = cu.CutID

JOIN dbo.tlkp_GarmentNames gn ON gn.NameID = g.GarmentNameID
JOIN dbo.tlkp_ItemSource i ON i.ItemSourceID = g.ItemSourceID
JOIN dbo.tlkp_GarmentLocation glo ON glo.GarmentLocationID = g.GarmentLocationID
JOIN dbo.tlkp_GarmentGender gg ON gg.GenderID =  g.GarmentGenderID
JOIN dbo.tlkp_GarmentLayers gla ON gla.LayerID =  g.GarmentLayerID

JOIN dbo.tbl_Storage s ON s.InvID = g.GarmentStoredID
JOIN dbo.tlkp_Storage_Location sl ON sl.InvLocationID = s.InvLocationID

JOIN dbo.tbl_Contacts co ON co.ID = g.CustomerID

END
GO

