using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kaefig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello World!\n");
            Cage<Tiger> tigerCage = new Cage<Tiger>();
            Cage<Monkey> monkeyCage = new Cage<Monkey>();

            Monkey monkey1 = new Monkey("Affe 1");
            Monkey monkey2 = new Monkey("Affe 2");
            Monkey monkey3 = new Monkey("Affe 3");

            Tiger tiger1 = new Tiger("Katze 1");
            Tiger tiger2 = new Tiger("Katze 2");
            Tiger tiger3 = new Tiger("Katze 3");

            monkeyCage.addAnimal(monkey1);
            monkeyCage.addAnimal(monkey2);
            monkeyCage.addAnimal(monkey3);
            monkeyCage.removeAnimal(monkey2);

            tigerCage.addAnimal(tiger1);
            tigerCage.addAnimal(tiger2);
            tigerCage.addAnimal(tiger3);
            tigerCage.removeAnimal(tiger2);

            var monkeys = monkeyCage.getListT();            
            List<Tiger> tigers = tigerCage.getListT();

            foreach (var tiger in tigers)
            {
                Console.WriteLine(tiger.ToString());
            }
            Console.WriteLine();
            foreach (var monkey in monkeys)
            {
                Console.WriteLine(monkey.ToString());
            }
        }
    }
}
