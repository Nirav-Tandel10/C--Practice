using Code_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace Code_Practice.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name = "coco", Age = 2 };
            return View(doggo);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View("Index");
        }

        public String Home()
        {
            return "Home page";
        }
    }
}
