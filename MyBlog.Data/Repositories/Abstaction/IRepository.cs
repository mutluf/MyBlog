using MyBlog.Core.Entities;
using System.Linq.Expressions;

namespace MyBlog.Data.Repositories.Abstaction
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task AddAysnc(T model);
        Task<List<T>> GetAllAysnc(Expression<Func<T, bool>> method=null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T model);
        Task DeleteAsync(T model);
        Task<bool> AnyAsync(Expression<Func<T, bool>> method);
        Task<int> CountAsync(Expression<Func<T, bool>> method = null);

        Task SaveAsync();
    }
}
