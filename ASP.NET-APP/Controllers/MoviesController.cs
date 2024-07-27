using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using ASP.NET_APP.Models;

namespace ASP.NET_APP.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {

            var movie = new Movie()
            {
                name = "Shrek!"
            };

            return View(movie);
        }
    }
}
       


