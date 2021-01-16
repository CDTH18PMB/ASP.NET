using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;

namespace CinemaWeb.Areas.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HoaDonAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public HoaDonAPIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/HoaDonAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoaDonModel>>> GetHoaDon()
        {
            return await _context.HoaDon.ToListAsync();
        }

        // GET: api/HoaDonAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HoaDonModel>> GetHoaDonModel(int id)
        {
            var hoaDonModel = await _context.HoaDon.FindAsync(id);

            if (hoaDonModel == null)
            {
                return NotFound();
            }

            return hoaDonModel;
        }

        // PUT: api/HoaDonAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHoaDonModel(int id, HoaDonModel hoaDonModel)
        {
            if (id != hoaDonModel.MaHD)
            {
                return BadRequest();
            }

            _context.Entry(hoaDonModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoaDonModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HoaDonAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HoaDonModel>> PostHoaDonModel(HoaDonModel hoaDonModel)
        {
            _context.HoaDon.Add(hoaDonModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHoaDonModel", new { id = hoaDonModel.MaHD }, hoaDonModel);
        }

        // DELETE: api/HoaDonAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHoaDonModel(int id)
        {
            var hoaDonModel = await _context.HoaDon.FindAsync(id);
            hoaDonModel.TrangThai = false;
            if (hoaDonModel == null)
            {
                return NotFound();
            }

            _context.HoaDon.Update(hoaDonModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HoaDonModelExists(int id)
        {
            return _context.HoaDon.Any(e => e.MaHD == id);
        }
    }
}
