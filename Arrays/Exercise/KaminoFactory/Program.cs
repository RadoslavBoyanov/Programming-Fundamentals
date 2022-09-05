using System;
using System.Linq;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int[] DNA = new int[lenght];

            int startIndex = 0;
            int dnaSample = 0;  
            int DNAcount = 0;
            int dnaSum = 0;
            bool isBetterDna = false;

            int samples = 0;


            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] currDna = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                samples++;
                int currCount = 0;
                int currDnaSum = 0;
                int currEndIndex = 0;
                int currStartIndex = -1;

                int count = 0;
                
                for (int i = 0; i < currDna.Length; i++)
                {
                    
                    if (currDna[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;
                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }
                
                currStartIndex = currEndIndex - currCount + 1;
                currDnaSum = currDna.Sum();

                if (currCount > DNAcount)
                {
                    isBetterDna = true;
                }
                else if (currCount == DNAcount)
                {
                    if (currStartIndex < startIndex)
                    {
                        isBetterDna = true;
                    }
                    else if (currStartIndex == startIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isBetterDna = true;
                        }
                    }
                }

                if (isBetterDna)
                {
                    DNA = currDna;
                    DNAcount = currCount;
                    startIndex = currStartIndex;
                    dnaSum = currDnaSum;
                    samples = dnaSample;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {dnaSample} with sum: {dnaSum}.");

            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
