using Microsoft.AspNetCore.Mvc;
using MyBlog.Entity.Entities;
using MyBlog.Service.Abstraction;

namespace MyBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
