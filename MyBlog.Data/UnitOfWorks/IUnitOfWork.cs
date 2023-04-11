using MyBlog.Core.Entities;
using MyBlog.Data.Repositories.Abstaction;

namespace MyBlog.Data.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task<int> SaveAsync();
        int Save();

    }
}
