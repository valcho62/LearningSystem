
using System;
using System.Collections.Generic;
using LearningSystem.Models.Entity;

namespace LearningSystem.Models.View.Course
{
    public class CreateVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual ICollection<Student> Students { get; set; }
       
    }
}
