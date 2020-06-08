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
            ObjectGenerator<Beer> objectGeneratorBeer = new ObjectGenerator<Beer>();
            ObjectGenerator<Car> objectGeneratorCar = new ObjectGenerator<Car>();
            ObjectGenerator<Monkey> objectGeneratorMonkey = new ObjectGenerator<Monkey>();
            ObjectGenerator<Tiger> objectGeneratorTiger = new ObjectGenerator<Tiger>();

            var beer1 = objectGeneratorBeer.GetNewObject<Beer>();
            var beer2 = objectGeneratorBeer.GetNewObject<Beer>();

            var car1 = objectGeneratorCar.GetNewObject<Car>();
            var car2 = objectGeneratorCar.GetNewObject<Car>();

            var monkey1 = objectGeneratorMonkey.GetNewObject<Monkey>();
            var monkey2 = objectGeneratorMonkey.GetNewObject<Monkey>();

            var monkeys = objectGeneratorMonkey.GetNewObjects<Monkey>(5);

            // why this not run!! find no constructor!!
            //var tiger1 = objectGeneratorTiger.GetObject(new Tiger[2], new object[] { 4,  "Schmusekatze" });

            //Console.WriteLine(tiger1);           
         
            Console.WriteLine($"{beer1}\n{beer2}\n\n{car1}\n{car2}\n\n{monkey1}\n{monkey2}\n");
            foreach (var monkey in monkeys)
            {
                Console.WriteLine(monkey);
            }
        }
    }
}
