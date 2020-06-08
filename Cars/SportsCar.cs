using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class SportsCar : Car 
    {
        public SportsCar(string model, string brand, int constructionYear, string color) : base(CarType.SPORTS, model,brand,constructionYear,color)
        {         
        }
    }
}
