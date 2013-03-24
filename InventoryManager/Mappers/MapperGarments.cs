using System.Collections.Generic;
using InventoryManager.Models;

namespace InventoryManager.Mappers
{
    public interface IMapperGarments
    {
        GarmentsModel MapToGarmentsModel(GarmentsFullModel fullModel);
        GarmentsFullModel MapToFullGarmentsModel(GarmentsModel garmentsModel, string iD);
        GarmentsFullModel MapDictionaryToFullGarmentsModel(Dictionary<string, string> dictionary);
        GarmentsFullModel MapDictionaryTofullGarmentsModel(Dictionary<string, string> dictionary);
        GarmentsModel MapEmptyGarmentsModel();
        GarmentsFullModel MapEmptyGarmentsFullModel();
        NewGarmentModel MapEmptyNewGarmentModel();
    }

    public class MapperGarments : MapperHelper, IMapperGarments
    {
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
                           PatternNumberID = string.Empty,
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
                           PatternNumberID = string.Empty,
                           GarmentId = string.Empty
                       };
        }

        public NewGarmentModel MapEmptyNewGarmentModel()
        {
            return new NewGarmentModel
                                    {
                                        GarmentsFullModel = MapEmptyGarmentsFullModel()
                                    };
        }
    }
}
