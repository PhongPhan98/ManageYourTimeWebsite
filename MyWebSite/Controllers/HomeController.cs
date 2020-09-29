using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {

        private MyDBEntities2 db = new MyDBEntities2();

        // GET: Home
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult My100()
        {  
            return View(db.C100Things.ToList());
        }

        public ActionResult AboutMe()
        {
            return View();
        }
    }
}