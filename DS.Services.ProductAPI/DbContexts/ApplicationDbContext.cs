using DS.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace DS.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Samosa",
                Price = 15,
                Description = "Mobile",
                ImageUrl = "",
                CategoryName = "Mobile"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Laptop",
                Price = 13.99,
                Description = "Laptop",
                ImageUrl = "",
                CategoryName = "Laptop"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Mobile",
                Price = 10.99,
                Description = "",
                ImageUrl = "",
                CategoryName = "Mobile"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                ProductName = "Mobile",
                Price = 15,
                Description = "",
                ImageUrl = "",
                CategoryName = "Mobile"
            });
        }
    }
}
