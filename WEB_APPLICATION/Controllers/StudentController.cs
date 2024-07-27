using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEB_APPLICATION.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentBio()
        {
            return View();
        }
    }
}