using System.Collections.Generic;
using System.Linq;
using InventoryManager.DataAccess;
using InventoryManager.Models;

namespace InventoryManager.Mappers
{
    public interface IMapperGarments
    {
        List<ColorModel> MapColorModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentCutNamesModel> MapCutModel(List<Dictionary<string, string>> dataRecords);
        List<EmbelishmentNamesModel> MapEmbelishMentNamesModel(List<Dictionary<string, string>> dataRecords);
        List<GamentRegionModel> MapGamentRegionModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentEraModel> MapGarmentEraModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentGenderModel> MapGarmentGenderModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentLayerModel> MapGarmentLayerModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentLocationModel>MapGarmentLocationModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentNameModel> MapGarmentNameModel(List<Dictionary<string, string>> dataRecords);
        List<GarmentUseModel> MapGarmentUseModel(List<Dictionary<string, string>> dataRecords);
        GarmentsModel MapToGarmentsModel(GarmentsFullModel fullModel);
        GarmentsFullModel MapToFullGarmentsModel(GarmentsModel garmentsModel, string iD);
        GarmentsFullModel MapDictionaryToFullGarmentsModel(Dictionary<string, string> dictionary);
        GarmentsFullModel MapDictionaryTofullGarmentsModel(Dictionary<string, string> dictionary);
        GarmentsModel MapEmptyGarmentsModel();
        GarmentsFullModel MapEmptyGarmentsFullModel();
        NewGarmentModel MapEmptyNewGarmentModel();
        List<GarmentNameModel> MapEmptyGarmentNameModel();
        List<PatternCompaniesModel> MapEmptyPatternCompaniesModel();
        List<GarmentLocationModel> MapEmptyGarmentLocationModel();
        List<GarmentGenderModel> MapEmptyGarmentGenderModel();
        List<GarmentLayerModel> MapEmptyGarmentLayerModel();
        List<GarmentEraModel> MapEmptyGarmentEraModel();
        List<ItemSourceModel> MapEmptyItemSourceModel();
        List<GarmentUseModel> MapEmptyGarmentUseModel();
        List<GamentRegionModel>  MapEmptyGamentRegionModel();
        List<EmbelishmentNamesModel> MapEmptyEmbelishMentNamesModel();
        List<GarmentCutNamesModel> MapEmptyCutNamesModel();
        List<ColorModel> MapEmptyColorModel();
        List<ItemSourceModel> MapItemSourceModel(List<Dictionary<string, string>> dataRecords);
    }

    public class MapperGarments : MapperHelper, IMapperGarments
    {

