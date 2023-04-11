using Microsoft.EntityFrameworkCore;
using MyBlog.Core.Entities;
using MyBlog.Data.Context;
using MyBlog.Data.Repositories.Abstaction;
using System.Linq.Expressions;

namespace MyBlog.Data.Repositories.Concretes
{
    public class Repository<T>: IRepository<T> where T: BaseEntity
    {
        private readonly MyBlogDbContext context;

        public Repository(MyBlogDbContext context)
        {
            this.context = context;
        }

        private DbSet<T> Table { get => context.Set<T>(); }

        public async Task AddAysnc(T model)
        {
            await Table.AddAsync(model);           
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> method)
        {
            return await Table.AnyAsync(method);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> method = null)
        {
            return await Table.CountAsync();
        }

        public async Task DeleteAsync(T model)
        {
            await Task.Run(() => Table.Remove(model));
        }

        public async Task<List<T>> GetAllAysnc(Expression<Func<T, bool>> method = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table.AsQueryable();

            if (method!=null)
            {
                query = query.Where(method);
            }

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table.AsQueryable();
            query = query.Where(method);

            if (includeProperties.Any())
            {
                foreach(var item in includeProperties)
                { query = query.Include(item); }
            }

            return await query.SingleAsync();
        }


        public async Task<T> UpdateAsync(T model)
        {
            //async yapmak için 1. yöntem
            //Table.Attach(model);
            //context.Entry(model).State= EntityState.Modified;

            //2. yöntem
            await Task.Run(()=> Table.Update(model));

            return model;
        }
    }
}
