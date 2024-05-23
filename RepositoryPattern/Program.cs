using RepositoryPattern.Database;
using RepositoryPattern.Database.Models;
using RepositoryPattern.Repository.Implementation;
using RepositoryPattern.Repository.Interfaces;

namespace RepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ProductContext())
            {
                context.Products.Add(new Product { Name = "Product 1", Price = 123.99M });
                context.SaveChanges();

                IRepository<Product> repo = new ProductRepository(context);

                var products = repo.GetAll().ToList();
                foreach (var product in products)
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }

    }
}
