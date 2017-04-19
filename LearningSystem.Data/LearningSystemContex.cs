using LearningSystem.Models.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LearningSystemContex : IdentityDbContext<ApplicationUser>
    {

        public LearningSystemContex()
            : base("LearningSystemContex", throwIfV1Schema: false)
        {
        }
        public static LearningSystemContex Create()
        {
            return new LearningSystemContex();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Article> Articles { get; set; }

    }

}  