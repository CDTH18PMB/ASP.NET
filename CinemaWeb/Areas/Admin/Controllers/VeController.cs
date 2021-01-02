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
    public class VeController : Controller
    {
        private readonly DPContext _context;

        public VeController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Ve
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Ve
                .Include(v => v.maghe)
                .Include(v => v.maphim)
                .Include(v => v.maphong)
                .Include(v => v.nguoimua)
                .Include(v => v.suatchieu);
            return View(await dPContext.ToListAsync());
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

        //GET: Admin/Ve/AddOrEdit //GET: Admin/Ve/AddOrEdit/5
        public async Task<IActionResult> AddOrEdit(int id =0)
        {
            ViewData["MaGhe"] = new SelectList(_context.Ghe, "MaGhe", "MaGhe");
            ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "TenPhim");
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong");
            ViewData["NguoiMua"] = new SelectList(_context.TaiKhoan, "Username", "Username");
            ViewData["SuatChieu"] = new SelectList(_context.LichChieu, "MaLichChieu", "NgayChieu");
            if (id == 0)
            {
                return View( new VeModel());
            }
            else
            {
                var veModel = await _context.Ve.FindAsync(id);
                if (veModel == null)
                {
                    return NotFound();
                }
                return View(veModel);
            }
        }

        //POST: Admin/Ve/AddOrEdit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("MaVe,MaPhim,Gia,MaPhong,MaGhe,SuatChieu,NgayMua,NguoiMua")] VeModel veModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    veModel.NgayMua = DateTime.Now;
                    _context.Add(veModel);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(veModel);
                        await _context.SaveChangesAsync();
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
                }
                var dPContext = _context.Ve
                        .Include(v => v.maghe)
                        .Include(v => v.maphim)
                        .Include(v => v.maphong)
                        .Include(v => v.nguoimua)
                        .Include(v => v.suatchieu);
                return Json(new { isValid = true, html = ConvertString.RenderRazorViewToString(this, "_ViewIndex", dPContext.ToList()) });
            }
            ViewData["MaGhe"] = new SelectList(_context.Ghe, "MaGhe", "MaGhe", veModel.MaGhe);
            ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "TenPhim", veModel.MaPhim);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", veModel.MaPhong);
            ViewData["NguoiMua"] = new SelectList(_context.TaiKhoan, "Username", "Username", veModel.NguoiMua);
            ViewData["SuatChieu"] = new SelectList(_context.LichChieu, "MaLichChieu", "NgayChieu", veModel.SuatChieu);
            return Json(new { isValid = false, html = ConvertString.RenderRazorViewToString(this, "AddOrEdit", veModel )});
        }

        // POST: Admin/Ve/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var veModel = await _context.Ve.FindAsync(id);
            _context.Ve.Remove(veModel);
            await _context.SaveChangesAsync();
            var dPContext = _context.Ve
                        .Include(v => v.maghe)
                        .Include(v => v.maphim)
                        .Include(v => v.maphong)
                        .Include(v => v.nguoimua)
                        .Include(v => v.suatchieu);
            return Json(new { html = ConvertString.RenderRazorViewToString(this, "_ViewIndex", dPContext.ToList())});
        }

        private bool VeModelExists(int id)
        {
            return _context.Ve.Any(e => e.MaVe == id);
        }
    }
}
