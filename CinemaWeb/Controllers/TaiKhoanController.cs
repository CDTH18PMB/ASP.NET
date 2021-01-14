using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Areas.Admin.Data;

namespace CinemaWeb.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly DPContext _context;

        public TaiKhoanController(DPContext context)
        {
            _context = context;
        }

        // GET: TaiKhoan
        public async Task<IActionResult> Index()
        {
            return View(await _context.TaiKhoan.ToListAsync());
        }


        // GET: TaiKhoan/Edit/5
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

        // POST: TaiKhoan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Username,Password,HoTen,SDT,LoaiTK,TrangThai")] TaiKhoanModel taiKhoanModel)
        {
            if (id == taiKhoanModel.Username)
            {
                taiKhoanModel.Password = StringProcessing.CreateMD5Hash(taiKhoanModel.Password);
                _context.TaiKhoan.Add(taiKhoanModel);
            }
            return RedirectToAction("Index", "Home");
        }

        private bool TaiKhoanModelExists(string id)
        {
            return _context.TaiKhoan.Any(e => e.Username == id);
        }
    }
}
