
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LearningSystem.Models.Entity;
using LearningSystem.Models.View.Course;
using Microsoft.AspNet.Identity;

namespace LearningSystem.Services
{
    public class CourseService :Service
    {
        public void Create(CreateVM model)
        {
            var course = new Course()
            {
                Description = model.Description,
                Name = model.Name,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };
            Contex.Courses.Add(course);
            Contex.SaveChanges();

        }
        public IEnumerable<CreateVM> GetAllCourses()
        {
            var courses = Contex.Courses.ToList();
            var result = Mapper.Map<IEnumerable<Course>, IEnumerable<CreateVM>>(courses);
            return result;
        }

        public void SignStudentToCourse(string courseName)
        {
            var course = Contex.Courses.FirstOrDefault(x => x.Name == courseName);
            var user = Request
        }
    }
}
