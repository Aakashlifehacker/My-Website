using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "AboutMe";
            return View();
        }
    }
}