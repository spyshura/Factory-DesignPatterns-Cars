using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.Parts
{
    class BigWheels : Wheels
    {
        public BigWheels()
        {
            Console.WriteLine("Wheels is big");
        }
    }
}
