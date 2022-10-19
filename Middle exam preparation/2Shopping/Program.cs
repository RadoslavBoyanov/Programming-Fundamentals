using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _2Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split(' ');
                string typeOfCommand = tokens[0];

                switch (typeOfCommand)
                {
                    case "Urgent":
                        string product = tokens[1];
                        UrgentAItem(product, shoppingList);
                        break;
                    case "Unnecessary":
                        string foodOrDrink = tokens[1];
                        UnenecessaryProduct(foodOrDrink, shoppingList);
                        break;
                    case "Correct": 
                        string oldItem = tokens[1];
                        string newItem = tokens[2];
                        CorrectShoppingList(oldItem, newItem, shoppingList);
                        break;
                    case "Rearrange":
                        string grocery = tokens[1];
                        ChangePlaces(grocery, shoppingList);
                        break;
                }


                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", shoppingList));
        }

        private static void ChangePlaces(string grocery, List<string> shoppingList)
        {
            if (shoppingList.Contains(grocery))
            {
                int index = shoppingList.IndexOf(grocery);

                shoppingList.RemoveAt(index);

                shoppingList.Add(grocery);
            }
            else
            {
                return;
            }
        }

        [SuppressMessage("ReSharper.DPA", "DPA0003: Excessive memory allocations in LOH", MessageId = "type: System.String[]")]
        private static void CorrectShoppingList(string oldItem, string newItem, List<string> shoppingList)
        {
            if (shoppingList.Contains(oldItem))
            {
                int index = shoppingList.IndexOf(oldItem);

                if (index != -1)
                {
                    shoppingList[index] = newItem;
                }
            }
            else
            {
                return;
            }
        }

        private static void UnenecessaryProduct(string foodOrDrink, List<string> shoppingList)
        {
            if (shoppingList.Contains(foodOrDrink))
            {
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    if (foodOrDrink == shoppingList[i])
                    {
                        shoppingList.Remove(shoppingList[i]);
                    }
                }
            }
            else
            {
               return;
            }
        }

        private static void UrgentAItem(string product, List<string> shoppingList)
        {
            if (shoppingList.Contains(product))
            {
                return;
            }
            else
            {
                shoppingList.Insert(0, product);
            }
        }
    }
}
