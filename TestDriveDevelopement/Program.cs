using System;
using TestDriveDevelopement.Extensions;

namespace TestDriveDevelopement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\nHello World!\n");

            var coffee = Breakfast.PourCoffee();
            Console.WriteLine(coffee);

            Console.WriteLine(coffee.Temperature);
            Console.WriteLine(coffee.Temperature);
            Console.WriteLine(coffee.Temperature);
            Console.WriteLine(coffee.Temperature);

            var eggs = Breakfast.FryEggs(2);
            Console.WriteLine(eggs.Length);

            Console.WriteLine(eggs.Print());

            var bacon = Breakfast.FryBacon(3);
            Console.WriteLine(bacon.Length);
            Breakfast.EatBacon(ref bacon, 2);
            Console.WriteLine(bacon.Length);

            var toasts = Breakfast.ToastBread(2);
            Console.WriteLine(toasts.Length);

            toasts[0] = Breakfast.ApplyButter(toasts[0]);
            toasts[1] = Breakfast.ApplyJam(toasts[1]);

            Console.WriteLine(toasts[0].JamApplied);
            Console.WriteLine(toasts[1].ButterApplied);
            Console.WriteLine(toasts[1].JamApplied);
            Console.WriteLine(toasts[0].ButterApplied);
        }
    }
}
