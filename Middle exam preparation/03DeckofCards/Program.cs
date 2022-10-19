using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _03DeckofCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfCard = Console.ReadLine().Split(", ").ToList();

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(", ");
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string card = tokens[1];
                        AddCard(card, listOfCard);
                        break;
                    case "Remove":
                        string cardForRemove = tokens[1];
                        RemoveCard(cardForRemove, listOfCard);
                        break;
                    case "Remove At":
                        int indexRemove = int.Parse(tokens[1]);
                        RemoveAt(indexRemove, listOfCard);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string nameOfCard = tokens[2];
                        Insert(index, nameOfCard, listOfCard);
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", listOfCard));
        }

        private static void Insert(int index, string nameOfCard, List<string> listOfCard)
        {
            if (index < 0 || index > listOfCard.Count - 1)
            {
                Console.WriteLine("Index out of range");
            }
            else if (listOfCard.Contains(nameOfCard))
            {
                Console.WriteLine("Card is already added");
            }
            else
            {
                listOfCard.Insert(index, nameOfCard);
                Console.WriteLine("Card successfully added");
            }
        }

        private static void RemoveAt(int indexRemove, List<string> listOfCard)
        {
            if (indexRemove < 0 || indexRemove > listOfCard.Count - 1)
            {
                Console.WriteLine("Index out of range");
            }
            else
            {
                listOfCard.RemoveAt(indexRemove);
                Console.WriteLine("Card successfully removed");
            }
        }

        private static void RemoveCard(string cardForRemove, List<string> listOfCard)
        {
            if (listOfCard.Contains(cardForRemove))
            { 
                listOfCard.Remove(cardForRemove);
                Console.WriteLine("Card successfully removed");
            }
            else
            {
                Console.WriteLine("Card not found");
            }
        }

        private static void AddCard(string card, List<string> listOfCard)
        {
            if (listOfCard.Contains(card))
            {
                Console.WriteLine("Card is already in the deck");
            }
            else
            {
                listOfCard.Add(card);
                Console.WriteLine("Card successfully added");
            }
        }
    }
}
