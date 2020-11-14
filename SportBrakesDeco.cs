using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class SportBrakesDeco : Decorator
    {
        public SportBrakesDeco(ICar car)
        {
            car.CarInfo();
            Console.WriteLine(" with additional sports brakes.");
        }
    }
}
