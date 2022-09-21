using System;
using System.Collections.Generic;
using System.Linq;

namespace _06StoreBoxes
{
    class Box
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
        public decimal TotalPriceBox { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (strings[0] != "end")
            {
                Box box = new Box();

                string serialNumber = strings[0];
                string name = strings[1];
                int quantity = int.Parse(strings[2]);
                decimal price = decimal.Parse(strings[3]);
                decimal totalPrice = quantity * price;

                box.SerialNumber = serialNumber;
                box.Name = name;
                box.ItemQuantity = quantity;
                box.PriceForABox = price;
                box.TotalPriceBox = totalPrice;
                boxes.Add(box);

                strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            List<Box> sortiBoxes = boxes.OrderByDescending(boxes => boxes.TotalPriceBox).ToList();

            foreach (Box box in sortiBoxes)
            {
                Console.WriteLine($" {box.SerialNumber}");
                Console.WriteLine($"-- {box.Name} - ${box.PriceForABox:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.TotalPriceBox:f2}");
            }
        }
    }
}
