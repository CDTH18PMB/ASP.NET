using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Doan.Controllers
{
    public class BookTicketController : Controller
    {
        private readonly DPContext _context;

        public BookTicketController(DPContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
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
            else // nếu chưa đăng nhập chuyển hướng về trang chủ
            {
                TaiKhoanModel tk = new TaiKhoanModel();
                tk.Username = null;
                ViewBag.TaiKhoan = tk;
                return Redirect("/");
            }

            return View(await _context.Phim.ToListAsync());
        }

        [HttpGet]
        public JsonResult Load_LichChieu(int id)
        {
            // ds lịch chiếu theo mã phim
            var listLichChieu = _context.LichChieu.Where(s => s.Phim == id && s.TrangThai == true);

            // số lịch chiếu theo mã phim
            var count = listLichChieu.Count();

            //tổng lịch chiếu trong database
            var tongLichChieu = _context.LichChieu.ToList().Count();

            return Json(new {
                data = listLichChieu,
                count = count,
                total = tongLichChieu,
                status = true
            });
        }

        [HttpGet]
        public JsonResult Load_Ghe(int id)
        {
            // lấy danh sách ghế dựa vào suất chiếu, kết thêm bảng Ghe để lấy tên ghế theo mã ghế
            var listGhe = (from p in _context.TrangThaiGhe
                           join c in _context.Ghe on p.Ghe equals c.MaGhe
                           where p.Suat == id
                           select new { c.TenGhe, p.TrangThai });
            var count = listGhe.Count();

            return Json(new
            {
                data = listGhe,
                count = count,
                status = true
            });
        }

        [HttpPost]
        public JsonResult ThanhToan(string data)
        {
            JObject json = JObject.Parse(data);

            //========================= lưu hóa đơn ==============================

            // xóa khoảng trắng ở cuối chuỗi
            string arr = json["Ghe"].ToString();
            string arrGhe = arr.Substring(0, arr.Length - 1);

            string Username = json["Username"].ToString();
            string VeDaDat = arrGhe;
            int TongTien = Convert.ToInt32(json["TongTien"].ToString());
            DateTime Ngay = DateTime.Today;
            bool TrangThai = true;

            HoaDonModel hoaDon = new HoaDonModel(Username, VeDaDat, TongTien, Ngay, TrangThai);
            _context.Add(hoaDon);
            _context.SaveChanges();

            //============================ Lưu vé ==================================
            string[] Ghe = arrGhe.Split(" ");
            int MaPhim = Convert.ToInt32(json["MaPhim"].ToString());
            int GiaVe = 100000;
            int MaPhong = Convert.ToInt32(json["Phong"].ToString());
            int SuatChieu = Convert.ToInt32(json["MaSuatChieu"].ToString());

            //chuỗi các mã ghế
            string strMaGhe = "";

            for(int i = 0; i < Ghe.Length; i++)
            {
                var MaGhe = _context.Ghe.Where(s => s.TenGhe == Ghe[i] && s.maphong.MaPhong == MaPhong).First().MaGhe;
                strMaGhe += (MaGhe.ToString() + " ");
                VeModel veModel = new VeModel(MaPhim, GiaVe, MaPhong, MaGhe, SuatChieu, DateTime.Today, Username, TrangThai);

                _context.Add(veModel);
                _context.SaveChanges();
            }

            return Json(new
            {
                maghe = strMaGhe,
                status = true
            });
        }
    }
}
