using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

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

        //view bag
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (ViewBag.ListPC == null)
            {
                ViewBag.ListPC = _context.PhongChieu.ToList();
            }
            base.OnActionExecuted(context);
        }
        // GET: Admin/PhongChieu
        public async Task<IActionResult> Index(int? id, int? search)
        {
            PhongChieuModel phongChieu = null;
            if (id != null)
            {
                phongChieu = await _context.PhongChieu.FirstOrDefaultAsync(f => f.MaPhong == id);
            }
            if (search != null)
            {   //tìm kiếm theo mã phòng.
                ViewData["search"] = search;
                ViewBag.ListPC = (from f in _context.PhongChieu
                                  where f.MaPhong == search
                                  select f).ToList();
            }
            JObject us = JObject.Parse(HttpContext.Session.GetString("user"));
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.Username = us.SelectToken("Username").ToString();
            tk.Password = us.SelectToken("Password").ToString();
            ViewBag.TaiKhoan = tk;
            return View(phongChieu);
        }

        // POST: Admin/PhongChieu/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPhong,SoGhe,TrangThai")] PhongChieuModel phongChieuModel)
        {
            if (ModelState.IsValid)
            {   //tạo phòng
                _context.Add(phongChieuModel);
                await _context.SaveChangesAsync();
                //thông báo
                Message = $"Tạo thành công phòng số {phongChieuModel.MaPhong}";
                //tạo ghế với số ghế có trong phòng
                int row = phongChieuModel.SoGhe / 18;
                for (int i = 0; i < row; i++)
                {
                    char alphabet = (char)(65 + i);
                    for (int j = 1; j < 19; j++)
                    {
                        GheModel gheModel = new GheModel();
                        gheModel.TenGhe = alphabet + j.ToString();
                        gheModel.Phong = phongChieuModel.MaPhong;
                        gheModel.TrangThai = true;
                        _context.Add(gheModel);
                        await _context.SaveChangesAsync();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // POST: Admin/PhongChieu/Edit/5
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
                {   //cập nhật phòng
                    _context.Update(phongChieuModel);
                    await _context.SaveChangesAsync();
                    Message = $"Cập nhật thành công phòng số {phongChieuModel.MaPhong}";
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

        private bool PhongChieuModelExists(int id)
        {
            return _context.PhongChieu.Any(e => e.MaPhong == id);
        }

        [TempData]
        public string Message { get; set; }
    }
}
