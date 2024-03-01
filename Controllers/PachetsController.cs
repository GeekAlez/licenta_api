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
    public class PachetsController : ControllerBase
    {
        private readonly WebAPIContext _context;

        public PachetsController(WebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Pachets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pachet>>> GetPachet()
        {
            return await _context.Pachet.ToListAsync();
        }

        // GET: api/Pachets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pachet>> GetPachet(int id)
        {
            var pachet = await _context.Pachet.FindAsync(id);

            if (pachet == null)
            {
                return NotFound();
            }

            return pachet;
        }

        // PUT: api/Pachets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPachet(int id, Pachet pachet)
        {
            if (id != pachet.Id)
            {
                return BadRequest();
            }

            _context.Entry(pachet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PachetExists(id))
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

        // POST: api/Pachets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pachet>> PostPachet(Pachet pachet)
        {
            _context.Pachet.Add(pachet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPachet", new { id = pachet.Id }, pachet);
        }

        // DELETE: api/Pachets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePachet(int id)
        {
            var pachet = await _context.Pachet.FindAsync(id);
            if (pachet == null)
            {
                return NotFound();
            }

            _context.Pachet.Remove(pachet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PachetExists(int id)
        {
            return _context.Pachet.Any(e => e.Id == id);
        }
    }
}
