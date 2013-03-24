using System.Collections.Generic;
using System.Linq;
using InventoryManager.Models;

namespace InventoryManager.Mappers
{

    public class MapperFabric : MapperHelper
    {
        //public FabricModel MapToFabricModel(FabricFullModel fullModel)
        //{
        //    return new FabricModel()
        //               {

        //               };
        //}

        //public FabricFullModel MapToFullFabricModel(FabricModel fabricModel, string iD)
        //{
        //    return new FabricFullModel()
        //               {
        //               };
        //}

        //public FabricFullModel MapDictionaryToFullFabricModel(Dictionary<string, string> dictionary)
        //{
        //    return new FabricFullModel
        //               {

        //               };

        //}

        //public FabricFullModel MapDictionaryTofullFabricModel(Dictionary<string, string> dictionary)
        //{
        //    var FabricModel = new FabricFullModel();
        //    return FabricModel;
        //}

        public NewFabricModel MapNewFabricModel()
        {
            return new NewFabricModel()
                       {
                           GarmentsFullModel = MapEmptyFabricFullModel()
                       };
        }


        public FabricModel MapEmptyFabricModel()
        {
            return new FabricModel
                       {
                           FabricWidthID = string.Empty,
                           Quantity = string.Empty,
                           WeaveID = string.Empty
                       };
        }

        public FabricFullModel MapEmptyFabricFullModel()
        {
            return new FabricFullModel()
                       {
                           CareID = string.Empty,
                           FabricWidthID = string.Empty,
                           Quantity = string.Empty,
                           WeaveID = string.Empty
                       };
        }

        public List<WeaveModel> MapWeaveModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new WeaveModel
            {
                WeaveID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new WeaveModel()).FirstOrDefault()),
                Weave = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new WeaveModel()).Last())
            }).ToList();
        }

        public List<DryCycleModel> MapDryCycleModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new DryCycleModel
            {
                ID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new DryCycleModel()).FirstOrDefault()),
                DryCycle = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new DryCycleModel()).Last())
            }).ToList();
        }

        public List<DryTempModel> MapDryTempModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new DryTempModel
              {
                  ID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new DryTempModel()).FirstOrDefault()),
                  DryTemp = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new DryTempModel()).Last())
              }).ToList();
        }

        public List<FabricWidthModel> MapFabricWidthModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new FabricWidthModel
            {
                WidthID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new FabricWidthModel()).FirstOrDefault()),
                Width = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new FabricWidthModel()).Last())
            }).ToList();
        }

        public List<FiberPercentModel> MapFiberPercentModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new FiberPercentModel
            {
                PercentID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new FiberPercentModel()).FirstOrDefault()),
                Percent = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new FiberPercentModel()).Last())
            }).ToList();
        }

        public List<FiberTypeModel> MapFiberTypeModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new FiberTypeModel
            {
                FiberID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new FiberTypeModel()).FirstOrDefault()),
                FiberType = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new FiberTypeModel()).Last())
            }).ToList();
        }

        public List<IronTempModel> MapIronTempModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new IronTempModel
            {
                ID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new IronTempModel()).FirstOrDefault()),
                IronTemp = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new IronTempModel()).Last())
            }).ToList();
        }

        public List<WashTypeModel> MapWashTypeModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new WashTypeModel
            {
                ID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new WashTypeModel()).FirstOrDefault()),
                WashType = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new WashTypeModel()).Last())
            }).ToList();
        }

        public List<WashTempModel> MapWashTempModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new WashTempModel
            {
                ID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new WashTempModel()).FirstOrDefault()),
                WashTemp = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new WashTempModel()).Last())
            }).ToList();
        }
    }
}
