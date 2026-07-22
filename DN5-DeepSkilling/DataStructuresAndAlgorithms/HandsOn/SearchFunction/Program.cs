using System;

namespace SearchFunction
{
    // Aryan Kumar Raj - 231fa18066
    public class Product : IComparable<Product>
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public int CompareTo(Product? other)
        {
            if (other == null) return 1;
            return ProductId.CompareTo(other.ProductId);
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
        }
    }

    public class SearchAlgorithms
    {
        // Linear Search
        public static Product? LinearSearch(Product[] products, int targetId)
        {
            foreach (var product in products)
            {
                if (product.ProductId == targetId)
                {
                    return product;
                }
            }
            return null;
        }

        // Binary Search
        public static Product? BinarySearch(Product[] products, int targetId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (products[mid].ProductId == targetId)
                {
                    return products[mid];
                }
                else if (products[mid].ProductId < targetId)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Name: Aryan Kumar Raj");
            Console.WriteLine("Roll No: 231fa18066\n");

            Product[] products = new Product[]
            {
                new Product { ProductId = 3, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 1, ProductName = "Mouse", Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Keyboard", Category = "Electronics" },
                new Product { ProductId = 4, ProductName = "Monitor", Category = "Electronics" }
            };

            Console.WriteLine("--- Linear Search ---");
            Product? foundProduct1 = SearchAlgorithms.LinearSearch(products, 2);
            Console.WriteLine(foundProduct1 != null ? $"Found: {foundProduct1}" : "Product not found.");

            Console.WriteLine("\n--- Binary Search ---");
            // Binary search requires a sorted array
            Array.Sort(products);
            Product? foundProduct2 = SearchAlgorithms.BinarySearch(products, 3);
            Console.WriteLine(foundProduct2 != null ? $"Found: {foundProduct2}" : "Product not found.");
        }
    }
}
