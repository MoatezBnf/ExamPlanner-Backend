namespace ExamPlanner_Backend.Models
{
    public class Class
    {
        public int? ClassId { get; set; }
        public string? Name { get; set; }
        public int? SpecialityLevelId { get; set; }

        public SpecialityLevel? SpecialityLevel { get; set; }
        public ICollection<Group>? Groups { get; set; }

    }

}
