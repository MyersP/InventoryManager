using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using InventoryManager.DataAccess;
using InventoryManager.Mappers;
using InventoryManager.Models;

namespace InventoryManager.Builders
{
    public interface IBuilderGarments
    {
        void UpdateGarment(GarmentsFullModel newGarment);
        void DeleteGarment(string garmentId);
        void EnterNewGarment(GarmentsModel newGarment);
        List<GarmentsFullModel> GetGarments(string garmentId = "");
        NewGarmentModel BuildGarmentsModel();
    }

    internal class BuilderGarments : TableNames, IBuilderGarments
    {
        private readonly IDataAccess _dataAccess = new DataAccess.DataAccess();
        private readonly IMapperGarments _mapperGarments = new MapperGarments();
        private readonly IMapperShared _mapperShared = new MapperShared();

        public void UpdateGarment(GarmentsFullModel newGarment)
        {
            _dataAccess.DataUpdate(newGarment, GarmentTableName, GarmentId, Convert.ToInt32(newGarment.GarmentId));
        }

        public void DeleteGarment(string garmentId)
        {
            _dataAccess.DataDelete(GarmentTableName, GarmentId, garmentId);
        }

        public void EnterNewGarment(GarmentsModel newGarment)
        {
            _dataAccess.DataInsert(newGarment, GarmentTableName);
        }

        public List<GarmentsFullModel> GetGarments(string garmentId = "")
        {

            return new List<GarmentsFullModel> {_mapperGarments.MapEmptyGarmentsFullModel()};
            //var garmentModel = new GarmentsModel();
            //var dataRecords = _dataAccess.DataSelect(garmentModel, GarmentTableName, GarmentId, garmentId);
            //return dataRecords.Select(_mapperGarments.MapDictionaryTofullGarmentsModel).ToList();
        }

        public NewGarmentModel BuildGarmentsModel()
        {
            var newGarmentModel = _mapperGarments.MapEmptyNewGarmentModel();
            newGarmentModel.GarmentInfo = new SharedInfoModel()
                                              {
                                                  ColorModel = GetColors(),
                                                  CutNamesModel = GetCutNames(),
                                                  EmbelishmentNamesModel = GetEmbelishMents(),
                                                  RegionModel = GetRegions(),
                                                  EraModel = GetEras(),
                                                  GenderModel = GetGenders(),
                                                  LayerModel = GetLayers(),
                                                  LocationModel = GetGarmentLocations(),
                                                  NameModel = GetGarmentNames(),
                                                  UsesModel = GetUses(),
                                                  ItemSourceModel = GetSources(),
                                                  PatternNumbersModel = GetPatterns(), 
                                                  TrimModel = GetTrims(),
                                                  BasicContactsModel = GetBasicContacts()
                                              };
            return newGarmentModel;
        }

        private List<BasicContactsModel> GetBasicContacts()
        {
            var dataRecords = _dataAccess.DataSelect(new ContactsFullModel(), ContactsTablename, ContactsId,
                              string.Empty);
            return _mapperShared.MapBasicContactsModel(dataRecords);
        }

        private List<TrimModel> GetTrims()
        {
            var dataRecords = _dataAccess.DataSelect(new TrimModel(), TrimNamesTablename, TrimNamesId,
                                          string.Empty);
            return _mapperShared.MapTrimModel(dataRecords);
        }

        private List<PatternNumbersModel> GetPatterns()
        {
            var dataRecords = _dataAccess.DataSelect(new PatternNumbersModel(), PatternCompaniesTablename, PatternCompaniesId,
                                          string.Empty);
            return _mapperShared.MapPatternModel(dataRecords);
        }

        private List<ItemSourceModel> GetSources()
        {
            var dataRecords = _dataAccess.DataSelect(new ItemSourceModel(), ItemSourceTablename, ItemSourceId,
                                                     string.Empty);
            return _mapperShared.MapItemSourceModel(dataRecords);
        }

        private List<UsesModel> GetUses()
        {
            var dataRecords = _dataAccess.DataSelect(new UsesModel(), UsesTablename, UsesId, string.Empty);
            return _mapperShared.MapUseModel(dataRecords);
        }

        private List<NameModel> GetGarmentNames()
        {
            var dataRecords = _dataAccess.DataSelect(new NameModel(), NameTablename, NameId, string.Empty);
            return _mapperShared.MapNameModel(dataRecords);
        }

        private List<LocationModel> GetGarmentLocations()
        {
            var dataRecords = _dataAccess.DataSelect(new LocationModel(), LocationTablename, LocationId,
                                                     string.Empty);
            return _mapperShared.MapLocationModel(dataRecords);
        }

        private List<LayerModel> GetLayers()
        {
            var dataRecords = _dataAccess.DataSelect(new LayerModel(), LayersTablename, LayersId,
                                                     string.Empty);
            return _mapperShared.MapLayerModel(dataRecords);
        }

        private List<GenderModel> GetGenders()
        {
            var dataRecords = _dataAccess.DataSelect(new GenderModel(), GenderTablename, GenderId,
                                                     string.Empty);
            return _mapperShared.MapGenderModel(dataRecords);
        }

        private List<EraModel> GetEras()
        {
            var dataRecords = _dataAccess.DataSelect(new EraModel(), EraTablename, Era, string.Empty);
            return _mapperShared.MapEraModel(dataRecords);
        }

        private List<RegionModel> GetRegions()
        {
            var dataRecords = _dataAccess.DataSelect(new RegionModel(), RegionTablename, RegionId,
                                                     string.Empty);
            return _mapperShared.MapRegionModel(dataRecords);
        }

        private List<EmbelishmentNamesModel> GetEmbelishMents()
        {
            var dataRecords = _dataAccess.DataSelect(new EmbelishmentNamesModel(), EmbelishmentNamesTablename,
                                                     EmbelishmentNamesId, string.Empty);
            return _mapperShared.MapEmbelishMentNamesModel(dataRecords);
        }

        private List<CutNamesModel> GetCutNames()
        {
            var dataRecords = _dataAccess.DataSelect(new CutNamesModel(), CutNamesTablename, CutNamesId,
                                                     string.Empty);
            return _mapperShared.MapCutModel(dataRecords);
        }

        public List<ColorModel> GetColors()
        {
            var dataRecords = _dataAccess.DataSelect(new ColorModel(), ColorTablename, ColorId, string.Empty);
            return _mapperShared.MapColorModel(dataRecords);
        }
    }
}
