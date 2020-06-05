using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class ProductData
    {
        private static string productTextFile = "ProductData.txt";

        public static void AddNewProduct(ProductModel product)
        {
            List<ProductModel> products = GetAllProducts();

            AddProductToProductList(products, product);

            List<string> lines = ConvertModelsToText(products);

            File.WriteAllLines(productTextFile, lines);
        }


        public static void AddProductToProductList(List<ProductModel> products, ProductModel newProduct)
        {
            products.Add(newProduct);
        }


        public static List<string> ConvertModelsToText(List<ProductModel> products)
        {
            List<string> output = new List<string>();

            foreach (ProductModel product in products)
            {
                output.Add($"{ product.ProductName },{ product.Price },{ product.Quantity }");
            }

            return output;
        }

        public static List<ProductModel> GetAllProducts()
        {
            List<ProductModel> output = new List<ProductModel>();
            string[] lines = File.ReadAllLines(productTextFile);

            foreach (string line in lines)
            {
                string[] info = line.Split(',');
                output.Add(new ProductModel { ProductName = info[0], Price = decimal.Parse(info[1]), Quantity = int.Parse(info[2]) });
            }

            return output;
        }


       
    }
}
