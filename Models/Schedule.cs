namespace ExamPlanner_Backend.Models
{
    public class Schedule
    {
        public int? ScheduleId { get; set; }
        public string? Name { get; set; }
        public string? ScholarYear { get; set; }
        public string? Semester { get; set; }
        public TimeSpan? Duration { get; set; }
        public int? GroupId { get; set; }

        public Group? Group { get; set; }
        public ICollection<Exam>? Exams { get; set; }
    }

}
