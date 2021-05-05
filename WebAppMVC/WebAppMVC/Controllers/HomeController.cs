using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var viewResult = new ViewResult();
            //viewResult.ViewName = "Index";
            //return viewResult;
            //return View();

            //return Content("Home Index");
            //return Json(new {name= "Jafar", surname = "Memmedzade"});

            //var type = typeof(HomeController);
            //var controllerName = nameof(HomeController);

            //return Content(type.ToString());
            //return Content(controllerName);

            //return RedirectToAction("Index", "Contact");
            //var controllerName = "HomeController";
            return View();
        }

        public string About(int id)
        {
            return $"Home About ID = {id}";
        }
    }
}
