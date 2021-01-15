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

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (ViewBag.Listtheloai == null)
            {
                ViewBag.Listtheloai = _context.TheLoai.ToList();
            }
            base.OnActionExecuted(context);
            //ViewBag.Listtheloai = _context.TheLoai.ToList();
            //base.OnActionExecuted(context);
        }

        // GET: Admin/Theloai
        public async Task<IActionResult> Index(int? id)
        {
            TheloaiModel theloaiModel = null;
            if (id != null)
            {
                theloaiModel = await _context.TheLoai
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            }


            return View(theloaiModel);
        }
         //các action POST để tạo và sửa sản phẩm để sau khi thực hiện xong đều trả về action Index.
        // POST: Admin/Theloai/Create
       // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLoai,TenLoai,TrangThai")] TheloaiModel theloaiModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theloaiModel);
                await _context.SaveChangesAsync();
                Message = $"Tạo thể loại thành công {theloaiModel.MaLoai}";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }


        // POST: Admin/Theloai/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                    Message = $"Cập nhật thể loại thành công {theloaiModel.MaLoai}";
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
            }
            return RedirectToAction(nameof(Index));
        }

        private bool TheloaiModelExists(int id)
        {
            return _context.TheLoai.Any(e => e.MaLoai == id);
        }
        //<!--tempdata-->
        [TempData]
        public string Message { get; set; }
    }
}
