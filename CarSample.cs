using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie6
{
    class CarSample : ICar 
    {
        public List<ICar> list;
        public CarSample()
        {
            list = new List<ICar>();
        }
        public void Add(ICar car)
        {
            list.Add(car);
        }
        public void CarInfo()
        {
            foreach(ICar c in list)
            {
                c.CarInfo();
            }
        }
    }
}
