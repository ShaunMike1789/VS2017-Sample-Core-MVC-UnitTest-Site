using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplication.Controllers
{
    public class ShaunzCoolController : Controller
    {
        public IActionResult Index()
        {
            ViewData["SomeAddition"] = Convert.ToString(AddTwoIntegers(2, 3));
            
            return View();
        }

        public int AddTwoIntegers(int a, int b)
        {
            return a + b;
        }
    }
}