using AutoMapper;
using MyBlog.Entity.DTOs;
using MyBlog.Entity.Entities;

namespace MyBlog.Service.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<ArticleDto,Article>().ReverseMap();
        }
    }
}
