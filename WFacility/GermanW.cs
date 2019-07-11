using Factory_cars.cars;
using Factory_cars.PartsFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.WFacility
{
    class GermanW : Wfacility
    {
        //Фабричный метод:
        // Создатели: WFacility - GetCar(), CreateCar() - фм
        // Наследники

        // Продукт: Car и наследники

        // Параллелизм: две иерархии Фасилити и кар

        // Паттерн позволяет определить общий интерфейс создания объектов, при этом позволяя подклассам выбирать конкретный продукт для создания

        // Паттерн инкапсулирует создание объектов
        public override Cars CreateCar(string type)
        {

            CarPartsFactory factory = new GermanCarPartsFactory();

            if (type == "Golf")
               return new Golf(factory);
            else if (type == "Tuareg")
                return new Tuareg(factory);

            return null;
        }
    }
}
