using System;
using System.Collections.Generic;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();

            Dictionary<string, double> newProductsPrice = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] tokens = input.Split();
                string product = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, price);
                    newProductsPrice.Add(product, quantity);
                }
                else if (products.ContainsKey(product))
                {
                    products.Remove(product);
                    products.Add(product, price);
                    newProductsPrice[product] += quantity;
                }
              
                
                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                foreach (var newProductPrice in newProductsPrice)
                {
                    if (product.Key == newProductPrice.Key)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Value * newProductPrice.Value:f2}");
                    }
                }   
            }
        }
    }
}

