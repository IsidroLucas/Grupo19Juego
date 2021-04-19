using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Changecolor();
            Console.WriteLine("Hello World!");
        }

        static void Changecolor()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
    }
}
