using Factory_cars.PartsFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.cars
{
    class Golf : Cars
    {
        private CarPartsFactory _factory;
        public Golf(CarPartsFactory factory)
        {
            Name = "Golf";
            _factory = factory;
        }
        public override void Configure()
        {
            Console.WriteLine("Configuring {0}", Name);
            Console.WriteLine("Body {0}", Body);

            Engine = _factory.CreateEngine();
            PaintColor = _factory.CreateColor();
            Wheels = _factory.CreateWheels();           
        }
    }
}
