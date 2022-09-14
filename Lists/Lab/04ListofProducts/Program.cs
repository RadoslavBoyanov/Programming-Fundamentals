using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string typeOfProduct = Console.ReadLine();
                products.Add(typeOfProduct);
            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

        }
    }
}
