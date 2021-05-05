using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class ContactController : Controller
    {
        public string Index()
        {
            return "Contact Index";
        }
    }
}
