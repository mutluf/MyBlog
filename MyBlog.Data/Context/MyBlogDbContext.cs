using Microsoft.EntityFrameworkCore;
using MyBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Context
{
    public class MyBlogDbContext : DbContext
    {
        public MyBlogDbContext(DbContextOptions<MyBlogDbContext> options) : base(options)
        {
        }
       
        public DbSet<Article> Articles { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
