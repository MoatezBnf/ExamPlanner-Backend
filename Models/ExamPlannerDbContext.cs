using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExamPlanner_Backend.Models
{
    public class ExamPlannerDbContext : IdentityDbContext<UserModel, IdentityRole<Guid>, Guid>
    {
        public ExamPlannerDbContext(DbContextOptions<ExamPlannerDbContext> options) : base(options)
        {

        }
    }
}