        public List<ColorModel> MapColorModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new ColorModel
                    {
                        ColorID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ColorModel()).FirstOrDefault()),
                        Color = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ColorModel()).Last())
                    }).ToList();
        }

        public List<GarmentCutNamesModel> MapCutModel(List<Dictionary<string, string>> dataRecords)
        {
            var cutModelList = new List<GarmentCutNamesModel>();

            foreach (var item in dataRecords)
            {

                var cutModel = new GarmentCutNamesModel
                {
                    GarmentCutNameID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentCutNamesModel()).FirstOrDefault()),
                    GarmentCutName = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentCutNamesModel()).Last())
                };

                cutModelList.Add(cutModel);
            }

            return cutModelList;
        }

        public List<EmbelishmentNamesModel> MapEmbelishMentNamesModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new EmbelishmentNamesModel
                    {
                        EmbelishmentID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new EmbelishmentNamesModel()).FirstOrDefault()),
                        EmbelishmentName = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new EmbelishmentNamesModel()).Last())
                    }).ToList();
        }

        public List<GamentRegionModel> MapGamentRegionModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GamentRegionModel
                    {
                        RegionID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GamentRegionModel()).FirstOrDefault()),
                        GarmentRegion = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GamentRegionModel()).Last())
                    }).ToList();
        }

        public List<GarmentEraModel> MapGarmentEraModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GarmentEraModel
                    {
                        EraId = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentEraModel()).FirstOrDefault()),
                        GarmentEra = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentEraModel()).Last())
                    }).ToList();
        }

        public List<GarmentGenderModel> MapGarmentGenderModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GarmentGenderModel
                    {
                        GenderID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentGenderModel()).FirstOrDefault()),
                        GarmentGender = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentGenderModel()).Last())
                    }).ToList();
        }

        public List<GarmentLayerModel> MapGarmentLayerModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GarmentLayerModel
                    {
                        LayerID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentLayerModel()).FirstOrDefault()),
                        GarmentLayer = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentLayerModel()).Last())
                    }).ToList();
        }

        public List<GarmentLocationModel>MapGarmentLocationModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GarmentLocationModel
                    {
                        GarmentLocationID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentLocationModel()).FirstOrDefault()),
                        GarmentLocation = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentLocationModel()).Last())
                    }).ToList();
        }

        public List<GarmentNameModel> MapGarmentNameModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GarmentNameModel
                    {
                        NameID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentNameModel()).FirstOrDefault()),
                        GarmentName = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentNameModel()).Last())
                    }).ToList();
        }

        public List<GarmentUseModel> MapGarmentUseModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GarmentUseModel
                    {
                        UseID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentUseModel()).FirstOrDefault()),
                        GarmentUse = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GarmentUseModel()).Last())
                    }).ToList();
        }

        public List<ItemSourceModel> MapItemSourceModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new ItemSourceModel
            {
                ItemSourceID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ItemSourceModel()).FirstOrDefault()),
                ItemSource = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ItemSourceModel()).Last())
            }).ToList();
        }

        public GarmentsModel MapToGarmentsModel(GarmentsFullModel fullModel)
        {
            return new GarmentsModel()
                       {
                           //FirstName = fullModel.FirstName,
                           //LastName = fullModel.LastName,
                           //MobleNumber = fullModel.MobleNumber,
                           //PhoneNumber = fullModel.PhoneNumber,
                           //EmailAddress = fullModel.EmailAddress,
                           //CustomerType = fullModel.CustomerType,
                           //BillingAddress = fullModel.BillingAddress,
                           //City = fullModel.City,
                           //CountryRegion = fullModel.CountryRegion,
                           //PostalCode = fullModel.PostalCode,
                           //StateOrProvince = fullModel.StateOrProvince
                       };
        }

        public GarmentsFullModel MapToFullGarmentsModel(GarmentsModel garmentsModel, string iD)
        {
            return new GarmentsFullModel()
                       {
                           //FirstName = GarmentsModel.FirstName,
                           //LastName = GarmentsModel.LastName,
                           //MobleNumber = GarmentsModel.MobleNumber,
                           //PhoneNumber = GarmentsModel.PhoneNumber,
                           //EmailAddress = GarmentsModel.EmailAddress,
                           //CustomerType = GarmentsModel.CustomerType,
                           //BillingAddress = GarmentsModel.BillingAddress,
                           //City = GarmentsModel.City,
                           //CountryRegion = GarmentsModel.CountryRegion,
                           //PostalCode = GarmentsModel.PostalCode,
                           //StateOrProvince = GarmentsModel.StateOrProvince,
                           //ID = iD
                       };
        }

        public GarmentsFullModel MapDictionaryToFullGarmentsModel(Dictionary<string, string> dictionary)
        {
            return new GarmentsFullModel
                       {
                           //FirstName = GetValueFromDict(dictionary, "FirstName"),
                           //LastName = GetValueFromDict(dictionary, "LastName"),
                           //PhoneNumber = GetValueFromDict(dictionary, "PhoneNumber"),
                           //MobleNumber = GetValueFromDict(dictionary, "MobleNumber"),
                           //EmailAddress = GetValueFromDict(dictionary, "EmailAddress"),
                           //CustomerType = GetValueFromDict(dictionary, "CustomerType"),
                           //BillingAddress = GetValueFromDict(dictionary, "BillingAddress"),
                           //City = GetValueFromDict(dictionary, "City"),
                           //CountryRegion = GetValueFromDict(dictionary, "CountryRegion"),
                           //PostalCode = GetValueFromDict(dictionary, "PostalCode"),
                           //StateOrProvince = GetValueFromDict(dictionary, "StateOrProvince"),
                           //ID = GetValueFromDict(dictionary, "ID")
                       };

        }

        public GarmentsFullModel MapDictionaryTofullGarmentsModel(Dictionary<string, string> dictionary)
        {
            var garmentsModel = new GarmentsFullModel();
            //garmentsModel.CareInstructionsId = GetValueFromDict(dictionary, "CareInstructionsId");
            //garmentsModel.GarmentId = GetValueFromDict(dictionary, "GarmentId");
            //garmentsModel.GarmentColor = GetValueFromDict(dictionary, "GarmentColor");
            //garmentsModel.GarmentGender = GetValueFromDict(dictionary, "GarmentGender");
            //garmentsModel.CustomerId = GetValueFromDict(dictionary, "CustomerId");
            //garmentsModel.GarmentLayer = GetValueFromDict(dictionary, "GarmentLayer");
            //garmentsModel.GarmentLocation = GetValueFromDict(dictionary, "GarmentLocation");
            //garmentsModel.GarmentMeasurementsId = GetValueFromDict(dictionary, "GarmentMeasurementsId");
            //garmentsModel.GarmentName = GetValueFromDict(dictionary, "GarmentName");
            //garmentsModel.GarmentStoredId = GetValueFromDict(dictionary, "GarmentStoredId");
            return garmentsModel;
        }

        public GarmentsModel MapEmptyGarmentsModel()
        {
            return new GarmentsModel
                       {
                           CustomerID = string.Empty,
                           GarmentGenderID = string.Empty,
                           GarmentLayerID = string.Empty,
                           GarmentLocationID = string.Empty,
                           GarmentMeasurementsID = string.Empty,
                           GarmentNameID = string.Empty,
                           GarmentStoredID = string.Empty,
                           PatternCompaniesID = string.Empty,
                       };
        }

        public GarmentsFullModel MapEmptyGarmentsFullModel()
        {
            return new GarmentsFullModel()
                       {
                           CustomerID = string.Empty,
                           GarmentGenderID = string.Empty,
                           GarmentLayerID = string.Empty,
                           GarmentLocationID = string.Empty,
                           GarmentMeasurementsID = string.Empty,
                           GarmentNameID = string.Empty,
                           GarmentStoredID = string.Empty,
                           PatternCompaniesID = string.Empty,
                           GarmentId = string.Empty
                       };
        }

        public NewGarmentModel MapEmptyNewGarmentModel()
        {
           return new NewGarmentModel
                                   {
                                       GarmentsFullModel = MapEmptyGarmentsFullModel(),
                                       GarmentCutNamesModel = MapEmptyCutNamesModel(),
                                       ColorModel = MapEmptyColorModel(),
                                       GarmentNameModel = MapEmptyGarmentNameModel(),
                                       GarmentEraModel = MapEmptyGarmentEraModel(),
                                       ItemSourceModel = MapEmptyItemSourceModel(),
                                       PatternCompaniesModel = MapEmptyPatternCompaniesModel(),
                                       EmbelishmentNamesModel = MapEmptyEmbelishMentNamesModel(),
                                       GamentRegionModel = MapEmptyGamentRegionModel(),
                                       GarmentGenderModel = MapEmptyGarmentGenderModel(),
                                       GarmentLayerModel = MapEmptyGarmentLayerModel(),
                                       GarmentLocationModel = MapEmptyGarmentLocationModel(),
                                       GarmentUseModel = MapEmptyGarmentUseModel()
                                   };
        }

        public List<GarmentNameModel> MapEmptyGarmentNameModel()
        {
            return new List<GarmentNameModel> { new GarmentNameModel { NameID = string.Empty, GarmentName = string.Empty } };
        }

        public List<PatternCompaniesModel> MapEmptyPatternCompaniesModel()
        {
            return new List<PatternCompaniesModel> { new PatternCompaniesModel { PatternCompaniesID = string.Empty, PatternCompanies = string.Empty } };
        }

        public List<GarmentLocationModel> MapEmptyGarmentLocationModel()
        {
            return new List<GarmentLocationModel> { new GarmentLocationModel { GarmentLocationID = string.Empty, GarmentLocation = string.Empty } };
        }

        public List<GarmentGenderModel> MapEmptyGarmentGenderModel()
        {
            return new List<GarmentGenderModel> { new GarmentGenderModel { GenderID = string.Empty, GarmentGender = string.Empty } };
        }

        public List<GarmentLayerModel> MapEmptyGarmentLayerModel()
        {
            return new List<GarmentLayerModel> { new GarmentLayerModel { LayerID = string.Empty, GarmentLayer = string.Empty } };
        }

        public List<GarmentEraModel> MapEmptyGarmentEraModel()
        {
            return new List<GarmentEraModel> {new GarmentEraModel {EraId = string.Empty, GarmentEra = string.Empty}};
        }

        public List<ItemSourceModel> MapEmptyItemSourceModel()
        {
            return new List<ItemSourceModel>{ new ItemSourceModel {ItemSourceID = string.Empty, ItemSource = string.Empty }};
        }

        public List<GarmentUseModel> MapEmptyGarmentUseModel()
        {
            return new List<GarmentUseModel>{ new GarmentUseModel { UseID = string.Empty, GarmentUse = string.Empty }};
        }

        public List<GamentRegionModel>  MapEmptyGamentRegionModel()
        {
            return new List<GamentRegionModel>{ new GamentRegionModel { RegionID = string.Empty, GarmentRegion = string.Empty }};
        }

        public List<EmbelishmentNamesModel> MapEmptyEmbelishMentNamesModel()
        {
            return new List<EmbelishmentNamesModel>{ new EmbelishmentNamesModel { EmbelishmentID = string.Empty, EmbelishmentName = string.Empty }};
        }

        public List<GarmentCutNamesModel> MapEmptyCutNamesModel()
        {
            return new List<GarmentCutNamesModel>{ new GarmentCutNamesModel { GarmentCutNameID = string.Empty, GarmentCutName = string.Empty }};
        }

        public List<ColorModel> MapEmptyColorModel()
        {
            return new List<ColorModel>{ new ColorModel { ColorID = string.Empty, Color = string.Empty }};
        }

    }
}
