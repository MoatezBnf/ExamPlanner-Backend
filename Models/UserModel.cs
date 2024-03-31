using Microsoft.AspNetCore.Identity;

namespace ExamPlanner_Backend.Models
{
    public class UserModel : IdentityUser<Guid>
    {
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public Roles PermissionLevel { get; set; }
    }

    public enum Roles
    {
        SuperAdmin = 0,
        Director = 1,
        StudentAffairesService = 2,
        PrintingService = 3,
        Teacher = 4
    }

}
