using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CinemaWeb.Areas.Admin.Models;

namespace CinemaWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Genre()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Book_Tickets()
        {
            return View();
        }
        public IActionResult Sign_In()
        {
            return View();
        }
        public IActionResult Sign_Up()
        {
            return View();
        }
    }
}
