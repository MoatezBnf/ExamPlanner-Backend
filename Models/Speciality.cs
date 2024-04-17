namespace ExamPlanner_Backend.Models
{
    public class Speciality
    {
        public int? SpecialityId { get; set; }
        public string? Name { get; set; }
        public int? DepartmentId { get; set; }

        public Department? Department { get; set; }
        public ICollection<SpecialityLevel>? SpecialityLevels { get; set; }

    }

}
