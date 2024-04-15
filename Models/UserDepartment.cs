namespace ExamPlanner_Backend.Models
{
    public class UserDepartment
    {
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }

}
