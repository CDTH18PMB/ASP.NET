using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemaWeb.Areas.Admin.Models;
using CinemaWeb.Data;

namespace CinemaWeb.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanAPIController : ControllerBase
    {
        private readonly DPContext _context;

        public TaiKhoanAPIController(DPContext context)
        {
            _context = context;
        }

        // GET: api/TaiKhoanAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaiKhoanModel>>> GetTaiKhoan()
        {
            return await _context.TaiKhoan.ToListAsync();
        }

        // GET: api/TaiKhoanAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaiKhoanModel>> GetTaiKhoanModel(string id)
        {
            var taiKhoanModel = await _context.TaiKhoan.FindAsync(id);

            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            return taiKhoanModel;
        }

        // PUT: api/TaiKhoanAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaiKhoanModel(string id, TaiKhoanModel taiKhoanModel)
        {
            if (id != taiKhoanModel.Username)
            {
                return BadRequest();
            }

            _context.Entry(taiKhoanModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaiKhoanModelExists(id))
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

        // POST: api/TaiKhoanAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaiKhoanModel>> PostTaiKhoanModel(TaiKhoanModel taiKhoanModel)
        {
            _context.TaiKhoan.Add(taiKhoanModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TaiKhoanModelExists(taiKhoanModel.Username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTaiKhoanModel", new { id = taiKhoanModel.Username }, taiKhoanModel);
        }

        // DELETE: api/TaiKhoanAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaiKhoanModel(string id)
        {
            var taiKhoanModel = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoanModel == null)
            {
                return NotFound();
            }

            _context.TaiKhoan.Remove(taiKhoanModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaiKhoanModelExists(string id)
        {
            return _context.TaiKhoan.Any(e => e.Username == id);
        }
    }
}
