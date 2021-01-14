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
    public class Ve_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public Ve_APIController(DPContext context)
        {
            _context = context;
        }

        private bool VeModelExists(int id)
        {
            return _context.Ve.Any(e => e.MaVe == id);
        }


        public class Ve_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public String UpdateStatus(Ve_Update_STT req)
        {   //thai đổi stt vé.
            (from p in _context.Ve
             where p.MaVe == req.ma
             select p).ToList().ForEach(x => x.TrangThai = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }
    }
}
