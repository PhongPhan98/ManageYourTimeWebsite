using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult My100()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }
    }
}