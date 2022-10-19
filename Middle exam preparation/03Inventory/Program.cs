using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> journalList = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] tokens = input.Split(" - ");
                string command = tokens[0];

                switch (command)
                {
                    case "Collect":
                        string addItem = tokens[1];
                        CollectItem(addItem, journalList);
                        break;
                    case "Drop":
                        string removeItem = tokens[1];
                        RemoveAItem(removeItem, journalList);
                        break;
                    case "Combine Items":
                        string[] combine = tokens[1].Split(":");
                        string oldItem = combine[0];
                        string newItem = combine[1];
                        CombineItems(oldItem, newItem, journalList);
                        break;
                    case "Renew":
                        string renewItem = tokens[1];
                        RenewItem(renewItem, journalList);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", journalList));
        }

        private static void RenewItem(string renewItem, List<string> journalList)
        {
            string itemBehindAll = renewItem;
            if (journalList.Contains(renewItem))
            {
                journalList.Remove(renewItem);
                journalList.Add(itemBehindAll);
            }
        }

        private static void CombineItems(string oldItem, string newItem, List<string> journalList)
        {
            if (journalList.Contains(oldItem))
            {
                int indexOfNewItem = journalList.IndexOf(oldItem);
                journalList.Insert(indexOfNewItem + 1, newItem);
            }
            else
            {
                return;
            }
        }

        private static void RemoveAItem(string removeItem, List<string> journalList)
        {
            if (journalList.Contains(removeItem))
            {
                journalList.Remove(removeItem);
            }
            else
            {
                return;
            }
        }

        private static void CollectItem(string addItem, List<string> journalList)
        {
           
            if (journalList.Contains(addItem)) 
            {
                return;
            }
            else
            {
                journalList.Add(addItem);
            }
        }
    }
}
