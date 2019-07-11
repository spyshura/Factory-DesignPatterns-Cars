using Factory_cars.PartsFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.cars
{
    class Tuareg : Cars
    {
        private CarPartsFactory _factory;
        public Tuareg(CarPartsFactory factory)
        {
            Name = "Tuareg";
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
