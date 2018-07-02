using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHost.Controllers
{
    public class ServiceController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Design()
        {
            return View();
        }

        public ActionResult Construction()
        {
            return View();
        }

        public ActionResult Maintenance()
        {
            return View();
        }
    }
}