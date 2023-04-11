using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Service.Abstraction;
using MyBlog.Service.Concrete;

namespace MyBlog.Service
{
    public static class ServiceRegistirations
    {
        public static IServiceCollection AddServiceLayerService( this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
