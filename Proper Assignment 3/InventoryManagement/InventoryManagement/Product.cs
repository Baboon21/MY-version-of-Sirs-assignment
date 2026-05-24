using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        //next comes the constructor for the product class building a new product with the properties above(like a new object of the same type).
        public Product(int id, string name, string brand, decimal price, int quantity)
        {
            ProductID = id;
            ProductName = name;
            ProductBrand = brand;
            ProductPrice = price;
            ProductQuantity = quantity;
        }
        public void displayProduct()
        {
            Console.WriteLine($"ID: {ProductID}");
            Console.WriteLine($"Name: {ProductName}");
            Console.WriteLine($"Brand: {ProductBrand}");
            Console.WriteLine($"Price: {ProductPrice:C}");
            Console.WriteLine($"Quantity: {ProductQuantity}");
        }

        public static void displayall(List<Product> products)
        {
            foreach (var product in products)
            {
                product.displayProduct();
                Console.WriteLine("--------------------");
            }
        }
    }
}
