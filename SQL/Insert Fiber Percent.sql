USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_FiberPercent]([percent])
     VALUES('25')
GO
INSERT INTO [dbo].[tlkp_FiberPercent]([percent])
     VALUES('50')
GO
INSERT INTO [dbo].[tlkp_FiberPercent]([percent])
     VALUES('75')
GO
INSERT INTO [dbo].[tlkp_FiberPercent]([percent])
     VALUES('100')
GO
select * from tlkp_FiberPercent
