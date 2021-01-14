using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;

namespace CinemaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LichChieuController : Controller
    {
        private readonly DPContext _context;

        public LichChieuController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/LichChieu
        public async Task<IActionResult> Index(string searchString, bool? SearchStatus)
        {
            ViewData["Search"] = searchString;
            //sắp xếp mã lịch giảm
            var dPContext = _context.LichChieu
                .Include(l => l.maphim)
                .Include(l => l.maphong)
                .OrderByDescending(l => l.MaLichChieu);
            if (searchString !=null)
            {
                if(SearchStatus == null)
                {   //tìm lịch theo tên phim.
                    var search = _context.LichChieu
                   .Where(l => l.maphim.TenPhim.Contains(searchString))
                   .Include(l => l.maphim)
                   .Include(l => l.maphong)
                   .OrderByDescending(l => l.MaLichChieu);
                    return View(await search.ToListAsync());
                }
                else
                {   //lọc theo stt
                    var search = _context.LichChieu
                   .Where(l => l.maphim.TenPhim.Contains(searchString))
                   .Where(l => l.TrangThai ==SearchStatus)
                   .Include(l => l.maphim)
                   .Include(l => l.maphong)
                   .OrderByDescending(l => l.MaLichChieu);
                    return View(await search.ToListAsync());
                }    
            }
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/LichChieu/AddOrEdit/5
        public async Task<IActionResult> AddOrEdit(int? id)
        {   //phim và phòng stt = true
            ViewData["MaPhim"] = new SelectList(_context.Phim.Where(p => p.TrangThai == true), "MaPhim", "TenPhim");
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu.Where(f => f.TrangThai == true), "MaPhong", "MaPhong");
            if (id == null)
            {   //tạo
                return View();
            }
            else
            {   //cập nhật
                var lichChieuModel = await _context.LichChieu.FindAsync(id);
                if (lichChieuModel == null)
                {
                    return NotFound();
                }
                return View(lichChieuModel);
            }
        }

        // POST: Admin/LichChieu/AddOrEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("MaLichChieu,Phim,Phong,NgayChieu,ThoiGian,SoGheTrong,TrangThai")] LichChieuModel lichChieuModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {   //tạo lịch chiếu với số ghế trống bằng số ghế có trong phòng
                    PhongChieuModel phongChieuModel = await _context.PhongChieu.FindAsync(lichChieuModel.Phong);
                    lichChieuModel.SoGheTrong = phongChieuModel.SoGhe;
                    _context.Add(lichChieuModel);
                    await _context.SaveChangesAsync();
                    //tạo ra số trạng thái ghế tương ứng.
                    var ArrayIDGhe = (from l in _context.Ghe
                                      where l.Phong == lichChieuModel.Phong
                                      select l.MaGhe).ToArray();
                    int Count = ArrayIDGhe.Count();
                    for(int i = 0; i < Count; i++)
                    {
                        TrangThaiGheModel trangThaiGheModel = new TrangThaiGheModel();
                        trangThaiGheModel.Suat = lichChieuModel.MaLichChieu;
                        trangThaiGheModel.Ghe = ArrayIDGhe[i];
                        trangThaiGheModel.TrangThai = false;
                        _context.Add(trangThaiGheModel);
                        await _context.SaveChangesAsync();
                    }
                    //nội dung thông báo
                    Message = $"Tạo thành công Lịch chiếu mã {lichChieuModel.MaLichChieu}.";
                }
                else
                {
                    try
                    {   //thay đổi phòng chiếu
                        LichChieuModel lichChieu = await _context.LichChieu.FindAsync(id);
                        if(lichChieu.Phong != lichChieuModel.Phong)
                        {   //xoá lần lược trang thai ghế củ
                            var trangThaiGhe = _context.TrangThaiGhe.Where(tt => tt.Suat == id).ToArray();
                            int count = trangThaiGhe.Count();
                            for(int i = 0; i < count; i++)
                            {
                                _context.TrangThaiGhe.Remove(trangThaiGhe[i]);
                                _context.SaveChanges();
                            }
                            //tạo lại trạng thái ghế cho lịch chiếu
                            var ArrayIDGhe = (from l in _context.Ghe where l.Phong == lichChieuModel.Phong select l.MaGhe).ToArray();
                            int Count = ArrayIDGhe.Count();
                            for (int i = 0; i < Count; i++)
                            {
                                TrangThaiGheModel trangThaiGheModel = new TrangThaiGheModel();
                                trangThaiGheModel.Suat = id;
                                trangThaiGheModel.Ghe = ArrayIDGhe[i];
                                trangThaiGheModel.TrangThai = false;
                                _context.Add(trangThaiGheModel);
                                await _context.SaveChangesAsync();
                            }
                        }
                        //do vẫn đan dùng id để theo dõi 
                        lichChieu.Phim = lichChieuModel.Phim;
                        lichChieu.Phong = lichChieuModel.Phong;
                        lichChieu.NgayChieu = lichChieuModel.NgayChieu;
                        lichChieu.ThoiGian = lichChieuModel.ThoiGian;
                        _context.Update(lichChieu);
                        await _context.SaveChangesAsync();
                        //nội dung thông báo
                        Message = $"Chỉnh sửa thành công Lịch chiếu mã {lichChieuModel.MaLichChieu}.";
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!LichChieuModelExists(lichChieuModel.MaLichChieu))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhim"] = new SelectList(_context.Phim.Where(p => p.TrangThai == true), "MaPhim", "TenPhim", lichChieuModel.maphim);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu.Where(f => f.TrangThai == true), "MaPhong", "MaPhong", lichChieuModel.maphim);
            return View(lichChieuModel);
        }

        private bool LichChieuModelExists(int id)
        {
            return _context.LichChieu.Any(e => e.MaLichChieu == id);
        }

        [TempData]
        public string Message { get; set; }
    }
}
