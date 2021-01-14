using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.Extensions.Logging;
=======
>>>>>>> afe335f5f613e5d6f1be2eaed5c8ed45baa1841f
using CinemaWeb.Areas.Admin.Models;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Data;
using System;
using System.Linq;

namespace CinemaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var Phim = await _context.Phim.ToListAsync();
            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                tk.HoTen = us.SelectToken("HoTen").ToString();
                tk.SDT = us.SelectToken("SDT").ToString();

                ViewBag.TaiKhoan = tk;
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                ViewBag.TaiKhoan = tk;
            }

            return View(Phim);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            var Phim = await _context.Phim.FirstOrDefaultAsync(m => m.MaPhim == id);

            ViewBag.TheLoai = _context.TheLoai.FirstAsync(m => m.MaLoai == Phim.TheLoai).Result;

            if (HttpContext.Session.GetString("user") != null)
            {
                JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = us.SelectToken("Username").ToString();
                tk.Password = us.SelectToken("Password").ToString();
                ViewBag.TaiKhoan = tk;
                return View(Phim);
            }
            else
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                ViewBag.TaiKhoan = tk;
                return View(Phim);
            }
        }

        // Đăng bình luận
        [HttpPost]
        public JsonResult PostBinhLuan(string data)
        {
            JObject json = JObject.Parse(data);

            int MaPhim = Convert.ToInt32(json["MaPhim"].ToString());
            string Username = json["Username"].ToString();
            string NoiDung = json["NoiDung"].ToString();

            BinhLuanModel model = new BinhLuanModel(MaPhim, Username, NoiDung, DateTime.Now, false);
            _context.Add(model);
            _context.SaveChanges();

            return Json(new
            {
                status = true
            });
        }

        [HttpGet]
        public JsonResult LoadBinhLuan(int id)
        {
            // danh sách bình luận sắp xếp theo mã giảm dần (ngày đăng mới nhất được hiện lên đầu)
            var ListBinhLuan = _context.BinhLuan.Where(m => m.Phim == id && m.TrangThai == true).OrderByDescending(m => m.MaBinhLuan);

            return Json(new
            {
                data = ListBinhLuan,
                status = true
            });
        }
    }
}
