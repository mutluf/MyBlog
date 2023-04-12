using Microsoft.AspNetCore.Mvc;
using MyBlog.Entity.Entities;
using MyBlog.Service.Abstraction;

namespace MyBlog.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            List<Article> articles= await articleService.GetAllArticleAsync();
            return View(articles);
        }
    }
}
