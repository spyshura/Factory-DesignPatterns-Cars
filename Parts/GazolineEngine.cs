using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.Parts
{
    class GazolineEngine : Engine
    {
        public GazolineEngine()
        {
            Console.WriteLine("Engine is Gazoline");
        }
    }
}
