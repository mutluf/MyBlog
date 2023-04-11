using MyBlog.Data.UnitOfWorks;
using MyBlog.Entity.Entities;
using MyBlog.Service.Abstraction;

namespace MyBlog.Service.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Article>> GetAllArticleAsync()
        {
            return await _unitOfWork.GetRepository<Article>().GetAllAysnc();
        }
    }
}
