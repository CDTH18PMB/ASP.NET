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
    public class PhongChieuController : Controller
    {
        private readonly DPContext _context;

        public PhongChieuController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/PhongChieu
        public async Task<IActionResult> Index()
        {
            return View(await _context.PhongChieu.ToListAsync());
        }

        // GET: Admin/PhongChieu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongChieuModel = await _context.PhongChieu
                .FirstOrDefaultAsync(m => m.MaPhong == id);
            if (phongChieuModel == null)
            {
                return NotFound();
            }

            return View(phongChieuModel);
        }

        // GET: Admin/PhongChieu/Edit/5
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new PhongChieuModel());
            }
            else
            {
                var phongChieuModel = await _context.PhongChieu.FindAsync(id);
                if (phongChieuModel == null)
                {
                    return NotFound();
                }
                return View(phongChieuModel);
            }
        }

        // POST: Admin/PhongChieu/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("MaPhong,SoGhe,TrangThai")] PhongChieuModel phongChieuModel)
        {
            if (ModelState.IsValid)
            {
                if(id == 0)
                {
                    _context.Add(phongChieuModel);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    try
                    {
                        _context.Update(phongChieuModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PhongChieuModelExists(phongChieuModel.MaPhong))
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
            return View(phongChieuModel);
        }


















        // GET: Admin/PhongChieu/Create
        public IActionResult Create()
        {
            return View();
        }



        // POST: Admin/PhongChieu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPhong,SoGhe,TrangThai")] PhongChieuModel phongChieuModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phongChieuModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phongChieuModel);
        }

        // GET: Admin/PhongChieu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongChieuModel = await _context.PhongChieu.FindAsync(id);
            if (phongChieuModel == null)
            {
                return NotFound();
            }
            return View(phongChieuModel);
        }

        // POST: Admin/PhongChieu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaPhong,SoGhe,TrangThai")] PhongChieuModel phongChieuModel)
        {
            if (id != phongChieuModel.MaPhong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phongChieuModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongChieuModelExists(phongChieuModel.MaPhong))
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
            return View(phongChieuModel);
        }

        // GET: Admin/PhongChieu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phongChieuModel = await _context.PhongChieu
                .FirstOrDefaultAsync(m => m.MaPhong == id);
            if (phongChieuModel == null)
            {
                return NotFound();
            }

            return View(phongChieuModel);
        }

        // POST: Admin/PhongChieu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phongChieuModel = await _context.PhongChieu.FindAsync(id);
            _context.PhongChieu.Remove(phongChieuModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongChieuModelExists(int id)
        {
            return _context.PhongChieu.Any(e => e.MaPhong == id);
        }
    }
}
