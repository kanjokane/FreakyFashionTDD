using FreakyFashionTDD.Console.Models;
using System.Linq;
using Xunit;

namespace FreakyFashionTDD.Tests
{
    public class ShoppingBasketTests
    {
        [Fact]
        public void AddProduct_Should_Add_Product_To_Basket()
        {
            // Arrange
            var sut = new ShoppingBasket();

            var product = new Product("ABC123", "Black T-Shirt", 199);
            var quantity = 2;

            // Act
            sut.AddProduct(product, quantity);

            // Assert

            // TODO: Use other means of checking collection size
            Assert.Single(sut.Items);
        }

        [Fact]
        public void AddProduct_Should_Increase_Quantity_When_Adding_Existing_Product()
        {
            // Arrange
            var sut = new ShoppingBasket();

            var product = new Product("ABC123", "Black T-Shirt", 199);

            sut.AddProduct(product, quantity: 1);

            // Act
            sut.AddProduct(product, quantity: 2);

            // Assert
            Assert.Single(sut.Items);
            Assert.Equal(3, sut.Items[product.ArticleNumber].Quantity);
        }

        [Fact]
        public void RemoveProduct_Should_Remove_Product_From_Basket()
        {
            // Arrange
            var sut = new ShoppingBasket();

            var product = new Product("ABC123", "Black T-Shirt", 199);

            sut.RemoveProduct(sut.Items);
            // Act
            sut.RemoveProduct(sut.Items);

            // Assert
            Assert.Single(sut.Items);
            Assert.Equal("ABC123", product.ArticleNumber);
        }

        [Fact]
        public void Empty_Should_Remove_All_Products_From_Basket()
        {
            // Arrange
            var sut = new ShoppingBasket();

            // Act
            sut.Empty(sut.Items);

            // Assert
            Assert.Single(sut.Items);
        }

        [Fact]
        public void ViewShoppingBasket_Should_Show_Shopping_Basket()
        {
            // Arrange
            var sut = new ShoppingBasket();

            // Act
            sut.ViewShoppingBasket(sut.Items);

            // Assert
            Assert.Single(sut.Items);


        }
    }
}
