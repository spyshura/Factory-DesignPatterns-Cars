using Factory_cars.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.PartsFactory
{
    public abstract class CarPartsFactory
    {
        public abstract Engine CreateEngine();
        public abstract PaintColor CreateColor();
        public abstract Wheels CreateWheels();
    }
}
