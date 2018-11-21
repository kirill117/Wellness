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

        public ActionResult SteamShower(string id)
        {
            var actionName = "SteamShower";

            if (!string.IsNullOrEmpty(id))
            {
                actionName = "SteamShowerItems/" + id;
            }

            return View(actionName);
        }

        public ActionResult IceGenerators()
        {
            return View();
        }

        public ActionResult SteamGenerators(string id)
        {
            var actionName = "SteamGenerators";

            if (!string.IsNullOrEmpty(id))
            {
                actionName = "SteamGenItems/" + id;
            }

            return View(actionName);
        }

        public ActionResult Hammam()
        {
            return View();
        }
        

        public ActionResult Deckchairs(string id)
        {
            var actionName = "Accessories/Deckchairs/Index";

            if (!string.IsNullOrEmpty(id))
            {
                actionName = "Accessories/Deckchairs/Items/" + id;
            }

            return View(actionName);
        }

        public ActionResult HeatDeckchairs()
        {
            return View("Accessories/HeatDeckchairs/Index");
        }

        public ActionResult Accessories()
        {
            return View();
        }
    }
}