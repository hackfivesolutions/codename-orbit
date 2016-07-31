using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codename_orbit.Controllers
{
    public class AnalyticsController : Controller
    {
        // GET: Analytics
        public ActionResult Index()
        {
            return RedirectToAction("Overview", "Analytics", null);
        }

        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult Analytics()
        {
            return View();
        }

        public ActionResult Simulation()
        {
            return View();
        }
    }
}