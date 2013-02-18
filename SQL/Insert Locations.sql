USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_Location](Location)
     VALUES('Inner')
GO
INSERT INTO [dbo].[tlkp_Location](Location)
     VALUES('Outer')
GO
INSERT INTO [dbo].[tlkp_Location] (Location)
     VALUES('Exterior')
GO

select * from [tlkp_Location]

