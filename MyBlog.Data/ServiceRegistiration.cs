using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Data.Repositories.Abstaction;
using MyBlog.Data.Repositories.Concretes;

namespace MyBlog.Data
{
    public static class ServiceRegistiration
    {
        public static IServiceCollection AddDataLayerService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
