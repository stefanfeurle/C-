 using System;
using System.Collections.Generic;
using System.Text;

namespace Kaefig
{
    public class Monkey
    {
        public string Name { get; set; }

        public Monkey(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} (Monkey)";
        }
    }
}
