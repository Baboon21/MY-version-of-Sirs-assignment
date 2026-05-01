using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_3
{
    internal static class InventoryService
    {
        public static List<Product> LoadFromCSV(string filePath)
        {
            List<Product> products = new List<Product>();
            if (!File.Exists(filePath)) return products;

            var lines = File.ReadAllLines(filePath).Skip(1);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Now checking for exactly 4 columns as per your new header
                if (parts.Length >= 4)
                {
                    try
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string brand = parts[2];
                        // Price is now at index 3. Divide by 100 if stored as cents.
                        decimal price = decimal.Parse(parts[3]) / 100m;

                        // Since Quantity isn't in your new CSV yet, default it to 0
                        int quantity = 0;

                        products.Add(new Product(id, name, brand, price, quantity));
                    }
                    catch
                    {
                        // Skips rows with formatting errors
                    }
                }
            }
            return products;
        }

        public static void SaveToCSV(string filePath, List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Match your new header exactly
                writer.WriteLine("ProductID,ProductName,ProductBrand,Price,Quantity");

                foreach (var p in products)
                {
                    // Converts price back to cents for storage and includes quantity
                    string line = $"{p.ProductID},{p.ProductName},{p.ProductBrand},{p.ProductPrice * 100},{p.ProductQuantity}";
                    writer.WriteLine(line);
                }
            }
        }
    }
}
