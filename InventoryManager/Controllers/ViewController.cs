using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryManager.Builders;
using InventoryManager.DataAccess;

namespace InventoryManager.Controllers
{
    public class ViewController : MainController
    {
        //
        // GET: /Default1/

        public ActionResult Contacts()
        {
            var model = BuilderContacts.GetContacts();
            return View("ContactsView", model);
        }

        public ActionResult Contact(string id)
        {
            var model = BuilderContacts.GetContacts(id);
            return View("ContactsView", model);
        }

        public ActionResult Garments()
        {
            var model = BuilderGarments.GetGarments();
            return View("GarmentsView", model);
        }

        public ActionResult Garment(string customerId)
        {
            var model = BuilderGarments.GetGarments(customerId);
            return View("GarmentsView", model);
        }

        public ActionResult Sizes(string customerId)
        {
            var model = BuilderGarments.GetGarments(customerId);
            return View("SizesView", model);
        }

        public ActionResult Fabric()
        {
            var model = BuilderFabrics.GetFabrics();
            return View("FabricView", model);
        }

        public ActionResult Colors(string customerId)
        {
            return View("ColorCodeView");
        }

    }
}
