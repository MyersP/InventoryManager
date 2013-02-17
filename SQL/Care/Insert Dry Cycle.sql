USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_DryCycle] ([DryCycle])
     VALUES ('Do Not Dry')
GO
INSERT INTO [dbo].[tlkp_DryCycle]([DryCycle])
     VALUES('In Shade')
GO
INSERT INTO [dbo].[tlkp_DryCycle]([DryCycle])
     VALUES('Drip Dry')
GO
INSERT INTO [dbo].[tlkp_DryCycle]([DryCycle])
     VALUES('No Heat/Air')
GO
INSERT INTO [dbo].[tlkp_DryCycle]([DryCycle])
     VALUES ('low')
GO
INSERT INTO [dbo].[tlkp_DryCycle]([DryCycle])
     VALUES ('Medium')
GO
INSERT INTO [dbo].[tlkp_DryCycle] ([DryCycle])
     VALUES ('High')
GO
INSERT INTO [dbo].[tlkp_DryCycle] ([DryCycle])
     VALUES ('Any Heat')
GO
select * from tlkp_DryCycle