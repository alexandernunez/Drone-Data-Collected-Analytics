using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using finalprojectMVC2.Models;


namespace finalprojectMVC.Controllers
{
    public class DataAController : Controller
    {
        public IActionResult DataAList()
        {
            return View();
        }
    }
}
