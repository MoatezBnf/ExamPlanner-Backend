namespace ExamPlanner_Backend.Models
{
    public class Room
    {
        public int? RoomId { get; set; }
        public string? Name { get; set; }
        public ICollection<Group>? Groups { get; set; }
    }

}
