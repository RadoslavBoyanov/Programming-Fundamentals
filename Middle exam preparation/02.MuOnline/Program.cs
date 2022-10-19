using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _02.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dungeon = Console.ReadLine().Split('|').ToList();

            int initinialHealth = 100;

            int initinialBitcoins = 0;

            int rooms = 0;

            for (int i = 0; i < dungeon.Count; i++)
            {
                string[] splitCommand = dungeon[i].Split(' ');

                string tokens = splitCommand[0];

                switch (tokens)
                {
                    case "potion":
                        rooms++;
                        int bonusHealth = int.Parse(splitCommand[1]);
                        if (initinialHealth + bonusHealth <= 100)
                        {
                            initinialHealth += bonusHealth;

                            Console.WriteLine($"You healed for {bonusHealth} hp.");
                            Console.WriteLine($"Current health: {initinialHealth} hp.");
                        }
                        else
                        {
                            if (initinialHealth + bonusHealth > 100)
                            {
                                int addHealth = 0;
                                for (int j = 0; j < bonusHealth; j++)
                                {
                                    initinialHealth += i;
                                    addHealth++;
                                    if (initinialHealth == 100)
                                    {
                                        break;
                                    }
                                }
                                Console.WriteLine($"You healed for {addHealth} hp.");
                                Console.WriteLine($"Current health: {initinialHealth} hp.");
                            }
                        }
                        break;
                    case "chest":
                        rooms++;
                        int addBitcoins = int.Parse(splitCommand[1]);
                        initinialBitcoins += addBitcoins;
                        Console.WriteLine($"You found {addBitcoins} bitcoins.");
                        break;
                    default:
                        rooms++;
                        string monster = splitCommand[0];
                        int attackOfTheMonster = int.Parse(splitCommand[1]);
                        initinialHealth -= attackOfTheMonster;
                        if (initinialHealth > 0)
                        {
                            Console.WriteLine($"You slayed {monster}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monster}.");
                            Console.WriteLine($"Best room: {rooms}");

                            return;
                        }
                        break;
                }

            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {initinialBitcoins}");
            Console.WriteLine($"Health: {initinialHealth}");
        }
    }
}