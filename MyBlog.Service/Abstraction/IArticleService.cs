
using MyBlog.Entity.DTOs;

namespace MyBlog.Service.Abstraction
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticleAsync();
    }
}
