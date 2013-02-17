using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManager.Models;

namespace InventoryManager.Controllers
{
    public class UpdateController : MainController
    {
        //
        // GET: /View/
        [HttpPost]
        public ActionResult Contact(ContactsFullModel contactsModel)
        {
            var id = string.Empty;
            if ( string.IsNullOrEmpty(contactsModel.ID))
            {
                id = BuilderContacts.EnterNewContact(BuilderContacts.BuildMapToContactsModel(contactsModel));
            }
            else
            {
                BuilderContacts.UpdateContact(contactsModel);
                id = contactsModel.ID;
            }

            return RedirectToAction("Contact", "View", new { id });
        }


    }
}
