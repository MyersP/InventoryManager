using System.Collections.Generic;
using InventoryManager.Models;

namespace InventoryManager.Mappers
{
    public interface IMapperContacts
    {
        ContactsModel MapToContactsModel(ContactsFullModel fullModel);
        //ContactsFullModel MapToFullContactsModel(ContactsModel contactsModel, string iD);
        ContactsFullModel MapDictionaryToFullContactsModel(Dictionary<string, string> dictionary);
        ContactType MapDictionaryToContactsTypesModel(Dictionary<string, string> dictionary);
        ContactsFullModel MapEmptyContactsFullModel();
    }

    public class MapperContacts : MapperHelper, IMapperContacts
    {
        public ContactsModel MapToContactsModel(ContactsFullModel fullModel)
        {
            return new ContactsModel()
                       {
                           FirstName = fullModel.FirstName,
                           LastName = fullModel.LastName,
                           MobleNumber = fullModel.MobleNumber,
                           PhoneNumber = fullModel.PhoneNumber,
                           EmailAddress = fullModel.EmailAddress,
                           CustomerType = fullModel.CustomerType,
                           BillingAddress = fullModel.BillingAddress,
                           City = fullModel.City,
                           CountryRegion = fullModel.CountryRegion,
                           PostalCode = fullModel.PostalCode,
                           StateOrProvince = fullModel.StateOrProvince
                       };
        }

       // public ContactsFullModel MapToFullContactsModel(ContactsModel contactsModel, string iD)
        //{
        //    return new ContactsFullModel()
        //               {
        //                   FirstName = contactsModel.FirstName,
        //                   LastName = contactsModel.LastName,
        //                   MobleNumber = contactsModel.MobleNumber,
        //                   PhoneNumber = contactsModel.PhoneNumber,
        //                   EmailAddress = contactsModel.EmailAddress,
        //                   CustomerType = contactsModel.CustomerType,
        //                   BillingAddress = contactsModel.BillingAddress,
        //                   City = contactsModel.City,
        //                   CountryRegion = contactsModel.CountryRegion,
        //                   PostalCode = contactsModel.PostalCode,
        //                   StateOrProvince = contactsModel.StateOrProvince,
        //                   ID = iD
        //               };
        //}

        public ContactsFullModel MapDictionaryToFullContactsModel(Dictionary<string, string> dictionary)
        {
            return new ContactsFullModel
                       {
                           FirstName = GetValueFromDict(dictionary, "FirstName"),
                           LastName = GetValueFromDict(dictionary, "LastName"),
                           PhoneNumber = GetValueFromDict(dictionary, "PhoneNumber"),
                           MobleNumber = GetValueFromDict(dictionary, "MobleNumber"),
                           EmailAddress = GetValueFromDict(dictionary, "EmailAddress"),
                           CustomerType = GetValueFromDict(dictionary, "CustomerType"),
                           BillingAddress = GetValueFromDict(dictionary, "BillingAddress"),
                           City = GetValueFromDict(dictionary, "City"),
                           CountryRegion = GetValueFromDict(dictionary, "CountryRegion"),
                           PostalCode = GetValueFromDict(dictionary, "PostalCode"),
                           StateOrProvince = GetValueFromDict(dictionary, "StateOrProvince"),
                           ID = GetValueFromDict(dictionary, "ID")
                       };

        }

        public ContactType MapDictionaryToContactsTypesModel(Dictionary<string, string> dictionary)
        {
            var contactType = new ContactType();
            contactType.CustomerType = GetValueFromDict(dictionary, "CustomerType");
            return contactType;
        }
        
        public ContactsFullModel MapEmptyContactsFullModel()
        {
            return new ContactsFullModel
                       {
                           FirstName = string.Empty,
                           LastName = string.Empty,
                           MobleNumber = string.Empty,
                           PhoneNumber = string.Empty,
                           EmailAddress = string.Empty,
                           CustomerType = string.Empty,
                           BillingAddress = string.Empty,
                           City = string.Empty,
                           CountryRegion = string.Empty,
                           PostalCode = string.Empty,
                           StateOrProvince = string.Empty,
                           ID = string.Empty
                       };
        }
    }
}
