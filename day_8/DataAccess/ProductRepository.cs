

using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace DataAccess
{
    public class ProductRepository : IProductRepository
    {
        const string filePath = "store.txt";

        public void Add(string name, int quantity)
        {
            var products = GetAll().ToList();
            products.Add(new Product(name, quantity));
            SaveAllProducts(products);
        }

        public void Delete(string name)
        {
            var products = GetAll().ToList();
            products.RemoveAll(x => x.Name == name);
            SaveAllProducts(products);
        }

        public IEnumerable<Product> GetAll()
        {
            if (!File.Exists(filePath))
            {
                return Enumerable.Empty<Product>();
            }
            string[] productLines = File.ReadAllLines(filePath, Encoding.UTF8);
            List<Product> allProducts = new List<Product>();

            foreach (var line in productLines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] splitted = line.Split(' ');
                if (splitted.Length != 2)
                {
                    Console.WriteLine($"Invalid line format, skipping: {line}");
                    continue;
                }

                string productName = splitted[0];
                if (!int.TryParse(splitted[1], out int productQuantity))
                {
                    Console.WriteLine($"Invalid quantity format, skipping: {splitted[1]} in line: {line}");
                    continue;
                }

                allProducts.Add(new Product(productName, productQuantity));
            }

            return allProducts;
        }

        public Product ProductGetByName(string name)
        {
            var products = GetAll();
            return products.SingleOrDefault(s => s.Name == name);
        }

        public void UpdateQuantity(string productName, int quantity)
        {
            var products = GetAll().ToList();
            var product = products.Single(s => s.Name == productName);
            product.Quantity = quantity;
            SaveAllProducts(products);
        }

        private void SaveAllProducts(IEnumerable<Product> products)
        {
            File.WriteAllLines(filePath, products.Select(s => $"{s.Name} {s.Quantity}"));
        }
    }
}


