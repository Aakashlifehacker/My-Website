using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MVC.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Projects";
            return View();
        }
        public ActionResult page(int id)
        {
            string result;
            int first=0;
            using (WebClient client = new WebClient()) {
            result = client.DownloadString("https://github.com/JankowskiZachariasz/My-Website/commits/master");}
            if(result.Contains("relative-time datetime=")){
                first = result.IndexOf("relative-time datetime=") + "relative-time datetime=".Length + 1;
            }
                return Json(new { page = result.Substring(first,10) });
        }

        public IActionResult Website()
        {

            string result;
            int first=0;
            using (WebClient client = new WebClient()) {
            result = client.DownloadString("https://github.com/JankowskiZachariasz/Zachariasz-Jankowski/commits/master");}
            if(result.Contains("relative-time datetime=")){
                first = result.IndexOf("relative-time datetime=") + "relative-time datetime=".Length + 1;
            }
            ViewBag.Message = "Projects";
            DateTime lastcommit = new DateTime();
            lastcommit = Convert.ToDateTime(result.Substring(first,10));
            DateTime today = DateTime.Now;
            int total =(int)(today - lastcommit).TotalDays;
            ViewData["days"]=total;
            return View();
        }

        public IActionResult Android()
        {
            ViewBag.Message = "Projects";
            return View();
        }

        public IActionResult Gui()
        {
            ViewBag.Message = "Projects";
            return View();
        }

        public IActionResult Finch()
        {
            ViewBag.Message = "Projects";
            return View();
        }

        public IActionResult Game()
        {
            ViewBag.Message = "Projects";
            return View();
        }
    }
}