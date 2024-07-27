using BusinessObjectMVC;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BusinessObjectMVC.Controllers
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
