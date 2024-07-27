using BusinessLayer1;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_DEMO.Controllers
{
    public class EmployeeController : Controller  
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Showdata(EmployeeBusinessLayer1 employeeBusinessLayer) {

            EmployeeBusinessLayer1 employeeBusinessLayer1 = new EmployeeBusinessLayer1();
            List<Employee> employees = employeeBusinessLayer1.GetAllEmployess();
               
            return View(employees);
        }
    }
}