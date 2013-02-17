USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_IronTemp]([IronTemp])
     VALUES ('Low (230F)')
GO
INSERT INTO [dbo].[tlkp_IronTemp]([IronTemp])
     VALUES ('Medium (150F)')
GO
INSERT INTO [dbo].[tlkp_IronTemp]([IronTemp])
     VALUES ('High (390F)')
GO
select * from tlkp_IronTemp