USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Hall Closet')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Rack 1')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Rack 2')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Red Trunk')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Blue Trunk')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Wardrobe Trunk')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Garage Dresser')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('Delivered')
GO
INSERT INTO [dbo].[tlkp_Storage_Location] ([InvLocation])
     VALUES ('In Work')
GO

select * from [tlkp_Storage_Location]