﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codename_orbit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Overview()
        {
            ViewBag.Message = "Foo";

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