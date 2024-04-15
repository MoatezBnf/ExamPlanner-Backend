using Microsoft.AspNetCore.Identity;

namespace ExamPlanner_Backend.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserDepartment>? UserDepartments { get; set; }
    }

}
