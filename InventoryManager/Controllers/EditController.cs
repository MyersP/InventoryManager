using System.Linq;
using System.Web.Mvc;
using InventoryManager.Models;


namespace InventoryManager.Controllers
{
    public class EditController : MainController
    {
        public ActionResult Contact(string id)
        {
            var model = new ContactsFullModel();
            if (!string.IsNullOrEmpty(id))
            {
                model = BuilderContacts.GetContacts(id).FirstOrDefault();
            }

            else
            {//new contact with empty model to fill out
                model = BuilderContacts.BuildEmptyContactsModel().FirstOrDefault();
            }
            model.CustomerTypeList = BuilderContacts.GetContactTypes();

            return View("ContactsEdit", model);
        }

        public ActionResult Garments(string id)
        {
            var model = new NewGarmentModel();
            if (!string.IsNullOrEmpty(id))
            {
               // model = BuilderGarments.GetGarments(id).FirstOrDefault();
                model = BuilderGarments.BuildGarmentsModel();
            }

            else
            {//new garment with empty model to fill out

                model = BuilderGarments.BuildGarmentsModel();
            }
            return View("GarmentsEdit", model);
        }


        public ActionResult Fabrics(string id)
        {
            NewFabricModel model;
            if (!string.IsNullOrEmpty(id))
            {
                // model = BuilderGarments.GetGarments(id).FirstOrDefault();
                model = BuilderFabrics.BuildFabricsModel();
            }

            else
            {//new garment with empty model to fill out

                model = BuilderFabrics.BuildFabricsModel();
            }
            return View("FabricsEdit", model);
        }
    }
}
