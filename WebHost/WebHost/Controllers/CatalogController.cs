using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHost.Controllers
{
    public class CatalogController : Controller
    {
        public ActionResult Furnaces()  // печи
        {
            return View();
        }

        public ActionResult Spa()  
        {
            return View();
        }

        public ActionResult IceGenerators()
        {
            return View();
        }
    }
}