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
    public class TheloaiController : Controller
    {
        private readonly DPContext _context;

        public TheloaiController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Theloai
        public async Task<IActionResult> Index()
        {
            return View(await _context.TheLoai.ToListAsync());
        }

        // GET: Admin/Theloai/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloaiModel = await _context.TheLoai
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            if (theloaiModel == null)
            {
                return NotFound();
            }

            return View(theloaiModel);
        }

        // GET: Admin/Theloai/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Theloai/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLoai,TenLoai,TrangThai")] TheloaiModel theloaiModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theloaiModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(theloaiModel);
        }

        // GET: Admin/Theloai/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloaiModel = await _context.TheLoai.FindAsync(id);
            if (theloaiModel == null)
            {
                return NotFound();
            }
            return View(theloaiModel);
        }

        // POST: Admin/Theloai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaLoai,TenLoai,TrangThai")] TheloaiModel theloaiModel)
        {
            if (id != theloaiModel.MaLoai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theloaiModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheloaiModelExists(theloaiModel.MaLoai))
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
            return View(theloaiModel);
        }

        // GET: Admin/Theloai/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theloaiModel = await _context.TheLoai
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            if (theloaiModel == null)
            {
                return NotFound();
            }

            return View(theloaiModel);
        }

        // POST: Admin/Theloai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var theloaiModel = await _context.TheLoai.FindAsync(id);
            _context.TheLoai.Remove(theloaiModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheloaiModelExists(int id)
        {
            return _context.TheLoai.Any(e => e.MaLoai == id);
        }
    }
}
