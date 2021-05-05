using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVC.Models;

namespace WebAppMVC.ViewModels
{
    public class TestViewModel
    {
        public List<Student> Students { get; set; }

        public string Group { get; set; }
    }
}
