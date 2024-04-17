using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExamPlanner_Backend.Models
{
    public class ExamPlannerDbContext(DbContextOptions<ExamPlannerDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedRoles(modelBuilder);
            SeedDepartments(modelBuilder);

            modelBuilder.Entity<UserDepartment>()
            .HasKey(ud => new { ud.UserId, ud.DepartmentId });

            modelBuilder.Entity<UserDepartment>()
                .HasOne(ud => ud.User)
                .WithMany(u => u.UserDepartments)
                .HasForeignKey(ud => ud.UserId);

            modelBuilder.Entity<UserDepartment>()
                .HasOne(ud => ud.Department)
                .WithMany(d => d.UserDepartments)
                .HasForeignKey(ud => ud.DepartmentId);
            modelBuilder.Entity<SpecialityLevel>()
                .HasKey(sl => new { sl.SpecialityId, sl.LevelId });

            modelBuilder.Entity<SpecialityLevel>()
                .HasOne(sl => sl.Speciality)
                .WithMany(s => s.SpecialityLevels)
                .HasForeignKey(sl => sl.SpecialityId);

            modelBuilder.Entity<SpecialityLevel>()
                .HasOne(sl => sl.Level)
                .WithMany(l => l.SpecialityLevels)
                .HasForeignKey(sl => sl.LevelId);


        }

        private static void SeedDepartments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "SuperAdmin" },
                new Department { DepartmentId = 2, Name = "Digital" },
                new Department { DepartmentId = 3, Name = "Business" },
                new Department { DepartmentId = 4, Name = "Polytechnic" }
    );
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
        public DbSet<UserModel> UserModel { get; set; } = default!;
        public DbSet<Department> Departments { get; set; }
        public DbSet<UserDepartment> UserDepartments { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<SpecialityLevel> SpecialityLevels { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
