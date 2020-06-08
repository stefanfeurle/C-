using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Job { get; set; }

        public Person(string name, int age, string city, string job)
        {
            Name = name;
            Age = age;
            City = city;
            Job = job;
        }
    }
}
