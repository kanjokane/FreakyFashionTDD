using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace FreakyFashionTDD.Console.Models
{
    public class ShoppingBasket
    {
        public Dictionary<string, BasketItem> Items = new Dictionary<string, BasketItem>();

        public void AddProduct(Product product, int quantity)
        {
            bool productExists = Items.ContainsKey(product.ArticleNumber);

            if (productExists)
            {
                var basketItem = Items[product.ArticleNumber];

                basketItem.Quantity += quantity;
            }
            else
            {
                var basketItem = new BasketItem(product, quantity);

                Items.Add(product.ArticleNumber, basketItem);
            }

        }

        //var basketItem = Items.FirstOrDefault(x => FindByArticleNumber(x, product));

        //private bool FindByArticleNumber(BasketItem basketItem, Product product)
        //    => basketItem.Product.ArticleNumber == product.ArticleNumber;

        public void RemoveProduct(Dictionary<string, BasketItem> basket)
        {
            Write("Write articlenumber to delete: ");
            var productToDelete = ReadLine();

           
            foreach (var item in Items.Values)
            {
                
                if (productToDelete == item.Product.ArticleNumber)
                {
                    Items.Remove(item.Product.ArticleNumber);
                    break;
                }
            }

        }

        public void Empty(Dictionary<string, BasketItem> items)
        {
            
            foreach (var product in items.Values)
            {
                items.Remove(product.Product.ArticleNumber);
            }
        }

        public void ViewShoppingBasket(Dictionary<string, BasketItem> items)
        {
            Clear();

            WriteLine($"Art.no        Name          Price      |      Quantity");

            foreach (var item in Items.Values)
            {
                
                WriteLine("------------------------------------------------------");
                WriteLine($"{item.Product.ArticleNumber}    {item.Product.Name}    " +
                    $"  {item.Product.Price}       |       {item.Quantity}");
            }

            ReadKey(true);
        }

        
    }
    
}