namespace ExamPlanner_Backend.Models
{
    public class Student
    {
        public int? StudentId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? GroupId { get; set; }

        public Group? Group { get; set; }
    }

}
