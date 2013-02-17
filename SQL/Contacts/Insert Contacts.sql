USE [InventoryManagement]
GO

INSERT INTO [dbo].[tbl_Contacts]
 ([CustomerType],[FirstName],[LastName],[EmailAddress],[PhoneNumber],
 [MobleNumber],[BillingAddress],[City],[StateOrProvince],[CountryRegion],[PostalCode])
     VALUES
('Family','Adrienne','Myers','eggiebert@hotmail.com','206-244-5835',
'206-344-5835','447 S 206 th ST','DesMoines','WA','USA','98198')

GO
INSERT INTO [dbo].[tbl_Contacts]
     VALUES
('Family','Paul','Myers','Myers.Paul@gmail.com','206-920-4980',
'206-920-4980','447 S 206 th ST','DesMoines','WA','USA','98198')

--ID	CustomerType	FirstName	LastName	EmailAddress	PhoneNumber	MobleNumber	BillingAddress	City	StateOrProvince	CountryRegion	PostalCode
--27	Family	Adrienne	Myers	eggiebert@hotmail.com	206-244-5835	206-344-5835	447 S 206 th ST	DesMoines	WA	USA	98198
--29	Family	Paul	Myers	Myers.Paul@gmail.com	206-920-4980	206-920-4980	447 S 206 th ST	DesMoines	WA	USA	98198

--delete from [dbo].[tbl_Contacts]
--select * from [dbo].[tbl_Contacts]