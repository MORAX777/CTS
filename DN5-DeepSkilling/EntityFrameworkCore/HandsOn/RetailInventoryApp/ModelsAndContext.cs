using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RetailInventoryApp
{
    // Aryan Kumar Raj - 231fa18066
    
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use local DB for testing
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RetailInventoryDb;Trusted_Connection=True;");
        }
    }
}
