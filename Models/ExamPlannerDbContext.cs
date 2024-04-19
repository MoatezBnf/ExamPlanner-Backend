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
            SeedData(modelBuilder);


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

            modelBuilder.Entity<Class>()
                .HasOne(c => c.SpecialityLevel)
                .WithMany(sl => sl.Classes)
                .HasForeignKey(c => new { c.SpecialityId, c.LevelId });

            modelBuilder.Entity<Exam>()
                .HasOne(e => e.SpecialityLevel)
                .WithMany(sl => sl.Exams)
                .HasForeignKey(e => new { e.SpecialityId, e.LevelId });
        }

        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "SuperAdmin", NormalizedName = "SUPERADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole { Name = "Director", NormalizedName = "DIRECTOR", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole { Name = "StudentAffairsService", NormalizedName = "STUDENTAFFAIRSSERVICE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole { Name = "PrintingService", NormalizedName = "PRINTINGSERVICE", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole { Name = "Teacher", NormalizedName = "TEACHER", ConcurrencyStamp = Guid.NewGuid().ToString() }
            );
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, Name = "SuperAdmin" },
                new Department { DepartmentId = 2, Name = "Digital" },
                new Department { DepartmentId = 3, Name = "Business" },
                new Department { DepartmentId = 4, Name = "Polytechnic" }
            );

            // Seed Specialities
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality { SpecialityId = 1, Name = "Computer Science", DepartmentId = 1 },
                new Speciality { SpecialityId = 2, Name = "Software Engineering", DepartmentId = 2 },
                new Speciality { SpecialityId = 3, Name = "Data Science", DepartmentId = 2 },
                new Speciality { SpecialityId = 4, Name = "Web Development", DepartmentId = 2 },
                new Speciality { SpecialityId = 5, Name = "Marketing", DepartmentId = 3 },
                new Speciality { SpecialityId = 6, Name = "Finance", DepartmentId = 3 },
                new Speciality { SpecialityId = 7, Name = "International Business", DepartmentId = 3 },
                new Speciality { SpecialityId = 8, Name = "Mechanical Engineering", DepartmentId = 4 },
                new Speciality { SpecialityId = 9, Name = "Electrical Engineering", DepartmentId = 4 },
                new Speciality { SpecialityId = 10, Name = "Civil Engineering", DepartmentId = 4 }
            );

            // Seed Levels
            modelBuilder.Entity<Level>().HasData(
                new Level { LevelId = 1, Name = "First Year" },
                new Level { LevelId = 2, Name = "Second Year" },
                new Level { LevelId = 3, Name = "Third Year" }
            );

            // Seed SpecialityLevels
            for (var specialityId = 1; specialityId <= 10; specialityId++)
            {
                for (var levelId = 1; levelId <= 3; levelId++)
                {
                    modelBuilder.Entity<SpecialityLevel>().HasData(
                        new SpecialityLevel { SpecialityId = specialityId, LevelId = levelId }
                    );
                }
            }

            // Seed Classes
            var classId = 1;
            var classNames = new[] { "A", "B", "C" };
            for (var specialityId = 1; specialityId <= 10; specialityId++)
            {
                for (var levelId = 1; levelId <= 3; levelId++)
                {
                    for (var i = 0; i < classNames.Length; i++)
                    {
                        modelBuilder.Entity<Class>().HasData(
                            new Class { ClassId = classId++, Name = $"Class {classNames[i]}", SpecialityId = specialityId, LevelId = levelId }
                        );
                    }
                }
            }

            // Seed Rooms
            var roomId = 1;
            var roomNames = new[] { "101", "102", "103", "104", "201", "202", "203", "204",
                    "301", "302", "303", "304", "401", "402", "403", "404" };
            for (var i = 0; i < roomNames.Length; i++)
            {
                modelBuilder.Entity<Room>().HasData(
                    new Room { RoomId = roomId++, Name = $"Room {roomNames[i]}" }
                );
            }

            // Seed Groups
            var groupId = 1;
            var groupNames = new[] { "Group 1", "Group 2" };
            for (var classId1 = 1; classId1 <= 90; classId1++)
            {
                for (var i = 0; i < groupNames.Length; i++)
                {
                    var roomId1 = (groupId - 1) % 12 + 1;
                    modelBuilder.Entity<Group>().HasData(
                        new Group { GroupId = groupId++, Name = groupNames[i], ClassId = classId1, RoomId = roomId1 }
                    );
                }
            }



            // Seed Students
            var studentId = 1;
            for (var groupId1 = 1; groupId1 <= 180; groupId1++)
            {
                for (var i = 1; i <= 15; i++)
                {
                    modelBuilder.Entity<Student>().HasData(
                        new Student { StudentId = studentId++, Name = $"Student {studentId - 1}", Email = $"Student{studentId - 1}@mail.com", GroupId = groupId1 }
                    );
                }
            }

            // Seed Exams
            var examId = 1;
            for (var specialityId = 1; specialityId <= 10; specialityId++)
            {
                for (var levelId = 1; levelId <= 3; levelId++)
                {
                    for (var i = 1; i <= 5; i++)
                    {
                        modelBuilder.Entity<Exam>().HasData(
                            new Exam { ExamId = examId++, Name = $"Exam {examId - 1}", Date = DateTime.Now.AddDays(i), Duration = TimeSpan.FromHours(2), SpecialityId = specialityId, LevelId = levelId }
                        );
                    }
                }
            }


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
