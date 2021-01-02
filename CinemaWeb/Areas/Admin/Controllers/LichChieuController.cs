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
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.LichChieu.Include(l => l.maphim).Include(l => l.maphong);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/LichChieu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuModel = await _context.LichChieu
                .Include(l => l.maphim)
                .Include(l => l.maphong)
                .FirstOrDefaultAsync(m => m.MaLichChieu == id);
            if (lichChieuModel == null)
            {
                return NotFound();
            }

            return View(lichChieuModel);
        }

        // GET: Admin/LichChieu/Create
        public IActionResult Create()
        {
            ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "TenPhim");
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong");
            return View();
        }

        // POST: Admin/LichChieu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLichChieu,NgayChieu,ThoiGian,MaPhim,MaPhong,SoGheTrong")] LichChieuModel lichChieuModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lichChieuModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "TenPhim", lichChieuModel.MaPhim);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", lichChieuModel.MaPhong);
            return View(lichChieuModel);
        }

        // GET: Admin/LichChieu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuModel = await _context.LichChieu.FindAsync(id);
            if (lichChieuModel == null)
            {
                return NotFound();
            }
            ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "TenPhim", lichChieuModel.MaPhim);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", lichChieuModel.MaPhong);
            return View(lichChieuModel);
        }

        // POST: Admin/LichChieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaLichChieu,NgayChieu,ThoiGian,MaPhim,MaPhong,SoGheTrong")] LichChieuModel lichChieuModel)
        {
            if (id != lichChieuModel.MaLichChieu)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lichChieuModel);
                    await _context.SaveChangesAsync();
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "TenPhim", lichChieuModel.MaPhim);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", lichChieuModel.MaPhong);
            return View(lichChieuModel);
        }

        // GET: Admin/LichChieu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lichChieuModel = await _context.LichChieu
                .Include(l => l.maphim)
                .Include(l => l.maphong)
                .FirstOrDefaultAsync(m => m.MaLichChieu == id);
            if (lichChieuModel == null)
            {
                return NotFound();
            }

            return View(lichChieuModel);
        }

        // POST: Admin/LichChieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lichChieuModel = await _context.LichChieu.FindAsync(id);
            _context.LichChieu.Remove(lichChieuModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LichChieuModelExists(int id)
        {
            return _context.LichChieu.Any(e => e.MaLichChieu == id);
        }
    }
}
