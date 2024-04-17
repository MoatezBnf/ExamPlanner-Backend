namespace ExamPlanner_Backend.Models
{
    public class Exam
    {
        public int? ExamId { get; set; }
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
        public int? SpecialityLevelId { get; set; }

        public SpecialityLevel? SpecialityLevel { get; set; }
    }


}
