namespace P01_CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using P01_CarManufacturer.Cars;
    using P01_CarManufacturer.Cars.CarParts;

    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> setsOfTires = new List<Tire[]>();

            // setsOfTires
            // 0 -> [Tire(2, 2.4), Tire(2, 2.4), Tire(2, 2.4), Tire(2, 2.4)]
            // 1 -> [Tire(3, 1.4), Tire(3, 1.4), Tire(3, 1.4), Tire(3, 1.4)]

            // 2 2.6 3 1.6 2 3.6 3 1.6
            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                List<string> tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                List<Tire> tires = new List<Tire>(); 
                for (int index = 0; index < tokens.Count; index += 2)   
                {
                    int year = int.Parse(tokens[index]);
                    double pressure = double.Parse(tokens[index + 1]);

                    Tire tire = new Tire(year, pressure);
                    tires.Add(tire);
                }

                setsOfTires.Add(tires.ToArray());

                input = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();

            string enginesInput = Console.ReadLine();
            while (enginesInput != "Engines done")
            {
                List<string> tokens = enginesInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                int horsePower = int.Parse(tokens[0]);
                double cubicCapacity = double.Parse(tokens[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);

                enginesInput = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();

            string carsInput = Console.ReadLine();
            while (carsInput != "Show special")
            {
                List<string> tokens = carsInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string make = tokens[0];
                string model = tokens[1];
                int year = int.Parse(tokens[2]);
                double fuelQuantity = double.Parse(tokens[3]);
                double fuelConsumption = double.Parse(tokens[4]);
                int setTiresIndex = int.Parse(tokens[5]);
                int engineIndex = int.Parse(tokens[6]);

                Engine engine = engines[engineIndex];
                Tire[] tires = setsOfTires[setTiresIndex];

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);

                cars.Add(car);

                carsInput = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                double tiresPressure = car
                    .Tires
                    .Sum(tire => tire.Pressure);

                if (car.Year >= 2017
                    && car.Engine.HorsePower > 330
                    && (tiresPressure >= 9 && tiresPressure <= 10))
                {
                    car.Drive(20);

                    Console.WriteLine(car.ToString());
                }
            }
        }
    }
}
