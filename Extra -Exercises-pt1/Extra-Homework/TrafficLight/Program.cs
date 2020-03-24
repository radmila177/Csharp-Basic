using System;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Stop");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("READY");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("GO");
            Console.ResetColor();

            Console.ReadLine();
        }
        
    }
}
