using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _DBC;
using _oBjects;

namespace _StudioShinWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class shinIps2Controller : ControllerBase
    {
        private readonly DataBase _context;

        public shinIps2Controller(DataBase context)
        {
            _context = context;
        }

        // GET: api/shinIps2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<shinIps2>>> GetshinIps2()
        {
            return await _context.shinIps2.ToListAsync();
        }

        // GET: api/shinIps2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<shinIps2>> GetshinIps2(long id)
        {
            var shinIps2 = await _context.shinIps2.FindAsync(id);

            if (shinIps2 == null)
            {
                return NotFound();
            }

            return shinIps2;
        }

        // PUT: api/shinIps2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutshinIps2(long id, shinIps2 shinIps2)
        {
            if (id != shinIps2.id)
            {
                return BadRequest();
            }

            _context.Entry(shinIps2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!shinIps2Exists(id))
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

        // POST: api/shinIps2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<shinIps2>> PostshinIps2(shinIps2 shinIps2)
        {
            _context.shinIps2.Add(shinIps2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetshinIps2", new { id = shinIps2.id }, shinIps2);
        }

        // DELETE: api/shinIps2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteshinIps2(long id)
        {
            var shinIps2 = await _context.shinIps2.FindAsync(id);
            if (shinIps2 == null)
            {
                return NotFound();
            }

            _context.shinIps2.Remove(shinIps2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool shinIps2Exists(long id)
        {
            return _context.shinIps2.Any(e => e.id == id);
        }
    }
}
