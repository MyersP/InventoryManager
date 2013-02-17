USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_GarmentLocation](GarmentLocation)
     VALUES('Inner')
GO
INSERT INTO [dbo].[tlkp_GarmentLocation](GarmentLocation)
     VALUES('Outer')
GO
INSERT INTO [dbo].[tlkp_GarmentLocation] (GarmentLocation)
     VALUES('Exterior')
GO

select * from [tlkp_GarmentLocation]

