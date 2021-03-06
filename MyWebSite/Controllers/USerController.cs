﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite.Models;


namespace MyWebSite.Controllers
{
    public class USerController : Controller
    {
        MyDBEntities2 db = new MyDBEntities2();

        // GET: USer/Details/5
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Reg model)
        {
            if (db.Regs.Any(e => e.UserName == model.UserName))
            {
                ViewBag.Error = "Đã tồn tại tên đăng nhập này";
                return RedirectToAction("Registration", "user");
            }
            else {
                db.Regs.Add(model);
                db.SaveChanges();
                Session["User"] = model.UserName;
                return RedirectToAction("Login", "user");
            }
            
        }

        public ActionResult Login()
        {
            return View();
        }

       [HttpPost]
        public ActionResult Login(Reg model)
        {
            var resutl = db.Regs.Any(e => e.UserName == model.UserName && e.PassWord == model.PassWord);
            if (resutl && model.UserName == "phongpx")
            {
                return RedirectToAction("AdminPage", "Admin");
            }
          else if (resutl)
            {
                Session["User"] = model.UserName;
                return RedirectToAction("AppHomePage", "App");
            }
            else
            {
                
                ViewBag.error = "Đăng nhập không thành công";
                return View(model);
            }

        }

 

    }
}
