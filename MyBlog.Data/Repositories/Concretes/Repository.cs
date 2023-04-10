using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Data.Context;

namespace MyBlog.Data.Repositories.Concretes
{
    public class Repository<T> where T: BaseEntity
    {
        private readonly MyBlogDbContext context;

        public Repository(MyBlogDbContext context)
        {
            this.context = context;
        }

        private DbSet<T> Table { get => context.Set<T>(); }

        public async Task<T> AddAysnc(T model)
        {
            await Table.AddAsync(model);
            return model;
        }
    }
}
