using System;
using System.Collections.Generic;
using System.Text;

namespace Objektgenerator.models
{
    public class Tiger
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Tiger(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return "Tiger";
        }
    }
}
