USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_DryTemp]([DryTemp])
     VALUES ('Normal')
GO

INSERT INTO [dbo].[tlkp_DryTemp]([DryTemp])
     VALUES ('Delicate Gentle')
GO

INSERT INTO [dbo].[tlkp_DryTemp]([DryTemp])
     VALUES ('Permanent Press')
GO
select * from [tlkp_DryTemp]