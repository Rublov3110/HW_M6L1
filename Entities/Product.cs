namespace HW_M6L1
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            if (price == 0)
            {
                throw new ArgumentException("Error");
            }

            Name = name;
            Price = price;
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string Name { get; }
        public decimal Price { get; }
        public DateTime CreatedAt { get; }
    }
}
