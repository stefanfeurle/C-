using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Stefan says: ";
            Console.WriteLine(myName + "Hello World!");

            List<Person> persons = new List<Person>();

            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\persons.txt");

            foreach (var myFileContetLine in myFileContent)
            {
                Console.WriteLine(myFileContetLine);
                string[] splitValue = myFileContetLine.Split(';');
                string name = splitValue[0];
                int age = int.Parse(splitValue[1]);
                string city = splitValue[2];
                string job = "";

                if (age < 50)
                {
                    job = "Coder";
                } else
                {
                    job = "Officer";
                }

                Person person = new Person(name, age, city, job);
                persons.Add(person);
            };

            List<string> myNewFile = new List<string>();

            foreach (Person person in persons)
            {
                //var myFileContentLine = person.Name + ';' + person.Age + ';' + person.City + ';' + person.Job;
                var myFileContentLine = $"{person.Name};{person.Age};{person.City};{person.Job}";
                Console.WriteLine(myFileContentLine);
                myNewFile.Add(myFileContentLine);

            }
            System.IO.File.WriteAllLines("C:\\Users\\DCV\\stefan\\IdeaProjects\\CodingCampus\\6. C#\\persons1.txt", myNewFile);
        }
    }
}
