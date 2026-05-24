using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    /*This class is responsible for handling the business logic related to products, such as adding, updating, deleting, and retrieving products from the inventory.
     * It will interact with the data access layer to perform these operations and provide a clean interface for the rest of the application to use
     */
    internal static class ProductService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            /*The program builds an instance of the ProductService class,
            *  which is responsible for handling the business logic related to products.
            *  It then calls the LoadFromCSV method, passing the file path of the CSV file containing the product data. The LoadFromCSV method reads the CSV file, parses the data, 
            *  and creates a list of Product objects that represent the products in the inventory. Finally, it returns this list of products to be used by other parts of the application.
           */
            List<Product> products = new List<Product>();
            if (!File.Exists(filePath)) return products;

            var lines = File.ReadAllLines(filePath).Skip(1);


            //creates products instances and one its done it returns the list of products to the caller
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                //now checking for 4 columns as per new header and parsing the data accordingly
                if (parts.Length >= 4)
                {
                    try
                    {//ID,Name,Brand,Price,Quantity
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string brand = parts[2];
                        decimal price = decimal.Parse(parts[3]);
                        int quantity = int.Parse(parts[4]);

                        products.Add(new Product(id, name, brand, price, quantity));

                    }
                    catch 
                    {

                    }

                }
            }
            return products;

        }
    }
}
