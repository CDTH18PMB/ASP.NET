﻿using System;
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
    public class TaiKhoanController : Controller
    {
        private readonly DPContext _context;

        public TaiKhoanController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/TaiKhoan
        public async Task<IActionResult> Index()
        {
            //return View(await _context.TaiKhoan.ToListAsync());
            var DsTaiKhoan1 = from m in _context.TaiKhoan
                              select m;

            ViewBag.DsTaiKhoan = DsTaiKhoan1;
            return View();
        }

        // GET: Admin/TaiKhoan/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoan
                .FirstOrDefaultAsync(m => m.Username == id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/TaiKhoan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Username,Password,HoTen,SDT,LoaiTK,TrangThai")] TaiKhoanModel taiKhoanModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoanModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }
            return View(taiKhoanModel);
        }

        // POST: Admin/TaiKhoan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Username,Password,HoTen,SDT,LoaiTK,TrangThai")] TaiKhoanModel taiKhoanModel)
        {
            if (id != taiKhoanModel.Username)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(taiKhoanModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanModelExists(taiKhoanModel.Username))
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
            return View(taiKhoanModel);
        }

        // GET: Admin/TaiKhoan/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoanModel = await _context.TaiKhoan
                .FirstOrDefaultAsync(m => m.Username == id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return View(taiKhoanModel);
        }

        // POST: Admin/TaiKhoan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var taiKhoanModel = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoanModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TaiKhoanModelExists(string id)
        {
            return _context.TaiKhoan.Any(e => e.Username == id);
        }
    }
}
