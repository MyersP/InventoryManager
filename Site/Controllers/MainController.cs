using System.Web.Mvc;
using InventoryManager.Builders;

namespace InventoryManager.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Default1/
        public IBuilderContacts BuilderContacts = new BuilderContacts();
        public IBuilderGarments BuilderGarments = new BuilderGarments();
    }
}
