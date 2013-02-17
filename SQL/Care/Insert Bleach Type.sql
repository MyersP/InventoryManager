USE [InventoryManagement]
GO

INSERT INTO [dbo].[tlkp_BleachType]
           ([BleachType])
     VALUES
           ('Do Not Bleach')
GO
INSERT INTO [dbo].[tlkp_BleachType]
           ([BleachType])
     VALUES
           ('Only Bleach When Needed')
GO
INSERT INTO [dbo].[tlkp_BleachType]
           ([BleachType])
     VALUES
           ('Non Chlorine Bleach When Needed')
GO

select * from [tlkp_BleachType]

--1	Do Not Bleach
--2	Only Bleach When Needed
--3	Non Chlorine Bleach When Needed

