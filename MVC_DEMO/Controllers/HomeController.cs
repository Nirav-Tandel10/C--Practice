﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DEMO.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "US",
                "Canada",
                "Brazil"
            };
            return View();
        }
    }
}
