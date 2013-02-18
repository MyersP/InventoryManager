using System.Collections.Generic;

namespace InventoryManager.Models
{
    public class GarmentsModel
    {
        public string PatternNumberID { get; set; }
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


    public class NewGarmentModel
    {
        public GarmentsFullModel GarmentsFullModel;
        public SharedInfoModel GarmentInfo;


    }


}