using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalprojectMVC2.Models;
using Microsoft.AspNetCore.Mvc;

namespace finalprojectMVC2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Our Company";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact me if you want more information about our services";
            ViewData["From"] = "";
            ViewData["Body"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contactme message)
        {
            ViewData["Message"] = "Contact me if you want more information about the party.";
            ViewData["From"] = message.From;
            ViewData["Body"] = message.Body;
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
