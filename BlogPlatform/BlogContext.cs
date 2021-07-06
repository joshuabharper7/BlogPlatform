using BlogPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb; Database=BlogDB_062021; Trusted_Connection=True";
            
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post(1, 1, "Farmhouse table", "Today, I built a farmhouse table for a customer. It turned out beautiful.", "Josh Harper") { PublishDate = new DateTime(2021, 6, 22) },
                new Post(2, 2, "Softball Game", "I am currently coaching my 9yr old daughters soft ball team.", "Joshua Harper") { PublishDate = new DateTime(2021, 6, 24) }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category(1,"Woodworking"),
                new Category(2, "parenting"),
                new Category(3, "Coding")
                );
        }
    }
}
