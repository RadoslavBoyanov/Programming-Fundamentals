using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _07VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();
            List<Truck> truckList = new List<Truck>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split("/", StringSplitOptions.RemoveEmptyEntries);

                string typeVehicle = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int horsePower = int.Parse(tokens[3]);
                if (typeVehicle == "Car")
                {
                    Car cars = new Car();
                    cars.Brand = brand;
                    cars.Model = model;
                    cars.HorsePower = horsePower;
                    carsList.Add(cars);
                }
                else if (typeVehicle == "Truck")
                {
                    Truck trucks = new Truck();
                    trucks.Brand = brand;
                    trucks.Model = model;
                    trucks.Weight = horsePower;
                    truckList.Add(trucks);
                }

                input = Console.ReadLine();
            }

            List<Car> filterCars = carsList.OrderBy(cars => cars.Brand).ToList();
            List<Truck> filterTrucks = truckList.OrderBy(trucks => trucks.Brand).ToList();

            if (carsList.Count != 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in filterCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (truckList.Count != 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in filterTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
    }
}
