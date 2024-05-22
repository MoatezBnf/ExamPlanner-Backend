using ExamPlanner_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamPlanner_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClassController : ControllerBase
    {
        private readonly ExamPlannerDbContext _context;

        public ClassController(ExamPlannerDbContext context)
        {
            _context = context;
        }

        // GET: api/class
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Class>>> GetClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        // GET: api/class/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Class>> GetClass(int id)
        {
            var classEntity = await _context.Classes.FindAsync(id);

            if (classEntity == null)
            {
                return NotFound();
            }

            return classEntity;
        }

        // POST: api/class
        [HttpPost]
        public async Task<ActionResult<Class>> PostClass(Class classEntity)
        {
            _context.Classes.Add(classEntity);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClass), new { id = classEntity.ClassId }, classEntity);
        }

        // PUT: api/class/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(int id, Class classEntity)
        {
            if (id != classEntity.ClassId)
            {
                return BadRequest();
            }

            _context.Entry(classEntity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/class/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            var classEntity = await _context.Classes.FindAsync(id);
            if (classEntity == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(classEntity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
