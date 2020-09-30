using MyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        private MyDBEntities2 db = new MyDBEntities2();
        [NoDirectAccess]
        public ActionResult Index()
        {
            return View(db.ToChucHoTroes.ToList());
        }
    }
}