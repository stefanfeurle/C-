using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dir = Directory.GetFiles(@"C:\Users\DCV\Downloads");
            var fileNames = "";
            foreach(var item in dir)
            {
                fileNames = string.IsNullOrEmpty(fileNames) ? item : fileNames + "\n" + item;
            }

            System.IO.File.WriteAllText(@"C:\Users\DCV\Downloads\myFiles.txt", fileNames);
        }
    }
}
