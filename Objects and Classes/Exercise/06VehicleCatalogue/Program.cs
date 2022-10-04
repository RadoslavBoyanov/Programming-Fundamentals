using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Channels;

namespace _06VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Cars> carsList = new List<Cars>();
            List<Truck> trucksList = new List<Truck>();
            List<Vehicle> vehiclesList = new List<Vehicle>();

            while (input != "End")
            {
                string[] tokens = input.Split(" ").ToArray();
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                double horsepower = double.Parse(tokens[3]);

                Truck truck = new Truck(type, model, color, horsepower);
                Cars cars = new Cars(type, model, color, horsepower);
                Vehicle vehicle = new Vehicle(type, model, color, horsepower);

                vehiclesList.Add(vehicle);
                if (type == "truck")
                {
                    trucksList.Add(truck);
                }
                else
                {
                    carsList.Add(cars);
                }

                input = Console.ReadLine();
            }

           
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Close the Catalogue")
                {
                    break;
                }

                Console.WriteLine(vehiclesList.Find(x => x.Model == command));
            }
           
            

            if (carsList.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {((carsList.Sum(x => x.Horsepower)) / carsList.Count):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucksList.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {((trucksList.Sum(x => x.Horsepower)) / trucksList.Count):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }

        class Cars
        {
            public Cars(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

        }
        class Truck
        {
            public Truck(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

        }

        class Vehicle
        {
            public Vehicle(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

            public override string ToString()
            {
                string vehicle = $"Type: {(this.Type == "car" ? "Car" : "Truck")} {Environment.NewLine} " +
                               $"Model: {this.Model}{Environment.NewLine}" +
                               $"Color: {this.Color}{Environment.NewLine}" +
                               $"Horsepower: {this.Horsepower}";
                return vehicle;
            }
        }

    }
}
