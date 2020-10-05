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
        [NoDirectAccess]
        public ActionResult AdminPage()
        {
            return View();
        }

        [NoDirectAccess]
        public ActionResult Add100()
        {
            return View();
        }

        [NoDirectAccess]
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

        [NoDirectAccess]
        public ActionResult ThemDiaChiBaoTro()
        {
            return View();
        }

        [NoDirectAccess]
        [HttpPost]
        public ActionResult ThemDiaChiBaoTro(ToChucHoTro model)
        {
            try
            {
                db.ToChucHoTroes.Add(model);
                db.SaveChanges();
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = "Thêm tổ chức thất bại";
                return View();
            }
            
        }

        public ActionResult QuanLyThongTin() {
            return View();
        }

    }
}