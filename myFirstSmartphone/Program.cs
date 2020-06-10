using myFirstSmartphone.models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;

namespace myFirstSmartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            var smartphone = new Smartphone();
            var whatsApp = new App("WhatsApp", Category.COMMUNICATION);
            var skype = new App("Skype", Category.COMMUNICATION);
            var mcDonalds = new App("McDonalds", Category.EATING);           
            var soccer = new Game("Soccer", Category.GAME, 8, SubCategory.SPORT);
            var solitaire = new Game("Solitär", Category.GAME, 6, SubCategory.CARD);
            var chess = new Game("Schach", Category.GAME, 7, SubCategory.BOARD);

            smartphone.add(whatsApp);
            smartphone.add(skype);
            smartphone.add(mcDonalds);
            smartphone.add(soccer);
            smartphone.add(solitaire);
            smartphone.add(chess);

            Console.WriteLine("\nMY SMARTPHONE\n\nMit 'Filter:<Apps>' oder 'Filter:<Games>' können sie ihre Apps und Games anschauen!" +
                "\nMit 'Start:<'appname' können sie die App Starten\n");
            var userInput = Console.ReadLine();
            //var userInput = "Start:  < whatsapp>";
            //var userInput = " Filter : <apps>";

            if (userInput.Contains(':'))
            {
                string[] splitValue = userInput.Split(':');
                string key = splitValue[0].Trim();
                string value = splitValue[1].Trim();
                if (value.StartsWith('<') && value.EndsWith('>'))
                {
                    value = value[1..^1].Trim();
                }
                if (key.ToUpper() == Key.START.ToString())
                {
                    App app = smartphone.Get<App>(value);
                    if (app != null)
                    {
                        Console.WriteLine(app.toStart());
                        if (app.Category.ToString() != Category.GAME.ToString())
                        {
                            Thread.Sleep(20000);
                        } else
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                Thread.Sleep(1000);
                                Console.WriteLine(i + 1);
                            }
                        }
                        
                        Console.WriteLine("Ende\n");
                    } else
                    {
                        Console.WriteLine("\nFalsche Eingabe!\n");
                    }
                } else if (key.ToUpper() == "Filter".ToUpper())
                {
                    List<App> apps = null;
                    if (value.ToUpper() == KindOfValueInput.APPS.ToString())
                    {
                        apps = smartphone.getList(new Category[] { Category.EATING, Category.COMMUNICATION });
                    } else if (value.ToUpper() == KindOfValueInput.GAMES.ToString())
                    {
                        apps = smartphone.getList(Category.GAME);
                    }
                    if(apps != null)
                    {
                        foreach (var item in apps)
                        {
                            Console.WriteLine(item.Name);
                        }
                    } else 
                    {
                        Console.WriteLine("\nFalsche Eingabe!\n");
                    }
                }

                //Console.WriteLine("\n" + skype);
                //Console.WriteLine(soccer);
                //Console.WriteLine(Key.START.ToString());
                //Console.WriteLine(value);
            }

           


        }
    }
}
