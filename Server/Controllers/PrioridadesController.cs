using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
    [ApiController]
    public class PrioridadesController : ControllerBase
    {
        private readonly Context _context;

        public PrioridadesController(Context context)
        {
            _context = context;
        }

        // GET: api/Prioridades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prioridades>>> GetPrioridades()
        {
            if (_context.Prioridades == null)
            {
                return NotFound();
            }
            return await _context.Prioridades.ToListAsync();
        }

        // GET: api/Prioridades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Prioridades>> GetPrioridades(int id)
        {
            if (_context.Prioridades == null)
            {
                return NotFound();
            }
            var prioridades = await _context.Prioridades.FindAsync(id);

            if (prioridades == null)
            {
                return NotFound();
            }

            return prioridades;
        }

        // POST: api/Prioridades
        [HttpPost]
        public async Task<ActionResult<Prioridades>> PostPrioridades(Prioridades prioridades)
        {
            if (!PrioridadesExists(prioridades.PrioridadId))
                _context.Prioridades.Add(prioridades);
            else
                _context.Prioridades.Update(prioridades);

            await _context.SaveChangesAsync();
            return Ok(prioridades);
        }

        // DELETE: api/Prioridades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrioridades(int id)
        {
            if (_context.Prioridades == null)
            {
                return NotFound();
            }
            var prioridades = await _context.Prioridades.FindAsync(id);
            if (prioridades == null)
            {
                return NotFound();
            }

            _context.Prioridades.Remove(prioridades);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PrioridadesExists(int id)
        {
            return (_context.Prioridades?.Any(e => e.PrioridadId == id)).GetValueOrDefault();
        }
    }