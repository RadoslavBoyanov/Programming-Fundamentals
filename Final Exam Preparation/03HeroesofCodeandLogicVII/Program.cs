using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace _03HeroesofCodeandLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var heroes = new Dictionary<string, KeyValuePair<int, int>>();

            for (int i = 0; i < n; i++)
            {
                var hero = Console.ReadLine().Split(" ");
                string nameOfHero = hero[0];
                int health = int.Parse(hero[1]);
                int mana = int.Parse(hero[2]);

                if (!heroes.ContainsKey(nameOfHero))
                {
                    if (health <= 100 && mana <= 200)
                    {
                        heroes.Add(nameOfHero, new KeyValuePair<int, int>(health, mana));
                    }
                }
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] tokensCmd = commands.Split(" - ");
                string action = tokensCmd[0];
                string name = tokensCmd[1];

                switch (action)
                {
                    case "CastSpell":
                        {
                            int manaCost = int.Parse(tokensCmd[2]);
                            string spellName = tokensCmd[3];
                            if (manaCost <= heroes[name].Value)
                            {
                                heroes[name] =
                                    new KeyValuePair<int, int>(heroes[name].Key, heroes[name].Value - manaCost);
                                int manaLeft = heroes[name].Value;
                                Console.WriteLine($"{name} has successfully cast {spellName} and now has {manaLeft} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                            }
                            break;
                        }
                    case "TakeDamage":
                        {
                            int damage = int.Parse(tokensCmd[2]);
                            string attacker = tokensCmd[3];
                            if (heroes[name].Key - damage > 0)
                            {
                                heroes[name] = new KeyValuePair<int, int>(heroes[name].Key - damage, heroes[name].Value);
                                int currentHp = heroes[name].Key;
                                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {currentHp} HP left!");
                            }
                            else
                            {
                                heroes.Remove(name);
                                Console.WriteLine($"{name} has been killed by {attacker}!");
                            }
                            break;
                        }
                    case "Recharge":
                        {
                            int amountMana = int.Parse(tokensCmd[2]);
                            if (heroes[name].Value + amountMana <= 200)
                            {
                                heroes[name] =
                                    new KeyValuePair<int, int>(heroes[name].Key, heroes[name].Value + amountMana);
                                Console.WriteLine($"{name} recharged for {amountMana} MP!");
                            }
                            else
                            {
                                int mana = 200 - heroes[name].Value;
                                heroes[name] = new KeyValuePair<int, int>(heroes[name].Key, 200);
                                Console.WriteLine($"{name} recharged for {mana} MP!");
                            }
                            break;
                        }
                    case "Heal":
                        {
                            int amountOfHealth = int.Parse(tokensCmd[2]);
                            if (heroes[name].Key + amountOfHealth <= 100)
                            {
                                heroes[name] = new KeyValuePair<int, int>(heroes[name].Key + amountOfHealth, heroes[name].Value);
                                Console.WriteLine($"{name} healed for {amountOfHealth} HP!");
                            }
                            else
                            {
                                int health = 100 - heroes[name].Key;
                                heroes[name] = new KeyValuePair<int, int>(100, heroes[name].Value);
                                Console.WriteLine($"{name} healed for {health} HP!");
                            }
                            break;
                        }
                }

                commands = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($" HP: {hero.Value.Key}");
                Console.WriteLine($" MP: {hero.Value.Value}");
            }
        }
    }
}
