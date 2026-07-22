using System;
using System.Linq;

namespace RetailInventoryApp
{
    // Aryan Kumar Raj - 231fa18066
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Name: Aryan Kumar Raj");
            Console.WriteLine("Roll No: 231fa18066\n");

            // Lab 1, 2 & 3: Database creation and Setup
            using (var context = new AppDbContext())
            {
                // Ensure database is created (For hands on purpose, in real app use migrations)
                context.Database.EnsureCreated();
                Console.WriteLine("Database connected.");

                // Lab 4: Inserting Initial Data
                if (!context.Categories.Any())
                {
                    var electronics = new Category { Name = "Electronics" };
                    context.Categories.Add(electronics);
                    
                    var laptop = new Product { Name = "Laptop", Price = 1200.00m, Category = electronics };
                    context.Products.Add(laptop);
                    
                    context.SaveChanges();
                    Console.WriteLine("Inserted initial data.");
                }

                // Lab 5: Retrieving Data
                var products = context.Products.ToList();
                Console.WriteLine("Products in DB:");
                foreach (var p in products)
                {
                    Console.WriteLine($"- {p.Name} (${p.Price})");
                }

                // Lab 6: Updating and Deleting Records
                var productToUpdate = context.Products.FirstOrDefault(p => p.Name == "Laptop");
                if (productToUpdate != null)
                {
                    productToUpdate.Price = 1150.00m;
                    context.SaveChanges();
                    Console.WriteLine("Updated Laptop price.");
                }

                // Lab 7: Writing Queries with LINQ
                var expensiveProducts = context.Products.Where(p => p.Price > 1000).ToList();
                Console.WriteLine("Expensive Products:");
                foreach (var p in expensiveProducts)
                {
                    Console.WriteLine($"- {p.Name} (${p.Price})");
                }
            }
        }
    }
}
