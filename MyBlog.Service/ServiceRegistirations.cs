using Microsoft.Extensions.DependencyInjection;
using MyBlog.Service.Abstraction;
using MyBlog.Service.Concrete;
using System.Reflection;

namespace MyBlog.Service
{
    public static class ServiceRegistirations
    {
        public static IServiceCollection AddServiceLayerService( this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
