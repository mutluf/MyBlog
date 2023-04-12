using MyBlog.Core.Entities;

namespace MyBlog.Entity.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
