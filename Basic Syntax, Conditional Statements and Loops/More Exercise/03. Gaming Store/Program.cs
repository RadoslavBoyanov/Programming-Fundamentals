using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double balanceDecreases = 0;
            double spentMoney = 0;
            double balance = currentBalance;

            string videoGame = Console.ReadLine();
            while (videoGame != "Game Time")
            {
                if (videoGame == "OutFall 4")
                {
                    if (currentBalance >= 39.99 )
                    {
                        currentBalance -= 39.99;
                        spentMoney += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (videoGame == "CS: OG")
                {
                    if (currentBalance >= 15.99)
                    {
                        currentBalance -= 15.99;
                        spentMoney += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (videoGame == "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        currentBalance -= 19.99;
                        spentMoney += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (videoGame == "Honored 2")
                {
                    if (currentBalance >= 59.99)
                    {
                        currentBalance -= 59.99;
                        spentMoney += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (videoGame == "RoverWatch")
                {
                    if (currentBalance >= 29.99)
                    {
                        currentBalance -= 29.99;
                        spentMoney += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (videoGame == "RoverWatch Origins Edition")
                {
                    if (currentBalance >= 39.99)
                    {
                        currentBalance -= 39.99;
                        spentMoney += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                videoGame = Console.ReadLine();
            }
            double diff = balance - spentMoney; 
            Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${diff:f2}");
        }
    }
}
