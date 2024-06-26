﻿namespace ExamPlanner_Backend.Models
{
    public class UserModel
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public List<int>? DepartmentIds { get; set; }
    }

}
