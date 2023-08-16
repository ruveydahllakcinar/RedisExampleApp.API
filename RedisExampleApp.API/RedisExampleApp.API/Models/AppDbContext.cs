using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RedisExampleApp.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Pencil 1" },
                new Product() { Id = 2, Name = "Pencil 2" },
                new Product() { Id = 3, Name = "Pencil 3" },
                new Product() { Id = 4, Name = "Pencil 4" },
                new Product() { Id = 5, Name = "Pencil 5" },
                new Product() { Id = 6, Name = "Pencil 6" },
                new Product() { Id = 7, Name = "Pencil 7" },
                new Product() { Id = 8, Name = "Pencil 8" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }

}