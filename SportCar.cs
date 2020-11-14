using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class SportCar : ICar
    {
        public string Engine { get; set; }
        public int HorsePower { get; set; }
        public SportCar(string e, int hp)
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
