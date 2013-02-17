USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_WashType]([WashType])
     VALUES ('Do Not Wash')
GO
INSERT INTO [dbo].[tlkp_WashType]([WashType])
     VALUES ('Delicate')
GO
INSERT INTO [dbo].[tlkp_WashType]([WashType])
     VALUES ('Hand Wash')
GO
INSERT INTO [dbo].[tlkp_WashType]([WashType])
     VALUES ('Normal')
GO
INSERT INTO [dbo].[tlkp_WashType]([WashType])
     VALUES ('Permanent Press')
GO
INSERT INTO [dbo].[tlkp_WashType]([WashType])
     VALUES ('Dry Clean Only')
GO


select * from [tlkp_WashType]



