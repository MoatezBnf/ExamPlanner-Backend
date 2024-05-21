namespace ExamPlanner_Backend.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int? ScheduleId { get; set; }

        public Schedule? Schedule { get; set; }
    }
}
