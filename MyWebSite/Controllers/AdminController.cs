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
            Session["UserName"] = @Session["User"];
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
                if (model.Status.StartsWith("Chưa") || model.Status.StartsWith("chưa"))
                {
                    model.Status = "1";
                    model.Con = model.Con;
                }
                else {
                    model.Status = "2";
                    model.Con = model.Con;
                }
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