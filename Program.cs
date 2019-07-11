using System;
using Factory_cars.WFacility;

namespace Factory_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать фабрику запчастей для автомобилей

            //SImpleFactory factory = new SImpleFactory();
            //  Wfacility facility = new Wfacility(factory);

            Wfacility facility = new RussiaW();
            facility.GetCars("Golf");
            Console.WriteLine();

            facility = new GermanW();
            facility.GetCars("Golf");
            Console.WriteLine();

            //facility.GetCars("Golf");
            //facility.GetCars("Tuareg");
        }
    }
}
