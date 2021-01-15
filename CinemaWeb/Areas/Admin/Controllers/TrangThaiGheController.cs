using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace CinemaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TrangThaiGheController : Controller
    {
        private readonly DPContext _context;

        public TrangThaiGheController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/TrangThaiGhe
        public async Task<IActionResult> Index(int? search)
        {   //tìm sơ đồ đặt ghế với lịch chiếu true.
            ViewData["MaLichChieu"] = new SelectList(_context.LichChieu.Where(f => f.TrangThai == true), "MaLichChieu", "MaLichChieu");
            if (search != null)
            { 
                var trangthaighe = _context.TrangThaiGhe.Include(v => v.ghemodel).Where(v => v.Suat == search);
                ViewData["TenLichChieu"] = (from f in _context.TrangThaiGhe where f.Suat == search select f.Suat).First();
                return View(await trangthaighe.ToListAsync());
            }
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.Username = us.SelectToken("Username").ToString();
            tk.Password = us.SelectToken("Password").ToString();
            ViewBag.TaiKhoan = tk;
            return View();
        }

        private bool TrangThaiGheModelExists(int id)
        {
            return _context.TrangThaiGhe.Any(e => e.Id == id);
        }
    }
}
