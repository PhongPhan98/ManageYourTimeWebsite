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

            if (ModelState != null)
            {
                try
                {

                    appModel model = new appModel();
                    model.tochuchotro = db.ToChucHoTroes.ToList();
                    model.thongtinkhaibao = null;
                    IEnumerable<SelectListItem> tochuc = db.ToChucHoTroes.Select(
                                b => new SelectListItem { Value = b.TenToChuc, Text = b.TenToChuc });
                    ViewData["ToChuc"] = tochuc;
                    return View(model);

                }
                catch (Exception ex)
                {

                    return View();
                }
            }
            else {      
                return View();
            }
            
        }

        [HttpPost]
        public ActionResult AppHomePage(appModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.ThongTinKhaiBaos.Add(model.thongtinkhaibao);
                    db.SaveChanges();
                    ModelState.Clear();
                    IEnumerable<SelectListItem> tochuc = db.ToChucHoTroes.Select(
                                b => new SelectListItem { Value = b.TenToChuc, Text = b.TenToChuc });
                    ViewData["ToChuc"] = tochuc;
                    return View(model);
                }
                catch (Exception ex)
                {
                    ViewBag.error = "Lỗi hệ thống, vui lòng liên hệ quản trị";
                    IEnumerable<SelectListItem> tochuc = db.ToChucHoTroes.Select(
                                b => new SelectListItem { Value = b.TenToChuc, Text = b.TenToChuc });
                    ViewData["ToChuc"] = tochuc;
                    return View(model);
                }
            }
            else
            {
                IEnumerable<SelectListItem> tochuc = db.ToChucHoTroes.Select(
                                b => new SelectListItem { Value = b.TenToChuc, Text = b.TenToChuc });
                ViewData["ToChuc"] = tochuc;
                return View(model);
            }

             
        }
    }
}