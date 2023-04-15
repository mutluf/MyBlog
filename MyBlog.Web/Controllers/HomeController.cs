﻿using Microsoft.AspNetCore.Mvc;
using MyBlog.Entity.DTOs;
using MyBlog.Entity.Entities;
using MyBlog.Service.Abstraction;
using MyBlog.Web.Models;
using System.Diagnostics;

namespace MyBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService _articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleService)
        {
            _logger = logger;
            _articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            List<ArticleDto> articles = await _articleService.GetAllArticleAsync();
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}