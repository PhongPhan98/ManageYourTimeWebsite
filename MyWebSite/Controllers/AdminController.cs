using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;


namespace MyWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        MyDBEntities2 db = new MyDBEntities2();
        public ActionResult AdminPage()
        {
            return View();
        }

        public ActionResult Add100()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add100(C100Things model)
        {
            try
            {
                db.C100Things.Add(model);
                db.SaveChanges();
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.errorr = "Thêm mới dữ liệu thất bại";
                return View();
            }
            

        }
    }
}