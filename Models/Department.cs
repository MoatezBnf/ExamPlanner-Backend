namespace ExamPlanner_Backend.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public ICollection<UserDepartment>? UserDepartments { get; set; }
        public ICollection<Speciality>? Specialities { get; set; }

    }

}
