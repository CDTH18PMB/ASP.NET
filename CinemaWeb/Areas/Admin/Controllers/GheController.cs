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
    public class GheController : Controller
    {
        private readonly DPContext _context;

        public GheController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Ghe
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Ghe.Include(g => g.lichchieu).Include(g => g.maphong);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Ghe/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.Ghe
                .Include(g => g.lichchieu)
                .Include(g => g.maphong)
                .FirstOrDefaultAsync(m => m.MaGhe == id);
            if (gheModel == null)
            {
                return NotFound();
            }

            return View(gheModel);
        }

        // GET: Admin/Ghe/Create
        public IActionResult Create()
        {
            ViewData["LichChieu"] = new SelectList(_context.LichChieu, "MaLichChieu", "NgayChieu");
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong");
            return View();
        }

        // POST: Admin/Ghe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaGhe,MaPhong,LichChieu,TrangThai")] GheModel gheModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gheModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LichChieu"] = new SelectList(_context.LichChieu, "MaLichChieu", "NgayChieu", gheModel.LichChieu);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", gheModel.MaPhong);
            return View(gheModel);
        }

        // GET: Admin/Ghe/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.Ghe.FindAsync(id);
            if (gheModel == null)
            {
                return NotFound();
            }
            ViewData["LichChieu"] = new SelectList(_context.LichChieu, "MaLichChieu", "NgayChieu", gheModel.LichChieu);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", gheModel.MaPhong);
            return View(gheModel);
        }

        // POST: Admin/Ghe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaGhe,TenGhe,MaPhong,LichChieu,TrangThai")] GheModel gheModel)
        {
            if (id != gheModel.MaGhe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gheModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GheModelExists(gheModel.MaGhe))
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
            ViewData["LichChieu"] = new SelectList(_context.LichChieu, "MaLichChieu", "NgayChieu", gheModel.LichChieu);
            ViewData["MaPhong"] = new SelectList(_context.PhongChieu, "MaPhong", "MaPhong", gheModel.MaPhong);
            return View(gheModel);
        }

        // GET: Admin/Ghe/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gheModel = await _context.Ghe
                .Include(g => g.lichchieu)
                .Include(g => g.maphong)
                .FirstOrDefaultAsync(m => m.MaGhe == id);
            if (gheModel == null)
            {
                return NotFound();
            }

            return View(gheModel);
        }

        // POST: Admin/Ghe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var gheModel = await _context.Ghe.FindAsync(id);
            _context.Ghe.Remove(gheModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GheModelExists(int id)
        {
            return _context.Ghe.Any(e => e.MaGhe == id);
        }
    }
}
