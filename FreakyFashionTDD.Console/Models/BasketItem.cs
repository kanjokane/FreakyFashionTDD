﻿namespace FreakyFashionTDD.Console.Models
{
    public class BasketItem
    {
        public BasketItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public Product Product { get; }
        public int Quantity { get; set; }
    }
}