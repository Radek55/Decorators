using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    abstract class Decorator : ICar
    {
        public void CarInfo() { }
        public void CarCost() { }
        public Decorator() { }
        //protected ICar car;   Jaki cel to ma?
    }
}
