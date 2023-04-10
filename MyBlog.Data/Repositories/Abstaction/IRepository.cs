using MyBlog.Core.Entities;

namespace MyBlog.Data.Repositories.Abstaction
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task<T> AddAysnc();
    }
}
