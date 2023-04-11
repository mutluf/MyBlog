using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Data.Context;
using MyBlog.Data.Repositories.Abstaction;
using MyBlog.Data.Repositories.Concretes;
using MyBlog.Data.UnitOfWorks;

namespace MyBlog.Data
{
    public static class ServiceRegistiration
    {
        public static IServiceCollection AddDataLayerService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddDbContext<MyBlogDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }


    }
}
