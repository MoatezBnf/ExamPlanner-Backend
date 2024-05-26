using ExamPlanner_Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamPlanner_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ScheduleController : ControllerBase
    {
        private readonly ExamPlannerDbContext _context;

        public ScheduleController(ExamPlannerDbContext context)
        {
            _context = context;
        }

        // GET: api/schedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Schedule>>> GetSchedules()
        {
            return await _context.Schedules.Include(s => s.Group).ToListAsync();
        }

        // GET: api/schedule/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Schedule>> GetSchedule(int id)
        {
            var schedule = await _context.Schedules.Include(s => s.Group).FirstOrDefaultAsync(s => s.ScheduleId == id);

            if (schedule == null)
            {
                return NotFound();
            }

            return schedule;
        }

        // POST: api/schedule
        [HttpPost]
        public async Task<ActionResult<Schedule>> PostSchedule(ScheduleInputModel input)
        {
            var groups = await _context.Groups
        .Include(g => g.Class)
        .Where(g => g.Class.LevelId == input.LevelId)
        .ToListAsync();
            foreach (var group in groups)
            {
                var schedule = new Schedule
                {
                    GroupId = group.GroupId,
                    Group = group,
                    ScholarYear = input.ScholarYear,
                    Semester = input.Semester,
                    Duration = input.Duration
                };

                _context.Schedules.Add(schedule);
                await _context.SaveChangesAsync();
                foreach (var examName in input.ExamNames)
                {
                    var exam = new Exam
                    {
                        Name = examName,
                        Duration = input.ExamDuration,
                        ScheduleId = schedule.ScheduleId
                    };

                    _context.Exams.Add(exam);
                }

                await _context.SaveChangesAsync();
            }
            return Ok();
        }

        // PUT: api/schedule/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchedule(int id, Schedule schedule)
        {
            if (id != schedule.ScheduleId)
            {
                return BadRequest();
            }

            _context.Entry(schedule).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/schedule/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchedule(int id)
        {
            var schedule = await _context.Schedules.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }

            _context.Schedules.Remove(schedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
