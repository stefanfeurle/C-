using System;
using System.Collections.Generic;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            List<UserInput> userInputs = new List<UserInput>();
            List<Car> cars = new List<Car>();

            User bernd = new User("Bernd");
            users.Add(bernd);
            SportsCar mclaren = new SportsCar("650S GT3", "Mclaren",  2017, "schwarz");
            cars.Add(mclaren);
            NormalCar kia = new NormalCar( "Ceed", "Kia", 2016, "weiß");
            cars.Add(kia);
            userInputs.Add(new UserInput(bernd, mclaren));
            userInputs.Add(new UserInput(bernd, kia));



            string name = string.Empty;
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("\nAUTOEINGABE nach Marcs Wünschen\n\nWie heißen sie?\n");
                name = Console.ReadLine();
            }

            User user = new User(name);
            users.Add(user);

            string userInput = null;
            while (userInput != "0")
            {
                userInput = null;
                while (userInput != "1" && userInput != "2" && userInput != "0")
                {
                    Console.WriteLine("\nMöchten Sie ein Auto eingeben oder die eingegebenen Autos anschauen!\n1. Input\n2. Show\n0.Beenden\n");
                    userInput = Console.ReadLine();

                    if (userInput != "1" && userInput != "2" && userInput != "0")
                    {
                        Console.WriteLine("Falsche Eingabe");
                    }
                }

                if (userInput == "1")
                {
                    string type = string.Empty;
                    while (type != "1" && type != "2")
                    {
                        Console.WriteLine("\nWelchen Typ von Auto möchtest du eingeben?\n1. Sportauto\n2. Normales Auto\n");
                        type = Console.ReadLine();
                        if (type != "1" && type != "2")
                        {
                            Console.WriteLine("Falsche Eingabe");
                        }
                    }

                    string brand = string.Empty;
                    while (string.IsNullOrEmpty(brand))
                    {
                        Console.WriteLine("\nVon welchem Hersteller stammt das Auto!\n");
                        brand = Console.ReadLine();
                    }

                    string model = string.Empty;
                    while (string.IsNullOrEmpty(model))
                    {
                        Console.WriteLine("\nModell dieses Auto?\n");
                        model = Console.ReadLine();
                    }

                    string color = string.Empty;
                    while (string.IsNullOrEmpty(color))
                    {
                        Console.WriteLine("\nFarbe dieses Auto?\n");
                        color = Console.ReadLine();
                    }

                    int constructionYear = 0;
                    bool correctInput = false;
                    while (correctInput == false)
                    {
                        Console.WriteLine("\nBaujahr?\n");
                        string year = Console.ReadLine();
                        int.TryParse(year, out constructionYear);
                        if (constructionYear <= 2020 && constructionYear >= 1900)
                        {
                            correctInput = true;
                        }

                    }
                    Console.WriteLine("Danke für deine Eingabe");

                    if (type == "1")
                    {
                        SportsCar userCar = new SportsCar(model, brand, constructionYear, color);
                        userInputs.Add(new UserInput(user, userCar));
                    } else
                    {
                        NormalCar userCar = new NormalCar(model, brand, constructionYear, color);
                        userInputs.Add(new UserInput(user, userCar));
                    }                    
                }
                else if (userInput == "2")
                {
                    string output = "\nAusgabe der eingegebenen Autos\n\n";
                    foreach (var userI in userInputs)
                    {
                        output = output + userI.Car.ToString() + userI.User.Name + " (Designer/" + userI.Car.CarType +")\n";
                    }
                    Console.WriteLine(output);
                }
            }
        }
    }
}

