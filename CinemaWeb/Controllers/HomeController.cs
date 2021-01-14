using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Doan.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using CinemaWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace CinemaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;
        public HomeController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                tk.HoTen = us.SelectToken("HoTen").ToString();
                tk.SDT = us.SelectToken("SDT").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }
        public IActionResult About()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }
        public IActionResult Contact()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }
        public IActionResult Genre()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }
        public IActionResult Detail()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }
        public IActionResult Book_Tickets()
        {
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                return View(tk);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                return View(tk);
            }
        }
    }
}
