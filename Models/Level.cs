namespace ExamPlanner_Backend.Models
{
    public class Level
    {
        public int? LevelId { get; set; }
        public string? Name { get; set; }
        public ICollection<SpecialityLevel>? SpecialityLevels { get; set; }
    }
}
