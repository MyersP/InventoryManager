using System;
using System.Web.Mvc;
using InventoryManager.Models;

namespace InventoryManager.Controllers
{
    public class DeleteController : MainController
    {
        [HttpPost]
        public ActionResult Contact(string id)
        {
            BuilderContacts.DeleteContact(id);

            return RedirectToAction("Contact", "View");
        }
    }
}
