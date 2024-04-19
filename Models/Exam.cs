using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPlanner_Backend.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int SpecialityId { get; set; }
        public int LevelId { get; set; }

        [ForeignKey("SpecialityId,LevelId")]
        public SpecialityLevel? SpecialityLevel { get; set; }
    }

}
