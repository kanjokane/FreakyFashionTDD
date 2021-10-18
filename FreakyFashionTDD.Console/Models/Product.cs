namespace FreakyFashionTDD.Console.Models
{
    public class Product
    {
        public Product(string articleNumber, string name, decimal price)
        {
            ArticleNumber = articleNumber;
            Name = name;
            Price = price;
        }

        public string ArticleNumber { get; }
        public string Name { get; }
        public decimal Price { get; }
    }
}
