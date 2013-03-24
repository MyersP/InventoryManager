using System;
using System.Collections.Generic;
using InventoryManager.DataAccess;
using InventoryManager.Mappers;
using InventoryManager.Models;

namespace InventoryManager.Builders
{
    public interface IBuilderFabrics
    {
        NewFabricModel BuildFabricsModel();
        List<FabricFullModel> GetFabrics();
    }

    public class BuilderFabrics : TableNames, IBuilderFabrics
    {
        private readonly MapperFabric _mapperFabric = new MapperFabric();
        private readonly MapperShared _mapperShared = new MapperShared();
        private readonly IDataAccess _dataAccess = new DataAccess.DataAccess();

        public List<FabricFullModel> GetFabrics()
        {
            return new List<FabricFullModel>();
        }

        public NewFabricModel BuildFabricsModel()
        {
            var fabricInfoModel = _mapperFabric.MapNewFabricModel();
            fabricInfoModel.FabricInfo = new FabricInfoModel()
                                              {
                                                  // Bleach = GetBleachModel(),
                                                  // WashWring = GetWashWringModel(),
                                                  // Iron = GetIronModel(),
                                                  // IronSteam = GetIronSteamModel(),
                                                  DryCycleModels = GetDryCycleModel(),
                                                  DryTempModels = GetDryTempModel(),
                                                  FabricWidthModels = GetFabricWidthModel(),
                                                  FiberPercentModels = GetFiberPercentModel(),
                                                  FiberTypeModels = GetFiberTypeModel(),
                                                  IronTempModels = GetIronTempModel(),
                                                  WashTempModels = GetWashTempModel(),
                                                  WashTypeModels = GetWashTypeModel(),
                                                  WeaveModels = GetWeaveModel(),
                                                  ColorModels = GetColorModel(),

                                              };
            return fabricInfoModel;
        }

        private List<ColorModel> GetColorModel()
        {
            var dataRecords = _dataAccess.DataSelect(new ColorModel(), ColorTablename, ColorId, string.Empty);
            return _mapperShared.MapColorModel(dataRecords);
        }

        private List<WashTempModel> GetWashTempModel()
        {
            var dataRecords = _dataAccess.DataSelect(new WashTempModel(), WashTempTableName, ID,
                                string.Empty);
            return _mapperFabric.MapWashTempModel(dataRecords);
        }

        private List<WashTypeModel> GetWashTypeModel()
        {
            var dataRecords = _dataAccess.DataSelect(new WashTypeModel(), WashTypeTableName, ID,
                                string.Empty);
            return _mapperFabric.MapWashTypeModel(dataRecords);
        }

        private List<IronTempModel> GetIronTempModel()
        {
            var dataRecords = _dataAccess.DataSelect(new IronTempModel(), IronTempTableName, ID,
                                string.Empty);
            return _mapperFabric.MapIronTempModel(dataRecords);
        }

        private List<FiberTypeModel> GetFiberTypeModel()
        {
            var dataRecords = _dataAccess.DataSelect(new FiberTypeModel(), FiberTypeTableName, FibereId,
                                string.Empty);
            return _mapperFabric.MapFiberTypeModel(dataRecords);
        }

        private List<FiberPercentModel> GetFiberPercentModel()
        {
            var dataRecords = _dataAccess.DataSelect(new FiberPercentModel(), FiberPercenTableName, FiberPercentId,
                                string.Empty);
            return _mapperFabric.MapFiberPercentModel(dataRecords);
        }

        private List<FabricWidthModel> GetFabricWidthModel()
        {
            var dataRecords = _dataAccess.DataSelect(new FabricWidthModel(), WidthTableName, WidthId,
                                string.Empty);
            return _mapperFabric.MapFabricWidthModel(dataRecords);
        }

        private List<DryTempModel> GetDryTempModel()
        {
            var dataRecords = _dataAccess.DataSelect(new DryTempModel(), DryTempTableName, ID,
                                string.Empty);
            return _mapperFabric.MapDryTempModel(dataRecords);
        }

        private List<DryCycleModel> GetDryCycleModel()
        {
            var dataRecords = _dataAccess.DataSelect(new DryCycleModel(), DryCycleTableName, ID,
                                string.Empty);
            return _mapperFabric.MapDryCycleModel(dataRecords);
        }

        //private bool GetIronSteamModel()
        //{
        //    throw new NotImplementedException();
        //}

        //private bool GetIronModel()
        //{
        //    throw new NotImplementedException();
        //}

        //private bool GetWashWringModel()
        //{
        //    throw new NotImplementedException();
        //}

        //private bool GetBleachModel()
        //{
        //  throw new NotImplementedException();
        //}

        private List<WeaveModel> GetWeaveModel()
        {
            var dataRecords = _dataAccess.DataSelect(new WeaveModel(), WeaveTableName, WeaveId,
                                string.Empty);
            return _mapperFabric.MapWeaveModel(dataRecords);
        }
    }
}
