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

        [HttpPost]
        public ActionResult Garment(GarmentPostBackModel Model)
        {


          //handle all the input from a new garment being entered.
            //how do I tie fabric to the garment, not there yet, need it first. DAMN.
           var id = Model;
          for (int i=0; i<10;i++)
            {
                id.ToString();
            }

            return RedirectToAction("Garments", "View", new { id });
        }


    }
}
