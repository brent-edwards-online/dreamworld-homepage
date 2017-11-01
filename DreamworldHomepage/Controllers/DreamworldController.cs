using DreamworldHomepage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamworldHomepage.Controllers
{
    public class DreamworldController : Controller
    {
        // GET: Dreamworld
        public ActionResult Home()
        {
            var model = new HomepageViewModel();
            return View(model);
        }
    }
}