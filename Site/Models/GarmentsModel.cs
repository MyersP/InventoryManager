using System.Collections.Generic;

namespace InventoryManager.Models
{
    public class GarmentsModel
    {
        public string PatternCompaniesID { get; set; }
        public string GarmentNameID { get; set; }
        public string GarmentLocationID { get; set; }
        public string GarmentGenderID { get; set; }
        public string GarmentLayerID { get; set; }
        public string GarmentStoredID { get; set; }
        public string CustomerID { get; set; }
        public string GarmentMeasurementsID { get; set; }
    }

    public class GarmentsFullModel : GarmentsModel
    {
        public string GarmentId ;
    }

    public class PatternCompaniesModel
    {
         public string PatternCompaniesID { get; set; }
         public string PatternCompanies { get; set; }
    }

    public class GarmentNameModel
    {
        public string NameID { get; set; }
        public string GarmentName { get; set; }
    }

    public class GarmentEraModel
    {
        public string EraId { get; set; }
        public string GarmentEra { get; set; }
    }
    
    public class GarmentLocationModel
    {
        public string GarmentLocationID { get; set; }
        public string GarmentLocation { get; set; }
    }

    public class GarmentGenderModel
    {
        public string GenderID { get; set; }
        public string GarmentGender { get; set; }
    }

    public class GarmentLayerModel
    {
        public string LayerID { get; set; }
        public string GarmentLayer { get; set; }
    }

    public class ItemSourceModel
    {
        public string ItemSourceID { get; set; }
        public string ItemSource { get; set; }
    }

    public class GarmentUseModel
    {
        public string UseID { get; set; }
        public string  GarmentUse { get; set; }
    }

    public class GamentRegionModel
    {
        public string RegionID { get; set; }
        public string GarmentRegion { get; set; }
    }

    public class EmbelishmentNamesModel
    {
        public string EmbelishmentID { get; set; }
        public string EmbelishmentName { get; set; }
       
    }

    public class GarmentCutNamesModel
    {
        public string GarmentCutNameID { get; set; }
        public string GarmentCutName { get; set; }
    }

    public class ColorModel
    {
        public string ColorID { get; set; }
        public string Color { get; set; }
    }

    public class NewGarmentModel
    {
        public GarmentsFullModel GarmentsFullModel;
        public List<GarmentNameModel> GarmentNameModel;
        public List<PatternCompaniesModel> PatternCompaniesModel;
        public List<GarmentLocationModel> GarmentLocationModel;
        public List<GarmentGenderModel> GarmentGenderModel;
        public List<GarmentLayerModel> GarmentLayerModel;
        public List<GarmentEraModel> GarmentEraModel;
        public List<ItemSourceModel> ItemSourceModel;
        public List<GarmentUseModel> GarmentUseModel;
        public List<GamentRegionModel> GamentRegionModel;
        public List<EmbelishmentNamesModel> EmbelishmentNamesModel;
        public List<GarmentCutNamesModel> GarmentCutNamesModel;
        public List<ColorModel> ColorModel;
    }


}
