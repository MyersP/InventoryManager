using System.Collections.Generic;

namespace InventoryManager.Models
{
    public class FabricModel
    {
        public string CareID { get; set; }
        public string Quantity { get; set; }
        public string WeaveID { get; set; }
        public string FabricWidthID { get; set; }
    }

    public class FabricFullModel : FabricModel
    {
        public string FabricId;
    }

    public class WeaveModel
    {
        public string WeaveID { get; set; }
        public string Weave { get; set; }
    }

    public class FabricWidthModel
    {
        public string WidthID { get; set; }
        public string Width { get; set; }
    }

    public class NewFabricModel
    {
        public FabricFullModel GarmentsFullModel;
        public FabricInfoModel FabricInfo;
    }

    public class FabricPostBackModel
    {
        public string FiberPercent { get; set; }
        public string FiberType { get; set; }
        public string WashType { get; set; }
        public string DryCycle { get; set; }
        public string DryTemp { get; set; }
        public string IronTemp { get; set; }
        public string WashTemp { get; set; }
        public string Weave { get; set; }
        public string FabricWidthM { get; set; }
        public string WashWring { get; set; }
        public string Bleach { get; set; }
        public string Iron { get; set; }
        public string IronSteam { get; set; }
    }

    public class FabricInfoModel
    {
        public List<FiberPercentModel> FiberPercentModels;
        public List<FiberTypeModel> FiberTypeModels;
        public List<WashTypeModel> WashTypeModels;
        public List<DryCycleModel> DryCycleModels;
        public List<DryTempModel> DryTempModels;
        public List<IronTempModel> IronTempModels;
        public List<WashTempModel> WashTempModels;
        public List<WeaveModel> WeaveModels;
        public List<FabricWidthModel> FabricWidthModels;
        public List<ColorModel> ColorModels;
        //public bool WashWring;
        //public bool Bleach;
        //public bool Iron;
        //public bool IronSteam;
    }

}