﻿namespace ExamPlanner_Backend.Models
{
    public class SpecialityLevel
    {
        public int SpecialityId { get; set; }
        public Speciality? Speciality { get; set; }
        public int LevelId { get; set; }
        public Level? Level { get; set; }
    }
}
