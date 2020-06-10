using System;
using System.Collections.Generic;
using System.Text;

namespace myFirstSmartphone.models
{
    public class Game : App
    {
        public int SuitableAge { get; set; }
        public SubCategory SubCategory { get; set; }

        public Game(string name, Category category, int suitableAge, SubCategory subCategory) : base(name, category)
        {
            SuitableAge = suitableAge;
            SubCategory = subCategory;
        }

        public override string ToString()
        {
            return Name;
        }

        public override string toStart() => $"\n{Key.START} {Key.START} {Key.START}\n{Name} {Name} {Name}\nLass uns Spielen und Spaß haben!\n";
    }
}
