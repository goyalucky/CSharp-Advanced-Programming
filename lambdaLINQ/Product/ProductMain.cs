using System;
using System.Collections.Generic;
using System.Linq;

namespace Product
{
    public class ProductMain
    {
        public static void Start()
        {
            /* WAP TO use of LINQ to group a list of products by category and calculate the average price for each category. It covers concepts 
of grouping, aggregation, and projection using LINQ in C#. */
        
            // List of products
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics", Price = 60000 },
                new Product { Name = "Mobile", Category = "Electronics", Price = 30000 },
                new Product { Name = "TV", Category = "Electronics", Price = 45000 },
                new Product { Name = "Chair", Category = "Furniture", Price = 5000 },
                new Product { Name = "Table", Category = "Furniture", Price = 8000 }
            };

            // LINQ Group by Category and calculate Average Price
            var result = products.GroupBy(p => p.Category).Select(g => new {Category = g.Key, AveragePrice = g.Average(p => p.Price)});

            // Display result
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");
            }
            Console.WriteLine();
        }
    }
}