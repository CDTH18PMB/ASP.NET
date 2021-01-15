using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CinemaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhimController : Controller
    {
        private readonly DPContext _context;

        public PhimController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Phim
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Phim.Include(p => p.theloai);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Phim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.Phim
                .Include(p => p.theloai)
                .FirstOrDefaultAsync(m => m.MaPhim == id);
            if (phimModel == null)
            {
                return NotFound();
            }

            return View(phimModel);
        }

        // GET: Admin/Phim/Create
        public IActionResult Create()
        {
            ViewData["TheLoai"] = new SelectList(_context.TheLoai, "MaLoai", "TenLoai");
            return View();
        }

        // POST: Admin/Phim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPhim,TenPhim,Poster,DaoDien,Trailer,ThoiLuong,NoiDung,QuocGia,TheLoai,NgayKhoiChieu,TrangThai")] PhimModel phimModel, IFormFile ful)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(phimModel) /*thêm vào DBCONtext chưa vào DB*/;
                //cắt đuôi hình
                string sImage = phimModel.TenPhim + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                //Lưu file theo đường dẫn
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/post", sImage);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);
                }
                phimModel.Poster = sImage;
                //Cập nhật data vào database
                _context.Add(phimModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            ViewData["TheLoai"] = new SelectList(_context.TheLoai, "MaLoai", "TenLoai", phimModel.TheLoai);
            return View(phimModel);
        }

        // GET: Admin/Phim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.Phim.FindAsync(id);
            if (phimModel == null)
            {
                return NotFound();
            }
            ViewData["TheLoai"] = new SelectList(_context.TheLoai, "MaLoai", "TenLoai", phimModel.TheLoai);
            return View(phimModel);
        }

        // POST: Admin/Phim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaPhim,TenPhim,Poster,DaoDien,Trailer,ThoiLuong,NoiDung,QuocGia,TheLoai,NgayKhoiChieu,TrangThai")] PhimModel phimModel, IFormFile ful)
        {
            if (id != phimModel.MaPhim)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(ful != null)
                    {
                        String sImage = phimModel.TenPhim + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        var path = Path.Combine(
                            Directory.GetCurrentDirectory(), "wwwroot/img/post", phimModel.Poster);
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/post", sImage);
                        using (var Stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(Stream);
                        }
                        phimModel.Poster = sImage;
                    }
                    _context.Update(phimModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhimModelExists(phimModel.MaPhim))
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
            ViewData["TheLoai"] = new SelectList(_context.TheLoai, "MaLoai", "TenLoai", phimModel.TheLoai);
            return View(phimModel);
        }

        // GET: Admin/Phim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phimModel = await _context.Phim
                .Include(p => p.theloai)
                .FirstOrDefaultAsync(m => m.MaPhim == id);
            if (phimModel == null)
            {
                return NotFound();
            }

            return View(phimModel);
        }

        // POST: Admin/Phim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phimModel = await _context.Phim.FindAsync(id);
            _context.Phim.Remove(phimModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhimModelExists(int id)
        {
            return _context.Phim.Any(e => e.MaPhim == id);
        }
    }
}
