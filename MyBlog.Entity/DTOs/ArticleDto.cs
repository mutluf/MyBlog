namespace MyBlog.Entity.DTOs
{
    public class ArticleDto
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual string CreatedBy { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
    }
}
