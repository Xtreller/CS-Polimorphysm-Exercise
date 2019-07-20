using Defining_Classes;
using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {

            List<Tire[]> tires = new List<Tire[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }
                string[] tireInfo = input.Split();
                var Tire = new Tire[4]
                    {
                        new Tire(int.Parse(tireInfo[0]),double.Parse(tireInfo[1])),
                        new Tire(int.Parse(tireInfo[2]),double.Parse(tireInfo[3])),
                        new Tire(int.Parse(tireInfo[4]),double.Parse(tireInfo[5])),
                        new Tire(int.Parse(tireInfo[6]),double.Parse(tireInfo[7])),
                        };
                tires.Add(Tire);

            }
            List<Engine> engines = new List<Engine>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }
                string[] currentEngine = input.Split();
                var Engine = new Engine(int.Parse(currentEngine[0]), double.Parse(currentEngine[1]));
                engines.Add(Engine);

            }
            List<Car> cars = new List<Car>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }
                string[] currentCar = input.Split();
                string make = currentCar[0];
                string model = currentCar[1];
                int year = int.Parse(currentCar[2]);
                int fuelQuantity = int.Parse(currentCar[3]);
                double fuelConsumption = double.Parse(currentCar[4]);
                int engineIndex = int.Parse(currentCar[5]);
                int tiresIndex = int.Parse(currentCar[6]);

                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }
            List<Car> specialCars = new List<Car>();
            foreach (var car in cars)
            {
                car.FuelQuantity -= (20 * car.FuelConsumption);
                if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    double pressureSum = 0;
                    foreach (var item in car.Tire)
                    {
                        pressureSum += item.Pressure;
                    }
                    if (pressureSum > 9 && pressureSum < 10)
                    {

                        Console.WriteLine($"Make: {car.Make}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Year: {car.Year}");
                        Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                        Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");

                    }


                }

            }

        }
    }
}
