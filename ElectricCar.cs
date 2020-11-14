using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class ElectricCar : ICar
    {
        public string Engine { get; set; } //dlaczego w instrukcji jest private set?
        public int HorsePower { get; set; }
        public ElectricCar(string e, int hp)
        {
            Engine = e;
            HorsePower = hp;
        }
        public void CarInfo()
        {
            Console.WriteLine("Car with " + Engine + " engine and " + HorsePower + "hp");
        }
    }
}
