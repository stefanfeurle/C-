using Objektgenerator.models;
using System;

namespace Objektgenerator
{
    class Program //<T> 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            //ObjectGenerator<T> objectGenerator = new ObjectGenerator<T>();
            ObjectGenerator objectGenerator = new ObjectGenerator();
            //ObjectGenerator<Car> objectGeneratorCar = new ObjectGenerator<Car>();
            //ObjectGenerator<Monkey> objectGeneratorMonkey = new ObjectGenerator<Monkey>();
            //ObjectGenerator<Tiger> objectGeneratorTiger = new ObjectGenerator<Tiger>();

            var beer1 = objectGenerator.GetNewObject<Beer>();
            var beer2 = objectGenerator.GetNewObject<Beer>();

            var car1 = objectGenerator.GetNewObject<Car>();
            var car2 = objectGenerator.GetNewObject<Car>();

            var monkey1 = objectGenerator.GetNewObject<Monkey>();
            var monkey2 = objectGenerator.GetNewObject<Monkey>();

            var monkeys = objectGenerator.GetNewObjects<Monkey>(5);

            // why this not run!! find no constructor!!
            var tiger1 = objectGenerator.GetObject<Tiger>( new object[] { 4,  "Schmusekatze" });

            Console.WriteLine(tiger1);           
         
            Console.WriteLine($"\n{beer1}\n{beer2}\n\n{car1}\n{car2}\n\n{monkey1}\n{monkey2}\n");
            foreach (var monkey in monkeys)
            {
                Console.WriteLine(monkey);
            }           
        }
    }
}
