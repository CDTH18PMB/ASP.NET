using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Data;
using CinemaWeb.Areas.Admin.Models;

namespace CinemaWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BinhLuanController : Controller
    {
        private readonly DPContext _context;

        public BinhLuanController(DPContext context)
        {
            _context = context;
        }

        //// GET: Admin/BinhLuan
        //public async Task<IActionResult> Index()
        //{
        //    var dPContext = _context.BinhLuan.Include(b => b.phim).Include(b => b.taikhoan);
        //    return View(await dPContext.ToListAsync());
        //}

        //// GET: Admin/BinhLuan/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var binhLuanModel = await _context.BinhLuan
        //        .Include(b => b.phim)
        //        .Include(b => b.taikhoan)
        //        .FirstOrDefaultAsync(m => m.MaPhim == id);
        //    if (binhLuanModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(binhLuanModel);
        //}

        //// GET: Admin/BinhLuan/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "DaoDien");
        //    ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username");
        //    return View();
        //}

        //// POST: Admin/BinhLuan/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("MaPhim,Username,NoiDung,NgayDang,TrangThai")] BinhLuanModel binhLuanModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(binhLuanModel);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "DaoDien", binhLuanModel.MaPhim);
        //    ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username", binhLuanModel.Username);
        //    return View(binhLuanModel);
        //}

        //// GET: Admin/BinhLuan/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var binhLuanModel = await _context.BinhLuan.FindAsync(id);
        //    if (binhLuanModel == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "DaoDien", binhLuanModel.MaPhim);
        //    ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username", binhLuanModel.Username);
        //    return View(binhLuanModel);
        //}

        //// POST: Admin/BinhLuan/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("MaPhim,Username,NoiDung,NgayDang,TrangThai")] BinhLuanModel binhLuanModel)
        //{
        //    if (id != binhLuanModel.MaPhim)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(binhLuanModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!BinhLuanModelExists(binhLuanModel.MaPhim))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaPhim"] = new SelectList(_context.Phim, "MaPhim", "DaoDien", binhLuanModel.MaPhim);
        //    ViewData["Username"] = new SelectList(_context.TaiKhoan, "Username", "Username", binhLuanModel.Username);
        //    return View(binhLuanModel);
        //}

        //// GET: Admin/BinhLuan/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var binhLuanModel = await _context.BinhLuan
        //        .Include(b => b.phim)
        //        .Include(b => b.taikhoan)
        //        .FirstOrDefaultAsync(m => m.MaPhim == id);
        //    if (binhLuanModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(binhLuanModel);
        //}

        //// POST: Admin/BinhLuan/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var binhLuanModel = await _context.BinhLuan.FindAsync(id);
        //    _context.BinhLuan.Remove(binhLuanModel);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool BinhLuanModelExists(int id)
        //{
        //    return _context.BinhLuan.Any(e => e.MaPhim == id);
        //}
    }
}
