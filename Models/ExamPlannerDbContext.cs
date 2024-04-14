using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExamPlanner_Backend.Models
{
    public class ExamPlannerDbContext(DbContextOptions<ExamPlannerDbContext> options) : IdentityDbContext<IdentityUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedRoles(modelBuilder);
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "SuperAdmin", NormalizedName = "SUPERADMIN" },
                new IdentityRole { Name = "Director", NormalizedName = "DIRECTOR" },
                new IdentityRole { Name = "StudentAffairsService", NormalizedName = "STUDENTAFFAIRSSERVICE" },
                new IdentityRole { Name = "PrintingService", NormalizedName = "PRINTINGSERVICE" },
                new IdentityRole { Name = "Teacher", NormalizedName = "TEACHER" }
            );
        }
        public DbSet<ExamPlanner_Backend.Models.UserModel> UserModel { get; set; } = default!;
    }
}
