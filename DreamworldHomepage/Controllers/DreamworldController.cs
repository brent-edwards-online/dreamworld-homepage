using System.Web.Mvc;

namespace DreamworldHomepage.Controllers
{
    public class DreamworldController : Controller
    {
        // GET: Dreamworld
        public ActionResult Home()
        {
            var model = TestData.TestData.GetData();
            return View(model);
        }
    }
}