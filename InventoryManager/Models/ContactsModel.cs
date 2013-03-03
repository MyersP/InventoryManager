
using System.Collections.Generic;

namespace InventoryManager.Models
{
    public class ContactsModel
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string BillingAddress{ get; set; }
        public string City{ get; set; }
        public string StateOrProvince{ get; set; }
        public string PostalCode{ get; set; }
        public string CountryRegion{ get; set; }
        public string PhoneNumber{ get; set; }
        public string EmailAddress{ get; set; }
        public string MobleNumber{ get; set; }
        public string CustomerType{ get; set; }
        public List<ContactType> CustomerTypeList { get; set; }
    }

    public class ContactsFullModel : ContactsModel
    {
        public string ID{ get; set; }
    }

    public class ContactType
    {
        public string CustomerType{ get; set; }
    }

    public class BasicContactsModel
    {
        public string ID { get; set; }
        public string FullName { get; set; }
    }

    public enum ContactColums
    {
        ID,
        FirstName,
        LastName,
        MobleNumber,
        PhoneNumber,
        PostalCode,
        StateOrProvince,
        BillingAddress,
        City,
        CountryRegion,
        CustomerType,
        EmailAddress
    }

}
