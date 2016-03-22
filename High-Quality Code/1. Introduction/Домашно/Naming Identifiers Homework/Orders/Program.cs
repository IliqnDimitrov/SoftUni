using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var mapper = new DataMapper();
            var categories = mapper.GetAllCategories();
            var products = mapper.GetAllProducts();
            var orders = mapper.GetAllOrders();

            // Names of the 5 most expensive products
            var mostExpensiveProduct = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, mostExpensiveProduct));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProductsPerCategory = products
                .GroupBy(p => p.CategoryId)
                .Select(grp => 
                    new
                    {
                        Category = categories.First(c => c.Id == grp.Key).Name, 
                        Count = grp.Count()
                    })
                .ToList();
            foreach (var item in numberOfProductsPerCategory)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var mostOrderedProducts = orders
                .GroupBy(o => o.ProductId)
                .Select(grp => 
                    new
                    {
                        Product = products.First(p => p.Id == grp.Key).Name, 
                        Quantities = grp.Sum(p => p.Quantity)
                    })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in mostOrderedProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var category = orders
                .GroupBy(o => o.ProductId)
                .Select(g => 
                    new
                    {
                        catId = products.First(p => p.Id == g.Key).CategoryId, 
                        price = products.First(p => p.Id == g.Key).UnitPrice, 
                        quantity = g.Sum(p => p.Quantity)
                    })
                .GroupBy(gg => gg.catId)
                .Select(grp => 
                    new
                    {
                        category_name = categories.First(c => c.Id == grp.Key).Name, 
                        total_quantity = grp.Sum(g => g.quantity * g.price)
                    })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", category.category_name, category.total_quantity);
        }
    }
}
