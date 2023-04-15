using AutoMapper;
using MyBlog.Data.UnitOfWorks;
using MyBlog.Entity.DTOs;
using MyBlog.Entity.Entities;
using MyBlog.Service.Abstraction;

namespace MyBlog.Service.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await  _unitOfWork.GetRepository<Article>().GetAllAysnc();
            var map = _mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
