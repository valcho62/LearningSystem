
using System;
using System.Data.Entity.Validation;
using LearningSystem.Models.Entity;

namespace LearningSystem.Services
{
    public class AccountService:Service
    {
        public  void RegisterStudent(ApplicationUser user)
        {
            var student = new Student() ;
            var currentUser = Contex.Users.Find(user.Id);
            student.User = currentUser;
            Contex.Students.Add(student);
                Contex.SaveChanges();
           
            
        }
    }
}
