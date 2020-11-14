using System;
using System.Text;
using System.Collections.Generic;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radoslaw Bielak IA1\nZadanie Domowe 6");
            Console.WriteLine("\nWywołanie kompozytu:\n");
            HydrogenCar h1 = new HydrogenCar("Hybrid hydrogen", 680);
            HydrogenCar h2 = new HydrogenCar("Hydrogen", 420);
            ElectricCar e1 = new ElectricCar("Hybrid electric", 740);
            ElectricCar e2 = new ElectricCar("Electric", 520);
            CarSample s1 = new CarSample();
            s1.Add(h1);
            s1.Add(h2);
            s1.Add(e1);
            s1.Add(e2);
            s1.CarInfo();

            Console.WriteLine("\nWywołanie dekoratora:\n");
            ICar ModelS = new SportCar("Petrol", 400);
            ModelS = new SportBrakesDeco(ModelS);
            ModelS = new TurbochargerDeco(ModelS);
            ICar ModelO = new OffroadCar("Diesel", 280);
            ModelO = new LeatherInteriorDeco(ModelO);
            ICar ModelC = new CityCar("Hybrid", 180);
            ModelC = new SportBrakesDeco(ModelC);
            ModelS.CarInfo();
            ModelO.CarInfo();
            ModelC.CarInfo();

        }
    }
}
