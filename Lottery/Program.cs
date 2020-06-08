using System;
using System.Security.Cryptography;
using System.Threading;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            LotteryTicket lotteryTicket = new LotteryTicket();

            string userInput = null;
            while (userInput != "0")
            {
                userInput = null;
                while (userInput != "1" &&  userInput != "0")
                {
                    Console.WriteLine("\nLOTTERIE\n\nWollen sie mit mir spielen! Erraten sie eine 6 - stellige Zufallszahl!\n" +
                        "Bei jedem Versuch erhalten sie die Information, wieviele Ziffern an der richtigen Stelle waren!\n1. Play\n0. End\n");
                    userInput = Console.ReadLine();

                    if (userInput != "1" && userInput != "0")
                    {
                        Console.WriteLine("Falsche Eingabe");
                    }
                }

                if (userInput == "1")
                {
                    int randomNumber = rnd.Next(1, 1000000);
                    lotteryTicket.setLotteryTicketNumber(randomNumber);
                    var attempt = 0;

                    string userNumberString = null;
                    while (!lotteryTicket.LotteryTicketNumber.Equals(userNumberString))
                    {
                        Console.WriteLine("\nBitte geben sie ein Zahl zwischen 1 und 999999 6 - stellig ein (1 ==> 000001)!\n" +
                        "Wenn sie aufgeben möchten, geben sie bitte AAAAAA ein! Viel Spass!\n");
                        userNumberString = Console.ReadLine();
                        if (userNumberString.Equals("AAAAAA"))
                        {
                            Console.WriteLine("\nSie haben nach dem " + attempt + " Versuch leider aufgegeben.\n" +
                                "Die korrekte Zahl wäre gewesen:  " + lotteryTicket.LotteryTicketNumber + "\n");
                            Thread.Sleep(10000);
                            userNumberString = lotteryTicket.LotteryTicketNumber;
                        } else
                        {
                            int.TryParse(userNumberString, out var userNumberInt);
                            if (userNumberInt > 0 && userNumberString.Length <= 6)
                            {
                                attempt++;
                                while (userNumberString.Length < 6)
                                {
                                    userNumberString = '0' + userNumberString;
                                }
                                int correctNumbers = lotteryTicket.checkUserNumberString(userNumberString);
                                if (correctNumbers == 6)
                                {
                                    Console.WriteLine($"\nPerfekt!! Sie haben im {attempt} Versuch die 6 - stellige Zufallszahl erraten!!");
                                } else
                                {
                                    Console.WriteLine($"\nVersuch: {attempt}\t\tRichtige Ziffern:  {correctNumbers}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nFalsche Eingabe!!");
                            }
                        }
                    }                    
                }
            }
        }                   
    }
}
