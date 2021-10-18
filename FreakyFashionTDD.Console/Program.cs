using FreakyFashionTDD.Console.Models;
using System;
using System.Collections.Generic;
using static System.Console;

namespace FreakyFashionTDD.Console
{
    public class Program
    {
        static ShoppingBasket basket = new ShoppingBasket();

        static Dictionary<string, Product> productDictionary = new Dictionary<string, Product>
        {
            { "ABC123", new Product("ABC123", "Black T-Shirt", 199) },
            { "DEF456", new Product("DEF456", "Magenta T-Shirt", 249) },
            { "GHI789", new Product("GHI789", "Cyan T-Shirt", 349) }
        };
        

        static void Main(string[] args)
        {
            
            bool applicationRunning = true;

            do
            {
                WriteLine("1. View products");
                WriteLine("2. Remove product");
                WriteLine("3. Remove all products in basket");
                WriteLine("4. View shopping basket");
                WriteLine("5. Exit");

                CursorVisible = false;

                ConsoleKeyInfo input;
                bool invalidChoice;

                do
                {
                    input = ReadKey(true);

                    invalidChoice = !(input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1
                        || input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2 ||
                        input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3 ||
                        input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4 ||
                        input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5);

                } while (invalidChoice);

                Clear();

                CursorVisible = true;


                switch (input.Key)
                {
                    case ConsoleKey.D1:

                        ViewProducts();

                        break;

                    case ConsoleKey.D2:

                        
                        basket.RemoveProduct(basket.Items);

                        break;

                    case ConsoleKey.D3:

                        basket.Empty(basket.Items);
                        
                        
                     break;

                    case ConsoleKey.D4:

                        basket.ViewShoppingBasket(basket.Items);

                        break;

                    case ConsoleKey.D5:

                        applicationRunning = false;

                        break;
                }

                Clear();

            } while (applicationRunning);
        }
        
        public static void ViewProducts()
        {

            WriteLine($"Art.no        Name                   Price");
            WriteLine("------------------------------------------------------");

            foreach (Product product in productDictionary.Values)
            {
                WriteLine($"{product.ArticleNumber}       {product.Name}      {product.Price}");
            }

            WriteLine();
            Write("(A)dd to cart");

            ReadKey(true);

            Clear();

            Write("Art.no: ");

            string articleNumber = ReadLine();

            Write("Quantity: ");

            // TODO: Use more restrictive integer variant
            int quantity = int.Parse(ReadLine());


            Product selectedProduct = productDictionary[articleNumber];

            // TODO: Add product to shopping cart
            
            basket.AddProduct(selectedProduct, quantity);

            

            WriteLine("\nProduct added to cart");
            ReadKey(true);
        }

    }
}
