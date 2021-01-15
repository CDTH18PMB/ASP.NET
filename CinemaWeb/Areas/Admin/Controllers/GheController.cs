using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace CinemaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GheController : Controller
    {
        private readonly DPContext _context;

        public GheController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Ghe
        public async Task<IActionResult> Index(int? search)
        {   //danh sách phòng true.
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu.Where(f => f.TrangThai == true), "MaPhong", "MaPhong");
            if (search != null)
            {   //tìm sơ đồ ghế
                var ghe = (from f in _context.Ghe where f.Phong == search select f);
                ViewData["TenPhong"] = (from f in _context.Ghe where f.Phong == search select f.Phong).First();
                return View(await ghe.ToListAsync());
            }
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.Username = us.SelectToken("Username").ToString();
            tk.Password = us.SelectToken("Password").ToString();
            ViewBag.TaiKhoan = tk;
            return View();
        }

        private bool GheModelExists(int id)
        {
            return _context.Ghe.Any(e => e.MaGhe == id);
        }
    }
}
