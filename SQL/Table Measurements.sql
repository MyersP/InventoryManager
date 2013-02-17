USE [InventoryManagement]
GO

/****** Object:  Table [dbo].[tbl_Measurements]    Script Date: 2/6/2013 9:30:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Measurements](
	[Sizeid] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[sholderslope] [int] NULL,
	[shoulderwidthfront] [int] NULL,
	[bustheight] [int] NULL,
	[bustfull] [int] NULL,
	[bustbelow] [int] NULL,
	[waist] [int] NULL,
	[hiphigh] [int] NULL,
	[hipfull] [int] NULL,
	[thighleft] [int] NULL,
	[thighright] [int] NULL,
	[waistknee] [int] NULL,
	[waistrightfloor] [int] NULL,
	[waistleftfloor] [int] NULL,
	[cfwaistfloor] [int] NULL,
	[frontclavacletowaist] [int] NULL,
	[frontbusthighwaist] [int] NULL,
	[frontbustfullwaist] [int] NULL,
	[apexwidth] [int] NULL,
	[apexwaistsloperight] [int] NULL,
	[apexwaistslpoeleft] [int] NULL,
	[frontbustlowwaist] [int] NULL,
	[bicepright] [int] NULL,
	[bicepleft] [int] NULL,
	[elbowright] [int] NULL,
	[elbowleft] [int] NULL,
	[forearmright] [int] NULL,
	[forarmleft] [int] NULL,
	[wristright] [int] NULL,
	[wristleft] [int] NULL,
	[knee] [int] NULL,
	[calfleft] [int] NULL,
	[calfright] [int] NULL,
	[cervicalwasit] [int] NULL,
	[shoulderwidthback] [int] NULL,
	[shoulderwidthlowback] [int] NULL,
	[shoulderbladewidth] [int] NULL,
	[shoulderwaistslopeleft] [int] NULL,
	[shoulderwaistsloperight] [int] NULL,
	[shoulderelboright] [int] NULL,
	[shoulderelbowleft] [int] NULL,
	[elbowwristright] [int] NULL,
	[elbowwristleft] [int] NULL,
	[waisttohighknee] [int] NULL,
	[waisttolowknee] [int] NULL,
	[wasitcalf] [int] NULL,
	[waistankle] [int] NULL,
	[height] [int] NULL,
	[weight] [int] NULL
) ON [PRIMARY]

GO
--drop table [tbl_Measurements]
