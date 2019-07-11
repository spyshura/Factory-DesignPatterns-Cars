using System;
using System.Collections.Generic;
using System.Text;
using Factory_cars.Parts;

namespace Factory_cars.PartsFactory
{
    class RussiaCarPartsFactory : CarPartsFactory
    {
        public override PaintColor CreateColor()
        {
            return new RedPaint();
        }

        public override Engine CreateEngine()
        {
            return new GazolineEngine();
        }

        public override Wheels CreateWheels()
        {
            return new MiniWheels();
        }
    }
}
