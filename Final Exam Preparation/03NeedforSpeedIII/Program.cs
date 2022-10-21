using System;
using System.Collections.Generic;
using System.Linq;

namespace _03NeedforSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, KeyValuePair<int, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                string carName = car[0];
                int mileage = int.Parse(car[1]);
                int fuel = int.Parse(car[2]);

                if (!cars.ContainsKey(carName))
                {
                    cars.Add(carName, new KeyValuePair<int, int>(mileage, fuel));
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokensCmd = command.Split(" : ");
                string operation = tokensCmd[0];
                string car = tokensCmd[1];

                switch (operation)
                {
                    case "Drive":
                    {
                        int distance = int.Parse(tokensCmd[2]);
                        int fuel = int.Parse(tokensCmd[3]);
                        if (fuel < cars[car].Value)
                        {
                                cars[car] = new KeyValuePair<int, int>(cars[car].Key + distance , cars[car].Value - fuel);
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }
                        else if (fuel > cars[car].Value)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        if (cars[car].Key >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                        break;
                    }
                    case "Refuel":
                    {
                        int fuel = int.Parse(tokensCmd[2]);
                        int tankLimit = 75;
                        if (cars[car].Value + fuel <= tankLimit)
                        {
                            cars[car] = new KeyValuePair<int, int>(cars[car].Key, cars[car].Value + fuel);
                            Console.WriteLine($"{car} refueled with {fuel} liters");
                        }
                        else if (cars[car].Value + fuel >= tankLimit)
                        {
                            int whenIsMoreFuel = tankLimit - cars[car].Value;
                                cars[car] = new KeyValuePair<int, int>(cars[car].Key, tankLimit);
                                Console.WriteLine($"{car} refueled with {whenIsMoreFuel} liters");
                        }
                        break;
                    }
                    case "Revert":
                    {
                        int kilometers = int.Parse(tokensCmd[2]);
                        if (cars[car].Key - kilometers >= 10000)
                        {
                            cars[car] = new KeyValuePair<int, int>(cars[car].Key - kilometers, cars[car].Value);
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        else if (cars[car].Key - kilometers < 10000)
                        {
                            cars[car] = new KeyValuePair<int, int>(10000, cars[car].Value);
                        }
                        break;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Key} kms, Fuel in the tank: {car.Value.Value} lt.");   
            }
        }
    }
}
