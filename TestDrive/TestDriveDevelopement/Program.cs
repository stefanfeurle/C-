using System;
using System.Threading;
using System.Threading.Tasks;
using TestDriveDevelopement.Extensions;

namespace TestDriveDevelopement
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("\nHello World!\n");

            var coffee = Breakfast.PourCoffee();
            Console.WriteLine($"{coffee} \n");

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

            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterOrAndJamAsync(2);           

            //Egg eggsT = await eggsTask;
            //Bacon baconT = await baconTask;
            //Toast toastsT = await toastTask;

            
            var pourCoffeeTask = PourCoffeeAsync();
            //coffee = await pourCoffeeTask;

            await Task.WhenAll(eggsTask, baconTask, toastTask, pourCoffeeTask);
            Console.WriteLine("Alles fertig, inklusive me!");
        }

        private static async Task<Coffee> PourCoffeeAsync()
        {
            Console.WriteLine("Kaffeemaschine startet hoch");
            await Task.Delay(2000);
            Console.WriteLine("Kaffee läuft in Tasse, hoffentlich");
            await Task.Delay(2000);
            return new Coffee();
        }

        private static async Task<Toast> MakeToastWithButterOrAndJamAsync(int toast)
        {
            for (int i = 0; i < toast; i++)
            {
                Console.WriteLine($"{i + 1}. Toast im Toaster");
                await Task.Delay(5000);
                Console.WriteLine(i % 2 == 1 ? $"{i + 1}. Toast mit Butter belegt!" : $"{i + 1}. Toast mit Marmelade belegt!");
                await Task.Delay(2000);                
            }
            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int bacon)
        {

            Console.WriteLine(bacon > 1 ? $"{bacon} Speckstücke fliegen in die Pfanne!" : "Das Speckstück fliegt in die Pfanne!");
            await Task.Delay(2000);
            Console.WriteLine("Speck bratet auf der ersten Seite!");
            await Task.Delay(6000);
            Console.WriteLine("Speck wenden");
            await Task.Delay(2000);
            Console.WriteLine("Speck bratet auf der zweiten Seite!");
            await Task.Delay(5000);
            Console.WriteLine("Der Speck ist fertig!");
            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int egg)
        {
            Console.WriteLine(egg > 1 ? $"{egg} Eier fliegen in die Pfanne!" : "Das Ei fliegt in die Pfanne!");
            await Task.Delay(20000);
            Console.WriteLine($"Die {egg} Eier sind fertig!");
            return new Egg();
        }
    }
}
