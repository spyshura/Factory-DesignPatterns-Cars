using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.Parts
{
    class MiniWheels : Wheels
    {
        public MiniWheels()
        {
            Console.WriteLine("Wheels is mini");
        }
    }
}
