﻿using Calculator.models;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enum.GetName(typeof(CalculationType), CalculationType.ADDITION));
            models.Calculator calc = new models.Calculator();

            Console.WriteLine("Welcome to our calculator");
            Console.WriteLine("Number 1:");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Number 2:");
            string number2Input = Console.ReadLine();
            Console.WriteLine("Operation (-,+,*,/):");
            string operation = Console.ReadLine();

            decimal.TryParse(number1Input, out var number1);
            decimal.TryParse(number2Input, out var number2);

            CalculationType? calculationType = null;
            

            switch (operation)
            {
                case "+":
                    calculationType = CalculationType.ADDITION;
                    break;

                case "-":
                    calculationType = CalculationType.SUBTRACTION;
                    break;

                case "*":
                    calculationType = CalculationType.MULTIPLICATION;
                    break;

                case "/":
                    calculationType = CalculationType.DIVISTION;
                    break;
            }

            if (calculationType.HasValue)
                Console.WriteLine(calc.Calculate(number1, number2, calculationType.Value));

        }
    }
}
