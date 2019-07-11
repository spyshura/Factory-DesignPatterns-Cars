using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.Parts
{
    class DiezelEngine : Engine
    {
        public DiezelEngine()
        {
            Console.WriteLine("Engine is Diezel");
        }
    }
}
