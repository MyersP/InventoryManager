using System.Collections.Generic;

namespace InventoryManager.Models
{
    public class FiberContentModel
    {
        public string FiberTypeID { get; set; }
        public string FiberPercentageID { get; set; }
    }

    public class FiberContentFullModel : FiberContentModel
    {
        public string FiberID;
    }

    public class FiberPercentModel
    {
        public string PercentID { get; set; }
        public string Percent { get; set; }
    }

    public class FiberTypeModel
    {
        public string FiberID { get; set; }
        public string FiberType { get; set; }
    }
}