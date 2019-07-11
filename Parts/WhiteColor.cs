using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.Parts
{
    class WhiteColor : PaintColor
    {
        public WhiteColor()
        {
            Console.WriteLine("Paint is White");
        }
    }
}
