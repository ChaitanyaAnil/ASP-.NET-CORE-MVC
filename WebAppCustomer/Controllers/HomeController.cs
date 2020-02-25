using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCustomer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerDetails()
        {
            return View();
        }
        public IActionResult GetDetails()
        {
           
            return View();
        }
    }
}