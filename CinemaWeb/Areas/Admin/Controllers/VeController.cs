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
    public class VeController : Controller
    {
        private readonly DPContext _context;

        public VeController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Ve
        public async Task<IActionResult> Index(string searchString, bool? searchStatus)
        {
            ViewData["Search"] = searchString;
            var dPContext = _context.Ve
                .Include(v => v.maghe)
                .Include(v => v.maphim)
                .Include(v => v.maphong)
                .Include(v => v.nguoimua)
                .Include(v => v.suatchieu)
                .OrderByDescending(v => v.MaVe);
            if(searchString != null)
            {
                if(searchStatus == null)
                {   //tìm theo sđt không có stt
                    var search = _context.Ve
                        .Include(v => v.maghe)
                        .Include(v => v.maphim)
                        .Include(v => v.maphong)
                        .Include(v => v.nguoimua)
                        .Include(v => v.suatchieu)
                        .Where(v => v.nguoimua.SDT == searchString)
                        .OrderByDescending(v => v.MaVe);
                    return View(await search.ToListAsync());
                }
                else
                {   //có stt
                    var search = _context.Ve
                        .Where(v => v.TrangThai == searchStatus)
                        .Include(v => v.maghe)
                        .Include(v => v.maphim)
                        .Include(v => v.maphong)
                        .Include(v => v.nguoimua)
                        .Include(v => v.suatchieu)
                        .Where(v => v.nguoimua.SDT == searchString)
                        .OrderByDescending(v => v.MaVe);
                    return View(await search.ToListAsync());
                }
            }
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.Username = us.SelectToken("Username").ToString();
            tk.Password = us.SelectToken("Password").ToString();
            ViewBag.TaiKhoan = tk;
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Ve/SearchEdit/5
        public async Task<IActionResult> SearchEdit(int? id, int? Phim, int? Suat)
        {
            if (id == null)
            {
                return NotFound();
            }
            var veModel = await _context.Ve.FindAsync(id);
            if (veModel == null)
            {
                return NotFound();
            }
            //chọn phim
            ViewData["Phim"] = new SelectList(_context.Phim.Where(p => p.TrangThai == true), "MaPhim", "TenPhim", veModel.Phim);
            if (Phim != null)
            {   //chọn suất
                ViewData["Suat"] = new SelectList(_context.LichChieu.Where(l => l.Phim == Phim).Where(l => l.TrangThai == true), "MaLichChieu", "ThoiGian");
            }
            if (Suat != null)
            {   //chọn ghế
                var suatModel = await _context.LichChieu.FindAsync(Suat);
                ViewData["Phong"] = new SelectList(_context.PhongChieu.Where(l => l.MaPhong == suatModel.Phong), "MaPhong", "MaPhong");
                ViewData["TrangThaiGhe"] = new SelectList(_context.TrangThaiGhe.Where(g => g.TrangThai == false)
                            .Where(g => g.Suat == suatModel.MaLichChieu).Include(g => g.ghemodel), "Ghe", "ghemodel.TenGhe");
            }
            return View(veModel);
        }

        // POST: Admin/Ve/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaVe,Phim,GiaVe,Phong,Ghe,Suat,User,NgayMua,TrangThai")] VeModel veModel)
        {
            if (id != veModel.MaVe)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {   //cập nhật trạng thái cho trạng thái ghế củ
                    var ve = await _context.Ve.FindAsync(id);
                    (from tt in _context.TrangThaiGhe
                     where tt.Ghe == ve.Ghe
                     where tt.Suat == ve.Suat
                     select tt).ToList().ForEach(x => x.TrangThai = false);
                    _context.SaveChanges();
                    //cập nhật vé
                    ve.Phim = veModel.Phim;
                    ve.GiaVe = veModel.GiaVe;
                    ve.Phong = veModel.Phong;
                    ve.Ghe = veModel.Ghe;
                    ve.Suat = veModel.Suat;
                    ve.User = veModel.User;
                    ve.NgayMua = veModel.NgayMua;
                    ve.TrangThai = veModel.TrangThai;
                    _context.Update(ve);
                    await _context.SaveChangesAsync();
                    //nội dung thông báo
                    Message = $"Chỉnh sửa thành công vé mã số {veModel.MaVe}.";
                    //đổi trạng thái cho trạng thái ghế mới
                    (from tt in _context.TrangThaiGhe
                     where tt.Ghe == veModel.Ghe
                     where tt.Suat == veModel.Suat
                     select tt).ToList().ForEach(x => x.TrangThai = true);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeModelExists(veModel.MaVe))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(veModel);
        }

        // GET: Admin/Ve/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var veModel = await _context.Ve
                .Include(v => v.maghe)
                .Include(v => v.maphim)
                .Include(v => v.maphong)
                .Include(v => v.nguoimua)
                .Include(v => v.suatchieu)
                .FirstOrDefaultAsync(m => m.MaVe == id);
            if (veModel == null)
            {
                return NotFound();
            }

            return View(veModel);
        }

        private bool VeModelExists(int id)
        {
            return _context.Ve.Any(e => e.MaVe == id);
        }

        [TempData]
        public string Message { get; set; }

    }
}
