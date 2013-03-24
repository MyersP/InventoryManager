using InventoryManager.DataAccess;

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
        public static readonly string PatternCompaniesId = "PatternNumberID";
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

        public static readonly string TrimNamesTablename = "tlkp_TrimNames";
        public static readonly string TrimNamesId = "TrimNameID";

        public static readonly string FabricTableName = "tbl_Fabric";
        public static readonly string FabricId = "FabricID";
        public static readonly string WeaveTableName = "tlkp_Weave";
        public static readonly string WeaveId = "WeaveID";
        public static readonly string WidthTableName = "tlkp_FabricWidth";
        public static readonly string WidthId = "WidthID";

        public static readonly string CareTableName = "tlkp_Care";
        public static readonly string CareId = "CareID";
        public static readonly string FiberTableName = "tbl_FiberContent";
        public static readonly string FibereId = "FiberID";

        public static readonly string DryTempTableName = "tlkp_DryTemp";
        public static readonly string DryCycleTableName = "tlkp_DryCycle";
        public static readonly string WashTempTableName = "tlkp_WashTemp";
        public static readonly string WashTypeTableName = "tlkp_WashType";
        public static readonly string IronTempTableName = "tlkp_IronTemp";
        public static readonly string ID = "ID";

        public static readonly string FiberPercenTableName = "tlkp_FiberPercent";
        public static readonly string FiberPercentId = "PercentID";
        public static readonly string FiberTypeTableName = "tlkp_FiberType";
        public static readonly string FiberId = "FiberID";
    }
}