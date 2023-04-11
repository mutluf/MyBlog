using MyBlog.Core.Entities;
using MyBlog.Data.Context;
using MyBlog.Data.Repositories.Abstaction;
using MyBlog.Data.Repositories.Concretes;

namespace MyBlog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyBlogDbContext _context;

        public UnitOfWork(MyBlogDbContext context)
        {
            _context = context;
        }
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
