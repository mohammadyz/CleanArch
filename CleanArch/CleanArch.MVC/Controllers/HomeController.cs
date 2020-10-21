using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CleanArch.MVC.Models;

namespace CleanArch.MVC.Controllers
{
    public class HomeController : Controller
    {
        private ICourseServices _courseServices;

        public HomeController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        public IActionResult Index()
        {
            return View(_courseServices.GetCourses());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
