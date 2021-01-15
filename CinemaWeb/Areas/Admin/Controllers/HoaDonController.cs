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
    public class HoaDonController : Controller
    {
        private readonly DPContext _context;

        public HoaDonController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/HoaDon
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.HoaDon.Include(h => h.username);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/HoaDon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.HoaDon
                .Include(h => h.username)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // GET: Admin/HoaDon/Create
        public IActionResult Create()
        {
            ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username");
            return View();
        }

        // POST: Admin/HoaDon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHD,Username,GheDaDat,TongTien,Ngay,TrangThai")] HoaDonModel hoaDonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username", hoaDonModel.Username);
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.HoaDon.FindAsync(id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }
            ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username", hoaDonModel.Username);
            return View(hoaDonModel);
        }

        // POST: Admin/HoaDon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHD,Username,GheDaDat,TongTien,Ngay,TrangThai")] HoaDonModel hoaDonModel)
        {
            if (id != hoaDonModel.MaHD)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonModelExists(hoaDonModel.MaHD))
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
            ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username", hoaDonModel.Username);
            return View(hoaDonModel);
        }

        // GET: Admin/HoaDon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonModel = await _context.HoaDon
                .Include(h => h.username)
                .FirstOrDefaultAsync(m => m.MaHD == id);
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return View(hoaDonModel);
        }

        // POST: Admin/HoaDon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDonModel = await _context.HoaDon.FindAsync(id);
            _context.HoaDon.Remove(hoaDonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonModelExists(int id)
        {
            return _context.HoaDon.Any(e => e.MaHD == id);
        }
    }
}
