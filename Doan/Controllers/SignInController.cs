﻿using Doan.Areas.Admin.Data;
using Doan.Data;
using Doan.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doan.Controllers
{
    public class SignInController : Controller
    {
        private readonly DPContext _context;
        public SignInController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sign_Up()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("Username,Password")] TaiKhoanModel taikhoan)
        {
            var r = _context.TaiKhoan.Where(m => (m.Username == taikhoan.Username && m.Password ==
             StringProcessing.CreateMD5Hash(taikhoan.Password))).ToList();
            if (r.Count == 0)
            {
                return View("Index");
            }
            //gắn session
            //var str = JsonConvert.SerializeObject(taikhoan);
            //HttpContext.Session.SetString("user", str);
            if (r[0].LoaiTK == "Admin")
            {
                //var url = Url.RouteUrl("areas", new { controller = "Admin", action = "Index", area = "Admin" });
                return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
