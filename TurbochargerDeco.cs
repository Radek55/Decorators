using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class TurbochargerDeco : Decorator
    {
        public TurbochargerDeco(ICar car)
        {
            car.CarInfo();
            Console.WriteLine(" with additional turbocharger.");
        }
    }
}
