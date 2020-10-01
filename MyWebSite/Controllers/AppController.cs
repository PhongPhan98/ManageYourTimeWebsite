using MyWebSite.Models;
using System;
using System.Collections;
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
        public ActionResult AppHomePage()
        {
            try
            {
                appModel model = new appModel();
                model.tochuchotro = db.ToChucHoTroes.ToList();
                model.thongtinkhaibao = null;

                 ViewBag.tochuc = db.ToChucHoTroes.Select(c => new SelectListItem
                {
                    Value = c.TenToChuc.ToString(),
                    Text = c.TenToChuc
                });



                return View(model);
            }
            catch (Exception ex)
            {
                
                return View();
            }
        }

        [HttpPost]
        public ActionResult AppHomePage(appModel model)
        {
            try
            {
                db.ThongTinKhaiBaos.Add(model.thongtinkhaibao);
                db.SaveChanges();
                ModelState.Clear();
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.error = "Lỗi hệ thống, vui lòng liên hệ quản trị";
                ModelState.Clear();
                return View();
            }
        }
    }
}