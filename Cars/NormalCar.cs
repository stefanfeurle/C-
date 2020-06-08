using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class NormalCar : Car
    {
        public NormalCar(string model, string brand, int constructionYear, string color) : base(CarType.NORMAL, model, brand, constructionYear, color)
        {
        }
    }
}
