using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zachariasz_Jankowski.Data;
using System.Net;

namespace MVC.Controllers
{
    public class ProjectsController : Controller
    {


        private DataDbContext _context;
        public ProjectsController()
        {

            var optionsBuilder = new DbContextOptionsBuilder<DataDbContext>();
            optionsBuilder.UseSqlite("Data Source=data.db");
            _context = new DataDbContext(optionsBuilder.Options);

        }
        protected override void Dispose(bool disposing)
        {
            //garbage collector won't dispose datbase connection properly
            _context.Dispose();
        }


        public IActionResult Index()
        {
            ViewBag.Message = "Projects";
            return View();
        }

        public IActionResult Website()
        {

            ViewBag.Message = "Projects";
            ViewData["days"] = _context.project.First(a => a.id == "thisWebsite").daysAgo;
            return View();
        }

        public IActionResult Android()
        {
            ViewBag.Message = "Projects";
            ViewData["days"] = _context.project.First(a => a.id == "ReceiptManager").daysAgo;
            return View();
        }

        public IActionResult Gui()
        {
            ViewBag.Message = "Projects";
            ViewData["days"] = _context.project.First(a => a.id == "GUI Windows").daysAgo;
            return View();
        }

        public IActionResult Finch()
        {
            ViewBag.Message = "Projects";
            ViewData["days"] = _context.project.First(a => a.id == "FinchRobotDriver").daysAgo;
            return View();
        }

        public IActionResult Game()
        {
            ViewBag.Message = "Projects";
            ViewData["days"] = _context.project.First(a => a.id == "2dPlatformer").daysAgo;
            return View();
        }
    }
}
