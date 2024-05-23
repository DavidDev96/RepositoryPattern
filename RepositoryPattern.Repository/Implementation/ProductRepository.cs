using RepositoryPattern.Database;
using RepositoryPattern.Database.Models;
using RepositoryPattern.Repository.Interfaces;

namespace RepositoryPattern.Repository.Implementation
{
    public class ProductRepository(ProductContext productContext) : IRepository<Product>
    {
        private readonly ProductContext _context = productContext;

        public void Create(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Product> GetAll()
        {
            return [.. _context.Products];
        }

        public Product? GetById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId == id);
        }

        public void Update(Product entity)
        {
            _context.Products.Update(entity);
            _context.SaveChanges();
        }
    }
}
