using System.ComponentModel.DataAnnotations;

namespace ExamPlanner_Backend.Models
{
    public class RegisterModel
    {
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        public string? Role { get; set; }

        [Required]
        public List<int>? DepartmentIds { get; set; }

    }

}
