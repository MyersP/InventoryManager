using System.Web.Mvc;
using InventoryManager.DataAccess;

namespace InventoryManager.Controllers.Contacts
{
    public class ContactsController : MainController
    {
        //
        // GET: /Default1/

        public ActionResult ContactsView()
        {
            var model = BuilderContacts.GetContacts();
            return View("View", model);
        }

        //public ActionResult EditContacts()
        //{
        //    var model = BuilderContacts.GetContacts();
        //    return View("Contacts", model);
        //}

    }
}
