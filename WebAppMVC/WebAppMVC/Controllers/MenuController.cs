using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;
using WebAppMVC.ViewModels;

namespace WebAppMVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Abdulaziz";
            ViewBag.Surname = "Karimli";

            TempData["Age"] = 20;

            //return RedirectToAction("Test");
            return View();
        }

        public IActionResult Test()
        {
            var st = new Student();
            st.Id = 4;
            st.Name = "Jafar";
            st.Surname = "Memmedzade";
            st.Age = 20;

            var students = new List<Student>
            {
                new Student {Id = 1, Name = "Faig", Surname = "Abdullayev", Age = 21},
                new Student {Id = 2, Name = "Nihat", Surname = "Osmanov", Age = 20},
                new Student {Id = 3, Name = "Nazim", Surname = "Hesenov", Age = 29},
                st
            };

            var testViewModel = new TestViewModel
            {
                Students = students,
                Group = "P316"
            };

            //return View(students);
            return View(testViewModel);
        }
    }
}
