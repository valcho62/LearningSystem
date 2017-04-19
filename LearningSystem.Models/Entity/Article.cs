
using System;

namespace LearningSystem.Models.Entity
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? PublishDate { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}
