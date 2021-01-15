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
    public class Ghe_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public Ghe_APIController(DPContext context)
        {
            _context = context;
        }

        public class Ghe_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public String UpdateStatus(Ghe_Update_STT req)
        {   //cập nhật trạng thái ghế
            (from l in _context.Ghe
             where l.MaGhe == req.ma
             select l).ToList().ForEach(x => x.TrangThai = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }

        private bool GheModelExists(int id)
        {
            return _context.Ghe.Any(e => e.MaGhe == id);
        }
    }
}
