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
        public static readonly string GamentNameTablename = "tlkp_GarmentNames";
        public static readonly string GamentNameId = "NameID";
        public static readonly string PatternCompaniesTablename = "tlkp_PatternCompanies";
        public static readonly string PatternCompaniesId = "PatternCompaniesID";
        public static readonly string GarmentLocationTablename = "tlkp_GarmentLocation";
        public static readonly string GarmentLocationId = "GarmentLocationID";
        public static readonly string GarmentGenderTablename = "tlkp_GarmentGender";
        public static readonly string GarmentGenderId = "GenderID";
        public static readonly string GarmentLayersTablename = "tlkp_GarmentLayers";
        public static readonly string GarmentLayersId = "LayerID";
        public static readonly string GarmentEraTablename = "tlkp_GarmentEra";
        public static readonly string GarmentEra = "EraID";
        public static readonly string GarmentUseTablename = "tlkp_GarmentUse";
        public static readonly string GarmentUseId = "UseID";
        public static readonly string GarmentRegionTablename = "tlkp_GarmentRegion";
        public static readonly string GarmentRegionId = "RegionID";
        public static readonly string EmbelishmentNamesTablename = "tlkp_EmbelishmentNames";
        public static readonly string EmbelishmentNamesId = "EmbelishmentID";
        public static readonly string GarmentCutNamesTablename = "tlkp_GarmentCutNames";
        public static readonly string GarmentCutNamesId = "GarmentCutNameID";

   
    }
}