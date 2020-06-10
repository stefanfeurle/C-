using System;
using System.Collections.Generic;
using System.Text;

namespace Kaefig
{
    public class Tiger
    {
        public string Name { get; set; }

        public Tiger(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} (Tiger)";
        }
    }
}
