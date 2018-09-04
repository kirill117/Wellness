using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHost.Controllers
{
    public class CatalogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SweetShower()
        {
            return View();
        }

        public ActionResult SaltRoom()
        {
            return View();
        }

        public ActionResult Furnaces()  // печи
        {
            return View();
        }

        public ActionResult Spa()  
        {
            return View();
        }

        public ActionResult Sauna(string id)
        {
            var actionName = "sauna";
            
            if (!string.IsNullOrEmpty(id))
            {
                actionName = "SaunaItems/" + id;
            }

            return View(actionName);
        }

        public ActionResult IceGenerators()
        {
            return View();
        }
    }
}