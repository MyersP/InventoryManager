using System.Collections.Generic;

namespace InventoryManager.Models
{
    public class CareModel
    {
        public bool WashWring { get; set; }
        public bool Bleach { get; set; }
        public bool Iron { get; set; }
        public bool IronSteam { get; set; }
        public string DryTempID { get; set; }
        public string IronTempID { get; set; }
        public string DryCycleID { get; set; }
        public string WashTempID { get; set; }
        public string WashTypeID { get; set; }
    }

    public class CareFullModel : CareModel
    {
        public string CareID;
    }

    public class IronTempModel
    {
        public string ID { get; set; }
        public string IronTemp { get; set; }
    }

    public class DryTempModel
    {
        public string ID { get; set; }
        public string DryTemp  { get; set; }
    }

    public class WashTypeModel
    {
        public string ID { get; set; }
        public string WashType { get; set; }
    }

    public class WashTempModel
    {
        public string ID { get; set; }
        public string WashTemp { get; set; }
    }

    public class DryCycleModel
    {
        public string ID { get; set; }
        public string DryCycle { get; set; }
    }


}