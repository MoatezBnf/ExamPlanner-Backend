namespace ExamPlanner_Backend.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string? Name { get; set; }
        public int LevelId { get; set; }

        public Level? Level { get; set; }
        public ICollection<Group>? Groups { get; set; }
    }
}
