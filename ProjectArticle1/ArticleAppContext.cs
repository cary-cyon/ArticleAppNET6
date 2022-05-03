using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectArticle1.Models;

namespace ProjectArticle1
{
    public class ArticleAppContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Author { get; set; }

        public string DbPath { get; }

        public ArticleAppContext()
        {
            var path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "articleapp.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
