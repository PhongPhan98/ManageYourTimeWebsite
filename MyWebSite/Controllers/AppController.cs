﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class AppController : Controller
    {
        // GET: App

        [NoDirectAccess]
        public ActionResult Index()
        {
            return View();
        }
    }
}