using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPlanner_Backend.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string? Name { get; set; }
        public int SpecialityId { get; set; }
        public int LevelId { get; set; }

        [ForeignKey("SpecialityId,LevelId")]
        public SpecialityLevel? SpecialityLevel { get; set; }
        public ICollection<Group>? Groups { get; set; }
    }


}
