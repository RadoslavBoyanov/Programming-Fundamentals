using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\+\-\*\/.,0-9]";
            string damagePattern = @"-?\d+\.?\d*";
            string multiplyOrDividePattern = @"[*,\/]";
            string splitPattern = @"[,\s]+";

            string input = Console.ReadLine();

            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();

            for (int i = 0; i < demons.Length; i++)
            {
                string currDemon = demons[i];

                var heathMatched = Regex.Matches(currDemon, healthPattern);

                var health = 0;

                foreach (Match match in heathMatched)
                {
                    char curChar = char.Parse(match.ToString());
                    health += curChar;
                }

                double dmg = 0;
                var dmgMatched = Regex.Matches(currDemon, damagePattern);

                foreach (Match match in dmgMatched)
                {
                    double curDmg = double.Parse(match.ToString());
                    dmg += curDmg;
                }

                var multiplyOrDivide = Regex.Matches(currDemon, multiplyOrDividePattern);

                foreach (Match match in multiplyOrDivide)
                {
                    char currOperator = char.Parse(match.ToString());
                    if (currOperator == '*')
                    {
                        dmg *= 2;
                    }
                    else
                    {
                        dmg /= 2;
                    }
                }

                Console.WriteLine($"{currDemon} - {health} health, {dmg:f2} damage");
            }
        }
    }
}
