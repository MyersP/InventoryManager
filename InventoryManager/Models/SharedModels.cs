

using System.Collections.Generic;

namespace InventoryManager.Models
{

    public class PatternNumbers
    {
        public string PatternCompaniesID { get; set; }
        public string PatternCompanies { get; set; }
    }

    public class NameModel
    {
        public string NameID { get; set; }
        public string Name { get; set; }
    }

    public class EraModel
    {
        public string EraId { get; set; }
        public string Era { get; set; }
    }

    public class LocationModel
    {
        public string LocationID { get; set; }
        public string Location { get; set; }
    }

    public class GenderModel
    {
        public string GenderID { get; set; }
        public string Gender { get; set; }
    }

    public class LayerModel
    {
        public string LayerID { get; set; }
        public string Layer { get; set; }
    }

    public class ItemSourceModel
    {
        public string ItemSourceID { get; set; }
        public string ItemSource { get; set; }
    }

    public class UsesModel
    {
        public string UsesID { get; set; }
        public string Uses { get; set; }
    }

    public class RegionModel
    {
        public string RegionID { get; set; }
        public string Region { get; set; }
    }

    public class EmbelishmentNamesModel
    {
        public string EmbelishmentID { get; set; }
        public string EmbelishmentName { get; set; }

    }

    public class CutNamesModel
    {
        public string CutNameID { get; set; }
        public string CutName { get; set; }
    }

    public class ColorModel
    {
        public string ColorID { get; set; }
        public string Color { get; set; }
    }

    public class SharedInfoModel
    {
        public List<PatternNumbers> PatternNumbersModel;
        public List<NameModel> NameModel;
        public List<LocationModel> LocationModel;
        public List<GenderModel> GenderModel;
        public List<LayerModel> LayerModel;
        public List<EraModel> EraModel;
        public List<ItemSourceModel> ItemSourceModel;
        public List<UsesModel> UsesModel;
        public List<RegionModel> RegionModel;
        public List<EmbelishmentNamesModel> EmbelishmentNamesModel;
        public List<CutNamesModel> CutNamesModel;
        public List<ColorModel> ColorModel;
    }

}