USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_FiberPercent]([Percent])
     VALUES('25')
GO
INSERT INTO [dbo].[tlkp_FiberPercent]([Percent])
     VALUES('50')
GO
INSERT INTO [dbo].[tlkp_FiberPercent]([Percent])
     VALUES('75')
GO
INSERT INTO [dbo].[tlkp_FiberPercent]([Percent])
     VALUES('100')
GO
select * from tlkp_FiberPercent
