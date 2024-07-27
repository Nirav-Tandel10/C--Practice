using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;

namespace BusinessObjectMVC.Controllers
{
    public class Employee : Controller
    {
       public IActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> employees = (List<Employee>)employeeBusinessLayer.Employee;

            return View(employees.ToList());
        }
    }
   }


//using Microsoft.AspNetCore.Mvc;
//using BusinessLayer; // Assuming EmployeeBusinessLayer class is in this namespace

//namespace BusinessObjectMVC.Controllers
//{
//    public class EmployeeController : Controller
//    {
//        public IActionResult Index()
//        {  
//            var employeeBusinessLayer = new EmployeeBusinessLayer();
//            var employees = employeeBusinessLayer.GetEmployees();

//            return View(employees);
//        }
//    }
//}
