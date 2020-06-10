using System;
using System.Collections.Generic;
using System.Text;

namespace myFirstSmartphone.models
{
    public class App
    {
        public string Name { get; set; }
        public Category Category { get; set; }

        public App(string name, Category category)
        {
            Name = name;
            Category = category;
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual string toStart()
        {
            return $"\n{Key.START} {Key.START} {Key.START}\n{Name} {Name} {Name}\nSei schlau und schau!\n";
        }
    }
}
