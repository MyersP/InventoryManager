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
        NewGarmentModel BuildEmptyGarmentsModel();
    }

    class BuilderGarments :TableNames, IBuilderGarments
    {

        private readonly IDataAccess _dataAccess = new DataAccess.DataAccess();
        private IMapperGarments _mapperGarments = new MapperGarments();

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

            return new List<GarmentsFullModel> { _mapperGarments.MapEmptyGarmentsFullModel() };
            //var garmentModel = new GarmentsModel();
            //var dataRecords = _dataAccess.DataSelect(garmentModel, GarmentTableName, GarmentId, garmentId);
            //return dataRecords.Select(_mapperGarments.MapDictionaryTofullGarmentsModel).ToList();
        }

        public NewGarmentModel BuildEmptyGarmentsModel()
        {
            var newGarmentModel = _mapperGarments.MapEmptyNewGarmentModel();
            newGarmentModel.ColorModel = GetColors();
            newGarmentModel.GarmentCutNamesModel = GetCutNames();
            newGarmentModel.EmbelishmentNamesModel = GetEmbelishMents();
            newGarmentModel.GamentRegionModel = GetRegions();
            newGarmentModel.GarmentEraModel = GetEras();
            newGarmentModel.GarmentGenderModel = GetGenders();
            newGarmentModel.GarmentLayerModel = GetLayers();
            newGarmentModel.GarmentLocationModel = GetGarmentLocations();
            newGarmentModel.GarmentNameModel = GetGarmentNames();
            newGarmentModel.GarmentUseModel = GetUses();
            newGarmentModel.ItemSourceModel = GetSources();
            return newGarmentModel;
        }

        private List<ItemSourceModel> GetSources()
        {
            var dataRecords = _dataAccess.DataSelect(new ItemSourceModel(), ItemSourceTablename, ItemSourceId, string.Empty);
            return _mapperGarments.MapItemSourceModel(dataRecords);
        }

        private List<GarmentUseModel> GetUses()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentUseModel(), GarmentUseTablename, GarmentUseId, string.Empty);
            return _mapperGarments.MapGarmentUseModel(dataRecords);
        }

        private List<GarmentNameModel> GetGarmentNames()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentNameModel(), GamentNameTablename, GamentNameId, string.Empty);
            return _mapperGarments.MapGarmentNameModel(dataRecords); 
        }

        private List<GarmentLocationModel> GetGarmentLocations()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentLocationModel(), GarmentLocationTablename, GarmentLocationId, string.Empty);
            return _mapperGarments.MapGarmentLocationModel(dataRecords);
        }

        private List<GarmentLayerModel> GetLayers()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentLayerModel(), GarmentLayersTablename, GarmentLayersId, string.Empty);
            return _mapperGarments.MapGarmentLayerModel(dataRecords);
        }

        private List<GarmentGenderModel> GetGenders()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentGenderModel(), GarmentGenderTablename, GarmentGenderId, string.Empty);
            return _mapperGarments.MapGarmentGenderModel(dataRecords);
        }

        private List<GarmentEraModel> GetEras()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentEraModel(), GarmentEraTablename, GarmentEra, string.Empty);
            return _mapperGarments.MapGarmentEraModel(dataRecords);
        }

        private List<GamentRegionModel> GetRegions()
        {
            var dataRecords = _dataAccess.DataSelect(new GamentRegionModel(), GarmentRegionTablename, GarmentRegionId, string.Empty);
            return _mapperGarments.MapGamentRegionModel(dataRecords);
        }

        private List<EmbelishmentNamesModel> GetEmbelishMents()
        {
            var dataRecords = _dataAccess.DataSelect(new EmbelishmentNamesModel(), EmbelishmentNamesTablename, EmbelishmentNamesId, string.Empty);
            return _mapperGarments.MapEmbelishMentNamesModel(dataRecords);
        }

        private List<GarmentCutNamesModel> GetCutNames()
        {
            var dataRecords = _dataAccess.DataSelect(new GarmentCutNamesModel(), GarmentCutNamesTablename, GarmentCutNamesId, string.Empty);
            return _mapperGarments.MapCutModel(dataRecords);
        }

        public List<ColorModel> GetColors()
        {
            var dataRecords = _dataAccess.DataSelect(new ColorModel(), ColorTablename, ColorId, string.Empty);
            return _mapperGarments.MapColorModel(dataRecords);
        }

        //public List<GarmentNameModel> GetGarmentNames()
        //{
        //    var garmentNameModel = new GarmentNameModel();

        //      var dataRecords = _dataAccess.DataSelect(garmentNameModel, garmentTableName, string.Empty, string.Empty);
        //    return dataRecords.Select(_mapperGarments.MapDictionaryTofullGarmentsModel).ToList();
        //    DataSelect

        //    var newGarmentName = new List<GarmentNameModel>();
        //    try
        //    {
        //        var reader = ReadCommand("SELECT * from tlkp_GarmentNames");
        //        while (reader.Read())
        //        {
        //            newGarmentName.Add(new GarmentNameModel { GarmentName = reader[_garmentName].ToString() });
        //        }
        //        reader.Close();
        //        return newGarmentName;
        //    }
        //    catch { return newGarmentName; }
        //    finally { CloseConnection(); }
        //}

        //public List<GarmentGenderModel> GetGarmentGender()
        //{
        //    var newGarmentType = new List<GarmentGenderModel>();
        //    try
        //    {
        //        var reader = ReadCommand("SELECT * from tlkp_GarmentGender");
        //        while (reader.Read())
        //        {
        //            newGarmentType.Add(new GarmentGenderModel { GarmentGender = reader[_garmentGender].ToString() });
        //        }
        //        reader.Close();
        //        return newGarmentType;
        //    }
        //    catch { return newGarmentType; }
        //    finally { CloseConnection(); }
        //}

        //public List<GarmentLocationModel> GetGarmentLocation()
        //{
        //    var newGarmentLocation = new List<GarmentLocationModel>();
        //    try
        //    {
        //        var reader = ReadCommand("SELECT * from tlkp_GarmentLocation");
        //        while (reader.Read())
        //        {
        //            newGarmentLocation.Add(new GarmentLocationModel { GarmentLocation = reader[_garmentLocation].ToString() });
        //        }
        //        reader.Close();
        //        return newGarmentLocation;
        //    }
        //    catch { return newGarmentLocation; }
        //    finally { CloseConnection(); }
        //}

        //public List<GarmentLayerModel> GetGarmentLayers()
        //{
        //    var newGarmentLayer = new List<GarmentLayerModel>();
        //    try
        //    {
        //        var reader = ReadCommand("SELECT * from tlkp_GarmentLayers");
        //        while (reader.Read())
        //        {
        //            newGarmentLayer.Add(new GarmentLayerModel {GarmentLayer = reader[_garmentLayer].ToString()});
        //        }
        //        reader.Close();
        //        return newGarmentLayer;
        //    }
        //    catch { return newGarmentLayer; }
        //    finally{CloseConnection();}
        //}

    }
}
