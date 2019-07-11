using System;
using System.Collections.Generic;
using System.Text;
using Factory_cars.cars;
using Factory_cars.PartsFactory;

namespace Factory_cars.WFacility
{
    class RussiaW : Wfacility
    {
        public override Cars CreateCar(string type)
        {
            CarPartsFactory factory = new RussiaCarPartsFactory();

            if (type == "Golf")
               return new Golf(factory);
            else if (type == "Tuareg")
               return new Tuareg(factory);

            //  car.Configure();

            return null;
        }
    }
}
