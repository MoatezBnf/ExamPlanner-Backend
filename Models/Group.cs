namespace ExamPlanner_Backend.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string? Name { get; set; }
        public int ClassId { get; set; }
        public int RoomId { get; set; }

        public Class? Class { get; set; }
        public Room? Room { get; set; }

        public ICollection<Student>? Students { get; set; }

    }

}
