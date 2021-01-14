using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;

namespace CinemaWeb.Areas.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LichChieu_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public LichChieu_APIController(DPContext context)
        {
            _context = context;
        }

        public class LichChieu_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public String UpdateStatus(LichChieu_Update_STT req)
        {   //cập nhật trạng thái lịch chiếu
            (from l in _context.LichChieu
             where l.MaLichChieu == req.ma
             select l).ToList().ForEach(x => x.TrangThai = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }

        private bool LichChieuModelExists(int id)
        {
            return _context.LichChieu.Any(e => e.MaLichChieu == id);
        }
    }
}
