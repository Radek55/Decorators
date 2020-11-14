using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class LeatherInteriorDeco : Decorator
    {
        public LeatherInteriorDeco(ICar car)
        {
            car.CarInfo();
            Console.WriteLine(" with additional leather interior.");
        }
    }
}
