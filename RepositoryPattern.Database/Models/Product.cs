namespace RepositoryPattern.Database.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ProductId: {ProductId}, Name: {Name}, Price: {Price}";
        }
    }
}
