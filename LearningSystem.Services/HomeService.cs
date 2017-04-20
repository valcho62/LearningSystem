
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.Entity;
using LearningSystem.Models.View.Course;

namespace LearningSystem.Services
{
    public class HomeService : Service
    {
        public IEnumerable<CreateVM> GetAllCourses()
        {
            var courses = Contex.Courses.ToList();
            var result = Mapper.Map<IEnumerable<Course>, IEnumerable<CreateVM>>(courses);
            return result;
        }
    }
}
