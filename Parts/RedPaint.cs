using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.Parts
{
    class RedPaint : PaintColor
    {
        public RedPaint()
        {
            Console.WriteLine("Color is Red");
        }
    }
}
