using Factory_cars.cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.WFacility
{
     abstract class Wfacility
    {
        //SImpleFactory _factory;

        //public Wfacility(SImpleFactory factory)
        //{
        //    _factory = factory;
        //}
        public Cars GetCars(string type)
        {
            //Cars car = _factory.GetCars(type);
            Cars car = CreateCar(type);
            car.Configure();

            return car;
        }

        public abstract Cars CreateCar(string type);
    }
}
