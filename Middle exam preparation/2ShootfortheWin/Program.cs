using System;
using System.Collections.Generic;
using System.Linq;

namespace _2ShootfortheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequenseInts = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            string comand = Console.ReadLine();
            int counter = 0;
            while (comand != "End")
            {
                int index = int.Parse(comand);
                
                
                int lenght = sequenseInts.Count - 1;

                if (index >= 0 && index <= lenght)
                {
                    int number = sequenseInts[index];
                    sequenseInts[index] = -1;
                    counter++;
                    for (int i = 0; i < sequenseInts.Count; i++)
                    {
                        if (sequenseInts[i] > 0)
                        {
                            if (number >= sequenseInts[i])
                            {
                                sequenseInts[i] += number;
                            }
                            else
                            {
                                sequenseInts[i] -= number;
                            }
                        }
                    }
                }
                

                comand = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {String.Join(' ', sequenseInts)}");
        }

    }
}
