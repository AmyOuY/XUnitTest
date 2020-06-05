using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string ProductInfo
        {
            get
            {
                return $"{ ProductName }     price: { Price }     quantity: { Quantity }";
            }
        }
    }
}
