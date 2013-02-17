USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_Contacts]    Script Date: 2/6/2013 9:29:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Contacts](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CustomerType] [nvarchar](50) NULL,
	[FirstName] [nvarchar](30) NULL,
	[LastName] [nvarchar](50) NULL,
	[EmailAddress] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](30) NULL,
	[MobleNumber] [nvarchar](30) NULL,
	[BillingAddress] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[StateOrProvince] [nvarchar](20) NULL,
	[CountryRegion] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](20) NULL
) ON [PRIMARY]

GO

--Drop table [tbl_Contacts]
