using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumarRezervaresController : ControllerBase
    {
        private readonly WebAPIContext _context;

        public SumarRezervaresController(WebAPIContext context)
        {
            _context = context;
        }

        // GET: api/SumarRezervares
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SumarRezervare>>> GetSumarRezervare()
        {
            return await _context.SumarRezervare.ToListAsync();
        }

        // GET: api/SumarRezervares/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SumarRezervare>> GetSumarRezervare(int id)
        {
            var sumarRezervare = await _context.SumarRezervare.FindAsync(id);

            if (sumarRezervare == null)
            {
                return NotFound();
            }

            return sumarRezervare;
        }

        // PUT: api/SumarRezervares/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSumarRezervare(int id, SumarRezervare sumarRezervare)
        {
            if (id != sumarRezervare.Id)
            {
                return BadRequest();
            }

            _context.Entry(sumarRezervare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SumarRezervareExists(id))
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

        // POST: api/SumarRezervares
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SumarRezervare>> PostSumarRezervare(SumarRezervare sumarRezervare)
        {
            _context.SumarRezervare.Add(sumarRezervare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSumarRezervare", new { id = sumarRezervare.Id }, sumarRezervare);
        }

        // DELETE: api/SumarRezervares/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSumarRezervare(int id)
        {
            var sumarRezervare = await _context.SumarRezervare.FindAsync(id);
            if (sumarRezervare == null)
            {
                return NotFound();
            }

            _context.SumarRezervare.Remove(sumarRezervare);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SumarRezervareExists(int id)
        {
            return _context.SumarRezervare.Any(e => e.Id == id);
        }
    }
}
