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
    public class PhongChieu_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public PhongChieu_APIController(DPContext context)
        {
            _context = context;
        }

        private bool PhongChieuModelExists(int id)
        {
            return _context.PhongChieu.Any(e => e.MaPhong == id);
        }

        public class PhongChieu_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public String UpdateStatus(PhongChieu_Update_STT req)
        {   //thay đổ trạng thái phòng
            (from p in _context.PhongChieu
             where p.MaPhong == req.ma
             select p).ToList().ForEach(x => x.TrangThai = req.stt);
            _context.SaveChanges();
            //thay đổ trạng thái ghế
            (from g in _context.Ghe
             where g.Phong == req.ma
             select g).ToList().ForEach(x => x.TrangThai = req.stt);
            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }


        //// PUT: api/PhongChieu_API/5
        //[HttpPut("{id}")]
        //public async Task<String> PutPhongChieuModel(int id, PhongChieuModel phongChieuModel)
        //{
        //    if (id != phongChieuModel.MaPhong)
        //    {
        //        return "0";
        //    }

        //    _context.Entry(phongChieuModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PhongChieuModelExists(id))
        //        {
        //            return "0";
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return "{\"id\":" + id + ",\"stt\":\"" + phongChieuModel.TrangThai + "\"}";
        //}
    }
}
