using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Database.Models;

namespace RepositoryPattern.Database
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Product;Integrated Security=True");
    }
}
