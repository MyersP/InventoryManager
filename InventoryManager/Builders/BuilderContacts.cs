using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using InventoryManager.DataAccess;
using InventoryManager.Mappers;
using InventoryManager.Models;

namespace InventoryManager.Builders
{
    public interface IBuilderContacts
    {
        void UpdateContact(ContactsFullModel newContact);
        void DeleteContact(string contactId);
        string EnterNewContact(ContactsModel newContact);
        List<ContactsFullModel> GetContacts();
        List<ContactsFullModel> GetContacts(string contactId);
        List<ContactType> GetContactTypes();
        //ContactType MapDictionaryToContactsTypesModel(Dictionary<string, string> dictionary);
        //GarmentsFullModel MapDictionaryTofullGarmentsModel(Dictionary<string, string> dictionary);
        List<ContactsFullModel> BuildEmptyContactsModel();
        ContactsModel BuildMapToContactsModel(ContactsFullModel fullModel);
        ContactsFullModel AddContactTypes(ContactsFullModel objModel);
    }

    class BuilderContacts :TableNames, IBuilderContacts
    {
        private readonly IMapperContacts _mapperContacts = new MapperContacts();
        private readonly IDataHelpers _dataHelpers = new DataHelpers();
        private readonly IDataAccess _dataAccess = new DataAccess.DataAccess();
        private static readonly string ContactID = ContactColums.ID.ToString();

        public void UpdateContact(ContactsFullModel newContact)
        {
            _dataAccess.DataUpdate(_mapperContacts.MapToContactsModel(newContact),
                ContactsTablename, ContactID, Convert.ToInt32(newContact.ID));
        }

        public void DeleteContact(string contactId)
        {
            _dataAccess.DataDelete(ContactsTablename, ContactID, contactId);
            _dataAccess.DataUpdateSingleValue(GarmentTableName, GarmentsCustomerId, contactId, GarmentsCustomerId, "0");
        }

        public string EnterNewContact(ContactsModel newContact)
        {
            return _dataAccess.DataInsert(newContact, ContactsTablename);
        }

        public List<ContactsFullModel> GetContacts()
        {
          return GetContacts(string.Empty);
        }

        public List<ContactsFullModel> GetContacts(string contactId)
        {
            var newFullModel = new ContactsFullModel();
            var dataRecords = _dataAccess.DataSelect(newFullModel, ContactsTablename, ContactID, contactId);
            return dataRecords.Select(_mapperContacts.MapDictionaryToFullContactsModel).ToList();
        }

        public List<ContactType> GetContactTypes()
        {
            var contactType = new ContactType();
            var dataRecords = _dataAccess.DataSelect(contactType, CustomerTypeTablename, string.Empty, string.Empty);
            return dataRecords.Select(_mapperContacts.MapDictionaryToContactsTypesModel).ToList();
        }

        //public ContactType MapDictionaryToContactsTypesModel(Dictionary<string, string> dictionary)
        //{
        //    throw new NotImplementedException();
        //}

        public List<ContactsFullModel> BuildEmptyContactsModel()
        {
            return new List<ContactsFullModel>{_mapperContacts.MapEmptyContactsFullModel()};
        }

        public ContactsModel BuildMapToContactsModel(ContactsFullModel fullModel)
        {
            return _mapperContacts.MapToContactsModel(fullModel);
        }


        public ContactsFullModel AddContactTypes(ContactsFullModel objModel)
        {
            objModel.CustomerTypeList = GetContactTypes();
            return objModel;
        }
    }
}
