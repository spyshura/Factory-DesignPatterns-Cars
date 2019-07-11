using Factory_cars.Parts;
using Factory_cars.PartsFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_cars.cars
{
    public abstract class Cars
    {
        protected string Name;
        protected string Body = "Caravan";

        protected Engine Engine;
        protected PaintColor PaintColor;
        protected Wheels Wheels;


        public abstract void Configure();

        // Абстрактная фабрика 
        // Паттерн предоставляет интерфейс создания взаимосвязанных или взаимозависимых обектов без указания конкретных типов

        // Фабр метод использует наследование, призван создавать лишь один продукт
        // Абстр фабрика использует композицию, призван создавать семейство продуктов сразу
       
    }
}
