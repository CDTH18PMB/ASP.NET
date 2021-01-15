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
    public class Theloai_APIController : ControllerBase
    {
        private readonly DPContext _context;

        public Theloai_APIController(DPContext context)
        {
            _context = context;
        }
        


        public class TheLoai_Update_STT
        {
            public int ma { get; set; }
            public bool stt { get; set; }
        }
        [HttpPost]
        public string UpdateStatus(TheLoai_Update_STT req)
        {
            //cập nhật trạng thái thể loại phim
            (from p in _context.TheLoai
             where p.MaLoai == req.ma
             select p).ToList().ForEach(x => x.TrangThai = req.stt);

            _context.SaveChanges();
            return "{\"id\":" + req.ma + ",\"stt\":\"" + req.stt + "\"}";
        }







        // GET: api/Theloai_API
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TheloaiModel>>> GetTheLoai()
        {
            return await _context.TheLoai.ToListAsync();
        }

        // GET: api/Theloai_API/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TheloaiModel>> GetTheloaiModel(int id)
        {
            var theloaiModel = await _context.TheLoai.FindAsync(id);

            if (theloaiModel == null)
            {
                return NotFound();
            }

            return theloaiModel;
        }

        // PUT: api/Theloai_API/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheloaiModel(int id, TheloaiModel theloaiModel)
        {
            if (id != theloaiModel.MaLoai)
            {
                return BadRequest();
            }

            _context.Entry(theloaiModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheloaiModelExists(id))
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

        // POST: api/Theloai_API
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TheloaiModel>> PostTheloaiModel(TheloaiModel theloaiModel)
        {
            _context.TheLoai.Add(theloaiModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheloaiModel", new { id = theloaiModel.MaLoai }, theloaiModel);
        }

        // DELETE: api/Theloai_API/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheloaiModel(int id)
        {
            var theloaiModel = await _context.TheLoai.FindAsync(id);
            if (theloaiModel == null)
            {
                return NotFound();
            }

            _context.TheLoai.Remove(theloaiModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TheloaiModelExists(int id)
        {
            return _context.TheLoai.Any(e => e.MaLoai == id);
        }
    }
}
