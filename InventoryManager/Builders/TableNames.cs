using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManager.Builders
{
    public class TableNames
    {
        //Contacts
        public static readonly string ContactsTablename = "tbl_Contacts";
        public static readonly string ContactsId = "ID";

        //CustomerType
        public static readonly string CustomerTypeTablename = "tlkp_CustomerType";

        //Garments
        public static readonly string GarmentTableName = "tbl_Garment";
        public static readonly string GarmentId = "GarmentID";
        public static readonly string GarmentsCustomerId = "CustomerID";

        public static readonly string ColorTablename = "tlkp_Color";
        public static readonly string ColorId = "ColorID";
        public static readonly string ItemSourceTablename = "tlkp_ItemSource";
        public static readonly string ItemSourceId = "ItemSourceID";
        public static readonly string NameTablename = "tlkp_Names";
        public static readonly string NameId = "NameID";
        public static readonly string PatternCompaniesTablename = "tlkp_PatternCompanies";
        public static readonly string PatternCompaniesId = "PatternCompaniesID";
        public static readonly string LocationTablename = "tlkp_Location";
        public static readonly string LocationId = "LocationID";
        public static readonly string GenderTablename = "tlkp_Gender";
        public static readonly string GenderId = "GenderID";
        public static readonly string LayersTablename = "tlkp_Layers";
        public static readonly string LayersId = "LayerID";
        public static readonly string EraTablename = "tlkp_Era";
        public static readonly string Era = "EraID";
        public static readonly string UsesTablename = "tlkp_Uses";
        public static readonly string UsesId = "UseID";
        public static readonly string RegionTablename = "tlkp_Region";
        public static readonly string RegionId = "RegionID";
        public static readonly string EmbelishmentNamesTablename = "tlkp_EmbelishmentNames";
        public static readonly string EmbelishmentNamesId = "EmbelishmentID";
        public static readonly string CutNamesTablename = "tlkp_CutNames";
        public static readonly string CutNamesId = "CutNameID";

   
    }
}