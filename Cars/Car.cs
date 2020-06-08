using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Car
    {
        public CarType CarType { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int ConstructionYear { get; set; }
        public string Color { get; set; }
        public int MyProperty { get; set; }

        public Car(CarType carType, string model, string brand, int constructionYear, string color)
        {
            CarType = carType;
            Model = model;
            Brand = brand;
            ConstructionYear = constructionYear;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({ConstructionYear}/{Color}) --> ";
        }
    }
}
