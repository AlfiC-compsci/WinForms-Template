using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms_Template.Retail
{
    public struct Product
    {
        public string description;
        public decimal unitPrice;

        public bool isValid
        {
            get
            {
                bool returnValue = true;
                if(description.Length < 5) { returnValue = false; }
                if(unitPrice <= 0) { returnValue = false; }
                return returnValue;
            }
        }

        public Product(string desc, decimal price)
        {
            description = desc;
            unitPrice = price;
        }
    }

    public class ProductList
    {
        public Dictionary<string, Product> data;

        public ProductList()
        {
            data = new Dictionary<string, Product>()
            {
                { "5000000000011", new Product("Coca Cola 330ml", 1.25m) },
                { "5000000000028", new Product("Diet Coke 330ml", 1.25m) },
                { "5000000000035", new Product("Mars Bar 51g", 0.85m) },
                { "5000000000042", new Product("Snickers 48g", 0.85m) },
                { "5000000000059", new Product("Walkers Ready Salted", 1.10m) },
                { "5000000000066", new Product("Walkers Cheese & Onion", 1.10m) },
                { "5000000000073", new Product("Kit Kat Chunky", 0.95m) },
                { "5000000000080", new Product("Galaxy Bar", 1.00m) },
                { "5000000000097", new Product("Hovis Bread", 1.50m) },
                { "5000000000103", new Product("Semi Skimmed Milk 2L", 2.10m) },
                { "5000000000110", new Product("Rich Tea Biscuits", 1.20m) },
                { "5000000000127", new Product("Baked Beans", 0.90m) }
            };
        }

        public Product? GetProduct(string productCode)
        {
            if (data.ContainsKey(productCode))
            {
                return data[productCode];
            }
            else
            {
                return null;
            }
        }

        public bool AddProduct(string productCode, Product productInfo)
        {
            if(productCode.Length != 13)
            {
                return false;
            }

            if (!productInfo.isValid)
            {
                return false;
            }

            data.Add(productCode, productInfo);
            return true;
        }
    }
}
