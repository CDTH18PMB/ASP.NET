using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CinemaWeb.Areas.Admin.Models;
using System;
using CinemaWeb.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Doan.Areas.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GheAPIController : ControllerBase
    {
        private readonly DPContext _context;
        public GheAPIController(DPContext context)
        {
            _context = context;
        }

        public class Ghe_Update_Status
        {
            // chuỗi các mã ghế
            public string MaLichChieu { get; set; }
            public string arrMaGhe { get; set; }
            public bool TrangThai { get; set; }
        }

        [HttpPost]
        public string UpdateStatus(Ghe_Update_Status src)
        {
            //===================== Cập nhật trạng thái Ghế ===========================
            // cắt chuỗi
            string[] arr = src.arrMaGhe.Split(" ");

            for(int i = 0; i < arr.Length - 1; i++)
            {
                (from p in _context.TrangThaiGhe
                 where p.Suat == Convert.ToInt32(src.MaLichChieu) && p.Ghe == Convert.ToInt32(arr[i])
                 select p).ToList().ForEach(x => x.TrangThai = src.TrangThai);

                _context.SaveChanges();
            }

            //===================== Trừ số lượng ghế trống =================================
            (from p in _context.LichChieu
             where p.MaLichChieu == Convert.ToInt32(src.MaLichChieu)
             select p).ToList().ForEach(x => x.SoGheTrong = (x.SoGheTrong - (arr.Length - 1)));
            _context.SaveChanges();

            return "success";
        }
    }
}
