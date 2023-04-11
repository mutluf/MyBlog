
using MyBlog.Entity.Entities;

namespace MyBlog.Service.Abstraction
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticleAsync();
    }
}
