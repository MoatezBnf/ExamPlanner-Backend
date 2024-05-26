namespace ExamPlanner_Backend.Models
{
    public class ScheduleInputModel
    {
        public int LevelId { get; set; }
        public int SpecialityId { get; set; }
        public string? ScholarYear { get; set; }
        public string Semester { get; set; }
        public TimeSpan Duration { get; set; }
        public List<string>? ExamNames { get; set; }
        public TimeSpan ExamDuration { get; set; }
    }

}
