using Factory_cars.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.PartsFactory
{
    class GermanCarPartsFactory : CarPartsFactory
    {
        public override PaintColor CreateColor()
        {
            return new WhiteColor();
        }

        public override Engine CreateEngine()
        {
            return new DiezelEngine();
        }

        public override Wheels CreateWheels()
        {
            return new BigWheels();
        }
    }
}
