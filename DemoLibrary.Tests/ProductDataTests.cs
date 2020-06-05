using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class ProductDataTests
    {
        [Fact]
        public void AddProductToProductList_ShouldWork()
        {
            ProductModel product = new ProductModel { ProductName = "Pineapple", Price = 1M, Quantity = 8 };
            List<ProductModel> products = new List<ProductModel>();
            ProductData.AddProductToProductList(products, product);

            Assert.True(products.Count == 1);
            Assert.Contains<ProductModel>(product, products);
        }


        [Theory]
        [InlineData("", 2, 4, "ProductName")]
        [InlineData("watermelon", -1.5, 4, "Price")]
        [InlineData("watermelon", 2, -6, "Quantity")]
        public void AddProductToProductList_ShouldFail(string productName, decimal price, int quantity, string param)
        {
            ProductModel newProduct = new ProductModel { ProductName = productName, Price = price, Quantity = quantity };
            List<ProductModel> products = new List<ProductModel>();

            Assert.Throws<ArgumentException>(param, () => ProductData.AddProductToProductList(products, newProduct));
        }


        [Fact]
        public void ConvertModelsToText_ShouldWork()
        {
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel { ProductName = "grapefruit", Price = 1, Quantity = 10 });
            products.Add(new ProductModel { ProductName = "peach", Price = 0.2M, Quantity = 20 });
            products.Add(new ProductModel { ProductName = "prune", Price = 0.1M, Quantity = 10 });
            List<string> output = ProductData.ConvertModelsToText(products);

            Assert.True(output.Count == 3);
            Assert.Contains<string>("grapefruit,1,10", output);
            Assert.Contains<string>("peach,0.2,20", output);
            Assert.Contains<string>("prune,0.1,10", output);

            Assert.Equal("grapefruit,1,10", output[0]);
            Assert.Equal("peach,0.2,20", output[1]);
            Assert.Equal("prune,0.1,10", output[2]);
        }


        [Fact]
        public void ConvertTextToModel_ShouldWork()
        {
            string[] lines = { "grapefruit,1,10", "peach,0.2,20", "prune,0.1,10" };

            List<ProductModel> output = ProductData.ConvertTextToModels(lines);

            Assert.True(output.Count == 3);

            Assert.Equal("grapefruit", output[0].ProductName);
            Assert.Equal(1, output[0].Price);
            Assert.Equal(10, output[0].Quantity);

            Assert.Equal("peach", output[1].ProductName);
            Assert.Equal(0.2M, output[1].Price);
            Assert.Equal(20, output[1].Quantity);

            Assert.Equal("prune", output[2].ProductName);
            Assert.Equal(0.1M, output[2].Price);
            Assert.Equal(10, output[2].Quantity);

        }

    }
}
